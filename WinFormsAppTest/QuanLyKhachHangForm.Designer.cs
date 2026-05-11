namespace WinFormsAppTest
{
    partial class QuanLyKhachHangForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView _dgv;
        private Panel _top;
        private Label _title;
        private Button _btnHistory;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyKhachHangForm));
            _dgv = new DataGridView();
            _top = new Panel();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            _title = new Label();
            _btnHistory = new Button();
            ((System.ComponentModel.ISupportInitialize)_dgv).BeginInit();
            _top.SuspendLayout();
            SuspendLayout();
            // 
            // _dgv
            // 
            _dgv.AllowUserToAddRows = false;
            _dgv.AllowUserToDeleteRows = false;
            _dgv.BackgroundColor = Color.White;
            _dgv.BorderStyle = BorderStyle.None;
            _dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = Color.FromArgb(100, 88, 255);
            headerStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            headerStyle.ForeColor = Color.White;
            headerStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            headerStyle.SelectionForeColor = Color.White;
            headerStyle.WrapMode = DataGridViewTriState.True;
            _dgv.ColumnHeadersDefaultCellStyle = headerStyle;

            _dgv.ColumnHeadersHeight = 35;
            _dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cellStyle.BackColor = Color.White;
            cellStyle.Font = new Font("Segoe UI", 9F);
            cellStyle.ForeColor = Color.FromArgb(71, 69, 94);
            cellStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            cellStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            cellStyle.WrapMode = DataGridViewTriState.False;
            _dgv.DefaultCellStyle = cellStyle;

            _dgv.Dock = DockStyle.Fill;
            _dgv.EnableHeadersVisualStyles = false;
            _dgv.GridColor = Color.FromArgb(231, 229, 255);
            _dgv.Location = new Point(0, 110);
            _dgv.Name = "_dgv";
            _dgv.ReadOnly = true;
            _dgv.RowHeadersVisible = false;
            _dgv.RowHeadersWidth = 51;
            _dgv.RowTemplate.Height = 35;
            _dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgv.Size = new Size(1050, 540);
            _dgv.TabIndex = 0;
            // 
            // _top
            // 
            _top.BackColor = Color.FromArgb(198, 40, 40);
            _top.Controls.Add(btnXoa);
            _top.Controls.Add(btnSua);
            _top.Controls.Add(btnThem);
            _top.Controls.Add(_title);
            _top.Controls.Add(_btnHistory);
            _top.Dock = DockStyle.Top;
            _top.Location = new Point(0, 0);
            _top.Name = "_top";
            _top.Size = new Size(1050, 110);
            _top.TabIndex = 1;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(211, 47, 47);
            btnXoa.ForeColor = Color.White;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.Image = Icons.IconGenerator.GenerateDeleteIcon();
            btnXoa.ImageAlign = ContentAlignment.MiddleRight;
            btnXoa.Location = new Point(210, 60);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(85, 32);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 167, 38);
            btnSua.ForeColor = Color.Black;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.Image = Icons.IconGenerator.GenerateEditIcon();
            btnSua.ImageAlign = ContentAlignment.MiddleRight;
            btnSua.Location = new Point(120, 60);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(85, 32);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(255, 167, 38);
            btnThem.ForeColor = Color.Black;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.Image = Icons.IconGenerator.GenerateAddIcon();
            btnThem.ImageAlign = ContentAlignment.MiddleRight;
            btnThem.Location = new Point(30, 60);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(85, 32);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // _title
            // 
            _title.AutoSize = true;
            _title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _title.ForeColor = Color.FromArgb(255, 241, 118);
            _title.Location = new Point(12, 10);
            _title.Name = "_title";
            _title.Size = new Size(270, 37);
            _title.TabIndex = 0;
            _title.Text = "Quản lý Khách hàng";
            // 
            // _btnHistory
            // 
            _btnHistory.BackColor = Color.FromArgb(255, 167, 38);
            _btnHistory.ForeColor = Color.Black;
            _btnHistory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            _btnHistory.Location = new Point(300, 60);
            _btnHistory.Name = "_btnHistory";
            _btnHistory.Size = new Size(100, 32);
            _btnHistory.TabIndex = 2;
            _btnHistory.Text = "Lịch sử mua";
            _btnHistory.UseVisualStyleBackColor = false;
            _btnHistory.Click += btnHistory_Click;
            // 
            // QuanLyKhachHangForm
            // 
            ClientSize = new Size(1050, 650);
            Controls.Add(_dgv);
            Controls.Add(_top);
            Name = "QuanLyKhachHangForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "9. Quản lý Khách hàng";
            Load += (s, e) => QuanLyKhachHangForm_Load(s, e);
            ((System.ComponentModel.ISupportInitialize)_dgv).EndInit();
            _top.ResumeLayout(false);
            _top.PerformLayout();
            ResumeLayout(false);
        }

        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
    }
}
