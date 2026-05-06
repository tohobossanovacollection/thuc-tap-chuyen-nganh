using Microsoft.Data.SqlClient;

namespace WinFormsAppTest
{
    public partial class DangNhap : Form
    {
        // Don't access DatabaseConfig at field initialization time because the WinForms
        // designer may load this type at design-time and DatabaseConfig may depend
        // on runtime-only resources. Initialize at runtime in the Load event.
        private string _connectionString = string.Empty;

        public DangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize connection string at runtime (avoid design-time access)
            _connectionString = DatabaseConfig.ConnectionString;

            // Focus on username field
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string roleCode;
            string maNhanVien;

            try
            {
                using SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();

                if (!TryGetUserRole(connection, username, password, out roleCode, out maNhanVien))
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Đăng nhập thất bại",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kết nối database TTCN: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string roleDisplay = MapRoleDisplay(roleCode);

            Hide();
            using (Dashboard dashboard = new Dashboard(username, roleDisplay, maNhanVien))
            {
                dashboard.ShowDialog(this);
            }
            Close();
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            using DangKy dangKyForm = new DangKy();
            if (dangKyForm.ShowDialog(this) == DialogResult.OK)
            {
                txtUsername.Text = dangKyForm.RegisteredUsername;
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void lnkForgotPassword_Click(object sender, EventArgs e)
        {
            // TODO: Open password recovery form
            MessageBox.Show("Chức năng quên mật khẩu sẽ được phát triển!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Remove this if not needed
        }

        private static bool TryGetUserRole(SqlConnection connection, string username, string password, out string roleCode, out string maNhanVien)
        {
            const string query = """
                SELECT tk.quyen_han, nv.ma_nhan_vien
                FROM tai_khoan tk
                LEFT JOIN nhan_vien nv ON nv.ma_tai_khoan = tk.ma_tai_khoan
                WHERE tk.ten_dang_nhap = @username AND tk.mat_khau = @password;
                """;
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            using SqlDataReader reader = command.ExecuteReader();
            if (!reader.Read())
            {
                roleCode = string.Empty;
                maNhanVien = string.Empty;
                return false;
            }

            roleCode = reader["quyen_han"]?.ToString() ?? string.Empty;
            maNhanVien = reader["ma_nhan_vien"]?.ToString() ?? string.Empty;
            return !string.IsNullOrWhiteSpace(roleCode) && !string.IsNullOrWhiteSpace(maNhanVien);
        }

        private static string MapRoleDisplay(string roleCode)
        {
            return roleCode.ToUpperInvariant() switch
            {
                "ADMIN" => "Admin",
                "QUAN_LY" => "Quản lý",
                "NHAN_VIEN" => "Nhân viên",
                _ => roleCode
            };
        }

        private void lblSubTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
