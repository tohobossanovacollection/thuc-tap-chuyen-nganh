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
            components = new System.ComponentModel.Container();
            pnlTop = new Panel();
            lblTitle = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnDanhMuc = new Button();
            dgvSanPham = new DataGridView();

            pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).BeginInit();
            SuspendLayout();

            Text = "Quản lý sản phẩm";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(1200, 700);
            BackColor = Color.White;
            Load += QuanLySanPhamForm_Load;

            pnlTop.Dock = DockStyle.Top;
            pnlTop.Height = 86;
            pnlTop.BackColor = Color.FromArgb(198, 40, 40);

            lblTitle.Text = "Quản lý Sản phẩm";
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(255, 241, 118);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(16, 20);

            btnThem.Text = "Thêm";
            btnThem.SetBounds(680, 22, 110, 40);
            btnThem.BackColor = Color.FromArgb(255, 167, 38);
            btnThem.ForeColor = Color.Black;
            btnThem.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnThem.Click += btnThem_Click;

            btnSua.Text = "Sửa";
            btnSua.SetBounds(800, 22, 110, 40);
            btnSua.BackColor = Color.FromArgb(255, 167, 38);
            btnSua.ForeColor = Color.Black;
            btnSua.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSua.Click += btnSua_Click;

            btnXoa.Text = "Xóa";
            btnXoa.SetBounds(920, 22, 110, 40);
            btnXoa.BackColor = Color.FromArgb(211, 47, 47);
            btnXoa.ForeColor = Color.White;
            btnXoa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnXoa.Click += btnXoa_Click;

            btnLamMoi.Text = "Làm mới";
            btnLamMoi.SetBounds(1040, 22, 120, 40);
            btnLamMoi.BackColor = Color.FromArgb(97, 97, 97);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLamMoi.Click += btnLamMoi_Click;

            btnDanhMuc.Text = "Quản lý danh mục";
            btnDanhMuc.SetBounds(540, 22, 130, 40);
            btnDanhMuc.BackColor = Color.FromArgb(255, 167, 38);
            btnDanhMuc.ForeColor = Color.Black;
            btnDanhMuc.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDanhMuc.Click += btnDanhMuc_Click;

            pnlTop.Controls.Add(lblTitle);
            pnlTop.Controls.Add(btnDanhMuc);
            pnlTop.Controls.Add(btnThem);
            pnlTop.Controls.Add(btnSua);
            pnlTop.Controls.Add(btnXoa);
            pnlTop.Controls.Add(btnLamMoi);

            dgvSanPham.Dock = DockStyle.Fill;
            dgvSanPham.ReadOnly = true;
            dgvSanPham.RowHeadersVisible = false;
            dgvSanPham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AllowUserToDeleteRows = false;
            dgvSanPham.BackgroundColor = Color.White;

            Controls.Add(dgvSanPham);
            Controls.Add(pnlTop);

            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSanPham).EndInit();
            ResumeLayout(false);
        }
    }
}
