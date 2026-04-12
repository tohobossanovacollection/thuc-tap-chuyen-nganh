namespace WinFormsAppTest
{
    partial class QuanLyPhieuNhapForm
    {
        private System.ComponentModel.IContainer components = null;
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
            lblTitle = new Label();
            lblSubTitle = new Label();
            grpFilter = new GroupBox();
            _btnTim = new Button();
            _btnTao = new Button();
            txtKeyword = new TextBox();
            lblKeyword = new Label();
            dtpTo = new DateTimePicker();
            lblTo = new Label();
            dtpFrom = new DateTimePicker();
            lblFrom = new Label();
            splitMain = new SplitContainer();
            grpPhieuNhap = new GroupBox();
            _dgvPhieuNhap = new DataGridView();
            grpChiTiet = new GroupBox();
            pnlSummary = new Panel();
            lblTongTienValue = new Label();
            lblTongTienText = new Label();
            lblNgayNhapValue = new Label();
            lblNgayNhapText = new Label();
            lblMaPhieuValue = new Label();
            lblMaPhieuText = new Label();
            _dgvChiTiet = new DataGridView();
            grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitMain).BeginInit();
            splitMain.Panel1.SuspendLayout();
            splitMain.Panel2.SuspendLayout();
            splitMain.SuspendLayout();
            grpPhieuNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvPhieuNhap).BeginInit();
            grpChiTiet.SuspendLayout();
            pnlSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvChiTiet).BeginInit();
            SuspendLayout();
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
            grpFilter.Controls.Add(_btnTim);
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
            grpFilter.Location = new Point(0, 0);
            grpFilter.Margin = new Padding(3, 4, 3, 4);
            grpFilter.Name = "grpFilter";
            grpFilter.Padding = new Padding(3, 4, 3, 4);
            grpFilter.Size = new Size(1501, 129);
            grpFilter.TabIndex = 2;
            grpFilter.TabStop = false;
            grpFilter.Text = "Bộ lọc và thao tác";
            // 
            // _btnTim
            // 
            _btnTim.BackColor = Color.FromArgb(198, 40, 40);
            _btnTim.FlatStyle = FlatStyle.Flat;
            _btnTim.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            _btnTim.ForeColor = Color.White;
            _btnTim.Location = new Point(600, 75);
            _btnTim.Margin = new Padding(3, 4, 3, 4);
            _btnTim.Name = "_btnTim";
            _btnTim.Size = new Size(110, 31);
            _btnTim.TabIndex = 10;
            _btnTim.Text = "Tìm kiếm";
            _btnTim.UseVisualStyleBackColor = false;
            // 
            // _btnTao
            // 
            _btnTao.BackColor = Color.Yellow;
            _btnTao.FlatStyle = FlatStyle.Flat;
            _btnTao.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            _btnTao.ForeColor = Color.Red;
            _btnTao.Location = new Point(1380, 72);
            _btnTao.Margin = new Padding(3, 4, 3, 4);
            _btnTao.Name = "_btnTao";
            _btnTao.Size = new Size(109, 40);
            _btnTao.TabIndex = 6;
            _btnTao.Text = "Tạo phiếu";
            _btnTao.UseVisualStyleBackColor = false;
            _btnTao.Click += btnTao_Click;
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(310, 75);
            txtKeyword.Margin = new Padding(3, 4, 3, 4);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(280, 30);
            txtKeyword.TabIndex = 5;
            // 
            // lblKeyword
            // 
            lblKeyword.AutoSize = true;
            lblKeyword.Location = new Point(310, 45);
            lblKeyword.Name = "lblKeyword";
            lblKeyword.Size = new Size(212, 23);
            lblKeyword.TabIndex = 4;
            lblKeyword.Text = "Nhà cung cấp / Mã phiếu";
            // 
            // dtpTo
            // 
            dtpTo.CustomFormat = "dd/MM/yyyy";
            dtpTo.Format = DateTimePickerFormat.Custom;
            dtpTo.Location = new Point(165, 75);
            dtpTo.Margin = new Padding(3, 4, 3, 4);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(130, 30);
            dtpTo.TabIndex = 3;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Location = new Point(165, 45);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(86, 23);
            lblTo.TabIndex = 2;
            lblTo.Text = "Đến ngày";
            // 
            // dtpFrom
            // 
            dtpFrom.CustomFormat = "dd/MM/yyyy";
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.Location = new Point(20, 75);
            dtpFrom.Margin = new Padding(3, 4, 3, 4);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(130, 30);
            dtpFrom.TabIndex = 1;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(20, 45);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(75, 23);
            lblFrom.TabIndex = 0;
            lblFrom.Text = "Từ ngày";
            // 
            // splitMain
            // 
            splitMain.Dock = DockStyle.Fill;
            splitMain.Location = new Point(0, 129);
            splitMain.Margin = new Padding(3, 4, 3, 4);
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
            splitMain.Size = new Size(1501, 500);
            splitMain.SplitterDistance = 325;
            splitMain.SplitterWidth = 5;
            splitMain.TabIndex = 0;
            // 
            // grpPhieuNhap
            // 
            grpPhieuNhap.Controls.Add(_dgvPhieuNhap);
            grpPhieuNhap.Dock = DockStyle.Fill;
            grpPhieuNhap.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpPhieuNhap.ForeColor = Color.FromArgb(198, 40, 40);
            grpPhieuNhap.Location = new Point(0, 0);
            grpPhieuNhap.Margin = new Padding(3, 4, 3, 4);
            grpPhieuNhap.Name = "grpPhieuNhap";
            grpPhieuNhap.Padding = new Padding(3, 4, 3, 4);
            grpPhieuNhap.Size = new Size(1501, 325);
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
            _dgvPhieuNhap.Location = new Point(3, 27);
            _dgvPhieuNhap.Margin = new Padding(3, 4, 3, 4);
            _dgvPhieuNhap.Name = "_dgvPhieuNhap";
            _dgvPhieuNhap.ReadOnly = true;
            _dgvPhieuNhap.RowHeadersVisible = false;
            _dgvPhieuNhap.RowHeadersWidth = 51;
            _dgvPhieuNhap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvPhieuNhap.Size = new Size(1495, 294);
            _dgvPhieuNhap.TabIndex = 0;
            // 
            // grpChiTiet
            // 
            grpChiTiet.Controls.Add(pnlSummary);
            grpChiTiet.Controls.Add(_dgvChiTiet);
            grpChiTiet.Dock = DockStyle.Fill;
            grpChiTiet.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpChiTiet.ForeColor = Color.FromArgb(198, 40, 40);
            grpChiTiet.Location = new Point(0, 0);
            grpChiTiet.Margin = new Padding(3, 4, 3, 4);
            grpChiTiet.Name = "grpChiTiet";
            grpChiTiet.Padding = new Padding(3, 4, 3, 4);
            grpChiTiet.Size = new Size(1501, 170);
            grpChiTiet.TabIndex = 0;
            grpChiTiet.TabStop = false;
            grpChiTiet.Text = "Chi tiết phiếu nhập";
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
            pnlSummary.Dock = DockStyle.Right;
            pnlSummary.Location = new Point(1197, 27);
            pnlSummary.Margin = new Padding(3, 4, 3, 4);
            pnlSummary.Name = "pnlSummary";
            pnlSummary.Size = new Size(301, 139);
            pnlSummary.TabIndex = 1;
            pnlSummary.Paint += pnlSummary_Paint;
            // 
            // lblTongTienValue
            // 
            lblTongTienValue.AutoSize = true;
            lblTongTienValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTongTienValue.ForeColor = Color.FromArgb(191, 54, 12);
            lblTongTienValue.Location = new Point(100, 87);
            lblTongTienValue.Name = "lblTongTienValue";
            lblTongTienValue.Size = new Size(36, 23);
            lblTongTienValue.TabIndex = 5;
            lblTongTienValue.Text = "0 đ";
            // 
            // lblTongTienText
            // 
            lblTongTienText.AutoSize = true;
            lblTongTienText.Location = new Point(14, 87);
            lblTongTienText.Name = "lblTongTienText";
            lblTongTienText.Size = new Size(92, 23);
            lblTongTienText.TabIndex = 4;
            lblTongTienText.Text = "Tổng tiền:";
            // 
            // lblNgayNhapValue
            // 
            lblNgayNhapValue.AutoSize = true;
            lblNgayNhapValue.Location = new Point(109, 49);
            lblNgayNhapValue.Name = "lblNgayNhapValue";
            lblNgayNhapValue.Size = new Size(17, 23);
            lblNgayNhapValue.TabIndex = 3;
            lblNgayNhapValue.Text = "-";
            // 
            // lblNgayNhapText
            // 
            lblNgayNhapText.AutoSize = true;
            lblNgayNhapText.Location = new Point(14, 49);
            lblNgayNhapText.Name = "lblNgayNhapText";
            lblNgayNhapText.Size = new Size(102, 23);
            lblNgayNhapText.TabIndex = 2;
            lblNgayNhapText.Text = "Ngày nhập:";
            // 
            // lblMaPhieuValue
            // 
            lblMaPhieuValue.AutoSize = true;
            lblMaPhieuValue.Location = new Point(94, 16);
            lblMaPhieuValue.Name = "lblMaPhieuValue";
            lblMaPhieuValue.Size = new Size(17, 23);
            lblMaPhieuValue.TabIndex = 1;
            lblMaPhieuValue.Text = "-";
            // 
            // lblMaPhieuText
            // 
            lblMaPhieuText.AutoSize = true;
            lblMaPhieuText.Location = new Point(14, 16);
            lblMaPhieuText.Name = "lblMaPhieuText";
            lblMaPhieuText.Size = new Size(90, 23);
            lblMaPhieuText.TabIndex = 0;
            lblMaPhieuText.Text = "Mã phiếu:";
            // 
            // _dgvChiTiet
            // 
            _dgvChiTiet.AllowUserToAddRows = false;
            _dgvChiTiet.AllowUserToDeleteRows = false;
            _dgvChiTiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvChiTiet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            _dgvChiTiet.Dock = DockStyle.Left;
            _dgvChiTiet.Location = new Point(3, 27);
            _dgvChiTiet.Margin = new Padding(3, 4, 3, 4);
            _dgvChiTiet.Name = "_dgvChiTiet";
            _dgvChiTiet.ReadOnly = true;
            _dgvChiTiet.RowHeadersVisible = false;
            _dgvChiTiet.RowHeadersWidth = 51;
            _dgvChiTiet.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvChiTiet.Size = new Size(1194, 139);
            _dgvChiTiet.TabIndex = 0;
            _dgvChiTiet.CellContentClick += _dgvChiTiet_CellContentClick;
            // 
            // QuanLyPhieuNhapForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1501, 629);
            Controls.Add(splitMain);
            Controls.Add(grpFilter);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 5, 3, 5);
            Name = "QuanLyPhieuNhapForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "7. Quản lý Phiếu nhập";
            grpFilter.ResumeLayout(false);
            grpFilter.PerformLayout();
            splitMain.Panel1.ResumeLayout(false);
            splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitMain).EndInit();
            splitMain.ResumeLayout(false);
            grpPhieuNhap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgvPhieuNhap).EndInit();
            grpChiTiet.ResumeLayout(false);
            pnlSummary.ResumeLayout(false);
            pnlSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_dgvChiTiet).EndInit();
            ResumeLayout(false);
        }

        private Button _btnTim;
    }
}
