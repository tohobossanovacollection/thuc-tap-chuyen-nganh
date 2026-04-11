namespace WinFormsAppTest
{
    partial class QuanLyNhaCungCapForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView _dgv;
        private Panel _top;
        private Label _title;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            _dgv = new DataGridView();
            _top = new Panel();
            _title = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)_dgv).BeginInit();
            _top.SuspendLayout();
            SuspendLayout();
            // 
            // _dgv
            // 
            _dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgv.ColumnHeadersHeight = 29;
            _dgv.Dock = DockStyle.Fill;
            _dgv.Location = new Point(0, 80);
            _dgv.Name = "_dgv";
            _dgv.ReadOnly = true;
            _dgv.RowHeadersVisible = false;
            _dgv.RowHeadersWidth = 51;
            _dgv.Size = new Size(1000, 570);
            _dgv.TabIndex = 0;
            // 
            // _top
            // 
            _top.BackColor = Color.FromArgb(255, 241, 118);
            _top.Controls.Add(btnXoa);
            _top.Controls.Add(btnSua);
            _top.Controls.Add(btnThem);
            _top.Controls.Add(_title);
            _top.Dock = DockStyle.Top;
            _top.Location = new Point(0, 0);
            _top.Name = "_top";
            _top.Size = new Size(1000, 80);
            _top.TabIndex = 1;
            // 
            // _title
            // 
            _title.AutoSize = true;
            _title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _title.ForeColor = Color.FromArgb(198, 40, 40);
            _title.Location = new Point(12, 10);
            _title.Name = "_title";
            _title.Size = new Size(294, 37);
            _title.TabIndex = 0;
            _title.Text = "Quản lý Nhà cung cấp";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(198, 40, 40);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(12, 47);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(83, 30);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(198, 40, 40);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(101, 47);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(83, 30);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(198, 40, 40);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(190, 47);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(83, 30);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // QuanLyNhaCungCapForm
            // 
            ClientSize = new Size(1000, 650);
            Controls.Add(_dgv);
            Controls.Add(_top);
            Name = "QuanLyNhaCungCapForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "8. Quản lý Nhà cung cấp";
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
