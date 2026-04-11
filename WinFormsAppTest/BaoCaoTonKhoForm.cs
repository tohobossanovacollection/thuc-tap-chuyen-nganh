using System.Data;
using Microsoft.Data.SqlClient;

namespace WinFormsAppTest
{
    public partial class BaoCaoTonKhoForm : Form
    {
        private readonly string _connectionString = DatabaseConfig.ConnectionString;

        public BaoCaoTonKhoForm()
        {
            InitializeComponent();
            _cmbTrangThai.Items.AddRange(new object[] { "Còn hàng", "Hết hàng" });
            _cmbTrangThai.SelectedIndex = 0;
            LoadTonKho();
        }

        private void LoadTonKho()
        {
            try
            {
                string condition = _cmbTrangThai.SelectedIndex == 1 ? "so_luong_ton = 0" : "so_luong_ton > 0";
                string query = $@"SELECT ma_san_pham, ten_san_pham, so_luong_ton, gia_ban
                                  FROM san_pham
                                  WHERE {condition}
                                  ORDER BY so_luong_ton ASC, ten_san_pham";

                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                _dgvTonKho.DataSource = dt;

                if (_dgvTonKho.Columns.Contains("ma_san_pham")) _dgvTonKho.Columns["ma_san_pham"].HeaderText = "Mã SP";
                if (_dgvTonKho.Columns.Contains("ten_san_pham")) _dgvTonKho.Columns["ten_san_pham"].HeaderText = "Tên sản phẩm";
                if (_dgvTonKho.Columns.Contains("so_luong_ton")) _dgvTonKho.Columns["so_luong_ton"].HeaderText = "Tồn kho";
                if (_dgvTonKho.Columns.Contains("gia_ban"))
                {
                    _dgvTonKho.Columns["gia_ban"].HeaderText = "Giá bán";
                    _dgvTonKho.Columns["gia_ban"].DefaultCellStyle.Format = "N0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không tải được dữ liệu tồn kho: {ex.Message}");
            }
        }

        private static void SetupGrid(DataGridView dgv)
        {
            dgv.Dock = DockStyle.Fill;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            LoadTonKho();
        }
    }
}
