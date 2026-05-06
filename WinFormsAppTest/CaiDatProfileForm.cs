using System.Data;
using Microsoft.Data.SqlClient;

namespace WinFormsAppTest
{
    public partial class CaiDatProfileForm : Form
    {
        private readonly string _connectionString = DatabaseConfig.ConnectionString;
        private string _maNhanVien;
        private string _maTaiKhoan;

        public CaiDatProfileForm(string maNhanVien)
        {
            InitializeComponent();
            _maNhanVien = maNhanVien;
            LoadUserProfile();
        }

        private void LoadUserProfile()
        {
            if (string.IsNullOrEmpty(_maNhanVien))
            {
                MessageBox.Show("Mã nhân viên trống!");
                return;
            }

            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                const string query = @"
                    SELECT nv.*, tk.ten_dang_nhap, tk.ma_tai_khoan 
                    FROM nhan_vien nv
                    LEFT JOIN tai_khoan tk ON tk.ma_tai_khoan = nv.ma_tai_khoan
                    WHERE nv.ma_nhan_vien = @maNV";

                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@maNV", _maNhanVien.Trim());
                conn.Open();

                using SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    _maTaiKhoan = reader["ma_tai_khoan"]?.ToString();
                    string hoTen = reader["ho_ten"]?.ToString() ?? "N/A";
                    string email = reader["email"]?.ToString() ?? "";
                    string sdt = reader["so_dien_thoai"]?.ToString() ?? "";
                    string dc = reader["dia_chi"]?.ToString() ?? "";

                    _lblGreeting.Text = $"Xin chào, {hoTen}";
                    _lblUserNameValue.Text = reader["ten_dang_nhap"]?.ToString() ?? "N/A";
                    _lblMaNhanVienValue.Text = reader["ma_nhan_vien"]?.ToString() ?? "N/A";
                    
                    _txtHoTen.Text = hoTen;
                    _txtDiaChi.Text = dc;
                    _txtSoDienThoai.Text = sdt;
                    _txtEmail.Text = email;
                    _lblChucVuValue.Text = reader["chuc_vu"]?.ToString() ?? "N/A";

                    if (reader["ngay_sinh"] != DBNull.Value)
                        _dtpNgaySinh.Value = (DateTime)reader["ngay_sinh"];

                    // Debug message
                    // MessageBox.Show($"Dữ liệu tìm thấy: {hoTen}, {email}");
                }
                else
                {
                    MessageBox.Show($"Không tìm thấy bản ghi nào với mã: '{_maNhanVien}'");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message);
            }
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_maTaiKhoan)) return;

            string oldPass = _txtOldPass.Text;
            string newPass = _txtNewPass.Text;
            string confirmPass = _txtConfirmPass.Text;

            if (string.IsNullOrWhiteSpace(oldPass) || string.IsNullOrWhiteSpace(newPass))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ mật khẩu hiện tại và mật khẩu mới.");
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("Xác nhận mật khẩu mới không khớp.");
                return;
            }

            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                conn.Open();

                // 1. Kiểm tra mật khẩu cũ
                const string checkQuery = "SELECT COUNT(*) FROM tai_khoan WHERE ma_tai_khoan = @tk AND mat_khau = @p";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@tk", _maTaiKhoan);
                    checkCmd.Parameters.AddWithValue("@p", oldPass);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count == 0)
                    {
                        MessageBox.Show("Mật khẩu hiện tại không chính xác.");
                        return;
                    }
                }

                // 2. Cập nhật mật khẩu mới
                const string updateQuery = "UPDATE tai_khoan SET mat_khau = @p WHERE ma_tai_khoan = @tk";
                using (SqlCommand updateCmd = new SqlCommand(updateQuery, conn))
                {
                    updateCmd.Parameters.AddWithValue("@p", newPass);
                    updateCmd.Parameters.AddWithValue("@tk", _maTaiKhoan);
                    updateCmd.ExecuteNonQuery();
                }

                MessageBox.Show("Đổi mật khẩu thành công!");
                _txtOldPass.Clear();
                _txtNewPass.Clear();
                _txtConfirmPass.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                conn.Open();
                const string query = @"
                    UPDATE nhan_vien 
                    SET ho_ten = @ten, ngay_sinh = @ns, dia_chi = @dc, so_dien_thoai = @sdt, email = @email 
                    WHERE ma_nhan_vien = @maNV";

                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ten", _txtHoTen.Text);
                cmd.Parameters.AddWithValue("@ns", _dtpNgaySinh.Value);
                cmd.Parameters.AddWithValue("@dc", _txtDiaChi.Text);
                cmd.Parameters.AddWithValue("@sdt", _txtSoDienThoai.Text);
                cmd.Parameters.AddWithValue("@email", _txtEmail.Text);
                cmd.Parameters.AddWithValue("@maNV", _maNhanVien.Trim());

                cmd.ExecuteNonQuery();
                _lblGreeting.Text = $"Xin chào, {_txtHoTen.Text}";
                MessageBox.Show("Đã cập nhật thông tin thành công!");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi cập nhật: " + ex.Message); }
        }

        private void CaiDatProfileForm_Load(object sender, EventArgs e) { }
    }
}
