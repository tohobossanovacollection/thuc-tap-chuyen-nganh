using Guna.UI2.WinForms;

namespace WinFormsAppTest
{
    partial class SanPham
    {
        private System.ComponentModel.IContainer components = null;

        private Guna2Panel pnlHeader;
        private Guna2HtmlLabel lblTitle;

        private Guna2HtmlLabel lblMaSanPham;
        private Guna2TextBox txtMaSanPham;
        private Guna2HtmlLabel lblTenSanPham;
        private Guna2TextBox txtTenSanPham;
        private Guna2HtmlLabel lblDanhMuc;
        private Guna2TextBox txtDanhMuc;
        private Guna2HtmlLabel lblGiaNhap;
        private Guna2TextBox txtGiaNhap;
        private Guna2HtmlLabel lblGiaBan;
        private Guna2TextBox txtGiaBan;
        private Guna2HtmlLabel lblSoLuongTon;
        private Guna2TextBox txtSoLuongTon;
        private Guna2HtmlLabel lblMoTa;
        private Guna2TextBox txtMoTa;

        private Guna2Button btnLuu;
        private Guna2Button btnHuy;

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

            lblMaSanPham = new Guna2HtmlLabel();
            txtMaSanPham = new Guna2TextBox();
            lblTenSanPham = new Guna2HtmlLabel();
            txtTenSanPham = new Guna2TextBox();
            lblDanhMuc = new Guna2HtmlLabel();
            txtDanhMuc = new Guna2TextBox();
            lblGiaNhap = new Guna2HtmlLabel();
            txtGiaNhap = new Guna2TextBox();
            lblGiaBan = new Guna2HtmlLabel();
            txtGiaBan = new Guna2TextBox();
            lblSoLuongTon = new Guna2HtmlLabel();
            txtSoLuongTon = new Guna2TextBox();
            lblMoTa = new Guna2HtmlLabel();
            txtMoTa = new Guna2TextBox();

            btnLuu = new Guna2Button();
            btnHuy = new Guna2Button();

            SuspendLayout();

            // Header
            pnlHeader.BackColor = Color.FromArgb(198, 40, 40);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 72;
            pnlHeader.Controls.Add(lblTitle);

            lblTitle.BackColor = Color.Transparent;
            lblTitle.Text = "Item sản phẩm";
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(255, 241, 118);
            lblTitle.Location = new Point(18, 14);

            // Labels + TextBoxes
            lblMaSanPham.BackColor = Color.Transparent;
            lblMaSanPham.Text = "Mã sản phẩm";
            lblMaSanPham.Location = new Point(24, 90);
            txtMaSanPham.BorderRadius = 8;
            txtMaSanPham.Location = new Point(24, 112);
            txtMaSanPham.Size = new Size(220, 36);

            lblTenSanPham.BackColor = Color.Transparent;
            lblTenSanPham.Text = "Tên sản phẩm";
            lblTenSanPham.Location = new Point(260, 90);
            txtTenSanPham.BorderRadius = 8;
            txtTenSanPham.Location = new Point(260, 112);
            txtTenSanPham.Size = new Size(300, 36);

            lblDanhMuc.BackColor = Color.Transparent;
            lblDanhMuc.Text = "Danh mục";
            lblDanhMuc.Location = new Point(24, 162);
            txtDanhMuc.BorderRadius = 8;
            txtDanhMuc.Location = new Point(24, 184);
            txtDanhMuc.Size = new Size(220, 36);

            lblGiaNhap.BackColor = Color.Transparent;
            lblGiaNhap.Text = "Giá nhập";
            lblGiaNhap.Location = new Point(260, 162);
            txtGiaNhap.BorderRadius = 8;
            txtGiaNhap.Location = new Point(260, 184);
            txtGiaNhap.Size = new Size(140, 36);

            lblGiaBan.BackColor = Color.Transparent;
            lblGiaBan.Text = "Giá bán";
            lblGiaBan.Location = new Point(420, 162);
            txtGiaBan.BorderRadius = 8;
            txtGiaBan.Location = new Point(420, 184);
            txtGiaBan.Size = new Size(140, 36);

            lblSoLuongTon.BackColor = Color.Transparent;
            lblSoLuongTon.Text = "Số lượng tồn";
            lblSoLuongTon.Location = new Point(24, 234);
            txtSoLuongTon.BorderRadius = 8;
            txtSoLuongTon.Location = new Point(24, 256);
            txtSoLuongTon.Size = new Size(220, 36);

            lblMoTa.BackColor = Color.Transparent;
            lblMoTa.Text = "Mô tả";
            lblMoTa.Location = new Point(24, 306);
            txtMoTa.BorderRadius = 8;
            txtMoTa.Multiline = true;
            txtMoTa.Location = new Point(24, 328);
            txtMoTa.Size = new Size(536, 96);

            // Buttons
            btnLuu.Text = "Lưu";
            btnLuu.BorderRadius = 8;
            btnLuu.FillColor = Color.FromArgb(198, 40, 40);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(380, 440);
            btnLuu.Size = new Size(85, 40);
            btnLuu.Click += btnLuu_Click;

            btnHuy.Text = "Hủy";
            btnHuy.BorderRadius = 8;
            btnHuy.FillColor = Color.FromArgb(97, 97, 97);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(475, 440);
            btnHuy.Size = new Size(85, 40);
            btnHuy.Click += btnHuy_Click;

            // Form
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(590, 500);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(lblMoTa);
            Controls.Add(txtMoTa);
            Controls.Add(lblSoLuongTon);
            Controls.Add(txtSoLuongTon);
            Controls.Add(lblGiaBan);
            Controls.Add(txtGiaBan);
            Controls.Add(lblGiaNhap);
            Controls.Add(txtGiaNhap);
            Controls.Add(lblDanhMuc);
            Controls.Add(txtDanhMuc);
            Controls.Add(lblTenSanPham);
            Controls.Add(txtTenSanPham);
            Controls.Add(lblMaSanPham);
            Controls.Add(txtMaSanPham);
            Controls.Add(pnlHeader);

            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinMart+ - Item sản phẩm";

            ResumeLayout(false);
            PerformLayout();
        }
    }
}