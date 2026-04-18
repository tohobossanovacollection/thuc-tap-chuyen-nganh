using System.Data;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Data.SqlClient;
using WinFormsAppTest.Icons;

namespace WinFormsAppTest
{
    public partial class Dashboard : Form
    {
        private readonly string _connectionString = DatabaseConfig.ConnectionString;
        private readonly string _username;
        private readonly string _role;
        private readonly Panel _contentHost;
        private Form? _activeChildForm;
        private bool _isQuanLyMenuExpanded;
        private int _quanLyMenuOffset;
        private Point _nhapHangExpandedLocation;
        private Point _baoCaoExpandedLocation;
        private Point _caiDatExpandedLocation;

        public Dashboard(string username, string role)
        {
            InitializeComponent();
            _username = username;
            _role = role;
            CaptureMenuLayout();
            SetQuanLyMenuExpanded(false);
            LoadMenuIcons();

            _contentHost = new Panel
            {
                Location = new Point(280, 110),
                Size = new Size(1051, 598),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                BackColor = Color.White,
                Visible = false
            };
            Controls.Add(_contentHost);
            _contentHost.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Xin chào, {_username} ({_role})";
            LoadDashboardData();
        }

        private void btnMenuBanHang_Click(object sender, EventArgs e)
        {
            ShowChildFormInMain(new BanHangForm("NV01"));
        }

        private void btnMenuSanPham_Click(object sender, EventArgs e)
        {
            ShowChildFormInMain(new QuanLySanPhamForm());
        }

        private void btnMenuNhapHang_Click(object sender, EventArgs e)
        {
            ShowChildFormInMain(new QuanLyPhieuNhapForm());
        }

        private void btnMenuKhachHang_Click(object sender, EventArgs e)
        {
            ShowChildFormInMain(new QuanLyKhachHangForm());
        }

        private void btnMenuNhanVienTaiKhoan_Click(object sender, EventArgs e)
        {
            ShowChildFormInMain(new QuanLyNhanVienForm());
        }

        private void btnMenuKhuyenMai_Click(object sender, EventArgs e)
        {
            ShowChildFormInMain(new QuanLyGiamGiaForm());
        }

        private void btnMenuBaoCao_Click(object sender, EventArgs e)
        {
            ShowChildFormInMain(new BaoCaoMainForm());
        }

        private void btnMenuCaiDat_Click(object sender, EventArgs e)
        {
            ShowChildFormInMain(new CaiDatProfileForm());
        }

        private void btnMenuNhaCungCap_Click(object sender, EventArgs e)
        {
            ShowChildFormInMain(new QuanLyNhaCungCapForm());
        }

        private void btnMenuHoaDon_Click(object sender, EventArgs e)
        {
            //ShowChildFormInMain(new QuanLyHoaDon());
            using QuanLyHoaDon form = new QuanLyHoaDon();
            form.ShowDialog(this);
        }

        private void btnMenuQuanLy_Click(object sender, EventArgs e)
        {
            SetQuanLyMenuExpanded(!_isQuanLyMenuExpanded);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            CloseActiveChildForm();
            SetDashboardWidgetsVisible(true);
            LoadDashboardData();
        }

        private void ShowChildFormInMain(Form childForm)
        {
            CloseActiveChildForm();

            _activeChildForm = childForm;
            SetDashboardWidgetsVisible(false);
            _contentHost.Visible = true;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            _contentHost.Controls.Clear();
            _contentHost.Controls.Add(childForm);
            childForm.Show();
        }

        private void CloseActiveChildForm()
        {
            if (_activeChildForm is null)
            {
                return;
            }

            _contentHost.Controls.Clear();
            _activeChildForm.Dispose();
            _activeChildForm = null;
            _contentHost.Visible = false;
        }

        private void SetDashboardWidgetsVisible(bool visible)
        {
            cardTodayRevenue.Visible = visible;
            cardMonthRevenue.Visible = visible;
            cardInvoiceCount.Visible = visible;
            grpTopProducts.Visible = visible;
            grpRevenueChart.Visible = visible;
        }

        private void LoadDashboardData()
        {
            try
            {
                using SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();

                string invoiceDateCol = ResolveColumn(connection, "hoa_don", "ngay_gio_ban");
                string invoiceAmountCol = ResolveColumn(connection, "hoa_don", "tong_tien", "thanh_tien", "tri_gia");
                string detailProductCol = ResolveColumn(connection, "chi_tiet_hoa_don", "ten_san_pham", "ma_san_pham", "san_pham_id");
                string detailQtyCol = ResolveColumn(connection, "chi_tiet_hoa_don", "so_luong", "sl", "quantity");

                decimal todayRevenue = ExecuteDecimalScalar(connection,
                    $"SELECT ISNULL(SUM(CAST([{invoiceAmountCol}] AS DECIMAL(18,2))), 0) FROM hoa_don WHERE CAST([{invoiceDateCol}] AS DATE) = CAST(GETDATE() AS DATE)");

                decimal monthRevenue = ExecuteDecimalScalar(connection,
                    $"SELECT ISNULL(SUM(CAST([{invoiceAmountCol}] AS DECIMAL(18,2))), 0) FROM hoa_don WHERE MONTH([{invoiceDateCol}]) = MONTH(GETDATE()) AND YEAR([{invoiceDateCol}]) = YEAR(GETDATE())");

                int todayInvoiceCount = ExecuteIntScalar(connection,
                    $"SELECT COUNT(1) FROM hoa_don WHERE CAST([{invoiceDateCol}] AS DATE) = CAST(GETDATE() AS DATE)");

                lblTodayRevenueValue.Text = $"{todayRevenue:N0} đ";
                lblMonthRevenueValue.Text = $"{monthRevenue:N0} đ";
                lblInvoiceCountValue.Text = todayInvoiceCount.ToString("N0", CultureInfo.InvariantCulture);

                LoadTopProducts(connection, detailProductCol, detailQtyCol);
                LoadRevenueChart(connection, invoiceDateCol, invoiceAmountCol);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Không tải được dữ liệu Dashboard: {ex.Message}",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadTopProducts(SqlConnection connection, string productCol, string qtyCol)
        {
            string query = $@"
SELECT TOP 5
    [{productCol}] AS [Sản phẩm],
    SUM(CAST([{qtyCol}] AS INT)) AS [Số lượng bán]
FROM chi_tiet_hoa_don
GROUP BY [{productCol}]
ORDER BY [Số lượng bán] DESC;";

            using SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dgvTopProducts.DataSource = table;
        }

        private void LoadRevenueChart(SqlConnection connection, string dateCol, string amountCol)
        {
            if (chartRevenue is null)
            {
                chartRevenue = new Chart
                {
                    Dock = DockStyle.Fill
                };

                chartRevenue.ChartAreas.Add(new ChartArea("MainArea"));
                chartRevenue.Legends.Add(new Legend("MainLegend"));
                grpRevenueChart.Controls.Add(chartRevenue);
            }

            Series revenueSeries;
            if (chartRevenue.Series.IndexOf("DoanhThu") >= 0)
            {
                revenueSeries = chartRevenue.Series["DoanhThu"];
            }
            else
            {
                revenueSeries = new Series("DoanhThu")
                {
                    ChartType = SeriesChartType.Column,
                    XValueType = ChartValueType.String,
                    YValueType = ChartValueType.Double,
                    ChartArea = chartRevenue.ChartAreas[0].Name,
                    Legend = chartRevenue.Legends[0].Name
                };
                chartRevenue.Series.Add(revenueSeries);
            }

            revenueSeries.Points.Clear();

            string query = $@"
SELECT
    CAST([{dateCol}] AS DATE) AS Ngay,
    SUM(CAST([{amountCol}] AS DECIMAL(18,2))) AS DoanhThu
FROM hoa_don
WHERE CAST([{dateCol}] AS DATE) >= DATEADD(DAY, -29, CAST(GETDATE() AS DATE))
GROUP BY CAST([{dateCol}] AS DATE)
ORDER BY Ngay;";

            using SqlCommand command = new SqlCommand(query, connection);
            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                DateTime date = reader.GetDateTime(0);
                decimal revenue = reader.GetDecimal(1);
                revenueSeries.Points.AddXY(date.ToString("dd/MM"), revenue);
            }
        }

        private static int ExecuteIntScalar(SqlConnection connection, string query)
        {
            using SqlCommand command = new SqlCommand(query, connection);
            object? result = command.ExecuteScalar();
            return result is null || result == DBNull.Value ? 0 : Convert.ToInt32(result);
        }

        private static decimal ExecuteDecimalScalar(SqlConnection connection, string query)
        {
            using SqlCommand command = new SqlCommand(query, connection);
            object? result = command.ExecuteScalar();
            return result is null || result == DBNull.Value ? 0M : Convert.ToDecimal(result);
        }

        private static string ResolveColumn(SqlConnection connection, string tableName, params string[] preferredNames)
        {
            const string sql = @"
SELECT COLUMN_NAME
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = @tableName;";

            using SqlCommand command = new SqlCommand(sql, connection);
            command.Parameters.AddWithValue("@tableName", tableName);

            HashSet<string> columns = new(StringComparer.OrdinalIgnoreCase);
            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                columns.Add(reader.GetString(0));
            }

            foreach (string name in preferredNames)
            {
                if (columns.Contains(name))
                {
                    return name;
                }
            }

            throw new InvalidOperationException($"Không tìm thấy cột phù hợp trong bảng '{tableName}'.");
        }

        private void SetQuanLyMenuExpanded(bool expanded)
        {
            _isQuanLyMenuExpanded = expanded;

            btnMenuQuanLy.Text = expanded ? "2. Quản lý ▲" : "2. Quản lý ▼";

            btnMenuSanPham.Visible = expanded;
            btnMenuKhachHang.Visible = expanded;
            btnMenuNhanVienTaiKhoan.Visible = expanded;
            btnMenuKhuyenMai.Visible = expanded;
            btnMenuNhaCungCap.Visible = expanded;
            btnMenuHoaDon.Visible = expanded;

            if (expanded)
            {
                btnMenuNhapHang.Location = _nhapHangExpandedLocation;
                btnMenuBaoCao.Location = _baoCaoExpandedLocation;
                btnMenuCaiDat.Location = _caiDatExpandedLocation;
                return;
            }

            btnMenuNhapHang.Location = new Point(_nhapHangExpandedLocation.X, _nhapHangExpandedLocation.Y - _quanLyMenuOffset);
            btnMenuBaoCao.Location = new Point(_baoCaoExpandedLocation.X, _baoCaoExpandedLocation.Y - _quanLyMenuOffset);
            btnMenuCaiDat.Location = new Point(_caiDatExpandedLocation.X, _caiDatExpandedLocation.Y - _quanLyMenuOffset);
        }

        private void CaptureMenuLayout()
        {
            _nhapHangExpandedLocation = btnMenuNhapHang.Location;
            _baoCaoExpandedLocation = btnMenuBaoCao.Location;
            _caiDatExpandedLocation = btnMenuCaiDat.Location;
            _quanLyMenuOffset = Math.Max(0, btnMenuNhapHang.Top - btnMenuSanPham.Top);
        }

        private void LoadMenuIcons()
        {
            try
            {
                btnMenuBanHang.Image = IconGenerator.GenerateShoppingIcon();
                btnMenuQuanLy.Image = IconGenerator.GenerateManageIcon();
                btnMenuSanPham.Image = IconGenerator.GenerateProductIcon();
                btnMenuNhapHang.Image = IconGenerator.GenerateImportIcon();
                btnMenuKhachHang.Image = IconGenerator.GenerateCustomerIcon();
                btnMenuNhanVienTaiKhoan.Image = IconGenerator.GenerateStaffIcon();
                btnMenuKhuyenMai.Image = IconGenerator.GenerateDiscountIcon();
                btnMenuBaoCao.Image = IconGenerator.GenerateReportIcon();
                btnMenuNhaCungCap.Image = IconGenerator.GenerateSupplierIcon();
                btnMenuHoaDon.Image = IconGenerator.GenerateInvoiceIcon();
                btnMenuCaiDat.Image = IconGenerator.GenerateSettingIcon();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải icon: {ex.Message}", "Thông báo");
            }
        }

        private void grpRevenueChart_Click(object sender, EventArgs e)
        {

        }
    }
}