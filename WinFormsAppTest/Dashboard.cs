using System.Data;
using System.Globalization;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Data.SqlClient;

namespace WinFormsAppTest
{
    public partial class Dashboard : Form
    {
        private readonly string _connectionString = DatabaseConfig.ConnectionString;
        private readonly string _username;
        private readonly string _role;

        public Dashboard(string username, string role)
        {
            InitializeComponent();
            _username = username;
            _role = role;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Xin chào, {_username} ({_role})";
            LoadDashboardData();
        }

        private void btnMenuBanHang_Click(object sender, EventArgs e)
        {
            using BanHangForm form = new BanHangForm("NV01");
            form.ShowDialog(this);
        }

        private void btnMenuSanPham_Click(object sender, EventArgs e)
        {
            using QuanLySanPhamForm form = new QuanLySanPhamForm();
            form.ShowDialog(this);
        }

        private void btnMenuNhapHang_Click(object sender, EventArgs e)
        {
            using QuanLyPhieuNhapForm form = new QuanLyPhieuNhapForm();
            form.ShowDialog(this);
        }

        private void btnMenuKhachHang_Click(object sender, EventArgs e)
        {
            using QuanLyKhachHangForm form = new QuanLyKhachHangForm();
            form.ShowDialog(this);
        }

        private void btnMenuNhanVienTaiKhoan_Click(object sender, EventArgs e)
        {
            using QuanLyNhanVienForm form = new QuanLyNhanVienForm();
            form.ShowDialog(this);
        }

        private void btnMenuKhuyenMai_Click(object sender, EventArgs e)
        {
            using QuanLyGiamGiaForm form = new QuanLyGiamGiaForm();
            form.ShowDialog(this);
        }

        private void btnMenuBaoCao_Click(object sender, EventArgs e)
        {
            using BaoCaoMainForm form = new BaoCaoMainForm();
            form.ShowDialog(this);
        }

        private void btnMenuCaiDat_Click(object sender, EventArgs e)
        {
            using CaiDatProfileForm form = new CaiDatProfileForm();
            form.ShowDialog(this);
        }

        private void btnMenuNhaCungCap_Click(object sender, EventArgs e)
        {
            using QuanLyNhaCungCapForm form = new QuanLyNhaCungCapForm();
            form.ShowDialog(this);
        }

        private void btnMenuHoaDon_Click(object sender, EventArgs e)
        {
            using QuanLyHoaDon form = new QuanLyHoaDon();
            form.ShowDialog(this);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        private void LoadDashboardData()
        {
            try
            {
                using SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();

                string invoiceDateCol = ResolveColumn(connection, "hoa_don", "ngay_lap", "ngay_tao", "created_at", "ngay");
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
            chartRevenue.Series["DoanhThu"].Points.Clear();

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
                chartRevenue.Series["DoanhThu"].Points.AddXY(date.ToString("dd/MM"), revenue);
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

        private void grpRevenueChart_Click(object sender, EventArgs e)
        {

        }
    }
}