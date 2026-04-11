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
        private Guna2Button btnViewDetail;
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
            components = new System.ComponentModel.Container();

            pnlHeader = new Guna2Panel();
            lblTitle = new Guna2HtmlLabel();
            lblSubTitle = new Guna2HtmlLabel();

            grpFilter = new Guna2GroupBox();
            lblFrom = new Guna2HtmlLabel();
            lblTo = new Guna2HtmlLabel();
            lblCustomer = new Guna2HtmlLabel();
            dtpFrom = new Guna2DateTimePicker();
            dtpTo = new Guna2DateTimePicker();
            txtCustomerKeyword = new Guna2TextBox();
            btnSearch = new Guna2Button();
            btnResetFilter = new Guna2Button();
            btnRefresh = new Guna2Button();
            btnViewDetail = new Guna2Button();
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

            // Header
            pnlHeader.BackColor = Color.FromArgb(198, 40, 40);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 86;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSubTitle);

            lblTitle.BackColor = Color.Transparent;
            lblTitle.Text = "Quản lý Hóa đơn";
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(255, 241, 118);
            lblTitle.Location = new Point(20, 10);

            lblSubTitle.BackColor = Color.Transparent;
            lblSubTitle.Text = "WinMart+ | Danh sách - Chi tiết - Tìm kiếm - In hóa đơn";
            lblSubTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSubTitle.ForeColor = Color.White;
            lblSubTitle.Location = new Point(22, 54);

            // Filter
            grpFilter.Dock = DockStyle.Top;
            grpFilter.Height = 110;
            grpFilter.Text = "Bộ lọc và thao tác";
            grpFilter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpFilter.ForeColor = Color.FromArgb(198, 40, 40);
            grpFilter.BorderColor = Color.FromArgb(255, 167, 38);
            grpFilter.CustomBorderColor = Color.FromArgb(255, 241, 118);

            lblFrom.BackColor = Color.Transparent;
            lblFrom.Text = "Từ ngày";
            lblFrom.Location = new Point(16, 45);

            dtpFrom.BorderRadius = 8;
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(70, 40);
            dtpFrom.Size = new Size(130, 36);

            lblTo.BackColor = Color.Transparent;
            lblTo.Text = "Đến ngày";
            lblTo.Location = new Point(212, 45);

            dtpTo.BorderRadius = 8;
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(272, 40);
            dtpTo.Size = new Size(130, 36);

            lblCustomer.BackColor = Color.Transparent;
            lblCustomer.Text = "Khách hàng";
            lblCustomer.Location = new Point(415, 45);

            txtCustomerKeyword.BorderRadius = 8;
            txtCustomerKeyword.PlaceholderText = "Tên khách / mã khách / SĐT...";
            txtCustomerKeyword.Location = new Point(492, 40);
            txtCustomerKeyword.Size = new Size(250, 36);

            btnSearch.Text = "Tìm";
            btnSearch.BorderRadius = 8;
            btnSearch.FillColor = Color.FromArgb(255, 167, 38);
            btnSearch.ForeColor = Color.Black;
            btnSearch.Location = new Point(752, 40);
            btnSearch.Size = new Size(84, 36);
            btnSearch.Click += btnSearch_Click;

            btnResetFilter.Text = "Đặt lại";
            btnResetFilter.BorderRadius = 8;
            btnResetFilter.FillColor = Color.FromArgb(97, 97, 97);
            btnResetFilter.ForeColor = Color.White;
            btnResetFilter.Location = new Point(842, 40);
            btnResetFilter.Size = new Size(84, 36);
            btnResetFilter.Click += btnResetFilter_Click;

            btnRefresh.Text = "Làm mới";
            btnRefresh.BorderRadius = 8;
            btnRefresh.FillColor = Color.FromArgb(255, 167, 38);
            btnRefresh.ForeColor = Color.Black;
            btnRefresh.Location = new Point(932, 40);
            btnRefresh.Size = new Size(90, 36);
            btnRefresh.Click += btnRefresh_Click;

            btnViewDetail.Text = "Xem chi tiết";
            btnViewDetail.BorderRadius = 8;
            btnViewDetail.FillColor = Color.FromArgb(198, 40, 40);
            btnViewDetail.ForeColor = Color.White;
            btnViewDetail.Location = new Point(1028, 40);
            btnViewDetail.Size = new Size(104, 36);
            btnViewDetail.Click += btnViewDetail_Click;

            btnPrintInvoice.Text = "In hóa đơn";
            btnPrintInvoice.BorderRadius = 8;
            btnPrintInvoice.FillColor = Color.FromArgb(211, 47, 47);
            btnPrintInvoice.ForeColor = Color.White;
            btnPrintInvoice.Location = new Point(1138, 40);
            btnPrintInvoice.Size = new Size(104, 36);
            btnPrintInvoice.Click += btnPrintInvoice_Click;

            btnClose.Text = "Đóng";
            btnClose.BorderRadius = 8;
            btnClose.FillColor = Color.FromArgb(66, 66, 66);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1248, 40);
            btnClose.Size = new Size(84, 36);
            btnClose.Click += btnClose_Click;

            grpFilter.Controls.Add(lblFrom);
            grpFilter.Controls.Add(dtpFrom);
            grpFilter.Controls.Add(lblTo);
            grpFilter.Controls.Add(dtpTo);
            grpFilter.Controls.Add(lblCustomer);
            grpFilter.Controls.Add(txtCustomerKeyword);
            grpFilter.Controls.Add(btnSearch);
            grpFilter.Controls.Add(btnResetFilter);
            grpFilter.Controls.Add(btnRefresh);
            grpFilter.Controls.Add(btnViewDetail);
            grpFilter.Controls.Add(btnPrintInvoice);
            grpFilter.Controls.Add(btnClose);

            // Split
            splitMain.Dock = DockStyle.Fill;
            splitMain.SplitterDistance = 700;

            // Left
            grpInvoices.Dock = DockStyle.Fill;
            grpInvoices.Text = "Danh sách hóa đơn";
            grpInvoices.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpInvoices.ForeColor = Color.FromArgb(198, 40, 40);
            grpInvoices.BorderColor = Color.FromArgb(255, 167, 38);
            grpInvoices.CustomBorderColor = Color.FromArgb(255, 241, 118);

            dgvInvoices.Dock = DockStyle.Fill;
            dgvInvoices.ReadOnly = true;
            dgvInvoices.AllowUserToAddRows = false;
            dgvInvoices.AllowUserToDeleteRows = false;
            dgvInvoices.RowHeadersVisible = false;
            dgvInvoices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvInvoices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInvoices.CellClick += dgvInvoices_CellClick;
            dgvInvoices.CellDoubleClick += dgvInvoices_CellDoubleClick;

            grpInvoices.Controls.Add(dgvInvoices);
            splitMain.Panel1.Controls.Add(grpInvoices);

            // Right
            grpDetails.Dock = DockStyle.Fill;
            grpDetails.Text = "Chi tiết hóa đơn";
            grpDetails.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpDetails.ForeColor = Color.FromArgb(198, 40, 40);
            grpDetails.BorderColor = Color.FromArgb(255, 167, 38);
            grpDetails.CustomBorderColor = Color.FromArgb(255, 241, 118);

            pnlSummary.Dock = DockStyle.Top;
            pnlSummary.Height = 150;
            pnlSummary.FillColor = Color.FromArgb(255, 253, 231);

            lblMaHoaDonText.BackColor = Color.Transparent;
            lblMaHoaDonText.Text = "Mã HĐ:";
            lblMaHoaDonText.Location = new Point(12, 10);
            lblMaHoaDonValue.BackColor = Color.Transparent;
            lblMaHoaDonValue.Text = "-";
            lblMaHoaDonValue.Location = new Point(85, 10);

            lblNgayText.BackColor = Color.Transparent;
            lblNgayText.Text = "Ngày:";
            lblNgayText.Location = new Point(12, 35);
            lblNgayValue.BackColor = Color.Transparent;
            lblNgayValue.Text = "-";
            lblNgayValue.Location = new Point(85, 35);

            lblKhachText.BackColor = Color.Transparent;
            lblKhachText.Text = "Khách:";
            lblKhachText.Location = new Point(12, 60);
            lblKhachValue.BackColor = Color.Transparent;
            lblKhachValue.Text = "Khách lẻ";
            lblKhachValue.Location = new Point(85, 60);

            lblTongTienText.BackColor = Color.Transparent;
            lblTongTienText.Text = "Tổng tiền:";
            lblTongTienText.Location = new Point(12, 95);
            lblTongTienValue.BackColor = Color.Transparent;
            lblTongTienValue.Text = "0 đ";
            lblTongTienValue.Location = new Point(85, 95);

            lblGiamGiaText.BackColor = Color.Transparent;
            lblGiamGiaText.Text = "Giảm:";
            lblGiamGiaText.Location = new Point(220, 95);
            lblGiamGiaValue.BackColor = Color.Transparent;
            lblGiamGiaValue.Text = "0 đ";
            lblGiamGiaValue.Location = new Point(270, 95);

            lblThanhTienText.BackColor = Color.Transparent;
            lblThanhTienText.Text = "Thành tiền:";
            lblThanhTienText.Location = new Point(220, 120);
            lblThanhTienValue.BackColor = Color.Transparent;
            lblThanhTienValue.Text = "0 đ";
            lblThanhTienValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblThanhTienValue.ForeColor = Color.FromArgb(191, 54, 12);
            lblThanhTienValue.Location = new Point(292, 118);

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

            dgvDetails.Dock = DockStyle.Fill;
            dgvDetails.ReadOnly = true;
            dgvDetails.AllowUserToAddRows = false;
            dgvDetails.AllowUserToDeleteRows = false;
            dgvDetails.RowHeadersVisible = false;
            dgvDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            grpDetails.Controls.Add(dgvDetails);
            grpDetails.Controls.Add(pnlSummary);

            splitMain.Panel2.Controls.Add(grpDetails);

            // Form
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1360, 820);
            MinimumSize = new Size(1240, 760);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinMart+ - Quản lý Hóa đơn";
            Load += QuanLyHoaDon_Load;

            Controls.Add(splitMain);
            Controls.Add(grpFilter);
            Controls.Add(pnlHeader);

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