using Microsoft.Data.SqlClient;

namespace WinFormsAppTest
{
    public partial class DangKy : Form
    {
        // Don't access DatabaseConfig at field initialization time because the WinForms
        // designer may load this type at design-time and DatabaseConfig may depend
        // on runtime-only resources. Initialize at runtime in the Load event.
        private string _connectionString = string.Empty;

        public string RegisteredUsername { get; private set; } = string.Empty;

        public DangKy()
        {
            InitializeComponent();
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            _connectionString = DatabaseConfig.ConnectionString;
            cmbRole.SelectedIndex = 0;
            txtUsername.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }

            try
            {
                using SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();

                if (IsUsernameExists(connection, txtUsername.Text.Trim()))
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUsername.Focus();
                    return;
                }

                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text;
                string roleCode = MapRoleCode(cmbRole.SelectedItem?.ToString());
                string accountId = GenerateAccountId();

                if (!InsertAccount(connection, accountId, username, password, roleCode))
                {
                    MessageBox.Show("Không thể tạo tài khoản. Vui lòng kiểm tra cấu trúc bảng tai_khoan.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                RegisteredUsername = username;
                MessageBox.Show("Đăng ký tài khoản thành công.", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đăng ký thất bại: {ex.Message}\n\nKiểm tra SQL Server và database TTCN.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            if (txtPassword.Text.Length < 6)
            {
                MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }

            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return false;
            }

            if (cmbRole.SelectedIndex < 0 || cmbRole.SelectedItem is null)
            {
                MessageBox.Show("Vui lòng chọn vai trò.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRole.Focus();
                return false;
            }

            return true;
        }

        private static bool IsUsernameExists(SqlConnection connection, string username)
        {
            const string query = "SELECT COUNT(1) FROM tai_khoan WHERE ten_dang_nhap = @username";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            int count = Convert.ToInt32(command.ExecuteScalar());
            return count > 0;
        }

        private static bool InsertAccount(SqlConnection connection, string accountId, string username, string password, string roleCode)
        {
            const string query = "INSERT INTO tai_khoan (ma_tai_khoan, ten_dang_nhap, mat_khau, quyen_han) VALUES (@accountId, @username, @password, @roleCode)";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@accountId", accountId);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@roleCode", roleCode);
            return command.ExecuteNonQuery() > 0;
        }

        private static string GenerateAccountId()
        {
            return $"TK{DateTime.Now:yyyyMMddHHmmssfff}";
        }

        private static string MapRoleCode(string? displayRole)
        {
            return displayRole switch
            {
                "Admin" => "ADMIN",
                "Quản lý" => "QUAN_LY",
                "Nhân viên" => "NHAN_VIEN",
                _ => string.Empty
            };
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lblSubTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
