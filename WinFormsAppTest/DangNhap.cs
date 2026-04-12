using Microsoft.Data.SqlClient;

namespace WinFormsAppTest
{
    public partial class DangNhap : Form
    {
        private readonly string _connectionString = DatabaseConfig.ConnectionString;

        public DangNhap()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
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

            try
            {
                using SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();

                if (!TryGetUserRole(connection, username, password, out roleCode))
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

            MessageBox.Show($"Đăng nhập thành công!\nTài khoản: {username}\nVai trò: {roleDisplay}",
                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Hide();
            using (Dashboard dashboard = new Dashboard(username, roleDisplay))
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

        private static bool TryGetUserRole(SqlConnection connection, string username, string password, out string roleCode)
        {
            const string query = "SELECT quyen_han FROM tai_khoan WHERE ten_dang_nhap = @username AND mat_khau = @password";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            object? result = command.ExecuteScalar();
            if (result is null || result == DBNull.Value)
            {
                roleCode = string.Empty;
                return false;
            }

            roleCode = result.ToString() ?? string.Empty;
            return !string.IsNullOrWhiteSpace(roleCode);
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
