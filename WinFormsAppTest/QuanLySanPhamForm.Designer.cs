namespace WinFormsAppTest
{
    partial class QuanLySanPhamForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlTop;
        private Label lblTitle;
        private DataGridView dgvSanPham;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnDanhMuc;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnlTop = new Panel();
            lblTitle = new Label();
            btnDanhMuc = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            dgvSanPham = new DataGridView();
            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(198, 40, 40);
            pnlTop.Controls.Add(lblTitle);
            pnlTop.Controls.Add(btnDanhMuc);
            pnlTop.Controls.Add(btnThem);
            pnlTop.Controls.Add(btnSua);
            pnlTop.Controls.Add(btnXoa);
            pnlTop.Controls.Add(btnLamMoi);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(0, 0);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1200, 86);
            pnlTop.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(255, 241, 118);
            lblTitle.Location = new Point(16, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(273, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản lý Sản phẩm";
            // 
            // btnDanhMuc
            // 
            btnDanhMuc.BackColor = Color.FromArgb(255, 167, 38);
            btnDanhMuc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDanhMuc.ForeColor = Color.Black;
            btnDanhMuc.Location = new Point(497, 22);
            btnDanhMuc.Name = "btnDanhMuc";
            btnDanhMuc.Size = new Size(173, 40);
            btnDanhMuc.TabIndex = 1;
            btnDanhMuc.Text = "Quản lý danh mục";
            btnDanhMuc.UseVisualStyleBackColor = false;
            btnDanhMuc.Click += btnDanhMuc_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(255, 167, 38);
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(680, 22);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 40);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 167, 38);
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(800, 22);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 40);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            btnSua.Image = Icons.IconGenerator.GenerateEditIcon();
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(211, 47, 47);
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(920, 22);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 40);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(97, 97, 97);
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(1040, 22);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(120, 40);
            btnLamMoi.TabIndex = 5;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AllowUserToDeleteRows = false;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.BackgroundColor = Color.White;
            dgvSanPham.ColumnHeadersHeight = 29;
            dgvSanPham.Dock = DockStyle.Fill;
            dgvSanPham.Location = new Point(0, 86);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.ReadOnly = true;
            dgvSanPham.RowHeadersVisible = false;
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.Size = new Size(1200, 614);
            dgvSanPham.TabIndex = 0;
            // 
            // QuanLySanPhamForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(1200, 700);
            Controls.Add(dgvSanPham);
            Controls.Add(pnlTop);
            Name = "QuanLySanPhamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sản phẩm";
            Load += QuanLySanPhamForm_Load;
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);
        }
    }
}
