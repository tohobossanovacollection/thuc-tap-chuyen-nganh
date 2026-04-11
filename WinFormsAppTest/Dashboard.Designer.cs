using System.Windows.Forms.DataVisualization.Charting;
using Guna.UI2.WinForms;

namespace WinFormsAppTest
{
    partial class Dashboard
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2Panel pnlHeader;
        private Guna2HtmlLabel lblTitle;
        private Guna2HtmlLabel lblWelcome;
        private Guna2Button btnRefresh;
        private Guna2Panel cardTodayRevenue;
        private Guna2Panel cardMonthRevenue;
        private Guna2Panel cardInvoiceCount;
        private Guna2HtmlLabel lblTodayRevenueTitle;
        private Guna2HtmlLabel lblTodayRevenueValue;
        private Guna2HtmlLabel lblMonthRevenueTitle;
        private Guna2HtmlLabel lblMonthRevenueValue;
        private Guna2HtmlLabel lblInvoiceCountTitle;
        private Guna2HtmlLabel lblInvoiceCountValue;
        private Guna2GroupBox grpTopProducts;
        private Guna2DataGridView dgvTopProducts;
        private Guna2GroupBox grpRevenueChart;
        private Chart chartRevenue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            pnlHeader = new Guna2Panel();
            lblTitle = new Guna2HtmlLabel();
            lblWelcome = new Guna2HtmlLabel();
            btnRefresh = new Guna2Button();

            cardTodayRevenue = new Guna2Panel();
            cardMonthRevenue = new Guna2Panel();
            cardInvoiceCount = new Guna2Panel();

            lblTodayRevenueTitle = new Guna2HtmlLabel();
            lblTodayRevenueValue = new Guna2HtmlLabel();
            lblMonthRevenueTitle = new Guna2HtmlLabel();
            lblMonthRevenueValue = new Guna2HtmlLabel();
            lblInvoiceCountTitle = new Guna2HtmlLabel();
            lblInvoiceCountValue = new Guna2HtmlLabel();

            grpTopProducts = new Guna2GroupBox();
            dgvTopProducts = new Guna2DataGridView();

            grpRevenueChart = new Guna2GroupBox();
            chartRevenue = new Chart();

            SuspendLayout();

            // Header
            pnlHeader.BackColor = Color.FromArgb(198, 40, 40);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 90;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Controls.Add(btnRefresh);

            lblTitle.BackColor = Color.Transparent;
            lblTitle.Text = "Dashboard - Trang Tổng Quan";
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(255, 241, 118);
            lblTitle.Location = new Point(20, 12);

            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Text = "Xin chào";
            lblWelcome.Font = new Font("Segoe UI", 10F);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(22, 52);

            btnRefresh.Text = "Làm mới";
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.FillColor = Color.FromArgb(255, 167, 38);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.BorderRadius = 8;
            btnRefresh.Size = new Size(110, 40);
            btnRefresh.Location = new Point(1040, 25);
            btnRefresh.Click += btnRefresh_Click;

            // Card - Today revenue
            cardTodayRevenue.BackColor = Color.FromArgb(255, 253, 231);
            cardTodayRevenue.BorderRadius = 12;
            cardTodayRevenue.BorderColor = Color.FromArgb(255, 167, 38);
            cardTodayRevenue.BorderThickness = 2;
            cardTodayRevenue.Location = new Point(20, 110);
            cardTodayRevenue.Size = new Size(370, 110);
            cardTodayRevenue.Controls.Add(lblTodayRevenueTitle);
            cardTodayRevenue.Controls.Add(lblTodayRevenueValue);

            lblTodayRevenueTitle.BackColor = Color.Transparent;
            lblTodayRevenueTitle.Text = "Doanh thu hôm nay";
            lblTodayRevenueTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTodayRevenueTitle.ForeColor = Color.FromArgb(198, 40, 40);
            lblTodayRevenueTitle.Location = new Point(18, 15);

            lblTodayRevenueValue.BackColor = Color.Transparent;
            lblTodayRevenueValue.Text = "0 đ";
            lblTodayRevenueValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTodayRevenueValue.ForeColor = Color.FromArgb(191, 54, 12);
            lblTodayRevenueValue.Location = new Point(18, 45);

            // Card - Month revenue
            cardMonthRevenue.BackColor = Color.FromArgb(255, 253, 231);
            cardMonthRevenue.BorderRadius = 12;
            cardMonthRevenue.BorderColor = Color.FromArgb(255, 167, 38);
            cardMonthRevenue.BorderThickness = 2;
            cardMonthRevenue.Location = new Point(410, 110);
            cardMonthRevenue.Size = new Size(370, 110);
            cardMonthRevenue.Controls.Add(lblMonthRevenueTitle);
            cardMonthRevenue.Controls.Add(lblMonthRevenueValue);

            lblMonthRevenueTitle.BackColor = Color.Transparent;
            lblMonthRevenueTitle.Text = "Doanh thu tháng này";
            lblMonthRevenueTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMonthRevenueTitle.ForeColor = Color.FromArgb(198, 40, 40);
            lblMonthRevenueTitle.Location = new Point(18, 15);

            lblMonthRevenueValue.BackColor = Color.Transparent;
            lblMonthRevenueValue.Text = "0 đ";
            lblMonthRevenueValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblMonthRevenueValue.ForeColor = Color.FromArgb(191, 54, 12);
            lblMonthRevenueValue.Location = new Point(18, 45);

            // Card - Invoice count
            cardInvoiceCount.BackColor = Color.FromArgb(255, 253, 231);
            cardInvoiceCount.BorderRadius = 12;
            cardInvoiceCount.BorderColor = Color.FromArgb(255, 167, 38);
            cardInvoiceCount.BorderThickness = 2;
            cardInvoiceCount.Location = new Point(800, 110);
            cardInvoiceCount.Size = new Size(370, 110);
            cardInvoiceCount.Controls.Add(lblInvoiceCountTitle);
            cardInvoiceCount.Controls.Add(lblInvoiceCountValue);

            lblInvoiceCountTitle.BackColor = Color.Transparent;
            lblInvoiceCountTitle.Text = "Số hóa đơn hôm nay";
            lblInvoiceCountTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblInvoiceCountTitle.ForeColor = Color.FromArgb(198, 40, 40);
            lblInvoiceCountTitle.Location = new Point(18, 15);

            lblInvoiceCountValue.BackColor = Color.Transparent;
            lblInvoiceCountValue.Text = "0";
            lblInvoiceCountValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblInvoiceCountValue.ForeColor = Color.FromArgb(191, 54, 12);
            lblInvoiceCountValue.Location = new Point(18, 45);

            // Top products
            grpTopProducts.Text = "Top sản phẩm bán chạy";
            grpTopProducts.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpTopProducts.ForeColor = Color.FromArgb(198, 40, 40);
            grpTopProducts.BorderColor = Color.FromArgb(255, 167, 38);
            grpTopProducts.CustomBorderColor = Color.FromArgb(255, 241, 118);
            grpTopProducts.Location = new Point(20, 240);
            grpTopProducts.Size = new Size(470, 420);
            grpTopProducts.Controls.Add(dgvTopProducts);

            dgvTopProducts.Dock = DockStyle.Fill;
            dgvTopProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTopProducts.ReadOnly = true;
            dgvTopProducts.RowHeadersVisible = false;
            dgvTopProducts.AllowUserToAddRows = false;
            dgvTopProducts.AllowUserToDeleteRows = false;
            dgvTopProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Revenue chart
            grpRevenueChart.Text = "Biểu đồ doanh thu 30 ngày gần nhất";
            grpRevenueChart.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpRevenueChart.ForeColor = Color.FromArgb(198, 40, 40);
            grpRevenueChart.BorderColor = Color.FromArgb(255, 167, 38);
            grpRevenueChart.CustomBorderColor = Color.FromArgb(255, 241, 118);
            grpRevenueChart.Location = new Point(510, 240);
            grpRevenueChart.Size = new Size(660, 420);
            grpRevenueChart.Controls.Add(chartRevenue);

            chartRevenue.Dock = DockStyle.Fill;
            ChartArea area = new ChartArea("MainArea");
            area.AxisX.MajorGrid.Enabled = false;
            area.AxisY.MajorGrid.LineColor = Color.Gainsboro;
            chartRevenue.ChartAreas.Add(area);

            Legend legend = new Legend("MainLegend");
            chartRevenue.Legends.Add(legend);

            Series series = new Series("DoanhThu");
            series.ChartType = SeriesChartType.SplineArea;
            series.BorderWidth = 3;
            series.Color = Color.FromArgb(198, 40, 40);
            series.BackGradientStyle = GradientStyle.TopBottom;
            series.BackSecondaryColor = Color.FromArgb(255, 241, 118);
            chartRevenue.Series.Add(series);

            // Form
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 700);
            Controls.Add(grpRevenueChart);
            Controls.Add(grpTopProducts);
            Controls.Add(cardInvoiceCount);
            Controls.Add(cardMonthRevenue);
            Controls.Add(cardTodayRevenue);
            Controls.Add(pnlHeader);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinMart+ - Dashboard";
            Load += Dashboard_Load;

            ResumeLayout(false);
        }
    }
}