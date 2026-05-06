using System.Data;
using System.Linq;
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
                UpdateLowStockUI(dt);

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

        private void UpdateLowStockUI(DataTable dt)
        {
            // 1. Cảnh báo 5 sản phẩm sắp hết (giữ nguyên logic cũ cho Label)
            var lowStockProducts = dt.AsEnumerable()
                .OrderBy(r => r.Field<int>("so_luong_ton"))
                .Take(5)
                .ToList();

            string warningText = "⚠️ CẢNH BÁO HÀNG SẮP HẾT:\n";
            if (lowStockProducts.Count == 0)
            {
                _lblWarning.Text = "✅ Tình trạng tồn kho ổn định.";
            }
            else
            {
                foreach (var row in lowStockProducts)
                {
                    warningText += $"• {row.Field<string>("ten_san_pham")} (Tồn: {row.Field<int>("so_luong_ton")})\n";
                }
                _lblWarning.Text = warningText;
            }

            // 2. Biểu đồ 5 DANH MỤC có tổng tồn thấp nhất
            try
            {
                const string catQuery = @"
                    SELECT TOP 5 dm.ten_danh_muc, SUM(sp.so_luong_ton) as TongTon
                    FROM san_pham sp
                    JOIN danh_muc_san_pham dm ON dm.ma_danh_muc = sp.ma_danh_muc
                    GROUP BY dm.ten_danh_muc
                    ORDER BY TongTon ASC";

                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlCommand cmd = new SqlCommand(catQuery, conn);
                conn.Open();
                using SqlDataReader reader = cmd.ExecuteReader();

                _chartLowStock.Series[0].Points.Clear();
                _chartLowStock.Series[0].Name = "Tổng tồn theo danh mục";
                
                while (reader.Read())
                {
                    string catName = reader.GetString(0);
                    int totalStock = reader.GetInt32(1);
                    _chartLowStock.Series[0].Points.AddXY(catName, totalStock);
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Lỗi tải biểu đồ danh mục: " + ex.Message);
            }
        }
    }
}
