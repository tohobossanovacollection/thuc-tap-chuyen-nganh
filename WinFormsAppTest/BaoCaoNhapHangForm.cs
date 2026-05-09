using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Data.SqlClient;

namespace WinFormsAppTest
{
    public partial class BaoCaoNhapHangForm : Form
    {
        private readonly string _connectionString = DatabaseConfig.ConnectionString;

        public BaoCaoNhapHangForm()
        {
            InitializeComponent();
            _dtpFrom.Value = new System.DateTime(2026, 01, 01);
            _dtpTo.Value = DateTime.Today;
            LoadCharts();
        }

        private void BtnXemBieuDo_Click(object? sender, EventArgs e)
        {
            LoadCharts();
        }

        private void LoadCharts()
        {
            if (_dtpFrom.Value.Date > _dtpTo.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.");
                return;
            }

            LoadSupplierChart();
            LoadProductChart();
        }

        private void LoadSupplierChart()
        {
            try
            {
                const string query = @"
SELECT TOP 5 ncc.ten_nha_cung_cap AS NhaCungCap, SUM(pnh.tong_tien) AS TongTien
FROM phieu_nhap_hang pnh
JOIN nha_cung_cap ncc ON pnh.ma_nha_cung_cap = ncc.ma_nha_cung_cap
WHERE CAST(pnh.ngay_nhap AS DATE) BETWEEN @fromDate AND @toDate
GROUP BY ncc.ten_nha_cung_cap
ORDER BY TongTien DESC;";

                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@fromDate", _dtpFrom.Value.Date);
                da.SelectCommand.Parameters.AddWithValue("@toDate", _dtpTo.Value.Date);

                DataTable dt = new DataTable();
                da.Fill(dt);

                _chartSupplier.Series[0].Points.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    string name = Convert.ToString(row["NhaCungCap"]) ?? "Unknown";
                    if (name.Length > 20) name = name.Substring(0, 20) + "...";

                    decimal amount = row["TongTien"] == DBNull.Value ? 0M : Convert.ToDecimal(row["TongTien"]);
                    var p = _chartSupplier.Series[0].Points.AddXY(name, amount);
                    _chartSupplier.Series[0].Points[p].Label = amount.ToString("N0");
                    _chartSupplier.Series[0].Points[p].ToolTip = $"{name}: {amount:N0} đ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải biểu đồ nhà cung cấp: {ex.Message}");
            }
        }

        private void LoadProductChart()
        {
            try
            {
                const string query = @"
SELECT TOP 5 sp.ten_san_pham AS SanPham, SUM(ctpn.so_luong) AS SoLuong
FROM chi_tiet_phieu_nhap ctpn
JOIN phieu_nhap_hang pnh ON ctpn.ma_phieu_nhap = pnh.ma_phieu_nhap
JOIN san_pham sp ON ctpn.ma_san_pham = sp.ma_san_pham
WHERE CAST(pnh.ngay_nhap AS DATE) BETWEEN @fromDate AND @toDate
GROUP BY sp.ten_san_pham
ORDER BY SoLuong DESC;";

                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.SelectCommand.Parameters.AddWithValue("@fromDate", _dtpFrom.Value.Date);
                da.SelectCommand.Parameters.AddWithValue("@toDate", _dtpTo.Value.Date);

                DataTable dt = new DataTable();
                da.Fill(dt);

                _chartProduct.Series[0].Points.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    string name = Convert.ToString(row["SanPham"]) ?? "Unknown";
                    if (name.Length > 20) name = name.Substring(0, 20) + "...";

                    int qty = row["SoLuong"] == DBNull.Value ? 0 : Convert.ToInt32(row["SoLuong"]);
                    var p = _chartProduct.Series[0].Points.AddXY(name, qty);
                    _chartProduct.Series[0].Points[p].Label = "#PERCENT{P0}";
                    _chartProduct.Series[0].Points[p].LegendText = name;
                    _chartProduct.Series[0].Points[p].ToolTip = $"{name}: {qty:N0} (#PERCENT{{P1}})";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải biểu đồ sản phẩm: {ex.Message}");
            }
        }
    }
}