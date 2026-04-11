using Guna.UI2.WinForms;

namespace WinFormsAppTest
{
    partial class BanHangForm
    {
        private System.ComponentModel.IContainer components = null;
        private Guna2Panel pnlHeader;
        private Guna2HtmlLabel lblTitle;
        private Guna2HtmlLabel lblSub;
        private Guna2GroupBox grpProducts;
        private Guna2TextBox txtSearch;
        private Guna2DataGridView dgvProducts;
        private Guna2NumericUpDown numQuantity;
        private Guna2Button btnAddToCart;
        private Guna2GroupBox grpCart;
        private Guna2DataGridView dgvCart;
        private Guna2Button btnRemoveItem;
        private Guna2Button btnClearCart;
        private Guna2GroupBox grpCheckout;
        private Guna2ComboBox cmbCustomer;
        private Guna2TextBox txtDiscountCode;
        private Guna2Button btnApplyDiscount;
        private Guna2HtmlLabel lblSubTotal;
        private Guna2HtmlLabel lblDiscount;
        private Guna2HtmlLabel lblFinalTotal;
        private Guna2HtmlLabel lblSubTotalValue;
        private Guna2HtmlLabel lblDiscountValue;
        private Guna2HtmlLabel lblFinalTotalValue;
        private Guna2Button btnCreateInvoice;

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
            lblSub = new Guna2HtmlLabel();

            grpProducts = new Guna2GroupBox();
            txtSearch = new Guna2TextBox();
            dgvProducts = new Guna2DataGridView();
            numQuantity = new Guna2NumericUpDown();
            btnAddToCart = new Guna2Button();

            grpCart = new Guna2GroupBox();
            dgvCart = new Guna2DataGridView();
            btnRemoveItem = new Guna2Button();
            btnClearCart = new Guna2Button();

            grpCheckout = new Guna2GroupBox();
            cmbCustomer = new Guna2ComboBox();
            txtDiscountCode = new Guna2TextBox();
            btnApplyDiscount = new Guna2Button();
            lblSubTotal = new Guna2HtmlLabel();
            lblDiscount = new Guna2HtmlLabel();
            lblFinalTotal = new Guna2HtmlLabel();
            lblSubTotalValue = new Guna2HtmlLabel();
            lblDiscountValue = new Guna2HtmlLabel();
            lblFinalTotalValue = new Guna2HtmlLabel();
            btnCreateInvoice = new Guna2Button();

            SuspendLayout();

            // Header
            pnlHeader.BackColor = Color.FromArgb(198, 40, 40);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 90;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSub);

            lblTitle.BackColor = Color.Transparent;
            lblTitle.Text = "POS - Trang Bán Hàng";
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(255, 241, 118);
            lblTitle.Location = new Point(20, 12);

            lblSub.BackColor = Color.Transparent;
            lblSub.Text = "WinMart+ | Nhanh - Mượt - Chính xác";
            lblSub.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSub.ForeColor = Color.White;
            lblSub.Location = new Point(22, 56);

            // Products
            grpProducts.Text = "Danh sách sản phẩm";
            grpProducts.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpProducts.ForeColor = Color.FromArgb(198, 40, 40);
            grpProducts.CustomBorderColor = Color.FromArgb(255, 241, 118);
            grpProducts.BorderColor = Color.FromArgb(255, 167, 38);
            grpProducts.Location = new Point(12, 102);
            grpProducts.Size = new Size(620, 650);

            txtSearch.PlaceholderText = "Tìm theo mã hoặc tên sản phẩm...";
            txtSearch.BorderRadius = 8;
            txtSearch.Location = new Point(15, 45);
            txtSearch.Size = new Size(430, 38);
            txtSearch.TextChanged += txtSearch_TextChanged;

            numQuantity.Minimum = 1;
            numQuantity.Maximum = 999;
            numQuantity.Value = 1;
            numQuantity.Location = new Point(455, 45);
            numQuantity.Size = new Size(70, 38);

            btnAddToCart.Text = "Thêm";
            btnAddToCart.FillColor = Color.FromArgb(255, 167, 38);
            btnAddToCart.ForeColor = Color.Black;
            btnAddToCart.BorderRadius = 8;
            btnAddToCart.Location = new Point(531, 45);
            btnAddToCart.Size = new Size(75, 38);
            btnAddToCart.Click += btnAddToCart_Click;

            dgvProducts.Location = new Point(15, 95);
            dgvProducts.Size = new Size(591, 535);
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            grpProducts.Controls.Add(txtSearch);
            grpProducts.Controls.Add(numQuantity);
            grpProducts.Controls.Add(btnAddToCart);
            grpProducts.Controls.Add(dgvProducts);

            // Cart
            grpCart.Text = "Giỏ hàng";
            grpCart.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpCart.ForeColor = Color.FromArgb(198, 40, 40);
            grpCart.CustomBorderColor = Color.FromArgb(255, 241, 118);
            grpCart.BorderColor = Color.FromArgb(255, 167, 38);
            grpCart.Location = new Point(640, 102);
            grpCart.Size = new Size(610, 420);

            dgvCart.Location = new Point(15, 45);
            dgvCart.Size = new Size(580, 315);
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersVisible = false;
            dgvCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            btnRemoveItem.Text = "Xóa dòng";
            btnRemoveItem.FillColor = Color.FromArgb(211, 47, 47);
            btnRemoveItem.ForeColor = Color.White;
            btnRemoveItem.BorderRadius = 8;
            btnRemoveItem.Location = new Point(15, 370);
            btnRemoveItem.Size = new Size(140, 35);
            btnRemoveItem.Click += btnRemoveItem_Click;

            btnClearCart.Text = "Xóa giỏ hàng";
            btnClearCart.FillColor = Color.FromArgb(97, 97, 97);
            btnClearCart.ForeColor = Color.White;
            btnClearCart.BorderRadius = 8;
            btnClearCart.Location = new Point(165, 370);
            btnClearCart.Size = new Size(140, 35);
            btnClearCart.Click += btnClearCart_Click;

            grpCart.Controls.Add(dgvCart);
            grpCart.Controls.Add(btnRemoveItem);
            grpCart.Controls.Add(btnClearCart);

            // Checkout
            grpCheckout.Text = "Thanh toán";
            grpCheckout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpCheckout.ForeColor = Color.FromArgb(198, 40, 40);
            grpCheckout.CustomBorderColor = Color.FromArgb(255, 241, 118);
            grpCheckout.BorderColor = Color.FromArgb(255, 167, 38);
            grpCheckout.Location = new Point(640, 530);
            grpCheckout.Size = new Size(610, 222);

            cmbCustomer.Location = new Point(20, 45);
            cmbCustomer.Size = new Size(280, 36);

            txtDiscountCode.PlaceholderText = "Mã giảm giá...";
            txtDiscountCode.Location = new Point(310, 45);
            txtDiscountCode.Size = new Size(170, 36);

            btnApplyDiscount.Text = "Áp mã";
            btnApplyDiscount.FillColor = Color.FromArgb(255, 167, 38);
            btnApplyDiscount.ForeColor = Color.Black;
            btnApplyDiscount.BorderRadius = 8;
            btnApplyDiscount.Location = new Point(490, 45);
            btnApplyDiscount.Size = new Size(100, 36);
            btnApplyDiscount.Click += btnApplyDiscount_Click;

            lblSubTotal.Text = "Tạm tính:";
            lblSubTotal.Location = new Point(20, 100);
            lblSubTotalValue.Text = "0 đ";
            lblSubTotalValue.Location = new Point(130, 100);

            lblDiscount.Text = "Giảm giá:";
            lblDiscount.Location = new Point(20, 130);
            lblDiscountValue.Text = "0 đ";
            lblDiscountValue.Location = new Point(130, 130);

            lblFinalTotal.Text = "Thành tiền:";
            lblFinalTotal.Location = new Point(20, 160);
            lblFinalTotalValue.Text = "0 đ";
            lblFinalTotalValue.ForeColor = Color.FromArgb(191, 54, 12);
            lblFinalTotalValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFinalTotalValue.Location = new Point(130, 154);

            btnCreateInvoice.Text = "TẠO HÓA ĐƠN";
            btnCreateInvoice.FillColor = Color.FromArgb(198, 40, 40);
            btnCreateInvoice.ForeColor = Color.White;
            btnCreateInvoice.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCreateInvoice.BorderRadius = 10;
            btnCreateInvoice.Location = new Point(400, 145);
            btnCreateInvoice.Size = new Size(190, 55);
            btnCreateInvoice.Click += btnCreateInvoice_Click;

            grpCheckout.Controls.Add(cmbCustomer);
            grpCheckout.Controls.Add(txtDiscountCode);
            grpCheckout.Controls.Add(btnApplyDiscount);
            grpCheckout.Controls.Add(lblSubTotal);
            grpCheckout.Controls.Add(lblSubTotalValue);
            grpCheckout.Controls.Add(lblDiscount);
            grpCheckout.Controls.Add(lblDiscountValue);
            grpCheckout.Controls.Add(lblFinalTotal);
            grpCheckout.Controls.Add(lblFinalTotalValue);
            grpCheckout.Controls.Add(btnCreateInvoice);

            // Form
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 764);
            BackColor = Color.White;
            Controls.Add(grpCheckout);
            Controls.Add(grpCart);
            Controls.Add(grpProducts);
            Controls.Add(pnlHeader);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinMart+ - POS";
            Load += BanHangForm_Load;

            ResumeLayout(false);
        }
    }
}