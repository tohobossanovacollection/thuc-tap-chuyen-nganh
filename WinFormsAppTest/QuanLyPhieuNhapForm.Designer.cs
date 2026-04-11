namespace WinFormsAppTest
{
    partial class QuanLyPhieuNhapForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblSubTitle;

        private GroupBox grpFilter;
        private Label lblFrom;
        private DateTimePicker dtpFrom;
        private Label lblTo;
        private DateTimePicker dtpTo;
        private Label lblKeyword;
        private TextBox txtKeyword;
        private Button _btnTao;
        private Button _btnThemSP;
        private Button _btnTong;
        private Button _btnTon;

        private SplitContainer splitMain;
        private GroupBox grpPhieuNhap;
        private DataGridView _dgvPhieuNhap;
        private GroupBox grpChiTiet;
        private DataGridView _dgvChiTiet;

        private Panel pnlSummary;
        private Label lblMaPhieuText;
        private Label lblMaPhieuValue;
        private Label lblNgayNhapText;
        private Label lblNgayNhapValue;
        private Label lblTongTienText;
        private Label lblTongTienValue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblSubTitle = new Label();

            grpFilter = new GroupBox();
            lblFrom = new Label();
            dtpFrom = new DateTimePicker();
            lblTo = new Label();
            dtpTo = new DateTimePicker();
            lblKeyword = new Label();
            txtKeyword = new TextBox();
            _btnTao = new Button();
            _btnThemSP = new Button();
            _btnTong = new Button();
            _btnTon = new Button();

            splitMain = new SplitContainer();
            grpPhieuNhap = new GroupBox();
            _dgvPhieuNhap = new DataGridView();
            grpChiTiet = new GroupBox();
            _dgvChiTiet = new DataGridView();

            pnlSummary = new Panel();
            lblMaPhieuText = new Label();
            lblMaPhieuValue = new Label();
            lblNgayNhapText = new Label();
            lblNgayNhapValue = new Label();
            lblTongTienText = new Label();
            lblTongTienValue = new Label();

            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvPhieuNhap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_dgvChiTiet).BeginInit();
            pnlHeader.SuspendLayout();
            grpFilter.SuspendLayout();
            grpPhieuNhap.SuspendLayout();
            grpChiTiet.SuspendLayout();
            pnlSummary.SuspendLayout();
            SuspendLayout();

            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(198, 40, 40);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 86;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(255, 241, 118);
            lblTitle.Location = new Point(16, 8);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(264, 37);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản lý Phiếu nhập";
            // 
            // lblSubTitle
            // 
            lblSubTitle.AutoSize = true;
            lblSubTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSubTitle.ForeColor = Color.White;
            lblSubTitle.Location = new Point(18, 55);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(391, 23);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "WinMart+ | Tạo phiếu - thêm sản phẩm - tính tổng - cập nhật tồn kho";
            // 
            // grpFilter
            // 
            grpFilter.Controls.Add(_btnTon);
            grpFilter.Controls.Add(_btnTong);
            grpFilter.Controls.Add(_btnThemSP);
            grpFilter.Controls.Add(_btnTao);
            grpFilter.Controls.Add(txtKeyword);
            grpFilter.Controls.Add(lblKeyword);
            grpFilter.Controls.Add(dtpTo);
            grpFilter.Controls.Add(lblTo);
            grpFilter.Controls.Add(dtpFrom);
            grpFilter.Controls.Add(lblFrom);
            grpFilter.Dock = DockStyle.Top;
            grpFilter.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpFilter.ForeColor = Color.FromArgb(198, 40, 40);
            grpFilter.Location = new Point(0, 86);
            grpFilter.Name = "grpFilter";
            grpFilter.Size = new Size(1360, 110);
            grpFilter.TabIndex = 2;
            grpFilter.TabStop = false;
            grpFilter.Text = "Bộ lọc và thao tác";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(20, 38);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(65, 23);
            lblFrom.TabIndex = 0;
            lblFrom.Text = "Từ ngày";
            // 
            // dtpFrom
            // 
            dtpFrom.CustomFormat = "dd/MM/yyyy";
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.Location = new Point(20, 64);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(130, 30);
            dtpFrom.TabIndex = 1;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(165, 38);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(70, 23);
            lblTo.TabIndex = 2;
            lblTo.Text = "Đến ngày";
            // 
            // dtpTo
            // 
            dtpTo.CustomFormat = "dd/MM/yyyy";
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.Location = new Point(165, 64);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(130, 30);
            dtpTo.TabIndex = 3;
            // 
            // lblKeyword
            // 
            lblKeyword.AutoSize = true;
            lblKeyword.Location = new Point(310, 38);
            lblKeyword.Name = "lblKeyword";
            lblKeyword.Size = new Size(155, 23);
            lblKeyword.TabIndex = 4;
            lblKeyword.Text = "Nhà cung cấp / Mã phiếu";
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(310, 64);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(280, 30);
            txtKeyword.TabIndex = 5;
            // 
            // _btnTao
            // 
            _btnTao.BackColor = Color.FromArgb(198, 40, 40);
            _btnTao.FlatStyle = FlatStyle.Flat;
            _btnTao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            _btnTao.ForeColor = Color.White;
            _btnTao.Location = new Point(610, 56);
            _btnTao.Name = "_btnTao";
            _btnTao.Size = new Size(110, 34);
            _btnTao.TabIndex = 6;
            _btnTao.Text = "Tạo phiếu";
            _btnTao.UseVisualStyleBackColor = false;
            _btnTao.Click += btnTao_Click;
            // 
            // _btnThemSP
            // 
            _btnThemSP.BackColor = Color.FromArgb(198, 40, 40);
            _btnThemSP.FlatStyle = FlatStyle.Flat;
            _btnThemSP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            _btnThemSP.ForeColor = Color.White;
            _btnThemSP.Location = new Point(726, 56);
            _btnThemSP.Name = "_btnThemSP";
            _btnThemSP.Size = new Size(110, 34);
            _btnThemSP.TabIndex = 7;
            _btnThemSP.Text = "Thêm SP";
            _btnThemSP.UseVisualStyleBackColor = false;
            _btnThemSP.Click += btnThemSP_Click;
            // 
            // _btnTong
            // 
            _btnTong.BackColor = Color.FromArgb(198, 40, 40);
            _btnTong.FlatStyle = FlatStyle.Flat;
            _btnTong.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            _btnTong.ForeColor = Color.White;
            _btnTong.Location = new Point(842, 56);
            _btnTong.Name = "_btnTong";
            _btnTong.Size = new Size(110, 34);
            _btnTong.TabIndex = 8;
            _btnTong.Text = "Tính tổng";
            _btnTong.UseVisualStyleBackColor = false;
            _btnTong.Click += btnTong_Click;
            // 
            // _btnTon
            // 
            _btnTon.BackColor = Color.FromArgb(198, 40, 40);
            _btnTon.FlatStyle = FlatStyle.Flat;
            _btnTon.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            _btnTon.ForeColor = Color.White;
            _btnTon.Location = new Point(958, 56);
            _btnTon.Name = "_btnTon";
            _btnTon.Size = new Size(120, 34);
            _btnTon.TabIndex = 9;
            _btnTon.Text = "Cập nhật kho";
            _btnTon.UseVisualStyleBackColor = false;
            _btnTon.Click += btnTon_Click;
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(0, 196);
            splitMain.Name = "splitMain";
            splitMain.Orientation = Orientation.Horizontal;
            // 
            // splitMain.Panel1
            // 
            splitMain.Panel1.Controls.Add(grpPhieuNhap);
            // 
            // splitMain.Panel2
            // 
            splitMain.Panel2.Controls.Add(grpChiTiet);
            splitMain.Size = new Size(1360, 584);
            splitMain.SplitterDistance = 380;
            splitMain.TabIndex = 0;
            // 
            // grpPhieuNhap
            // 
            grpPhieuNhap.Controls.Add(_dgvPhieuNhap);
            grpPhieuNhap.Dock = DockStyle.Fill;
            grpPhieuNhap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpPhieuNhap.ForeColor = Color.FromArgb(198, 40, 40);
            grpPhieuNhap.Location = new Point(0, 0);
            grpPhieuNhap.Name = "grpPhieuNhap";
            grpPhieuNhap.Size = new Size(1360, 380);
            grpPhieuNhap.TabIndex = 0;
            grpPhieuNhap.TabStop = false;
            grpPhieuNhap.Text = "Danh sách phiếu nhập";
            // 
            // _dgvPhieuNhap
            // 
            _dgvPhieuNhap.AllowUserToAddRows = false;
            _dgvPhieuNhap.AllowUserToDeleteRows = false;
            _dgvPhieuNhap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dgvPhieuNhap.Dock = DockStyle.Fill;
            _dgvPhieuNhap.Location = new Point(3, 26);
            _dgvPhieuNhap.Name = "_dgvPhieuNhap";
            _dgvPhieuNhap.ReadOnly = true;
            _dgvPhieuNhap.RowHeadersVisible = false;
            _dgvPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvPhieuNhap.Size = new Size(1354, 351);
            _dgvPhieuNhap.TabIndex = 0;
            // 
            // grpChiTiet
            // 
            grpChiTiet.Controls.Add(_dgvChiTiet);
            grpChiTiet.Controls.Add(pnlSummary);
            grpChiTiet.Dock = DockStyle.Fill;
            grpChiTiet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpChiTiet.ForeColor = Color.FromArgb(198, 40, 40);
            grpChiTiet.Location = new Point(0, 0);
            grpChiTiet.Name = "grpChiTiet";
            grpChiTiet.Size = new Size(1360, 200);
            grpChiTiet.TabIndex = 0;
            grpChiTiet.TabStop = false;
            grpChiTiet.Text = "Chi tiết phiếu nhập";
            // 
            // _dgvChiTiet
            // 
            _dgvChiTiet.AllowUserToAddRows = false;
            _dgvChiTiet.AllowUserToDeleteRows = false;
            _dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dgvChiTiet.Dock = DockStyle.Fill;
            _dgvChiTiet.Location = new Point(3, 26);
            _dgvChiTiet.Name = "_dgvChiTiet";
            _dgvChiTiet.ReadOnly = true;
            _dgvChiTiet.RowHeadersVisible = false;
            _dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvChiTiet.Size = new Size(1354, 171);
            _dgvChiTiet.TabIndex = 0;
            // 
            // pnlSummary
            // 
            pnlSummary.BackColor = Color.FromArgb(255, 253, 231);
            pnlSummary.Controls.Add(lblTongTienValue);
            pnlSummary.Controls.Add(lblTongTienText);
            pnlSummary.Controls.Add(lblNgayNhapValue);
            pnlSummary.Controls.Add(lblNgayNhapText);
            pnlSummary.Controls.Add(lblMaPhieuValue);
            pnlSummary.Controls.Add(lblMaPhieuText);
            pnlSummary.Dock = DockStyle.Top;
            pnlSummary.Location = new Point(3, 26);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(1354, 120);
            pnlSummary.TabIndex = 1;
            // 
            // lblMaPhieuText
            // 
            lblMaPhieuText.AutoSize = true;
            lblMaPhieuText.Location = new Point(14, 14);
            lblMaPhieuText.Name = "lblMaPhieuText";
            lblMaPhieuText.Size = new Size(74, 23);
            lblMaPhieuText.TabIndex = 0;
            lblMaPhieuText.Text = "Mã phiếu:";
            // 
            // lblMaPhieuValue
            // 
            lblMaPhieuValue.AutoSize = true;
            lblMaPhieuValue.Location = new Point(94, 14);
            lblMaPhieuValue.Name = "lblMaPhieuValue";
            lblMaPhieuValue.Size = new Size(17, 23);
            lblMaPhieuValue.TabIndex = 1;
            lblMaPhieuValue.Text = "-";
            // 
            // lblNgayNhapText
            // 
            lblNgayNhapText.AutoSize = true;
            lblNgayNhapText.Location = new Point(14, 42);
            lblNgayNhapText.Name = "lblNgayNhapText";
            lblNgayNhapText.Size = new Size(91, 23);
            lblNgayNhapText.TabIndex = 2;
            lblNgayNhapText.Text = "Ngày nhập:";
            // 
            // lblNgayNhapValue
            // 
            lblNgayNhapValue.AutoSize = true;
            lblNgayNhapValue.Location = new Point(109, 42);
            lblNgayNhapValue.Name = "lblNgayNhapValue";
            lblNgayNhapValue.Size = new Size(17, 23);
            lblNgayNhapValue.TabIndex = 3;
            lblNgayNhapValue.Text = "-";
            // 
            // lblTongTienText
            // 
            lblTongTienText.AutoSize = true;
            lblTongTienText.Location = new Point(14, 74);
            lblTongTienText.Name = "lblTongTienText";
            lblTongTienText.Size = new Size(80, 23);
            lblTongTienText.TabIndex = 4;
            lblTongTienText.Text = "Tổng tiền:";
            // 
            // lblTongTienValue
            // 
            lblTongTienValue.AutoSize = true;
            lblTongTienValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTongTienValue.ForeColor = Color.FromArgb(191, 54, 12);
            lblTongTienValue.Location = new Point(100, 74);
            lblTongTienValue.Name = "lblTongTienValue";
            lblTongTienValue.Size = new Size(51, 23);
            lblTongTienValue.TabIndex = 5;
            lblTongTienValue.Text = "0 đ";
            // 
            // QuanLyPhieuNhapForm
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1360, 780);
            Controls.Add(splitMain);
            Controls.Add(grpFilter);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "QuanLyPhieuNhapForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "7. Quản lý Phiếu nhập";
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgvPhieuNhap).EndInit();
            ((System.ComponentModel.ISupportInitialize)_dgvChiTiet).EndInit();
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpFilter.ResumeLayout(false);
            grpFilter.PerformLayout();
            grpPhieuNhap.ResumeLayout(false);
            grpChiTiet.ResumeLayout(false);
            pnlSummary.ResumeLayout(false);
            pnlSummary.PerformLayout();
            ResumeLayout(false);
        }
    }
}
