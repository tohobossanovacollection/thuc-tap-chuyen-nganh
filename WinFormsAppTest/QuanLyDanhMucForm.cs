using System.Data;
using Microsoft.Data.SqlClient;

namespace WinFormsAppTest
{
    public partial class QuanLyDanhMucForm : Form
    {
        private readonly string _connectionString = DatabaseConfig.ConnectionString;

        public QuanLyDanhMucForm()
        {
            InitializeComponent();
            LoadCategories();
            _btnSua.Enabled = false;
        }

        private void LoadCategories()
        {
            const string query = "SELECT ma_danh_muc, ten_danh_muc FROM danh_muc_san_pham ORDER BY ten_danh_muc";
            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            _dgv.DataSource = dt;
            _dgv.Columns["ma_danh_muc"].HeaderText = "Mã danh mục";
            _dgv.Columns["ten_danh_muc"].HeaderText = "Tên danh mục";
        }

        private void _dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                _btnSua.Enabled = false;
                return;
            }

            string maDanhMuc = Convert.ToString(_dgv.Rows[e.RowIndex].Cells["ma_danh_muc"].Value) ?? string.Empty;
            string tenDanhMuc = Convert.ToString(_dgv.Rows[e.RowIndex].Cells["ten_danh_muc"].Value) ?? string.Empty;

            _txtMa.Text = maDanhMuc;
            _txtTen.Text = tenDanhMuc;
            _btnSua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_txtMa.Text) || string.IsNullOrWhiteSpace(_txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập mã và tên danh mục.");
                return;
            }

            const string query = @"INSERT INTO danh_muc_san_pham (ma_danh_muc, ten_danh_muc) 
                                   VALUES (@ma, @ten)";
            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma", _txtMa.Text.Trim());
                cmd.Parameters.AddWithValue("@ten", _txtTen.Text.Trim());
                conn.Open();
                cmd.ExecuteNonQuery();

                _txtMa.Clear();
                _txtTen.Clear();
                _btnSua.Enabled = false;
                LoadCategories();
                MessageBox.Show("Thêm danh mục thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Thêm danh mục thất bại: {ex.Message}");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_txtMa.Text) || string.IsNullOrWhiteSpace(_txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập mã và tên danh mục.");
                return;
            }

            string maDanhMuc = _txtMa.Text.Trim();
            string tenDanhMuc = _txtTen.Text.Trim();

            if (MessageBox.Show($"Cập nhật danh mục \"{tenDanhMuc}\"?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            const string query = @"UPDATE danh_muc_san_pham 
                                   SET ten_danh_muc = @ten 
                                   WHERE ma_danh_muc = @ma";
            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma", maDanhMuc);
                cmd.Parameters.AddWithValue("@ten", tenDanhMuc);
                conn.Open();
                cmd.ExecuteNonQuery();

                _txtMa.Clear();
                _txtTen.Clear();
                LoadCategories();
                _btnSua.Enabled = false;
                MessageBox.Show("Cập nhật danh mục thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cập nhật danh mục thất bại: {ex.Message}");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_dgv.CurrentRow is null)
            {
                MessageBox.Show("Vui lòng chọn danh mục cần xóa.");
                return;
            }

            string maDanhMuc = Convert.ToString(_dgv.CurrentRow.Cells["ma_danh_muc"].Value) ?? string.Empty;
            string tenDanhMuc = Convert.ToString(_dgv.CurrentRow.Cells["ten_danh_muc"].Value) ?? string.Empty;

            if (MessageBox.Show($"Bạn có chắc muốn xóa danh mục \"{tenDanhMuc}\"?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            const string query = "DELETE FROM danh_muc_san_pham WHERE ma_danh_muc = @ma";
            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma", maDanhMuc);
                conn.Open();
                cmd.ExecuteNonQuery();

                _txtMa.Clear();
                _txtTen.Clear();
                _btnSua.Enabled = false;
                LoadCategories();
                MessageBox.Show("Xóa danh mục thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xóa danh mục thất bại: {ex.Message}");
            }
        }
    }
}
