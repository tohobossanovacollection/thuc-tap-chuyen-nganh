using System.Data;
using Microsoft.Data.SqlClient;

namespace WinFormsAppTest
{
    public partial class QuanLySanPhamForm : Form
    {
        private readonly string _connectionString = DatabaseConfig.ConnectionString;

        public QuanLySanPhamForm()
        {
            InitializeComponent();
        }

        private void QuanLySanPhamForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using SanPham popup = new SanPham();
            if (popup.ShowDialog(this) != DialogResult.OK || popup.Result is null)
            {
                return;
            }

            if (!TryResolveCategoryIdByName(popup.Result.DanhMuc, out string maDanhMuc))
            {
                MessageBox.Show("Danh mục không tồn tại. Vui lòng nhập đúng tên danh mục trong bảng danh_muc_san_pham.");
                return;
            }

            const string query = @"
INSERT INTO san_pham (ma_san_pham, ma_danh_muc, ten_san_pham, gia_nhap, gia_ban, so_luong_ton, mo_ta_san_pham)
VALUES (@ma, @maDanhMuc, @ten, @giaNhap, @giaBan, @ton, @moTa);";

            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma", popup.Result.MaSanPham);
                cmd.Parameters.AddWithValue("@maDanhMuc", maDanhMuc);
                cmd.Parameters.AddWithValue("@ten", popup.Result.TenSanPham);
                cmd.Parameters.AddWithValue("@giaNhap", popup.Result.GiaNhap);
                cmd.Parameters.AddWithValue("@giaBan", popup.Result.GiaBan);
                cmd.Parameters.AddWithValue("@ton", popup.Result.SoLuongTon);
                cmd.Parameters.AddWithValue("@moTa", string.IsNullOrWhiteSpace(popup.Result.MoTa) ? (object)DBNull.Value : popup.Result.MoTa);
                conn.Open();
                cmd.ExecuteNonQuery();

                LoadProducts();
                MessageBox.Show("Thêm sản phẩm thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Thêm sản phẩm thất bại: {ex.Message}");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow is null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần sửa.");
                return;
            }

            ProductItemData current = new ProductItemData
            {
                MaSanPham = Convert.ToString(dgvSanPham.CurrentRow.Cells["ma_san_pham"].Value) ?? string.Empty,
                TenSanPham = Convert.ToString(dgvSanPham.CurrentRow.Cells["ten_san_pham"].Value) ?? string.Empty,
                DanhMuc = Convert.ToString(dgvSanPham.CurrentRow.Cells["ten_danh_muc"].Value) ?? string.Empty,
                GiaNhap = Convert.ToDecimal(dgvSanPham.CurrentRow.Cells["gia_nhap"].Value),
                GiaBan = Convert.ToDecimal(dgvSanPham.CurrentRow.Cells["gia_ban"].Value),
                SoLuongTon = Convert.ToInt32(dgvSanPham.CurrentRow.Cells["so_luong_ton"].Value),
                MoTa = Convert.ToString(dgvSanPham.CurrentRow.Cells["mo_ta_san_pham"].Value) ?? string.Empty
            };

            using SanPham popup = new SanPham(current);
            if (popup.ShowDialog(this) != DialogResult.OK || popup.Result is null)
            {
                return;
            }

            if (!TryResolveCategoryIdByName(popup.Result.DanhMuc, out string maDanhMuc))
            {
                MessageBox.Show("Danh mục không tồn tại. Vui lòng nhập đúng tên danh mục trong bảng danh_muc_san_pham.");
                return;
            }

            const string query = @"
UPDATE san_pham
SET ma_danh_muc = @maDanhMuc,
    ten_san_pham = @ten,
    gia_nhap = @giaNhap,
    gia_ban = @giaBan,
    so_luong_ton = @ton,
    mo_ta_san_pham = @moTa
WHERE ma_san_pham = @ma;";

            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma", popup.Result.MaSanPham);
                cmd.Parameters.AddWithValue("@maDanhMuc", maDanhMuc);
                cmd.Parameters.AddWithValue("@ten", popup.Result.TenSanPham);
                cmd.Parameters.AddWithValue("@giaNhap", popup.Result.GiaNhap);
                cmd.Parameters.AddWithValue("@giaBan", popup.Result.GiaBan);
                cmd.Parameters.AddWithValue("@ton", popup.Result.SoLuongTon);
                cmd.Parameters.AddWithValue("@moTa", string.IsNullOrWhiteSpace(popup.Result.MoTa) ? (object)DBNull.Value : popup.Result.MoTa);
                conn.Open();
                cmd.ExecuteNonQuery();

                LoadProducts();
                MessageBox.Show("Cập nhật sản phẩm thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cập nhật sản phẩm thất bại: {ex.Message}");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.CurrentRow is null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.");
                return;
            }

            string ma = Convert.ToString(dgvSanPham.CurrentRow.Cells["ma_san_pham"].Value) ?? string.Empty;
            if (string.IsNullOrWhiteSpace(ma))
            {
                return;
            }

            if (MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm {ma}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            const string query = "DELETE FROM san_pham WHERE ma_san_pham = @ma;";
            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma", ma);
                conn.Open();
                cmd.ExecuteNonQuery();

                LoadProducts();
                MessageBox.Show("Xóa sản phẩm thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xóa sản phẩm thất bại: {ex.Message}");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            using QuanLyDanhMucForm form = new QuanLyDanhMucForm();
            form.ShowDialog(this);
        }

        private void LoadProducts()
        {
            const string query = @"
SELECT sp.ma_san_pham,
       dm.ten_danh_muc,
       sp.ten_san_pham,
       sp.gia_nhap,
       sp.gia_ban,
       sp.so_luong_ton,
       sp.mo_ta_san_pham
FROM san_pham sp
JOIN danh_muc_san_pham dm ON dm.ma_danh_muc = sp.ma_danh_muc
ORDER BY sp.ten_san_pham;";

            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSanPham.DataSource = dt;

            if (!dgvSanPham.Columns.Contains("ma_san_pham"))
            {
                return;
            }

            dgvSanPham.Columns["ma_san_pham"].HeaderText = "Mã SP";
            dgvSanPham.Columns["ten_danh_muc"].HeaderText = "Danh mục";
            dgvSanPham.Columns["ten_san_pham"].HeaderText = "Tên sản phẩm";
            dgvSanPham.Columns["gia_nhap"].HeaderText = "Giá nhập";
            dgvSanPham.Columns["gia_ban"].HeaderText = "Giá bán";
            dgvSanPham.Columns["so_luong_ton"].HeaderText = "Tồn kho";
            dgvSanPham.Columns["mo_ta_san_pham"].HeaderText = "Mô tả";

            dgvSanPham.Columns["gia_nhap"].DefaultCellStyle.Format = "N0";
            dgvSanPham.Columns["gia_ban"].DefaultCellStyle.Format = "N0";
            dgvSanPham.Columns["so_luong_ton"].DefaultCellStyle.Format = "N0";
        }

        private bool TryResolveCategoryIdByName(string categoryName, out string categoryId)
        {
            categoryId = string.Empty;
            if (string.IsNullOrWhiteSpace(categoryName))
            {
                return false;
            }

            const string query = "SELECT TOP 1 ma_danh_muc FROM danh_muc_san_pham WHERE ten_danh_muc = @ten";
            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ten", categoryName.Trim());
            conn.Open();

            object? result = cmd.ExecuteScalar();
            if (result is null || result == DBNull.Value)
            {
                return false;
            }

            categoryId = Convert.ToString(result) ?? string.Empty;
            return !string.IsNullOrWhiteSpace(categoryId);
        }
    }
}
