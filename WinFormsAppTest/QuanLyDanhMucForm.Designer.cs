namespace WinFormsAppTest
{
    partial class QuanLyDanhMucForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView _dgv;
        private TextBox _txtMa;
        private TextBox _txtTen;
        private Panel _top;
        private Label _title;
        private Button _btnThem;
        private Button _btnSua;
        private Button _btnXoa;
        private Button _btnGan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            _dgv = new DataGridView();
            _txtMa = new TextBox();
            _txtTen = new TextBox();
            _top = new Panel();
            _title = new Label();
            _btnThem = new Button();
            _btnSua = new Button();
            _btnXoa = new Button();
            _btnGan = new Button();
            ((System.ComponentModel.ISupportInitialize)_dgv).BeginInit();
            _top.SuspendLayout();
            SuspendLayout();
            // 
            // _dgv
            // 
            _dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgv.ColumnHeadersHeight = 29;
            _dgv.Dock = DockStyle.Fill;
            _dgv.Location = new Point(0, 110);
            _dgv.Name = "_dgv";
            _dgv.ReadOnly = true;
            _dgv.RowHeadersVisible = false;
            _dgv.RowHeadersWidth = 51;
            _dgv.Size = new Size(1000, 540);
            _dgv.TabIndex = 0;
            // 
            // _txtMa
            // 
            _txtMa.Location = new Point(12, 55);
            _txtMa.Name = "_txtMa";
            _txtMa.PlaceholderText = "Mã danh mục";
            _txtMa.Size = new Size(150, 27);
            _txtMa.TabIndex = 1;
            // 
            // _txtTen
            // 
            _txtTen.Location = new Point(170, 55);
            _txtTen.Name = "_txtTen";
            _txtTen.PlaceholderText = "Tên danh mục";
            _txtTen.Size = new Size(250, 27);
            _txtTen.TabIndex = 2;
            // 
            // _top
            // 
            _top.BackColor = Color.Yellow;
            _top.Controls.Add(_title);
            _top.Controls.Add(_txtMa);
            _top.Controls.Add(_txtTen);
            _top.Controls.Add(_btnThem);
            _top.Controls.Add(_btnSua);
            _top.Controls.Add(_btnXoa);
            _top.Controls.Add(_btnGan);
            _top.Dock = DockStyle.Top;
            _top.Location = new Point(0, 0);
            _top.Name = "_top";
            _top.Size = new Size(1000, 110);
            _top.TabIndex = 1;
            // 
            // _title
            // 
            _title.AutoSize = true;
            _title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _title.ForeColor = Color.FromArgb(198, 40, 40);
            _title.Location = new Point(12, 10);
            _title.Name = "_title";
            _title.Size = new Size(249, 37);
            _title.TabIndex = 0;
            _title.Text = "Quản lý Danh mục";
            // 
            // _btnThem
            // 
            _btnThem.BackColor = Color.FromArgb(198, 40, 40);
            _btnThem.ForeColor = Color.White;
            _btnThem.Location = new Point(430, 53);
            _btnThem.Name = "_btnThem";
            _btnThem.Size = new Size(85, 32);
            _btnThem.TabIndex = 3;
            _btnThem.Text = "Thêm";
            _btnThem.UseVisualStyleBackColor = false;
            _btnThem.Click += btnThem_Click;
            // 
            // _btnSua
            // 
            _btnSua.BackColor = Color.FromArgb(198, 40, 40);
            _btnSua.ForeColor = Color.White;
            _btnSua.Location = new Point(520, 53);
            _btnSua.Name = "_btnSua";
            _btnSua.Size = new Size(85, 32);
            _btnSua.TabIndex = 4;
            _btnSua.Text = "Sửa";
            _btnSua.UseVisualStyleBackColor = false;
            _btnSua.Click += btnSua_Click;
            // 
            // _btnXoa
            // 
            _btnXoa.BackColor = Color.FromArgb(198, 40, 40);
            _btnXoa.ForeColor = Color.White;
            _btnXoa.Location = new Point(610, 53);
            _btnXoa.Name = "_btnXoa";
            _btnXoa.Size = new Size(85, 32);
            _btnXoa.TabIndex = 5;
            _btnXoa.Text = "Xóa";
            _btnXoa.UseVisualStyleBackColor = false;
            _btnXoa.Click += btnXoa_Click;
            // 
            // _btnGan
            // 
            _btnGan.BackColor = Color.FromArgb(198, 40, 40);
            _btnGan.ForeColor = Color.White;
            _btnGan.Location = new Point(700, 53);
            _btnGan.Name = "_btnGan";
            _btnGan.Size = new Size(140, 32);
            _btnGan.TabIndex = 6;
            _btnGan.Text = "Gán cho sản phẩm";
            _btnGan.UseVisualStyleBackColor = false;
            _btnGan.Click += btnGan_Click;
            // 
            // QuanLyDanhMucForm
            // 
            ClientSize = new Size(1000, 650);
            Controls.Add(_dgv);
            Controls.Add(_top);
            Name = "QuanLyDanhMucForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "6. Quản lý Danh mục";
            ((System.ComponentModel.ISupportInitialize)_dgv).EndInit();
            _top.ResumeLayout(false);
            _top.PerformLayout();
            ResumeLayout(false);
        }
    }
}
