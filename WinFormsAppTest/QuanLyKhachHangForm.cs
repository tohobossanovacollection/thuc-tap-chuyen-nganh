using System.Data;
using Microsoft.Data.SqlClient;

namespace WinFormsAppTest
{
    public partial class QuanLyKhachHangForm : Form
    {
        private readonly string _connectionString = DatabaseConfig.ConnectionString;
        private string _selectedCustomerId = "";

        public QuanLyKhachHangForm()
        {
            InitializeComponent();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            _btnHistory.Enabled = false;
            _dgv.CellClick += (s, e) => UpdateButtonStates();
        }

        private void QuanLyKhachHangForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            const string query = "SELECT ma_khach_hang, ten_khach_hang, so_dien_thoai, dia_chi FROM khach_hang ORDER BY ten_khach_hang";
            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                _dgv.DataSource = dt;
                _dgv.Columns["ma_khach_hang"].HeaderText = "Mã khách hàng";
                _dgv.Columns["ten_khach_hang"].HeaderText = "Tên khách hàng";
                _dgv.Columns["so_dien_thoai"].HeaderText = "Số điện thoại";
                _dgv.Columns["dia_chi"].HeaderText = "Địa chỉ";
                UpdateButtonStates();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách khách hàng: {ex.Message}");
            }
        }

        private void UpdateButtonStates()
        {
            bool hasSelection = _dgv.SelectedRows.Count > 0;
            btnSua.Enabled = hasSelection;
            btnXoa.Enabled = hasSelection;
            _btnHistory.Enabled = hasSelection;

            if (hasSelection)
            {
                _selectedCustomerId = _dgv.SelectedRows[0].Cells["ma_khach_hang"].Value?.ToString() ?? "";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using var dlg = new KhachHangEditDialog();
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                if (string.IsNullOrWhiteSpace(dlg.Ma) || string.IsNullOrWhiteSpace(dlg.Ten))
                {
                    MessageBox.Show("Vui lòng nhập mã và tên khách hàng.");
                    return;
                }

                const string query = @"INSERT INTO khach_hang (ma_khach_hang, ten_khach_hang, so_dien_thoai, dia_chi) 
                                       VALUES (@ma, @ten, @dienthoai, @diachi)";
                try
                {
                    using SqlConnection conn = new SqlConnection(_connectionString);
                    using SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma", dlg.Ma.Trim());
                    cmd.Parameters.AddWithValue("@ten", dlg.Ten.Trim());
                    cmd.Parameters.AddWithValue("@dienthoai", dlg.DienThoai?.Trim() ?? "");
                    cmd.Parameters.AddWithValue("@diachi", dlg.DiaChi?.Trim() ?? "");
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadCustomers();
                    MessageBox.Show("Thêm khách hàng thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Thêm khách hàng thất bại: {ex.Message}");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng để sửa.");
                return;
            }

            var row = _dgv.SelectedRows[0];
            string ma = row.Cells["ma_khach_hang"].Value?.ToString() ?? "";
            string ten = row.Cells["ten_khach_hang"].Value?.ToString() ?? "";
            string dienthoai = row.Cells["so_dien_thoai"].Value?.ToString() ?? "";
            string diachi = row.Cells["dia_chi"].Value?.ToString() ?? "";

            using var dlg = new KhachHangEditDialog();
            dlg.Ma = ma;
            dlg.Ten = ten;
            dlg.DienThoai = dienthoai;
            dlg.DiaChi = diachi;

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                if (string.IsNullOrWhiteSpace(dlg.Ten))
                {
                    MessageBox.Show("Vui lòng nhập tên khách hàng.");
                    return;
                }

                const string query = @"UPDATE khach_hang 
                                       SET ten_khach_hang = @ten, so_dien_thoai = @dienthoai, dia_chi = @diachi
                                       WHERE ma_khach_hang = @ma";
                try
                {
                    using SqlConnection conn = new SqlConnection(_connectionString);
                    using SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma", ma);
                    cmd.Parameters.AddWithValue("@ten", dlg.Ten.Trim());
                    cmd.Parameters.AddWithValue("@dienthoai", dlg.DienThoai?.Trim() ?? "");
                    cmd.Parameters.AddWithValue("@diachi", dlg.DiaChi?.Trim() ?? "");
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadCustomers();
                    MessageBox.Show("Cập nhật khách hàng thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Cập nhật khách hàng thất bại: {ex.Message}");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (_dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xóa.");
                return;
            }

            var row = _dgv.SelectedRows[0];
            string ma = row.Cells["ma_khach_hang"].Value?.ToString() ?? "";
            string ten = row.Cells["ten_khach_hang"].Value?.ToString() ?? "";

            if (MessageBox.Show($"Bạn có chắc muốn xóa khách hàng \"{ten}\"?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            const string query = "DELETE FROM khach_hang WHERE ma_khach_hang = @ma";
            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@ma", ma);
                conn.Open();
                cmd.ExecuteNonQuery();
                LoadCustomers();
                MessageBox.Show("Xóa khách hàng thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xóa khách hàng thất bại: {ex.Message}");
            }
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_selectedCustomerId))
            {
                MessageBox.Show("Vui lòng chọn khách hàng để xem lịch sử.");
                return;
            }

            try
            {
                const string query = @"SELECT hd.ma_hoa_don, hd.ngay_gio_ban, hd.tong_tien, hd.giam_gia, hd.thanh_tien_cuoi
                                       FROM hoa_don hd
                                       WHERE hd.ma_khach_hang = @ma
                                       ORDER BY hd.ngay_gio_ban DESC";
                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@ma", _selectedCustomerId);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Khách hàng này chưa có hóa đơn nào.");
                    return;
                }

                using var historyForm = new Form();
                historyForm.Text = $"Lịch sử mua hàng - {_dgv.SelectedRows[0].Cells["ten_khach_hang"].Value}";
                historyForm.Size = new Size(900, 500);
                historyForm.StartPosition = FormStartPosition.CenterParent;

                DataGridView dgvHistory = new DataGridView();
                dgvHistory.AutoGenerateColumns = false;
                dgvHistory.ReadOnly = true;
                dgvHistory.Dock = DockStyle.Fill;
                dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                // Create columns manually
                dgvHistory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ma_hoa_don", HeaderText = "Mã hóa đơn" });
                dgvHistory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ngay_gio_ban", HeaderText = "Ngày giờ" });
                dgvHistory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "tong_tien", HeaderText = "Tổng tiền" });
                dgvHistory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "giam_gia", HeaderText = "Giảm giá" });
                dgvHistory.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "thanh_tien_cuoi", HeaderText = "Thành tiền" });

                dgvHistory.DataSource = dt;

                historyForm.Controls.Add(dgvHistory);
                historyForm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xem lịch sử: {ex.Message}");
            }
        }
    }
}
