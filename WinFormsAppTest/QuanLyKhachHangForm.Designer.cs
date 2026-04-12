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
            _dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgv.ColumnHeadersHeight = 29;
            _dgv.Dock = DockStyle.Fill;
            _dgv.Location = new Point(0, 112);
            _dgv.Name = "_dgv";
            _dgv.ReadOnly = true;
            _dgv.RowHeadersVisible = false;
            _dgv.RowHeadersWidth = 51;
            _dgv.Size = new Size(1050, 538);
            _dgv.TabIndex = 0;
            // 
            // _top
            // 
            _top.BackColor = Color.FromArgb(255, 241, 118);
            _top.Controls.Add(btnXoa);
            _top.Controls.Add(btnSua);
            _top.Controls.Add(btnThem);
            _top.Controls.Add(_title);
            _top.Controls.Add(_btnHistory);
            _top.Dock = DockStyle.Top;
            _top.Location = new Point(0, 0);
            _top.Name = "_top";
            _top.Size = new Size(1050, 112);
            _top.TabIndex = 1;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(198, 40, 40);
            btnXoa.ForeColor = Color.White;
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = ContentAlignment.MiddleRight;
            btnXoa.Location = new Point(195, 66);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(85, 30);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(198, 40, 40);
            btnSua.ForeColor = Color.White;
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = ContentAlignment.MiddleRight;
            btnSua.Location = new Point(104, 66);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(85, 30);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(198, 40, 40);
            btnThem.ForeColor = Color.White;
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleRight;
            btnThem.Location = new Point(13, 66);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(85, 30);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // _title
            // 
            _title.AutoSize = true;
            _title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _title.ForeColor = Color.FromArgb(198, 40, 40);
            _title.Location = new Point(12, 10);
            _title.Name = "_title";
            _title.Size = new Size(270, 37);
            _title.TabIndex = 0;
            _title.Text = "Quản lý Khách hàng";
            // 
            // _btnHistory
            // 
            _btnHistory.BackColor = Color.FromArgb(198, 40, 40);
            _btnHistory.ForeColor = Color.White;
            _btnHistory.Location = new Point(289, 66);
            _btnHistory.Name = "_btnHistory";
            _btnHistory.Size = new Size(85, 30);
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
