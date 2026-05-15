using Guna.UI2.WinForms;

namespace WinFormsAppTest
{
    partial class QuanLySanPhamForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlTop;
        private Label lblTitle;
        private DataGridView dgvSanPham;
        private Guna2Button btnThem;
        private Guna2Button btnSua;
        private Guna2Button btnXoa;
        private Guna2Button btnLamMoi;
        private Guna2Button btnDanhMuc;

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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pnlTop = new Panel();
            lblTitle = new Label();
            btnDanhMuc = new Guna2Button();
            btnThem = new Guna2Button();
            btnSua = new Guna2Button();
            btnXoa = new Guna2Button();
            btnLamMoi = new Guna2Button();
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
            btnDanhMuc.BorderColor = Color.White;
            btnDanhMuc.BorderRadius = 8;
            btnDanhMuc.BorderThickness = 1;
            btnDanhMuc.FillColor = Color.FromArgb(255, 167, 38);
            btnDanhMuc.Font = new Font("Segoe UI", 9F);
            btnDanhMuc.ForeColor = Color.Black;
            btnDanhMuc.Location = new Point(497, 22);
            btnDanhMuc.Name = "btnDanhMuc";
            btnDanhMuc.Size = new Size(173, 40);
            btnDanhMuc.TabIndex = 1;
            btnDanhMuc.Text = "Quản lý danh mục";
            btnDanhMuc.Click += btnDanhMuc_Click;
            // 
            // btnThem
            // 
            btnThem.BorderColor = Color.White;
            btnThem.BorderRadius = 8;
            btnThem.BorderThickness = 1;
            btnThem.FillColor = Color.FromArgb(255, 167, 38);
            btnThem.Font = new Font("Segoe UI", 9F);
            btnThem.ForeColor = Color.Black;
            btnThem.Location = new Point(680, 22);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 40);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BorderColor = Color.White;
            btnSua.BorderRadius = 8;
            btnSua.BorderThickness = 1;
            btnSua.FillColor = Color.FromArgb(255, 167, 38);
            btnSua.Font = new Font("Segoe UI", 9F);
            btnSua.ForeColor = Color.Black;
            btnSua.Location = new Point(800, 22);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 40);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            btnSua.Image = Icons.IconGenerator.GenerateEditIcon();
            // 
            // btnXoa
            // 
            btnXoa.BorderColor = Color.White;
            btnXoa.BorderRadius = 8;
            btnXoa.BorderThickness = 1;
            btnXoa.FillColor = Color.FromArgb(211, 47, 47);
            btnXoa.Font = new Font("Segoe UI", 9F);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(920, 22);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 40);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BorderColor = Color.White;
            btnLamMoi.BorderRadius = 8;
            btnLamMoi.BorderThickness = 1;
            btnLamMoi.FillColor = Color.FromArgb(97, 97, 97);
            btnLamMoi.Font = new Font("Segoe UI", 9F);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(1040, 22);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(120, 40);
            btnLamMoi.TabIndex = 5;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dgvSanPham
            // 
            dgvSanPham.AllowUserToAddRows = false;
            dgvSanPham.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.BackgroundColor = Color.White;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvSanPham.ColumnHeadersHeight = 29;
            dgvSanPham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvSanPham.DefaultCellStyle = dataGridViewCellStyle3;
            dgvSanPham.Dock = DockStyle.Fill;
            dgvSanPham.EnableHeadersVisualStyles = false;
            dgvSanPham.GridColor = Color.FromArgb(231, 229, 255);
            dgvSanPham.Location = new Point(0, 86);
            dgvSanPham.Name = "dgvSanPham";
            dgvSanPham.ReadOnly = true;
            dgvSanPham.RowHeadersVisible = false;
            dgvSanPham.RowHeadersWidth = 51;
            dgvSanPham.RowTemplate.Height = 29;
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
