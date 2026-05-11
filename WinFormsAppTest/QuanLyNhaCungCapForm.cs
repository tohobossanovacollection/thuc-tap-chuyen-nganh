using System.Data;
using Microsoft.Data.SqlClient;

namespace WinFormsAppTest
{
    public partial class QuanLyNhaCungCapForm : Form
    {
        private readonly string _connectionString = DatabaseConfig.ConnectionString;
        private string _selectedSupplierId = "";

        public QuanLyNhaCungCapForm()
        {
            InitializeComponent();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            _dgv.CellClick += (s, e) => UpdateButtonStates();
        }

        private void QuanLyNhaCungCapForm_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            const string query = @"SELECT ma_nha_cung_cap, ten_nha_cung_cap, so_dien_thoai, dia_chi, email 
                                   FROM nha_cung_cap 
                                   ORDER BY ten_nha_cung_cap";
            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                _dgv.DataSource = dt;

                // Set column headers
                _dgv.Columns["ma_nha_cung_cap"].HeaderText = "Mã nhà cung cấp";
                _dgv.Columns["ten_nha_cung_cap"].HeaderText = "Tên nhà cung cấp";
                _dgv.Columns["so_dien_thoai"].HeaderText = "Số điện thoại";
                _dgv.Columns["dia_chi"].HeaderText = "Địa chỉ";
                _dgv.Columns["email"].HeaderText = "Email";

                UpdateButtonStates();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách nhà cung cấp: {ex.Message}");
            }
        }

        private void UpdateButtonStates()
        {
            bool hasSelection = _dgv.SelectedRows.Count > 0;
            btnSua.Enabled = hasSelection;
            btnXoa.Enabled = hasSelection;

            if (hasSelection)
            {
                _selectedSupplierId = _dgv.SelectedRows[0].Cells["ma_nha_cung_cap"].Value?.ToString() ?? "";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using var dlg = new NhaCungCapEditDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                if (string.IsNullOrWhiteSpace(dlg.Ma) || string.IsNullOrWhiteSpace(dlg.Ten))
                {
                    MessageBox.Show("Vui lòng nhập mã và tên nhà cung cấp.");
                    return;
                }

                const string query = @"INSERT INTO nha_cung_cap (ma_nha_cung_cap, ten_nha_cung_cap, so_dien_thoai, dia_chi, email) 
                                       VALUES (@ma, @ten, @dienthoai, @diachi, @email)";
                try
                {
                    using SqlConnection conn = new SqlConnection(_connectionString);
                    using SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma", dlg.Ma.Trim());
                    cmd.Parameters.AddWithValue("@ten", dlg.Ten.Trim());
                    cmd.Parameters.AddWithValue("@dienthoai", dlg.DienThoai?.Trim() ?? "");
                    cmd.Parameters.AddWithValue("@diachi", dlg.DiaChi?.Trim() ?? "");
                    cmd.Parameters.AddWithValue("@email", dlg.Email?.Trim() ?? "");
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadSuppliers();
                    MessageBox.Show("Thêm nhà cung cấp thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Thêm nhà cung cấp thất bại: {ex.Message}");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp để sửa.");
                return;
            }

            var row = _dgv.SelectedRows[0];
            string ma = row.Cells["ma_nha_cung_cap"].Value?.ToString() ?? "";

            using var dlg = new NhaCungCapEditDialog();
            dlg.Ma = ma;
            dlg.Ten = row.Cells["ten_nha_cung_cap"].Value?.ToString() ?? "";
            dlg.DienThoai = row.Cells["so_dien_thoai"].Value?.ToString() ?? "";
            dlg.DiaChi = row.Cells["dia_chi"].Value?.ToString() ?? "";
            dlg.Email = row.Cells["email"].Value?.ToString() ?? "";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                if (string.IsNullOrWhiteSpace(dlg.Ten))
                {
                    MessageBox.Show("Vui lòng nhập tên nhà cung cấp.");
                    return;
                }

                const string query = @"UPDATE nha_cung_cap 
                                       SET ten_nha_cung_cap = @ten, so_dien_thoai = @dienthoai, dia_chi = @diachi, email = @email
                                       WHERE ma_nha_cung_cap = @ma";
                try
                {
                    using SqlConnection conn = new SqlConnection(_connectionString);
                    using SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma", ma);
                    cmd.Parameters.AddWithValue("@ten", dlg.Ten.Trim());
                    cmd.Parameters.AddWithValue("@dienthoai", dlg.DienThoai?.Trim() ?? "");
                    cmd.Parameters.AddWithValue("@diachi", dlg.DiaChi?.Trim() ?? "");
                    cmd.Parameters.AddWithValue("@email", dlg.Email?.Trim() ?? "");
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadSuppliers();
                    MessageBox.Show("Cập nhật nhà cung cấp thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Cập nhật nhà cung cấp thất bại: {ex.Message}");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp để xóa.");
                return;
            }

            var row = _dgv.SelectedRows[0];
            string ma = row.Cells["ma_nha_cung_cap"].Value?.ToString() ?? "";
            string ten = row.Cells["ten_nha_cung_cap"].Value?.ToString() ?? "";

            if (MessageBox.Show($"Bạn có chắc muốn xóa nhà cung cấp \"{ten}\"?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            const string query = "DELETE FROM nha_cung_cap WHERE ma_nha_cung_cap = @ma";
            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma", ma);
                conn.Open();
                cmd.ExecuteNonQuery();
                LoadSuppliers();
                MessageBox.Show("Xóa nhà cung cấp thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xóa nhà cung cấp thất bại: {ex.Message}");
            }
        }

        private void _top_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
