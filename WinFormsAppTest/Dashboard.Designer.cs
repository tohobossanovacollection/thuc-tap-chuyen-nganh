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
        private Guna2Panel pnlMenu;
        private Guna2HtmlLabel lblMenuTitle;
        private Guna2Button btnMenuBanHang;
        private Guna2Button btnMenuSanPham;
        private Guna2Button btnMenuNhapHang;
        private Guna2Button btnMenuKhachHang;
        private Guna2Button btnMenuNhanVienTaiKhoan;
        private Guna2Button btnMenuKhuyenMai;
        private Guna2Button btnMenuBaoCao;
        private Guna2Button btnMenuNhaCungCap;
        private Guna2Button btnMenuHoaDon;
        private Guna2Button btnMenuCaiDat;
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges35 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges36 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlHeader = new Guna2Panel();
            lblTitle = new Guna2HtmlLabel();
            lblWelcome = new Guna2HtmlLabel();
            btnRefresh = new Guna2Button();
            pnlMenu = new Guna2Panel();
            lblMenuTitle = new Guna2HtmlLabel();
            btnMenuBanHang = new Guna2Button();
            btnMenuSanPham = new Guna2Button();
            btnMenuNhapHang = new Guna2Button();
            btnMenuKhachHang = new Guna2Button();
            btnMenuNhanVienTaiKhoan = new Guna2Button();
            btnMenuKhuyenMai = new Guna2Button();
            btnMenuBaoCao = new Guna2Button();
            btnMenuNhaCungCap = new Guna2Button();
            btnMenuHoaDon = new Guna2Button();
            btnMenuCaiDat = new Guna2Button();
            cardTodayRevenue = new Guna2Panel();
            lblTodayRevenueTitle = new Guna2HtmlLabel();
            lblTodayRevenueValue = new Guna2HtmlLabel();
            cardMonthRevenue = new Guna2Panel();
            lblMonthRevenueTitle = new Guna2HtmlLabel();
            lblMonthRevenueValue = new Guna2HtmlLabel();
            cardInvoiceCount = new Guna2Panel();
            lblInvoiceCountTitle = new Guna2HtmlLabel();
            lblInvoiceCountValue = new Guna2HtmlLabel();
            grpTopProducts = new Guna2GroupBox();
            dgvTopProducts = new Guna2DataGridView();
            grpRevenueChart = new Guna2GroupBox();
            pnlHeader.SuspendLayout();
            pnlMenu.SuspendLayout();
            cardTodayRevenue.SuspendLayout();
            cardMonthRevenue.SuspendLayout();
            cardInvoiceCount.SuspendLayout();
            grpTopProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTopProducts).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(198, 40, 40);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblWelcome);
            pnlHeader.Controls.Add(btnRefresh);
            pnlHeader.CustomizableEdges = customizableEdges3;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.ShadowDecoration.CustomizableEdges = customizableEdges4;
            pnlHeader.Size = new Size(1408, 90);
            pnlHeader.TabIndex = 6;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(255, 241, 118);
            lblTitle.Location = new Point(20, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(431, 43);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Dashboard - Trang Tổng Quan";
            // 
            // lblWelcome
            // 
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 10F);
            lblWelcome.ForeColor = Color.White;
            lblWelcome.Location = new Point(22, 52);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(69, 25);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Xin chào";
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnRefresh.BorderRadius = 8;
            btnRefresh.CustomizableEdges = customizableEdges1;
            btnRefresh.FillColor = Color.FromArgb(255, 167, 38);
            btnRefresh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(1184, 27);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnRefresh.Size = new Size(204, 40);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Làm mới";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(255, 253, 231);
            pnlMenu.BorderColor = Color.FromArgb(255, 167, 38);
            pnlMenu.BorderThickness = 1;
            pnlMenu.Controls.Add(lblMenuTitle);
            pnlMenu.Controls.Add(btnMenuBanHang);
            pnlMenu.Controls.Add(btnMenuSanPham);
            pnlMenu.Controls.Add(btnMenuNhapHang);
            pnlMenu.Controls.Add(btnMenuKhachHang);
            pnlMenu.Controls.Add(btnMenuNhanVienTaiKhoan);
            pnlMenu.Controls.Add(btnMenuKhuyenMai);
            pnlMenu.Controls.Add(btnMenuBaoCao);
            pnlMenu.Controls.Add(btnMenuNhaCungCap);
            pnlMenu.Controls.Add(btnMenuHoaDon);
            pnlMenu.Controls.Add(btnMenuCaiDat);
            pnlMenu.CustomizableEdges = customizableEdges21;
            pnlMenu.Location = new Point(10, 100);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.ShadowDecoration.CustomizableEdges = customizableEdges22;
            pnlMenu.Size = new Size(250, 590);
            pnlMenu.TabIndex = 0;
            // 
            // lblMenuTitle
            // 
            lblMenuTitle.BackColor = Color.Transparent;
            lblMenuTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMenuTitle.ForeColor = Color.FromArgb(198, 40, 40);
            lblMenuTitle.Location = new Point(75, 15);
            lblMenuTitle.Name = "lblMenuTitle";
            lblMenuTitle.Size = new Size(124, 30);
            lblMenuTitle.TabIndex = 0;
            lblMenuTitle.Text = "MAIN MENU";
            // 
            // btnMenuBanHang
            // 
            btnMenuBanHang.BorderRadius = 8;
            btnMenuBanHang.CustomizableEdges = customizableEdges5;
            btnMenuBanHang.FillColor = Color.FromArgb(198, 40, 40);
            btnMenuBanHang.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMenuBanHang.ForeColor = Color.White;
            btnMenuBanHang.Location = new Point(15, 55);
            btnMenuBanHang.Name = "btnMenuBanHang";
            btnMenuBanHang.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnMenuBanHang.Size = new Size(220, 42);
            btnMenuBanHang.TabIndex = 1;
            btnMenuBanHang.Text = "1. Bán hàng";
            btnMenuBanHang.Click += btnMenuBanHang_Click;
            // 
            // btnMenuSanPham
            // 
            btnMenuSanPham.BorderRadius = 8;
            btnMenuSanPham.CustomizableEdges = customizableEdges7;
            btnMenuSanPham.FillColor = Color.FromArgb(198, 40, 40);
            btnMenuSanPham.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMenuSanPham.ForeColor = Color.White;
            btnMenuSanPham.Location = new Point(15, 105);
            btnMenuSanPham.Name = "btnMenuSanPham";
            btnMenuSanPham.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnMenuSanPham.Size = new Size(220, 42);
            btnMenuSanPham.TabIndex = 2;
            btnMenuSanPham.Text = "2. Quản lý sản phẩm";
            btnMenuSanPham.Click += btnMenuSanPham_Click;
            // 
            // btnMenuNhapHang
            // 
            btnMenuNhapHang.BorderRadius = 8;
            btnMenuNhapHang.CustomizableEdges = customizableEdges9;
            btnMenuNhapHang.FillColor = Color.FromArgb(198, 40, 40);
            btnMenuNhapHang.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMenuNhapHang.ForeColor = Color.White;
            btnMenuNhapHang.Location = new Point(15, 155);
            btnMenuNhapHang.Name = "btnMenuNhapHang";
            btnMenuNhapHang.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnMenuNhapHang.Size = new Size(220, 42);
            btnMenuNhapHang.TabIndex = 3;
            btnMenuNhapHang.Text = "3. Nhập hàng";
            btnMenuNhapHang.Click += btnMenuNhapHang_Click;
            // 
            // btnMenuKhachHang
            // 
            btnMenuKhachHang.BorderRadius = 8;
            btnMenuKhachHang.CustomizableEdges = customizableEdges11;
            btnMenuKhachHang.FillColor = Color.FromArgb(198, 40, 40);
            btnMenuKhachHang.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMenuKhachHang.ForeColor = Color.White;
            btnMenuKhachHang.Location = new Point(15, 205);
            btnMenuKhachHang.Name = "btnMenuKhachHang";
            btnMenuKhachHang.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnMenuKhachHang.Size = new Size(220, 42);
            btnMenuKhachHang.TabIndex = 4;
            btnMenuKhachHang.Text = "4. Khách hàng";
            btnMenuKhachHang.Click += btnMenuKhachHang_Click;
            // 
            // btnMenuNhanVienTaiKhoan
            // 
            btnMenuNhanVienTaiKhoan.BorderRadius = 8;
            btnMenuNhanVienTaiKhoan.CustomizableEdges = customizableEdges13;
            btnMenuNhanVienTaiKhoan.FillColor = Color.FromArgb(198, 40, 40);
            btnMenuNhanVienTaiKhoan.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMenuNhanVienTaiKhoan.ForeColor = Color.White;
            btnMenuNhanVienTaiKhoan.Location = new Point(15, 255);
            btnMenuNhanVienTaiKhoan.Name = "btnMenuNhanVienTaiKhoan";
            btnMenuNhanVienTaiKhoan.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnMenuNhanVienTaiKhoan.Size = new Size(220, 42);
            btnMenuNhanVienTaiKhoan.TabIndex = 5;
            btnMenuNhanVienTaiKhoan.Text = "5. Quản lý nhân viên";
            btnMenuNhanVienTaiKhoan.Click += btnMenuNhanVienTaiKhoan_Click;
            // 
            // btnMenuKhuyenMai
            // 
            btnMenuKhuyenMai.BorderRadius = 8;
            btnMenuKhuyenMai.CustomizableEdges = customizableEdges15;
            btnMenuKhuyenMai.FillColor = Color.FromArgb(198, 40, 40);
            btnMenuKhuyenMai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMenuKhuyenMai.ForeColor = Color.White;
            btnMenuKhuyenMai.Location = new Point(15, 305);
            btnMenuKhuyenMai.Name = "btnMenuKhuyenMai";
            btnMenuKhuyenMai.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnMenuKhuyenMai.Size = new Size(220, 42);
            btnMenuKhuyenMai.TabIndex = 6;
            btnMenuKhuyenMai.Text = "6. Khuyến mãi";
            btnMenuKhuyenMai.Click += btnMenuKhuyenMai_Click;
            // 
            // btnMenuBaoCao
            // 
            btnMenuBaoCao.BorderRadius = 8;
            btnMenuBaoCao.CustomizableEdges = customizableEdges17;
            btnMenuBaoCao.FillColor = Color.FromArgb(198, 40, 40);
            btnMenuBaoCao.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMenuBaoCao.ForeColor = Color.White;
            btnMenuBaoCao.Location = new Point(15, 355);
            btnMenuBaoCao.Name = "btnMenuBaoCao";
            btnMenuBaoCao.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnMenuBaoCao.Size = new Size(220, 42);
            btnMenuBaoCao.TabIndex = 7;
            btnMenuBaoCao.Text = "7. Báo cáo";
            btnMenuBaoCao.Click += btnMenuBaoCao_Click;
            // 
            // btnMenuCaiDat
            // 
            btnMenuCaiDat.BorderRadius = 8;
            btnMenuCaiDat.CustomizableEdges = customizableEdges19;
            btnMenuCaiDat.FillColor = Color.FromArgb(198, 40, 40);
            btnMenuCaiDat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMenuCaiDat.ForeColor = Color.White;
            btnMenuCaiDat.Location = new Point(15, 505);
            btnMenuCaiDat.Name = "btnMenuCaiDat";
            btnMenuCaiDat.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnMenuCaiDat.Size = new Size(220, 42);
            btnMenuCaiDat.TabIndex = 8;
            btnMenuCaiDat.Text = "10. Cài đặt";
            btnMenuCaiDat.Click += btnMenuCaiDat_Click;
            // 
            // btnMenuNhaCungCap
            // 
            btnMenuNhaCungCap.BorderRadius = 8;
            btnMenuNhaCungCap.CustomizableEdges = customizableEdges33;
            btnMenuNhaCungCap.FillColor = Color.FromArgb(198, 40, 40);
            btnMenuNhaCungCap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMenuNhaCungCap.ForeColor = Color.White;
            btnMenuNhaCungCap.Location = new Point(15, 405);
            btnMenuNhaCungCap.Name = "btnMenuNhaCungCap";
            btnMenuNhaCungCap.ShadowDecoration.CustomizableEdges = customizableEdges34;
            btnMenuNhaCungCap.Size = new Size(220, 42);
            btnMenuNhaCungCap.TabIndex = 9;
            btnMenuNhaCungCap.Text = "8. Nhà cung cấp";
            btnMenuNhaCungCap.Click += btnMenuNhaCungCap_Click;
            // 
            // btnMenuHoaDon
            // 
            btnMenuHoaDon.BorderRadius = 8;
            btnMenuHoaDon.CustomizableEdges = customizableEdges35;
            btnMenuHoaDon.FillColor = Color.FromArgb(198, 40, 40);
            btnMenuHoaDon.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnMenuHoaDon.ForeColor = Color.White;
            btnMenuHoaDon.Location = new Point(15, 455);
            btnMenuHoaDon.Name = "btnMenuHoaDon";
            btnMenuHoaDon.ShadowDecoration.CustomizableEdges = customizableEdges36;
            btnMenuHoaDon.Size = new Size(220, 42);
            btnMenuHoaDon.TabIndex = 10;
            btnMenuHoaDon.Text = "9. Hóa đơn";
            btnMenuHoaDon.Click += btnMenuHoaDon_Click;
            // 
            // cardTodayRevenue
            // 
            cardTodayRevenue.BackColor = Color.FromArgb(255, 253, 231);
            cardTodayRevenue.BorderColor = Color.FromArgb(255, 167, 38);
            cardTodayRevenue.BorderRadius = 12;
            cardTodayRevenue.BorderThickness = 2;
            cardTodayRevenue.Controls.Add(lblTodayRevenueTitle);
            cardTodayRevenue.Controls.Add(lblTodayRevenueValue);
            cardTodayRevenue.CustomizableEdges = customizableEdges23;
            cardTodayRevenue.Location = new Point(280, 110);
            cardTodayRevenue.Name = "cardTodayRevenue";
            cardTodayRevenue.ShadowDecoration.CustomizableEdges = customizableEdges24;
            cardTodayRevenue.Size = new Size(323, 110);
            cardTodayRevenue.TabIndex = 5;
            // 
            // lblTodayRevenueTitle
            // 
            lblTodayRevenueTitle.BackColor = Color.Transparent;
            lblTodayRevenueTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTodayRevenueTitle.ForeColor = Color.FromArgb(198, 40, 40);
            lblTodayRevenueTitle.Location = new Point(18, 15);
            lblTodayRevenueTitle.Name = "lblTodayRevenueTitle";
            lblTodayRevenueTitle.Size = new Size(172, 27);
            lblTodayRevenueTitle.TabIndex = 0;
            lblTodayRevenueTitle.Text = "Doanh thu hôm nay";
            // 
            // lblTodayRevenueValue
            // 
            lblTodayRevenueValue.BackColor = Color.Transparent;
            lblTodayRevenueValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTodayRevenueValue.ForeColor = Color.FromArgb(191, 54, 12);
            lblTodayRevenueValue.Location = new Point(18, 45);
            lblTodayRevenueValue.Name = "lblTodayRevenueValue";
            lblTodayRevenueValue.Size = new Size(52, 47);
            lblTodayRevenueValue.TabIndex = 1;
            lblTodayRevenueValue.Text = "0 đ";
            // 
            // cardMonthRevenue
            // 
            cardMonthRevenue.BackColor = Color.FromArgb(255, 253, 231);
            cardMonthRevenue.BorderColor = Color.FromArgb(255, 167, 38);
            cardMonthRevenue.BorderRadius = 12;
            cardMonthRevenue.BorderThickness = 2;
            cardMonthRevenue.Controls.Add(lblMonthRevenueTitle);
            cardMonthRevenue.Controls.Add(lblMonthRevenueValue);
            cardMonthRevenue.CustomizableEdges = customizableEdges25;
            cardMonthRevenue.Location = new Point(670, 110);
            cardMonthRevenue.Name = "cardMonthRevenue";
            cardMonthRevenue.ShadowDecoration.CustomizableEdges = customizableEdges26;
            cardMonthRevenue.Size = new Size(323, 110);
            cardMonthRevenue.TabIndex = 4;
            // 
            // lblMonthRevenueTitle
            // 
            lblMonthRevenueTitle.BackColor = Color.Transparent;
            lblMonthRevenueTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblMonthRevenueTitle.ForeColor = Color.FromArgb(198, 40, 40);
            lblMonthRevenueTitle.Location = new Point(18, 15);
            lblMonthRevenueTitle.Name = "lblMonthRevenueTitle";
            lblMonthRevenueTitle.Size = new Size(184, 27);
            lblMonthRevenueTitle.TabIndex = 0;
            lblMonthRevenueTitle.Text = "Doanh thu tháng này";
            // 
            // lblMonthRevenueValue
            // 
            lblMonthRevenueValue.BackColor = Color.Transparent;
            lblMonthRevenueValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblMonthRevenueValue.ForeColor = Color.FromArgb(191, 54, 12);
            lblMonthRevenueValue.Location = new Point(18, 45);
            lblMonthRevenueValue.Name = "lblMonthRevenueValue";
            lblMonthRevenueValue.Size = new Size(52, 47);
            lblMonthRevenueValue.TabIndex = 1;
            lblMonthRevenueValue.Text = "0 đ";
            // 
            // cardInvoiceCount
            // 
            cardInvoiceCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cardInvoiceCount.BackColor = Color.FromArgb(255, 253, 231);
            cardInvoiceCount.BorderColor = Color.FromArgb(255, 167, 38);
            cardInvoiceCount.BorderRadius = 12;
            cardInvoiceCount.BorderThickness = 2;
            cardInvoiceCount.Controls.Add(lblInvoiceCountTitle);
            cardInvoiceCount.Controls.Add(lblInvoiceCountValue);
            cardInvoiceCount.CustomizableEdges = customizableEdges27;
            cardInvoiceCount.Location = new Point(1060, 110);
            cardInvoiceCount.Name = "cardInvoiceCount";
            cardInvoiceCount.ShadowDecoration.CustomizableEdges = customizableEdges28;
            cardInvoiceCount.Size = new Size(328, 108);
            cardInvoiceCount.TabIndex = 3;
            // 
            // lblInvoiceCountTitle
            // 
            lblInvoiceCountTitle.BackColor = Color.Transparent;
            lblInvoiceCountTitle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblInvoiceCountTitle.ForeColor = Color.FromArgb(198, 40, 40);
            lblInvoiceCountTitle.Location = new Point(18, 15);
            lblInvoiceCountTitle.Name = "lblInvoiceCountTitle";
            lblInvoiceCountTitle.Size = new Size(178, 27);
            lblInvoiceCountTitle.TabIndex = 0;
            lblInvoiceCountTitle.Text = "Số hóa đơn hôm nay";
            // 
            // lblInvoiceCountValue
            // 
            lblInvoiceCountValue.BackColor = Color.Transparent;
            lblInvoiceCountValue.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblInvoiceCountValue.ForeColor = Color.FromArgb(191, 54, 12);
            lblInvoiceCountValue.Location = new Point(18, 45);
            lblInvoiceCountValue.Name = "lblInvoiceCountValue";
            lblInvoiceCountValue.Size = new Size(22, 47);
            lblInvoiceCountValue.TabIndex = 1;
            lblInvoiceCountValue.Text = "0";
            // 
            // grpTopProducts
            // 
            grpTopProducts.BorderColor = Color.FromArgb(255, 167, 38);
            grpTopProducts.Controls.Add(dgvTopProducts);
            grpTopProducts.CustomBorderColor = Color.FromArgb(255, 241, 118);
            grpTopProducts.CustomizableEdges = customizableEdges29;
            grpTopProducts.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpTopProducts.ForeColor = Color.FromArgb(198, 40, 40);
            grpTopProducts.Location = new Point(280, 240);
            grpTopProducts.Name = "grpTopProducts";
            grpTopProducts.ShadowDecoration.CustomizableEdges = customizableEdges30;
            grpTopProducts.Size = new Size(425, 420);
            grpTopProducts.TabIndex = 2;
            grpTopProducts.Text = "Top sản phẩm bán chạy";
            // 
            // dgvTopProducts
            // 
            dgvTopProducts.AllowUserToAddRows = false;
            dgvTopProducts.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvTopProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTopProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTopProducts.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTopProducts.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTopProducts.Dock = DockStyle.Fill;
            dgvTopProducts.GridColor = Color.FromArgb(231, 229, 255);
            dgvTopProducts.Location = new Point(0, 40);
            dgvTopProducts.Name = "dgvTopProducts";
            dgvTopProducts.ReadOnly = true;
            dgvTopProducts.RowHeadersVisible = false;
            dgvTopProducts.RowHeadersWidth = 51;
            dgvTopProducts.Size = new Size(425, 380);
            dgvTopProducts.TabIndex = 0;
            dgvTopProducts.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvTopProducts.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvTopProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvTopProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvTopProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvTopProducts.ThemeStyle.BackColor = Color.White;
            dgvTopProducts.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvTopProducts.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvTopProducts.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTopProducts.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvTopProducts.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvTopProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTopProducts.ThemeStyle.HeaderStyle.Height = 29;
            dgvTopProducts.ThemeStyle.ReadOnly = true;
            dgvTopProducts.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvTopProducts.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTopProducts.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvTopProducts.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvTopProducts.ThemeStyle.RowsStyle.Height = 29;
            dgvTopProducts.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvTopProducts.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // grpRevenueChart
            // 
            grpRevenueChart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpRevenueChart.BorderColor = Color.FromArgb(255, 167, 38);
            grpRevenueChart.CustomBorderColor = Color.FromArgb(255, 241, 118);
            grpRevenueChart.CustomizableEdges = customizableEdges31;
            grpRevenueChart.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpRevenueChart.ForeColor = Color.FromArgb(198, 40, 40);
            grpRevenueChart.Location = new Point(772, 240);
            grpRevenueChart.Name = "grpRevenueChart";
            grpRevenueChart.ShadowDecoration.CustomizableEdges = customizableEdges32;
            grpRevenueChart.Size = new Size(617, 448);
            grpRevenueChart.TabIndex = 1;
            grpRevenueChart.Text = "Biểu đồ doanh thu 30 ngày gần nhất";
            grpRevenueChart.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            grpRevenueChart.Click += grpRevenueChart_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1408, 698);
            Controls.Add(pnlMenu);
            Controls.Add(grpRevenueChart);
            Controls.Add(grpTopProducts);
            Controls.Add(cardInvoiceCount);
            Controls.Add(cardMonthRevenue);
            Controls.Add(cardTodayRevenue);
            Controls.Add(pnlHeader);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinMart+ - Dashboard";
            Load += Dashboard_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            cardTodayRevenue.ResumeLayout(false);
            cardTodayRevenue.PerformLayout();
            cardMonthRevenue.ResumeLayout(false);
            cardMonthRevenue.PerformLayout();
            cardInvoiceCount.ResumeLayout(false);
            cardInvoiceCount.PerformLayout();
            grpTopProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTopProducts).EndInit();
            ResumeLayout(false);
        }

        private static void ConfigureMenuButton(Guna2Button button, string text, int y, EventHandler onClick)
        {
            button.Text = text;
            button.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button.BorderRadius = 8;
            button.FillColor = Color.FromArgb(198, 40, 40);
            button.ForeColor = Color.White;
            button.Size = new Size(220, 42);
            button.Location = new Point(15, y);
            button.Click += onClick;
        }
    }
}