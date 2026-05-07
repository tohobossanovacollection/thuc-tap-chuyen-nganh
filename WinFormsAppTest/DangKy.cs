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

                using SqlTransaction transaction = connection.BeginTransaction();
                try
                {
                    string username = txtUsername.Text.Trim();
                    string password = txtPassword.Text;
                    string chucVu = cmbChucVu.SelectedItem?.ToString() ?? "";
                    string roleCode = MapRoleCode(chucVu);
                    string accountId = GenerateAccountId();

                    if (!InsertAccount(connection, transaction, accountId, username, password, roleCode))
                    {
                        transaction.Rollback();
                        MessageBox.Show("Không thể tạo tài khoản. Vui lòng kiểm tra lại cấu trúc bảng tai_khoan.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string empId = GenerateEmployeeId();
                    string hoTen = txtHoTen.Text.Trim();
                    string diaChi = txtDiaChi.Text.Trim();
                    string soDienThoai = string.IsNullOrWhiteSpace(txtSoDienThoai.Text) ? null : txtSoDienThoai.Text.Trim();
                    string email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim();
                    string phongBan = cmbPhongBan.SelectedItem?.ToString() ?? "";
                    DateTime ngaySinh = dtpNgaySinh.Value;

                    if (!InsertEmployee(connection, transaction, empId, accountId, hoTen, ngaySinh, diaChi, soDienThoai, email, chucVu, phongBan))
                    {
                        transaction.Rollback();
                        MessageBox.Show("Không thể tạo thông tin nhân viên.", "Lỗi",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    transaction.Commit();

                    RegisteredUsername = username;
                    MessageBox.Show("Đăng ký tài khoản và thông tin nhân viên thành công.", "Thành công",
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
                MessageBox.Show("Mật khẩu xác nhận không khớp.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }

            if (cmbChucVu.SelectedIndex < 0 || cmbChucVu.SelectedItem is null)
            {
                MessageBox.Show("Vui lòng chọn chức vụ.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbChucVu.Focus();
                return false;
            }

            if (cmbPhongBan.SelectedIndex < 0 || cmbPhongBan.SelectedItem is null)
            {
                MessageBox.Show("Vui lòng chọn phòng ban.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbPhongBan.Focus();
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

        private static bool InsertAccount(SqlConnection connection, SqlTransaction transaction, string accountId, string username, string password, string roleCode)
        {
            const string query = "INSERT INTO tai_khoan (ma_tai_khoan, ten_dang_nhap, mat_khau, quyen_han) VALUES (@accountId, @username, @password, @roleCode)";
            using SqlCommand command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@accountId", accountId);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            command.Parameters.AddWithValue("@roleCode", roleCode);
            return command.ExecuteNonQuery() > 0;
        }

        private static bool InsertEmployee(SqlConnection connection, SqlTransaction transaction, string empId, string accountId, string hoTen, DateTime ngaySinh, string diaChi, string soDienThoai, string email, string chucVu, string phongBan)
        {
            const string query = @"INSERT INTO nhan_vien 
                (ma_nhan_vien, ma_tai_khoan, ho_ten, ngay_sinh, dia_chi, so_dien_thoai, email, chuc_vu, phong_ban, trang_thai) 
                VALUES 
                (@empId, @accountId, @hoTen, @ngaySinh, @diaChi, @soDienThoai, @email, @chucVu, @phongBan, 'ACTIVE')";
            using SqlCommand command = new SqlCommand(query, connection, transaction);
            command.Parameters.AddWithValue("@empId", empId);
            command.Parameters.AddWithValue("@accountId", accountId);
            command.Parameters.AddWithValue("@hoTen", hoTen);
            command.Parameters.AddWithValue("@ngaySinh", ngaySinh.Date);
            command.Parameters.AddWithValue("@diaChi", (object)diaChi ?? DBNull.Value);
            command.Parameters.AddWithValue("@soDienThoai", (object)soDienThoai ?? DBNull.Value);
            command.Parameters.AddWithValue("@email", (object)email ?? DBNull.Value);
            command.Parameters.AddWithValue("@chucVu", chucVu);
            command.Parameters.AddWithValue("@phongBan", phongBan);
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

        private static string MapRoleCode(string? chucVu)
        {
            if (string.IsNullOrWhiteSpace(chucVu)) return string.Empty;
            
            if (chucVu == "Giám đốc" || chucVu == "Phó giám đốc")
                return "ADMIN";
            
            if (chucVu == "Quản lý cửa hàng" || chucVu == "Quản lý kho")
                return "QUAN_LY";
                
            return "NHAN_VIEN";
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void lblSubTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
