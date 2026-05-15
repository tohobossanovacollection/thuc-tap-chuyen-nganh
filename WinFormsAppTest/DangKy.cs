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
            if (cmbChucVu.Items.Count > 0) cmbChucVu.SelectedIndex = 0;
            if (cmbPhongBan.Items.Count > 0) cmbPhongBan.SelectedIndex = 0;
            txtUsername.Focus();

            HideProfileControls();
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

                if (!string.IsNullOrWhiteSpace(txtEmail.Text) && IsEmailExists(connection, txtEmail.Text.Trim()))
                {
                    MessageBox.Show("Email đã tồn tại. Vui lòng nhập email khác.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }

                using SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    string username = txtUsername.Text.Trim();
                    string password = txtPassword.Text;
                    string chucVu = cmbChucVu.SelectedItem?.ToString() ?? "";
                    string accountId = GenerateAccountId();

                    if (!InsertAccount(connection, transaction, accountId, username, password))
                    {
                        transaction.Rollback();
                        MessageBox.Show("Không thể tạo tài khoản. Vui lòng kiểm tra lại cấu trúc bảng tai_khoan.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string empId = GenerateEmployeeIdByCount(connection, transaction);
                    string? email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim();

                    if (!InsertEmployee(connection, transaction, empId, accountId, email))
                    {
                        transaction.Rollback();
                        MessageBox.Show("Không thể tạo thông tin nhân viên.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    transaction.Commit();

                    RegisteredUsername = username;
                    MessageBox.Show("Đăng ký tài khoản thành công.", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                    Close();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đăng ký thất bại: {ex.Message}\n\nKiểm tra dữ liệu nhập (email, SĐT có thể đã tồn tại) hoặc bảng database TTCN.",
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
                MessageBox.Show("Mật khẩu không khớp vui lòng nhập lại.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Vui lòng nhập email.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            if (!InputValidator.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Thông tin email không hợp lệ vui lòng nhập lại.");
                txtEmail.Focus();
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

        private static bool IsEmailExists(SqlConnection connection, string email)
        {
            const string query = "SELECT COUNT(1) FROM nhan_vien WHERE email = @email";
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@email", email);
            int count = Convert.ToInt32(command.ExecuteScalar());
            return count > 0;
        }

        private static bool InsertAccount(SqlConnection connection, SqlTransaction transaction, string accountId, string username, string password)
        {
            const string query = "INSERT INTO tai_khoan (ma_tai_khoan, ten_dang_nhap, mat_khau) VALUES (@accountId, @username, @password)";
            using SqlCommand command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@accountId", accountId);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            return command.ExecuteNonQuery() > 0;
        }

        private static bool InsertEmployee(SqlConnection connection, SqlTransaction transaction, string empId, string accountId, string? email)
        {
            const string query = @"INSERT INTO nhan_vien 
                (ma_nhan_vien, ma_tai_khoan, ho_ten, ngay_sinh, dia_chi, so_dien_thoai, email, chuc_vu, phong_ban, trang_thai) 
                VALUES 
                (@empId, @accountId, @hoTen, NULL, NULL, NULL, @email, @chucVu, @phongBan, 'ACTIVE')";
            using SqlCommand command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@empId", empId);
            command.Parameters.AddWithValue("@accountId", accountId);
            command.Parameters.AddWithValue("@hoTen", EmployeeProfileHelper.PendingName);
            command.Parameters.AddWithValue("@email", (object)email ?? DBNull.Value);
            command.Parameters.AddWithValue("@chucVu", EmployeeProfileHelper.DefaultChucVu);
            command.Parameters.AddWithValue("@phongBan", EmployeeProfileHelper.DefaultPhongBan);
            return command.ExecuteNonQuery() > 0;
        }

        private static string GenerateAccountId()
        {
            return $"TK{DateTime.Now:yyyyMMddHHmmssfff}";
        }

        private static string GenerateEmployeeId()
        {
            return $"NV{DateTime.Now:MMddHHmmssfff}";
        }

        private static string GenerateEmployeeIdByCount(SqlConnection connection, SqlTransaction transaction)
        {
            const string query = "SELECT COUNT(*) FROM nhan_vien";
            using SqlCommand command = new SqlCommand(query, connection, transaction);
            int count = Convert.ToInt32(command.ExecuteScalar());
            int next = count + 1;
            return $"NV{next:000}";
        }

        private void HideProfileControls()
        {
            lblHoTen.Visible = false;
            txtHoTen.Visible = false;
            lblDiaChi.Visible = false;
            txtDiaChi.Visible = false;
            lblNgaySinh.Visible = false;
            dtpNgaySinh.Visible = false;
            lblSoDienThoai.Visible = false;
            txtSoDienThoai.Visible = false;
            lblPhongBan.Visible = false;
            cmbPhongBan.Visible = false;
            lblChucVu.Visible = false;
            cmbChucVu.Visible = false;
        }



        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lblSubTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
