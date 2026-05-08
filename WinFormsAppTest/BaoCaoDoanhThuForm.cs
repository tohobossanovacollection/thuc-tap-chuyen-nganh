using System.Data;
using System.Text;
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

                decimal totalRevenue = 0M;
                _chart.Series[0].Points.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    decimal revenue = row["DoanhThu"] == DBNull.Value ? 0M : Convert.ToDecimal(row["DoanhThu"]);
                    totalRevenue += revenue;
                    _chart.Series[0].Points.AddXY(
                        Convert.ToDateTime(row["Ngay"]).ToString("dd/MM"),
                        revenue);
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
                
                string rangeText = $"Báo cáo từ ngày {_dtpFrom.Value:dd/MM/yyyy} đến ngày {_dtpTo.Value:dd/MM/yyyy}";
                _lblRangeLine.Text = rangeText;
                _lblRangePie.Text = rangeText;
                _lblTotalRevenue.Text = $"Tổng thành tiền: {totalRevenue:N0} đ";
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

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            if (_dgv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string title = $"Báo cáo doanh thu từ ngày {_dtpFrom.Value:dd/MM/yyyy} đến ngày {_dtpTo.Value:dd/MM/yyyy}";
            string defaultFileName = $"BaoCaoDoanhThu_{_dtpFrom.Value:yyyyMMdd}_{_dtpTo.Value:yyyyMMdd}.csv";

            using SaveFileDialog dialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv",
                FileName = defaultFileName
            };

            if (dialog.ShowDialog(this) != DialogResult.OK)
            {
                return;
            }

            try
            {
                ExportRevenueToCsv(dialog.FileName, title);
                MessageBox.Show("Xuất file thành công.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể xuất file: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportRevenueToCsv(string filePath, string title)
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(title);

            var columnNames = _dgv.Columns.Cast<DataGridViewColumn>()
                .Where(column => column.Visible)
                .Select(column => column.HeaderText);
            builder.AppendLine(string.Join(",", columnNames.Select(EscapeCsv)));

            decimal totalRevenue = 0M;
            foreach (DataGridViewRow row in _dgv.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                var values = row.Cells.Cast<DataGridViewCell>()
                    .Where(cell => cell.OwningColumn.Visible)
                    .Select(cell => EscapeCsv(cell.FormattedValue?.ToString() ?? ""));
                builder.AppendLine(string.Join(",", values));

                if (row.Cells["DoanhThu"]?.Value is not null && row.Cells["DoanhThu"].Value != DBNull.Value)
                {
                    totalRevenue += Convert.ToDecimal(row.Cells["DoanhThu"].Value);
                }
            }

            builder.AppendLine($"Tổng doanh thu,{EscapeCsv(totalRevenue.ToString("N0"))}");

            // Write with BOM for Excel Vietnamese support
            File.WriteAllText(filePath, "\uFEFF" + builder.ToString(), Encoding.UTF8);
        }

        private static string EscapeCsv(string? value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            string escaped = value.Replace("\"", "\"\"");
            return escaped.Contains(',') || escaped.Contains('"') || escaped.Contains('\n')
                ? $"\"{escaped}\""
                : escaped;
        }

        private void _top_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
