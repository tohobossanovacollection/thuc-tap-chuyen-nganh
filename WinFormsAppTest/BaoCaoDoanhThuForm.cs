using System.Data;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Data.SqlClient;

namespace WinFormsAppTest
{
    public partial class BaoCaoDoanhThuForm : Form
    {
        private readonly string _connectionString = DatabaseConfig.ConnectionString;

        public BaoCaoDoanhThuForm()
        {
            InitializeComponent();
            _dtpFrom.Value = DateTime.Today.AddDays(-29);
            _dtpTo.Value = DateTime.Today;
            LoadRevenueByRange();
        }

        private void LoadRevenueByRange()
        {
            try
            {
                const string query = @"
SELECT CAST(ngay_gio_ban AS DATE) AS Ngay,
       SUM(thanh_tien_cuoi) AS DoanhThu
FROM hoa_don
WHERE CAST(ngay_gio_ban AS DATE) BETWEEN @fromDate AND @toDate
GROUP BY CAST(ngay_gio_ban AS DATE)
ORDER BY Ngay;";

                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@fromDate", _dtpFrom.Value.Date);
                da.SelectCommand.Parameters.AddWithValue("@toDate", _dtpTo.Value.Date);

                DataTable dt = new DataTable();
                da.Fill(dt);
                _dgv.DataSource = dt;

                _chart.Series[0].Points.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    _chart.Series[0].Points.AddXY(
                        Convert.ToDateTime(row["Ngay"]).ToString("dd/MM"),
                        Convert.ToDecimal(row["DoanhThu"]));
                }

                if (!_dgv.Columns.Contains("Ngay"))
                {
                    return;
                }

                _dgv.Columns["Ngay"].HeaderText = "Ngày";
                _dgv.Columns["Ngay"].DefaultCellStyle.Format = "dd/MM/yyyy";
                _dgv.Columns["DoanhThu"].HeaderText = "Doanh thu";
                _dgv.Columns["DoanhThu"].DefaultCellStyle.Format = "N0";

                LoadCategoryRevenuePie();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không tải được dữ liệu doanh thu: {ex.Message}");
            }
        }

        private void LoadCategoryRevenuePie()
        {
            const string categoryRevenueQuery = @"
SELECT
    ISNULL(dm.ten_danh_muc, N'Khác') AS DanhMuc,
    SUM(ct.thanh_tien) AS DoanhThu
FROM hoa_don hd
INNER JOIN chi_tiet_hoa_don ct ON ct.ma_hoa_don = hd.ma_hoa_don
LEFT JOIN san_pham sp ON sp.ma_san_pham = ct.ma_san_pham
LEFT JOIN danh_muc_san_pham dm ON dm.ma_danh_muc = sp.ma_danh_muc
WHERE CAST(hd.ngay_gio_ban AS DATE) BETWEEN @fromDate AND @toDate
GROUP BY ISNULL(dm.ten_danh_muc, N'Khác')
ORDER BY DoanhThu DESC;";

            using SqlConnection conn = new SqlConnection(_connectionString);
            using SqlDataAdapter da = new SqlDataAdapter(categoryRevenueQuery, conn);
            da.SelectCommand.Parameters.AddWithValue("@fromDate", _dtpFrom.Value.Date);
            da.SelectCommand.Parameters.AddWithValue("@toDate", _dtpTo.Value.Date);

            DataTable dtCategory = new DataTable();
            da.Fill(dtCategory);

            Series pieSeries = _chartCategoryPie.Series["TyLeDanhMuc"];
            pieSeries.Points.Clear();

            foreach (DataRow row in dtCategory.Rows)
            {
                string danhMuc = Convert.ToString(row["DanhMuc"]) ?? "Khác";
                decimal doanhThu = row["DoanhThu"] == DBNull.Value ? 0M : Convert.ToDecimal(row["DoanhThu"]);
                int pointIndex = pieSeries.Points.AddXY(danhMuc, doanhThu);

                DataPoint point = pieSeries.Points[pointIndex];
                point.LegendText = danhMuc;
                point.Label = "#PERCENT{P0}";
                point.ToolTip = $"{danhMuc}: {doanhThu:N0} đ (#PERCENT{{P1}})";
            }
        }

        private void btnXemBieuDo_Click(object sender, EventArgs e)
        {
            if (_dtpFrom.Value.Date > _dtpTo.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.");
                return;
            }

            LoadRevenueByRange();
        }

        private void _top_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
