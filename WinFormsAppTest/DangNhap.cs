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
            string phongBan;

            try
            {
                using SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();

                if (!TryGetAccountId(connection, username, password, out string maTaiKhoan))
                {
                    MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.", "Đăng nhập thất bại",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Clear();
                    txtPassword.Focus();
                    return;
                }

                if (!EnsureEmployeeProfile(connection, maTaiKhoan, out roleCode, out maNhanVien, out phongBan))
                {
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
            DialogResult result;
            using (Dashboard dashboard = new Dashboard(username, roleDisplay, maNhanVien, phongBan))
            {
                result = dashboard.ShowDialog(this);
            }

            if (result == DialogResult.OK)
            {
                txtUsername.Clear();
                txtPassword.Clear();
                Show();
                txtUsername.Focus();
                return;
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

        private static bool TryGetAccountId(SqlConnection connection, string username, string password, out string maTaiKhoan)
        {
            const string query = """
                SELECT ma_tai_khoan
                FROM tai_khoan
                WHERE ten_dang_nhap = @username AND mat_khau = @password;
                """;
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);

            object? result = command.ExecuteScalar();
            if (result is null || result == DBNull.Value)
            {
                maTaiKhoan = string.Empty;
                return false;
            }

            maTaiKhoan = result.ToString() ?? string.Empty;
            return !string.IsNullOrWhiteSpace(maTaiKhoan);
        }

        private bool EnsureEmployeeProfile(SqlConnection connection, string maTaiKhoan, out string roleCode, out string maNhanVien, out string phongBan)
        {
            const string query = """
                SELECT ma_nhan_vien, ho_ten, chuc_vu, phong_ban
                FROM nhan_vien
                WHERE ma_tai_khoan = @maTaiKhoan;
                """;

            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@maTaiKhoan", maTaiKhoan);

            using SqlDataReader reader = command.ExecuteReader();
            if (!reader.Read())
            {
                roleCode = string.Empty;
                maNhanVien = string.Empty;
                phongBan = string.Empty;
                reader.Close();
                return CreateEmployeeProfile(connection, maTaiKhoan, out roleCode, out maNhanVien, out phongBan);
            }

            maNhanVien = reader["ma_nhan_vien"]?.ToString() ?? string.Empty;
            string hoTen = reader["ho_ten"]?.ToString() ?? string.Empty;
            roleCode = reader["chuc_vu"]?.ToString() ?? string.Empty;
            phongBan = reader["phong_ban"]?.ToString() ?? string.Empty;
            reader.Close();

            if (hoTen == EmployeeProfileHelper.PendingName)
            {
                return UpdateEmployeeProfile(connection, maNhanVien, out roleCode, out phongBan);
            }

            return !string.IsNullOrWhiteSpace(roleCode)
                   && !string.IsNullOrWhiteSpace(maNhanVien)
                   && !string.IsNullOrWhiteSpace(phongBan);
        }

        private bool CreateEmployeeProfile(SqlConnection connection, string maTaiKhoan, out string roleCode, out string maNhanVien, out string phongBan)
        {
            using var dlg = new NhanVienProfileDialog();
            if (dlg.ShowDialog(this) != DialogResult.OK)
            {
                roleCode = string.Empty;
                maNhanVien = string.Empty;
                phongBan = string.Empty;
                return false;
            }

            maNhanVien = CodeGenerator.GetNextCode(_connectionString, "nhan_vien", "ma_nhan_vien", "NV");
            roleCode = dlg.ChucVu;
            phongBan = dlg.PhongBan;

            const string insertQuery = @"INSERT INTO nhan_vien (ma_nhan_vien, ma_tai_khoan, ho_ten, ngay_sinh, dia_chi, so_dien_thoai, email, chuc_vu, phong_ban, trang_thai)
                                         VALUES (@ma, @maTaiKhoan, @hoTen, @ngaySinh, @diaChi, @soDienThoai, NULL, @chucVu, @phongBan, 'ACTIVE')";
            using SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
            insertCommand.Parameters.AddWithValue("@ma", maNhanVien);
            insertCommand.Parameters.AddWithValue("@maTaiKhoan", maTaiKhoan);
            insertCommand.Parameters.AddWithValue("@hoTen", dlg.HoTen.Trim());
            insertCommand.Parameters.AddWithValue("@ngaySinh", dlg.NgaySinh.Date);
            insertCommand.Parameters.AddWithValue("@diaChi", dlg.DiaChi.Trim());
            insertCommand.Parameters.AddWithValue("@soDienThoai", dlg.SoDienThoai.Trim());
            insertCommand.Parameters.AddWithValue("@chucVu", dlg.ChucVu);
            insertCommand.Parameters.AddWithValue("@phongBan", dlg.PhongBan);
            insertCommand.ExecuteNonQuery();

            return true;
        }

        private bool UpdateEmployeeProfile(SqlConnection connection, string maNhanVien, out string roleCode, out string phongBan)
        {
            using var dlg = new NhanVienProfileDialog();
            if (dlg.ShowDialog(this) != DialogResult.OK)
            {
                roleCode = string.Empty;
                phongBan = string.Empty;
                return false;
            }

            roleCode = dlg.ChucVu;
            phongBan = dlg.PhongBan;

            const string updateQuery = @"UPDATE nhan_vien
                                         SET ho_ten = @hoTen, ngay_sinh = @ngaySinh, dia_chi = @diaChi, so_dien_thoai = @soDienThoai, chuc_vu = @chucVu, phong_ban = @phongBan
                                         WHERE ma_nhan_vien = @ma";
            using SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
            updateCommand.Parameters.AddWithValue("@ma", maNhanVien);
            updateCommand.Parameters.AddWithValue("@hoTen", dlg.HoTen.Trim());
            updateCommand.Parameters.AddWithValue("@ngaySinh", dlg.NgaySinh.Date);
            updateCommand.Parameters.AddWithValue("@diaChi", dlg.DiaChi.Trim());
            updateCommand.Parameters.AddWithValue("@soDienThoai", dlg.SoDienThoai.Trim());
            updateCommand.Parameters.AddWithValue("@chucVu", dlg.ChucVu);
            updateCommand.Parameters.AddWithValue("@phongBan", dlg.PhongBan);
            updateCommand.ExecuteNonQuery();

            return true;
        }

        private static string MapRoleDisplay(string roleCode)
        {
            return roleCode switch
            {
                "Giam doc" => "Giám đốc",
                "Quan ly cua hang" => "Quản lý cửa hàng",
                "Nhan vien" => "Nhân viên",
                _ => roleCode
            };
        }

        private void lblSubTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
