using Guna.UI2.WinForms;
namespace WinFormsAppTest
{
    partial class QuanLyHoaDon
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel pnlHeader;
        private Guna2HtmlLabel lblTitle;
        private Guna2HtmlLabel lblSubTitle;

        private Guna2GroupBox grpFilter;
        private Guna2HtmlLabel lblFrom;
        private Guna2HtmlLabel lblTo;
        private Guna2HtmlLabel lblCustomer;
        private Guna2DateTimePicker dtpFrom;
        private Guna2DateTimePicker dtpTo;
        private Guna2TextBox txtCustomerKeyword;
        private Guna2Button btnSearch;
        private Guna2Button btnResetFilter;
        private Guna2Button btnRefresh;
        private Guna2Button btnPrintInvoice;
        private Guna2Button btnClose;

        private SplitContainer splitMain;
        private Guna2GroupBox grpInvoices;
        private Guna2DataGridView dgvInvoices;
        private Guna2GroupBox grpDetails;
        private Guna2DataGridView dgvDetails;

        private Guna2Panel pnlSummary;
        private Guna2HtmlLabel lblMaHoaDonText;
        private Guna2HtmlLabel lblMaHoaDonValue;
        private Guna2HtmlLabel lblNgayText;
        private Guna2HtmlLabel lblNgayValue;
        private Guna2HtmlLabel lblKhachText;
        private Guna2HtmlLabel lblKhachValue;
        private Guna2HtmlLabel lblTongTienText;
        private Guna2HtmlLabel lblTongTienValue;
        private Guna2HtmlLabel lblGiamGiaText;
        private Guna2HtmlLabel lblGiamGiaValue;
        private Guna2HtmlLabel lblThanhTienText;
        private Guna2HtmlLabel lblThanhTienValue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlHeader = new Guna2Panel();
            lblTitle = new Guna2HtmlLabel();
            lblSubTitle = new Guna2HtmlLabel();
            grpFilter = new Guna2GroupBox();
            lblFrom = new Guna2HtmlLabel();
            dtpFrom = new Guna2DateTimePicker();
            lblTo = new Guna2HtmlLabel();
            dtpTo = new Guna2DateTimePicker();
            lblCustomer = new Guna2HtmlLabel();
            txtCustomerKeyword = new Guna2TextBox();
            btnSearch = new Guna2Button();
            btnResetFilter = new Guna2Button();
            btnRefresh = new Guna2Button();
            btnPrintInvoice = new Guna2Button();
            btnClose = new Guna2Button();
            splitMain = new SplitContainer();
            grpInvoices = new Guna2GroupBox();
            dgvInvoices = new Guna2DataGridView();
            grpDetails = new Guna2GroupBox();
            dgvDetails = new Guna2DataGridView();
            pnlSummary = new Guna2Panel();
            lblMaHoaDonText = new Guna2HtmlLabel();
            lblMaHoaDonValue = new Guna2HtmlLabel();
            lblNgayText = new Guna2HtmlLabel();
            lblNgayValue = new Guna2HtmlLabel();
            lblKhachText = new Guna2HtmlLabel();
            lblKhachValue = new Guna2HtmlLabel();
            lblTongTienText = new Guna2HtmlLabel();
            lblTongTienValue = new Guna2HtmlLabel();
            lblGiamGiaText = new Guna2HtmlLabel();
            lblGiamGiaValue = new Guna2HtmlLabel();
            lblThanhTienText = new Guna2HtmlLabel();
            lblThanhTienValue = new Guna2HtmlLabel();
            pnlHeader.SuspendLayout();
            grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            grpInvoices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).BeginInit();
            grpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).BeginInit();
            pnlSummary.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(198, 40, 40);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubTitle);
            pnlHeader.CustomizableEdges = customizableEdges1;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlHeader.Size = new Size(1384, 86);
            pnlHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(255, 241, 118);
            lblTitle.Location = new Point(20, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(265, 47);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản lý Hóa đơn";
            // 
            // lblSubTitle
            // 
            lblSubTitle.BackColor = Color.Transparent;
            lblSubTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSubTitle.ForeColor = Color.White;
            lblSubTitle.Location = new Point(22, 54);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(455, 25);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "WinMart+ | Danh sách - Chi tiết - Tìm kiếm - In hóa đơn";
            // 
            // grpFilter
            // 
            grpFilter.BorderColor = Color.FromArgb(255, 167, 38);
            grpFilter.Controls.Add(lblFrom);
            grpFilter.Controls.Add(dtpFrom);
            grpFilter.Controls.Add(lblTo);
            grpFilter.Controls.Add(dtpTo);
            grpFilter.Controls.Add(lblCustomer);
            grpFilter.Controls.Add(txtCustomerKeyword);
            grpFilter.Controls.Add(btnSearch);
            grpFilter.Controls.Add(btnResetFilter);
            grpFilter.Controls.Add(btnRefresh);
            grpFilter.Controls.Add(btnPrintInvoice);
            grpFilter.Controls.Add(btnClose);
            grpFilter.CustomBorderColor = Color.FromArgb(255, 241, 118);
            grpFilter.CustomizableEdges = customizableEdges21;
            grpFilter.Dock = DockStyle.Top;
            grpFilter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpFilter.ForeColor = Color.FromArgb(198, 40, 40);
            grpFilter.Location = new Point(0, 86);
            grpFilter.Name = "grpFilter";
            grpFilter.ShadowDecoration.CustomizableEdges = customizableEdges22;
            grpFilter.Size = new Size(1384, 179);
            grpFilter.TabIndex = 1;
            grpFilter.Text = "Bộ lọc và thao tác";
            // 
            // lblFrom
            // 
            lblFrom.BackColor = Color.Transparent;
            lblFrom.Location = new Point(25, 64);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(56, 22);
            lblFrom.TabIndex = 0;
            lblFrom.Text = "Từ ngày";
            // 
            // dtpFrom
            // 
            dtpFrom.BorderRadius = 8;
            dtpFrom.Checked = true;
            dtpFrom.CustomizableEdges = customizableEdges3;
            dtpFrom.Font = new Font("Segoe UI", 9F);
            dtpFrom.ForeColor = Color.White;
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(102, 64);
            dtpFrom.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpFrom.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.ShadowDecoration.CustomizableEdges = customizableEdges4;
            dtpFrom.Size = new Size(130, 36);
            dtpFrom.TabIndex = 1;
            dtpFrom.Value = new DateTime(2026, 4, 11, 17, 57, 13, 446);
            dtpFrom.ValueChanged += dtpFrom_ValueChanged;
            // 
            // lblTo
            // 
            lblTo.BackColor = Color.Transparent;
            lblTo.Location = new Point(330, 64);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(66, 22);
            lblTo.TabIndex = 2;
            lblTo.Text = "Đến ngày";
            // 
            // dtpTo
            // 
            dtpTo.BorderRadius = 8;
            dtpTo.Checked = true;
            dtpTo.CustomizableEdges = customizableEdges5;
            dtpTo.Font = new Font("Segoe UI", 9F);
            dtpTo.ForeColor = Color.White;
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(428, 64);
            dtpTo.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            dtpTo.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            dtpTo.Name = "dtpTo";
            dtpTo.ShadowDecoration.CustomizableEdges = customizableEdges6;
            dtpTo.Size = new Size(130, 36);
            dtpTo.TabIndex = 3;
            dtpTo.Value = new DateTime(2026, 4, 11, 17, 57, 13, 521);
            // 
            // lblCustomer
            // 
            lblCustomer.BackColor = Color.Transparent;
            lblCustomer.Location = new Point(25, 128);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(80, 22);
            lblCustomer.TabIndex = 4;
            lblCustomer.Text = "Khách hàng";
            // 
            // txtCustomerKeyword
            // 
            txtCustomerKeyword.BorderRadius = 8;
            txtCustomerKeyword.CustomizableEdges = customizableEdges7;
            txtCustomerKeyword.DefaultText = "";
            txtCustomerKeyword.Font = new Font("Segoe UI", 9F);
            txtCustomerKeyword.Location = new Point(122, 128);
            txtCustomerKeyword.Margin = new Padding(3, 4, 3, 4);
            txtCustomerKeyword.Name = "txtCustomerKeyword";
            txtCustomerKeyword.PlaceholderText = "Tên khách / mã khách / SĐT...";
            txtCustomerKeyword.SelectedText = "";
            txtCustomerKeyword.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtCustomerKeyword.Size = new Size(361, 36);
            txtCustomerKeyword.TabIndex = 5;
            // 
            // btnSearch
            // 
            btnSearch.BorderRadius = 8;
            btnSearch.CustomizableEdges = customizableEdges9;
            btnSearch.FillColor = Color.FromArgb(255, 167, 38);
            btnSearch.Font = new Font("Segoe UI", 9F);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(730, 119);
            btnSearch.Name = "btnSearch";
            btnSearch.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnSearch.Size = new Size(102, 45);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Tìm";
            btnSearch.Click += btnSearch_Click;
            // 
            // btnResetFilter
            // 
            btnResetFilter.BorderRadius = 8;
            btnResetFilter.CustomizableEdges = customizableEdges11;
            btnResetFilter.FillColor = Color.FromArgb(97, 97, 97);
            btnResetFilter.Font = new Font("Segoe UI", 9F);
            btnResetFilter.ForeColor = Color.White;
            btnResetFilter.Location = new Point(838, 119);
            btnResetFilter.Name = "btnResetFilter";
            btnResetFilter.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnResetFilter.Size = new Size(102, 45);
            btnResetFilter.TabIndex = 7;
            btnResetFilter.Text = "Đặt lại";
            btnResetFilter.Click += btnResetFilter_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BorderRadius = 8;
            btnRefresh.CustomizableEdges = customizableEdges13;
            btnRefresh.FillColor = Color.FromArgb(255, 167, 38);
            btnRefresh.Font = new Font("Segoe UI", 9F);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(946, 119);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnRefresh.Size = new Size(102, 45);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Làm mới";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnPrintInvoice
            // 
            btnPrintInvoice.BorderRadius = 8;
            btnPrintInvoice.CustomizableEdges = customizableEdges15;
            btnPrintInvoice.FillColor = Color.FromArgb(211, 47, 47);
            btnPrintInvoice.Font = new Font("Segoe UI", 9F);
            btnPrintInvoice.ForeColor = Color.White;
            btnPrintInvoice.Location = new Point(1054, 119);
            btnPrintInvoice.Name = "btnPrintInvoice";
            btnPrintInvoice.ShadowDecoration.CustomizableEdges = customizableEdges16;
            btnPrintInvoice.Size = new Size(102, 45);
            btnPrintInvoice.TabIndex = 9;
            btnPrintInvoice.Text = "In hóa đơn";
            btnPrintInvoice.Click += btnPrintInvoice_Click;
            // 
            // btnClose
            // 
            btnClose.BorderRadius = 8;
            btnClose.CustomizableEdges = customizableEdges17;
            btnClose.FillColor = Color.FromArgb(66, 66, 66);
            btnClose.Font = new Font("Segoe UI", 9F);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1162, 119);
            btnClose.Name = "btnClose";
            btnClose.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnClose.Size = new Size(102, 45);
            btnClose.TabIndex = 10;
            btnClose.Text = "Đóng";
            btnClose.Click += btnClose_Click;
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(0, 265);
            splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(grpInvoices);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(grpDetails);
            splitMain.Size = new Size(1384, 555);
            splitMain.SplitterDistance = 1116;
            splitMain.TabIndex = 0;
            // 
            // grpInvoices
            // 
            grpInvoices.BorderColor = Color.FromArgb(255, 167, 38);
            grpInvoices.Controls.Add(dgvInvoices);
            grpInvoices.CustomBorderColor = Color.FromArgb(255, 241, 118);
            grpInvoices.CustomizableEdges = customizableEdges23;
            grpInvoices.Dock = DockStyle.Fill;
            grpInvoices.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpInvoices.ForeColor = Color.FromArgb(198, 40, 40);
            grpInvoices.Location = new Point(0, 0);
            grpInvoices.Name = "grpInvoices";
            grpInvoices.ShadowDecoration.CustomizableEdges = customizableEdges24;
            grpInvoices.Size = new Size(1116, 555);
            grpInvoices.TabIndex = 0;
            grpInvoices.Text = "Danh sách hóa đơn";
            // 
            // dgvInvoices
            // 
            dgvInvoices.AllowUserToAddRows = false;
            dgvInvoices.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvInvoices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvInvoices.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvInvoices.DefaultCellStyle = dataGridViewCellStyle3;
            dgvInvoices.Dock = DockStyle.Fill;
            dgvInvoices.GridColor = Color.FromArgb(231, 229, 255);
            dgvInvoices.Location = new Point(0, 40);
            dgvInvoices.Name = "dgvInvoices";
            dgvInvoices.ReadOnly = true;
            dgvInvoices.RowHeadersVisible = false;
            dgvInvoices.RowHeadersWidth = 51;
            dgvInvoices.Size = new Size(1116, 515);
            dgvInvoices.TabIndex = 0;
            dgvInvoices.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvInvoices.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvInvoices.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvInvoices.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvInvoices.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvInvoices.ThemeStyle.BackColor = Color.White;
            dgvInvoices.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvInvoices.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvInvoices.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvInvoices.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvInvoices.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvInvoices.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvInvoices.ThemeStyle.HeaderStyle.Height = 29;
            dgvInvoices.ThemeStyle.ReadOnly = true;
            dgvInvoices.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvInvoices.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvInvoices.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvInvoices.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvInvoices.ThemeStyle.RowsStyle.Height = 29;
            dgvInvoices.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvInvoices.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvInvoices.CellClick += dgvInvoices_CellClick;
            dgvInvoices.CellDoubleClick += dgvInvoices_CellDoubleClick;
            // 
            // grpDetails
            // 
            grpDetails.BorderColor = Color.FromArgb(255, 167, 38);
            grpDetails.Controls.Add(dgvDetails);
            grpDetails.Controls.Add(pnlSummary);
            grpDetails.CustomBorderColor = Color.FromArgb(255, 241, 118);
            grpDetails.CustomizableEdges = customizableEdges27;
            grpDetails.Dock = DockStyle.Fill;
            grpDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDetails.ForeColor = Color.FromArgb(198, 40, 40);
            grpDetails.Location = new Point(0, 0);
            grpDetails.Name = "grpDetails";
            grpDetails.ShadowDecoration.CustomizableEdges = customizableEdges28;
            grpDetails.Size = new Size(264, 555);
            grpDetails.TabIndex = 0;
            grpDetails.Text = "Chi tiết hóa đơn";
            // 
            // dgvDetails
            // 
            dgvDetails.AllowUserToAddRows = false;
            dgvDetails.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvDetails.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvDetails.ColumnHeadersHeight = 29;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvDetails.DefaultCellStyle = dataGridViewCellStyle6;
            dgvDetails.Dock = DockStyle.Fill;
            dgvDetails.GridColor = Color.FromArgb(231, 229, 255);
            dgvDetails.Location = new Point(0, 223);
            dgvDetails.Name = "dgvDetails";
            dgvDetails.ReadOnly = true;
            dgvDetails.RowHeadersVisible = false;
            dgvDetails.RowHeadersWidth = 51;
            dgvDetails.Size = new Size(264, 332);
            dgvDetails.TabIndex = 0;
            dgvDetails.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvDetails.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvDetails.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvDetails.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvDetails.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvDetails.ThemeStyle.BackColor = Color.White;
            dgvDetails.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvDetails.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvDetails.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDetails.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvDetails.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvDetails.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvDetails.ThemeStyle.HeaderStyle.Height = 29;
            dgvDetails.ThemeStyle.ReadOnly = true;
            dgvDetails.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvDetails.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDetails.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvDetails.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvDetails.ThemeStyle.RowsStyle.Height = 29;
            dgvDetails.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvDetails.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // pnlSummary
            // 
            pnlSummary.Controls.Add(lblMaHoaDonText);
            pnlSummary.Controls.Add(lblMaHoaDonValue);
            pnlSummary.Controls.Add(lblNgayText);
            pnlSummary.Controls.Add(lblNgayValue);
            pnlSummary.Controls.Add(lblKhachText);
            pnlSummary.Controls.Add(lblKhachValue);
            pnlSummary.Controls.Add(lblTongTienText);
            pnlSummary.Controls.Add(lblTongTienValue);
            pnlSummary.Controls.Add(lblGiamGiaText);
            pnlSummary.Controls.Add(lblGiamGiaValue);
            pnlSummary.Controls.Add(lblThanhTienText);
            pnlSummary.Controls.Add(lblThanhTienValue);
            pnlSummary.CustomizableEdges = customizableEdges25;
            pnlSummary.Dock = DockStyle.Top;
            pnlSummary.FillColor = Color.FromArgb(255, 253, 231);
            pnlSummary.Location = new Point(0, 40);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.ShadowDecoration.CustomizableEdges = customizableEdges26;
            pnlSummary.Size = new Size(264, 183);
            pnlSummary.TabIndex = 1;
            // 
            // lblMaHoaDonText
            // 
            lblMaHoaDonText.BackColor = Color.Transparent;
            lblMaHoaDonText.Location = new Point(12, 10);
            lblMaHoaDonText.Name = "lblMaHoaDonText";
            lblMaHoaDonText.Size = new Size(53, 22);
            lblMaHoaDonText.TabIndex = 0;
            lblMaHoaDonText.Text = "Mã HĐ:";
            // 
            // lblMaHoaDonValue
            // 
            lblMaHoaDonValue.BackColor = Color.Transparent;
            lblMaHoaDonValue.Location = new Point(85, 10);
            lblMaHoaDonValue.Name = "lblMaHoaDonValue";
            lblMaHoaDonValue.Size = new Size(9, 22);
            lblMaHoaDonValue.TabIndex = 1;
            lblMaHoaDonValue.Text = "-";
            // 
            // lblNgayText
            // 
            lblNgayText.BackColor = Color.Transparent;
            lblNgayText.Location = new Point(12, 35);
            lblNgayText.Name = "lblNgayText";
            lblNgayText.Size = new Size(41, 22);
            lblNgayText.TabIndex = 2;
            lblNgayText.Text = "Ngày:";
            // 
            // lblNgayValue
            // 
            lblNgayValue.BackColor = Color.Transparent;
            lblNgayValue.Location = new Point(85, 35);
            lblNgayValue.Name = "lblNgayValue";
            lblNgayValue.Size = new Size(9, 22);
            lblNgayValue.TabIndex = 3;
            lblNgayValue.Text = "-";
            // 
            // lblKhachText
            // 
            lblKhachText.BackColor = Color.Transparent;
            lblKhachText.Location = new Point(12, 60);
            lblKhachText.Name = "lblKhachText";
            lblKhachText.Size = new Size(46, 22);
            lblKhachText.TabIndex = 4;
            lblKhachText.Text = "Khách:";
            // 
            // lblKhachValue
            // 
            lblKhachValue.BackColor = Color.Transparent;
            lblKhachValue.Location = new Point(85, 60);
            lblKhachValue.Name = "lblKhachValue";
            lblKhachValue.Size = new Size(59, 22);
            lblKhachValue.TabIndex = 5;
            lblKhachValue.Text = "Khách lẻ";
            // 
            // lblTongTienText
            // 
            lblTongTienText.BackColor = Color.Transparent;
            lblTongTienText.Location = new Point(10, 88);
            lblTongTienText.Name = "lblTongTienText";
            lblTongTienText.Size = new Size(69, 22);
            lblTongTienText.TabIndex = 6;
            lblTongTienText.Text = "Tổng tiền:";
            // 
            // lblTongTienValue
            // 
            lblTongTienValue.BackColor = Color.Transparent;
            lblTongTienValue.Location = new Point(98, 88);
            lblTongTienValue.Name = "lblTongTienValue";
            lblTongTienValue.Size = new Size(24, 22);
            lblTongTienValue.TabIndex = 7;
            lblTongTienValue.Text = "0 đ";
            // 
            // lblGiamGiaText
            // 
            lblGiamGiaText.BackColor = Color.Transparent;
            lblGiamGiaText.Location = new Point(12, 116);
            lblGiamGiaText.Name = "lblGiamGiaText";
            lblGiamGiaText.Size = new Size(64, 22);
            lblGiamGiaText.TabIndex = 8;
            lblGiamGiaText.Text = "Giảm giá:";
            lblGiamGiaText.Click += lblGiamGiaText_Click;
            // 
            // lblGiamGiaValue
            // 
            lblGiamGiaValue.BackColor = Color.Transparent;
            lblGiamGiaValue.Location = new Point(98, 116);
            lblGiamGiaValue.Name = "lblGiamGiaValue";
            lblGiamGiaValue.Size = new Size(24, 22);
            lblGiamGiaValue.TabIndex = 9;
            lblGiamGiaValue.Text = "0 đ";
            // 
            // lblThanhTienText
            // 
            lblThanhTienText.BackColor = Color.Transparent;
            lblThanhTienText.Location = new Point(10, 144);
            lblThanhTienText.Name = "lblThanhTienText";
            lblThanhTienText.Size = new Size(75, 22);
            lblThanhTienText.TabIndex = 10;
            lblThanhTienText.Text = "Thành tiền:";
            lblThanhTienText.Click += lblThanhTienText_Click;
            // 
            // lblThanhTienValue
            // 
            lblThanhTienValue.BackColor = Color.Transparent;
            lblThanhTienValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblThanhTienValue.ForeColor = Color.FromArgb(191, 54, 12);
            lblThanhTienValue.Location = new Point(150, 144);
            lblThanhTienValue.Name = "lblThanhTienValue";
            lblThanhTienValue.Size = new Size(29, 27);
            lblThanhTienValue.TabIndex = 11;
            lblThanhTienValue.Text = "0 đ";
            // 
            // QuanLyHoaDon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1384, 820);
            Controls.Add(splitMain);
            Controls.Add(grpFilter);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(1240, 760);
            Name = "QuanLyHoaDon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinMart+ - Quản lý Hóa đơn";
            Load += QuanLyHoaDon_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpFilter.ResumeLayout(false);
            grpFilter.PerformLayout();
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            grpInvoices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvInvoices).EndInit();
            grpDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDetails).EndInit();
            pnlSummary.ResumeLayout(false);
            pnlSummary.PerformLayout();
            ResumeLayout(false);
        }
    }
}