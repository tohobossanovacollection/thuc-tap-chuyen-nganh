using System.Data;
using Microsoft.Data.SqlClient;

namespace WinFormsAppTest
{
    public partial class QuanLyNhanVienForm : Form
    {
        private readonly string _connectionString = DatabaseConfig.ConnectionString;
        private string _selectedEmployeeId = "";

        public QuanLyNhanVienForm()
        {
            InitializeComponent();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnGanTk.Enabled = false;
            _dgv.CellClick += (s, e) => UpdateButtonStates();
        }

        private void QuanLyNhanVienForm_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            const string query = @"SELECT ma_nhan_vien, ma_tai_khoan, ho_ten, ngay_sinh, dia_chi, so_dien_thoai, email, chuc_vu, phong_ban, trang_thai 
                                   FROM nhan_vien 
                                   ORDER BY ho_ten";
            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                _dgv.DataSource = dt;

                // Set column headers
                _dgv.Columns["ma_nhan_vien"].HeaderText = "Mã nhân viên";
                _dgv.Columns["ma_tai_khoan"].HeaderText = "Mã tài khoản";
                _dgv.Columns["ho_ten"].HeaderText = "Họ tên";
                _dgv.Columns["ngay_sinh"].HeaderText = "Ngày sinh";
                _dgv.Columns["dia_chi"].HeaderText = "Địa chỉ";
                _dgv.Columns["so_dien_thoai"].HeaderText = "Số điện thoại";
                _dgv.Columns["email"].HeaderText = "Email";
                _dgv.Columns["chuc_vu"].HeaderText = "Chức vụ";
                _dgv.Columns["phong_ban"].HeaderText = "Phòng ban";
                _dgv.Columns["trang_thai"].HeaderText = "Trạng thái";

                UpdateButtonStates();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách nhân viên: {ex.Message}");
            }
        }

        private void UpdateButtonStates()
        {
            bool hasSelection = _dgv.SelectedRows.Count > 0;
            btnSua.Enabled = hasSelection;
            btnXoa.Enabled = hasSelection;
            btnGanTk.Enabled = hasSelection;

            if (hasSelection)
            {
                _selectedEmployeeId = _dgv.SelectedRows[0].Cells["ma_nhan_vien"].Value?.ToString() ?? "";
            }
        }

        private void btnCrud_Click(object sender, EventArgs e)
        {
            using var dlg = new NhanVienEditDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                if (string.IsNullOrWhiteSpace(dlg.Ma) || string.IsNullOrWhiteSpace(dlg.HoTen))
                {
                    MessageBox.Show("Vui lòng nhập mã và họ tên nhân viên.");
                    return;
                }

                const string query = @"INSERT INTO nhan_vien (ma_nhan_vien, ho_ten, ngay_sinh, dia_chi, so_dien_thoai, email, chuc_vu, phong_ban, trang_thai) 
                                       VALUES (@ma, @hoten, @ngaysinh, @diachi, @sdienthoai, @email, @chucvu, @phongban, @trangthai)";
                try
                {
                    using SqlConnection conn = new SqlConnection(_connectionString);
                    using SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma", dlg.Ma.Trim());
                    cmd.Parameters.AddWithValue("@hoten", dlg.HoTen.Trim());
                    cmd.Parameters.AddWithValue("@ngaysinh", dlg.NgaySinh ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@diachi", dlg.DiaChi?.Trim() ?? "");
                    cmd.Parameters.AddWithValue("@sdienthoai", dlg.SoDienThoai?.Trim() ?? "");
                    cmd.Parameters.AddWithValue("@email", dlg.Email?.Trim() ?? "");
                    cmd.Parameters.AddWithValue("@chucvu", dlg.ChucVu?.Trim() ?? "");
                    cmd.Parameters.AddWithValue("@phongban", dlg.PhongBan?.Trim() ?? "");
                    cmd.Parameters.AddWithValue("@trangthai", dlg.TrangThai?.Trim() ?? "Hoạt động");
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadEmployees();
                    MessageBox.Show("Thêm nhân viên thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Thêm nhân viên thất bại: {ex.Message}");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên để sửa.");
                return;
            }

            var row = _dgv.SelectedRows[0];
            string ma = row.Cells["ma_nhan_vien"].Value?.ToString() ?? "";

            using var dlg = new NhanVienEditDialog();
            dlg.Ma = ma;
            dlg.HoTen = row.Cells["ho_ten"].Value?.ToString() ?? "";
            dlg.NgaySinh = row.Cells["ngay_sinh"].Value as DateTime?;
            dlg.DiaChi = row.Cells["dia_chi"].Value?.ToString() ?? "";
            dlg.SoDienThoai = row.Cells["so_dien_thoai"].Value?.ToString() ?? "";
            dlg.Email = row.Cells["email"].Value?.ToString() ?? "";
            dlg.ChucVu = row.Cells["chuc_vu"].Value?.ToString() ?? "";
            dlg.PhongBan = row.Cells["phong_ban"].Value?.ToString() ?? "";
            dlg.TrangThai = row.Cells["trang_thai"].Value?.ToString() ?? "Hoạt động";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                if (string.IsNullOrWhiteSpace(dlg.HoTen))
                {
                    MessageBox.Show("Vui lòng nhập họ tên nhân viên.");
                    return;
                }

                const string query = @"UPDATE nhan_vien 
                                       SET ho_ten = @hoten, ngay_sinh = @ngaysinh, dia_chi = @diachi, so_dien_thoai = @sdienthoai, 
                                           email = @email, chuc_vu = @chucvu, phong_ban = @phongban, trang_thai = @trangthai
                                       WHERE ma_nhan_vien = @ma";
                try
                {
                    using SqlConnection conn = new SqlConnection(_connectionString);
                    using SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma", ma);
                    cmd.Parameters.AddWithValue("@hoten", dlg.HoTen.Trim());
                    cmd.Parameters.AddWithValue("@ngaysinh", dlg.NgaySinh ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@diachi", dlg.DiaChi?.Trim() ?? "");
                    cmd.Parameters.AddWithValue("@sdienthoai", dlg.SoDienThoai?.Trim() ?? "");
                    cmd.Parameters.AddWithValue("@email", dlg.Email?.Trim() ?? "");
                    cmd.Parameters.AddWithValue("@chucvu", dlg.ChucVu?.Trim() ?? "");
                    cmd.Parameters.AddWithValue("@phongban", dlg.PhongBan?.Trim() ?? "");
                    cmd.Parameters.AddWithValue("@trangthai", dlg.TrangThai?.Trim() ?? "Hoạt động");
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadEmployees();
                    MessageBox.Show("Cập nhật nhân viên thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Cập nhật nhân viên thất bại: {ex.Message}");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhân viên để xóa.");
                return;
            }

            var row = _dgv.SelectedRows[0];
            string ma = row.Cells["ma_nhan_vien"].Value?.ToString() ?? "";
            string hoTen = row.Cells["ho_ten"].Value?.ToString() ?? "";

            if (MessageBox.Show($"Bạn có chắc muốn xóa nhân viên \"{hoTen}\"?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            const string query = "DELETE FROM nhan_vien WHERE ma_nhan_vien = @ma";
            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma", ma);
                conn.Open();
                cmd.ExecuteNonQuery();
                LoadEmployees();
                MessageBox.Show("Xóa nhân viên thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xóa nhân viên thất bại: {ex.Message}");
            }
        }

        private void btnGanTk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_selectedEmployeeId))
            {
                MessageBox.Show("Vui lòng chọn nhân viên để gán tài khoản.");
                return;
            }

            MessageBox.Show("Chức năng gán tài khoản cho nhân viên.");
        }
    }
}
