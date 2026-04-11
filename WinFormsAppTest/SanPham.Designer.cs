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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(198, 40, 40);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.CustomizableEdges = customizableEdges1;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlHeader.Size = new Size(590, 72);
            pnlHeader.TabIndex = 16;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(255, 241, 118);
            lblTitle.Location = new Point(18, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(225, 43);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Thêm sản phẩm";
            // 
            // lblMaSanPham
            // 
            lblMaSanPham.BackColor = Color.Transparent;
            lblMaSanPham.Location = new Point(24, 90);
            lblMaSanPham.Name = "lblMaSanPham";
            lblMaSanPham.Size = new Size(92, 22);
            lblMaSanPham.TabIndex = 14;
            lblMaSanPham.Text = "Mã sản phẩm";
            // 
            // txtMaSanPham
            // 
            txtMaSanPham.BorderRadius = 8;
            txtMaSanPham.CustomizableEdges = customizableEdges3;
            txtMaSanPham.DefaultText = "";
            txtMaSanPham.Font = new Font("Segoe UI", 9F);
            txtMaSanPham.Location = new Point(24, 112);
            txtMaSanPham.Margin = new Padding(3, 4, 3, 4);
            txtMaSanPham.Name = "txtMaSanPham";
            txtMaSanPham.PlaceholderText = "";
            txtMaSanPham.SelectedText = "";
            txtMaSanPham.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtMaSanPham.Size = new Size(220, 36);
            txtMaSanPham.TabIndex = 15;
            // 
            // lblTenSanPham
            // 
            lblTenSanPham.BackColor = Color.Transparent;
            lblTenSanPham.Location = new Point(260, 90);
            lblTenSanPham.Name = "lblTenSanPham";
            lblTenSanPham.Size = new Size(95, 22);
            lblTenSanPham.TabIndex = 12;
            lblTenSanPham.Text = "Tên sản phẩm";
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.BorderRadius = 8;
            txtTenSanPham.CustomizableEdges = customizableEdges5;
            txtTenSanPham.DefaultText = "";
            txtTenSanPham.Font = new Font("Segoe UI", 9F);
            txtTenSanPham.Location = new Point(260, 112);
            txtTenSanPham.Margin = new Padding(3, 4, 3, 4);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.PlaceholderText = "";
            txtTenSanPham.SelectedText = "";
            txtTenSanPham.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtTenSanPham.Size = new Size(300, 36);
            txtTenSanPham.TabIndex = 13;
            // 
            // lblDanhMuc
            // 
            lblDanhMuc.BackColor = Color.Transparent;
            lblDanhMuc.Location = new Point(24, 162);
            lblDanhMuc.Name = "lblDanhMuc";
            lblDanhMuc.Size = new Size(70, 22);
            lblDanhMuc.TabIndex = 10;
            lblDanhMuc.Text = "Danh mục";
            // 
            // txtDanhMuc
            // 
            txtDanhMuc.BorderRadius = 8;
            txtDanhMuc.CustomizableEdges = customizableEdges7;
            txtDanhMuc.DefaultText = "";
            txtDanhMuc.Font = new Font("Segoe UI", 9F);
            txtDanhMuc.Location = new Point(24, 184);
            txtDanhMuc.Margin = new Padding(3, 4, 3, 4);
            txtDanhMuc.Name = "txtDanhMuc";
            txtDanhMuc.PlaceholderText = "";
            txtDanhMuc.SelectedText = "";
            txtDanhMuc.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtDanhMuc.Size = new Size(220, 36);
            txtDanhMuc.TabIndex = 11;
            // 
            // lblGiaNhap
            // 
            lblGiaNhap.BackColor = Color.Transparent;
            lblGiaNhap.Location = new Point(260, 162);
            lblGiaNhap.Name = "lblGiaNhap";
            lblGiaNhap.Size = new Size(62, 22);
            lblGiaNhap.TabIndex = 8;
            lblGiaNhap.Text = "Giá nhập";
            // 
            // txtGiaNhap
            // 
            txtGiaNhap.BorderRadius = 8;
            txtGiaNhap.CustomizableEdges = customizableEdges9;
            txtGiaNhap.DefaultText = "";
            txtGiaNhap.Font = new Font("Segoe UI", 9F);
            txtGiaNhap.Location = new Point(260, 184);
            txtGiaNhap.Margin = new Padding(3, 4, 3, 4);
            txtGiaNhap.Name = "txtGiaNhap";
            txtGiaNhap.PlaceholderText = "";
            txtGiaNhap.SelectedText = "";
            txtGiaNhap.ShadowDecoration.CustomizableEdges = customizableEdges10;
            txtGiaNhap.Size = new Size(140, 36);
            txtGiaNhap.TabIndex = 9;
            // 
            // lblGiaBan
            // 
            lblGiaBan.BackColor = Color.Transparent;
            lblGiaBan.Location = new Point(420, 162);
            lblGiaBan.Name = "lblGiaBan";
            lblGiaBan.Size = new Size(54, 22);
            lblGiaBan.TabIndex = 6;
            lblGiaBan.Text = "Giá bán";
            // 
            // txtGiaBan
            // 
            txtGiaBan.BorderRadius = 8;
            txtGiaBan.CustomizableEdges = customizableEdges11;
            txtGiaBan.DefaultText = "";
            txtGiaBan.Font = new Font("Segoe UI", 9F);
            txtGiaBan.Location = new Point(420, 184);
            txtGiaBan.Margin = new Padding(3, 4, 3, 4);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.PlaceholderText = "";
            txtGiaBan.SelectedText = "";
            txtGiaBan.ShadowDecoration.CustomizableEdges = customizableEdges12;
            txtGiaBan.Size = new Size(140, 36);
            txtGiaBan.TabIndex = 7;
            // 
            // lblSoLuongTon
            // 
            lblSoLuongTon.BackColor = Color.Transparent;
            lblSoLuongTon.Location = new Point(24, 234);
            lblSoLuongTon.Name = "lblSoLuongTon";
            lblSoLuongTon.Size = new Size(89, 22);
            lblSoLuongTon.TabIndex = 4;
            lblSoLuongTon.Text = "Số lượng tồn";
            // 
            // txtSoLuongTon
            // 
            txtSoLuongTon.BorderRadius = 8;
            txtSoLuongTon.CustomizableEdges = customizableEdges13;
            txtSoLuongTon.DefaultText = "";
            txtSoLuongTon.Font = new Font("Segoe UI", 9F);
            txtSoLuongTon.Location = new Point(24, 256);
            txtSoLuongTon.Margin = new Padding(3, 4, 3, 4);
            txtSoLuongTon.Name = "txtSoLuongTon";
            txtSoLuongTon.PlaceholderText = "";
            txtSoLuongTon.SelectedText = "";
            txtSoLuongTon.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtSoLuongTon.Size = new Size(220, 36);
            txtSoLuongTon.TabIndex = 5;
            // 
            // lblMoTa
            // 
            lblMoTa.BackColor = Color.Transparent;
            lblMoTa.Location = new Point(24, 306);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(42, 22);
            lblMoTa.TabIndex = 2;
            lblMoTa.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            txtMoTa.BorderRadius = 8;
            txtMoTa.CustomizableEdges = customizableEdges15;
            txtMoTa.DefaultText = "";
            txtMoTa.Font = new Font("Segoe UI", 9F);
            txtMoTa.Location = new Point(24, 328);
            txtMoTa.Margin = new Padding(3, 4, 3, 4);
            txtMoTa.Multiline = true;
            txtMoTa.Name = "txtMoTa";
            txtMoTa.PlaceholderText = "";
            txtMoTa.SelectedText = "";
            txtMoTa.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txtMoTa.Size = new Size(536, 96);
            txtMoTa.TabIndex = 3;
            // 
            // btnLuu
            // 
            btnLuu.BorderRadius = 8;
            btnLuu.CustomizableEdges = customizableEdges17;
            btnLuu.FillColor = Color.FromArgb(198, 40, 40);
            btnLuu.Font = new Font("Segoe UI", 9F);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(380, 440);
            btnLuu.Name = "btnLuu";
            btnLuu.ShadowDecoration.CustomizableEdges = customizableEdges18;
            btnLuu.Size = new Size(85, 40);
            btnLuu.TabIndex = 1;
            btnLuu.Text = "Lưu";
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuy
            // 
            btnHuy.BorderRadius = 8;
            btnHuy.CustomizableEdges = customizableEdges19;
            btnHuy.FillColor = Color.FromArgb(97, 97, 97);
            btnHuy.Font = new Font("Segoe UI", 9F);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(475, 440);
            btnHuy.Name = "btnHuy";
            btnHuy.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnHuy.Size = new Size(85, 40);
            btnHuy.TabIndex = 0;
            btnHuy.Text = "Hủy";
            btnHuy.Click += btnHuy_Click;
            // 
            // SanPham
            // 
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
            Name = "SanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm sản phẩm";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}