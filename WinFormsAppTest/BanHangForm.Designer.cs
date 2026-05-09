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
        private Guna2ComboBox cmbDiscount;
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlHeader = new Guna2Panel();
            lblTitle = new Guna2HtmlLabel();
            lblSub = new Guna2HtmlLabel();
            grpProducts = new Guna2GroupBox();
            txtSearch = new Guna2TextBox();
            numQuantity = new Guna2NumericUpDown();
            btnAddToCart = new Guna2Button();
            dgvProducts = new Guna2DataGridView();
            grpCart = new Guna2GroupBox();
            dgvCart = new Guna2DataGridView();
            btnRemoveItem = new Guna2Button();
            btnClearCart = new Guna2Button();
            grpCheckout = new Guna2GroupBox();
            cmbCustomer = new Guna2ComboBox();
            cmbDiscount = new Guna2ComboBox();
            btnApplyDiscount = new Guna2Button();
            lblSubTotal = new Guna2HtmlLabel();
            lblSubTotalValue = new Guna2HtmlLabel();
            lblDiscount = new Guna2HtmlLabel();
            lblDiscountValue = new Guna2HtmlLabel();
            lblFinalTotal = new Guna2HtmlLabel();
            lblFinalTotalValue = new Guna2HtmlLabel();
            btnCreateInvoice = new Guna2Button();
            pnlHeader.SuspendLayout();
            grpProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            grpCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            grpCheckout.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(198, 40, 40);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Controls.Add(lblSub);
            pnlHeader.CustomizableEdges = customizableEdges1;
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.ShadowDecoration.CustomizableEdges = customizableEdges2;
            pnlHeader.Size = new Size(1262, 96);
            pnlHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(255, 241, 118);
            lblTitle.Location = new Point(20, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(348, 47);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "POS - Trang Bán Hàng";
            // 
            // lblSub
            // 
            lblSub.BackColor = Color.Transparent;
            lblSub.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSub.ForeColor = Color.White;
            lblSub.Location = new Point(20, 53);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(310, 25);
            lblSub.TabIndex = 1;
            lblSub.Text = "WinMart+ | Nhanh - Mượt - Chính xác";
            // 
            // grpProducts
            // 
            grpProducts.BorderColor = Color.FromArgb(255, 167, 38);
            grpProducts.Controls.Add(txtSearch);
            grpProducts.Controls.Add(numQuantity);
            grpProducts.Controls.Add(btnAddToCart);
            grpProducts.Controls.Add(dgvProducts);
            grpProducts.CustomBorderColor = Color.FromArgb(255, 241, 118);
            grpProducts.CustomizableEdges = customizableEdges9;
            grpProducts.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpProducts.ForeColor = Color.FromArgb(198, 40, 40);
            grpProducts.Location = new Point(12, 102);
            grpProducts.Name = "grpProducts";
            grpProducts.ShadowDecoration.CustomizableEdges = customizableEdges10;
            grpProducts.Size = new Size(620, 650);
            grpProducts.TabIndex = 2;
            grpProducts.Text = "Danh sách sản phẩm";
            // 
            // txtSearch
            // 
            txtSearch.BorderRadius = 8;
            txtSearch.CustomizableEdges = customizableEdges3;
            txtSearch.DefaultText = "";
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.Location = new Point(15, 45);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm theo mã hoặc tên sản phẩm...";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtSearch.Size = new Size(430, 38);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // numQuantity
            // 
            numQuantity.BackColor = Color.Transparent;
            numQuantity.CustomizableEdges = customizableEdges5;
            numQuantity.Font = new Font("Segoe UI", 9F);
            numQuantity.Location = new Point(455, 45);
            numQuantity.Margin = new Padding(3, 4, 3, 4);
            numQuantity.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.ShadowDecoration.CustomizableEdges = customizableEdges6;
            numQuantity.Size = new Size(70, 38);
            numQuantity.TabIndex = 1;
            numQuantity.UpDownButtonFillColor = Color.Transparent;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddToCart
            // 
            btnAddToCart.BorderRadius = 8;
            btnAddToCart.CustomizableEdges = customizableEdges7;
            btnAddToCart.FillColor = Color.FromArgb(255, 167, 38);
            btnAddToCart.Font = new Font("Segoe UI", 9F);
            btnAddToCart.ForeColor = Color.Black;
            btnAddToCart.Location = new Point(531, 45);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnAddToCart.Size = new Size(75, 38);
            btnAddToCart.TabIndex = 2;
            btnAddToCart.Text = "Thêm";
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // dgvProducts
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProducts.ColumnHeadersHeight = 29;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProducts.GridColor = Color.FromArgb(231, 229, 255);
            dgvProducts.Location = new Point(15, 95);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(591, 535);
            dgvProducts.TabIndex = 3;
            dgvProducts.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvProducts.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvProducts.ThemeStyle.BackColor = Color.White;
            dgvProducts.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvProducts.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvProducts.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvProducts.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvProducts.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProducts.ThemeStyle.HeaderStyle.Height = 29;
            dgvProducts.ThemeStyle.ReadOnly = true;
            dgvProducts.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvProducts.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProducts.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvProducts.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvProducts.ThemeStyle.RowsStyle.Height = 29;
            dgvProducts.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvProducts.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // grpCart
            // 
            grpCart.BorderColor = Color.FromArgb(255, 167, 38);
            grpCart.Controls.Add(dgvCart);
            grpCart.Controls.Add(btnRemoveItem);
            grpCart.Controls.Add(btnClearCart);
            grpCart.CustomBorderColor = Color.FromArgb(255, 241, 118);
            grpCart.CustomizableEdges = customizableEdges15;
            grpCart.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpCart.ForeColor = Color.FromArgb(198, 40, 40);
            grpCart.Location = new Point(640, 102);
            grpCart.Name = "grpCart";
            grpCart.ShadowDecoration.CustomizableEdges = customizableEdges16;
            grpCart.Size = new Size(610, 420);
            grpCart.TabIndex = 1;
            grpCart.Text = "Giỏ hàng";
            // 
            // dgvCart
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvCart.ColumnHeadersHeight = 29;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvCart.DefaultCellStyle = dataGridViewCellStyle6;
            dgvCart.GridColor = Color.FromArgb(231, 229, 255);
            dgvCart.Location = new Point(15, 45);
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersVisible = false;
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(580, 315);
            dgvCart.TabIndex = 0;
            dgvCart.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvCart.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvCart.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvCart.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvCart.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvCart.ThemeStyle.BackColor = Color.White;
            dgvCart.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvCart.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvCart.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvCart.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvCart.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvCart.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvCart.ThemeStyle.HeaderStyle.Height = 29;
            dgvCart.ThemeStyle.ReadOnly = true;
            dgvCart.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvCart.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCart.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgvCart.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvCart.ThemeStyle.RowsStyle.Height = 29;
            dgvCart.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvCart.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.BorderRadius = 8;
            btnRemoveItem.CustomizableEdges = customizableEdges11;
            btnRemoveItem.FillColor = Color.FromArgb(211, 47, 47);
            btnRemoveItem.Font = new Font("Segoe UI", 9F);
            btnRemoveItem.ForeColor = Color.White;
            btnRemoveItem.Location = new Point(15, 370);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnRemoveItem.Size = new Size(140, 35);
            btnRemoveItem.TabIndex = 1;
            btnRemoveItem.Text = "Xóa dòng";
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnClearCart
            // 
            btnClearCart.BorderRadius = 8;
            btnClearCart.CustomizableEdges = customizableEdges13;
            btnClearCart.FillColor = Color.FromArgb(97, 97, 97);
            btnClearCart.Font = new Font("Segoe UI", 9F);
            btnClearCart.ForeColor = Color.White;
            btnClearCart.Location = new Point(165, 370);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.ShadowDecoration.CustomizableEdges = customizableEdges14;
            btnClearCart.Size = new Size(140, 35);
            btnClearCart.TabIndex = 2;
            btnClearCart.Text = "Xóa giỏ hàng";
            btnClearCart.Click += btnClearCart_Click;
            // 
            // grpCheckout
            // 
            grpCheckout.BorderColor = Color.FromArgb(255, 167, 38);
            grpCheckout.Controls.Add(cmbCustomer);
            grpCheckout.Controls.Add(cmbDiscount);
            grpCheckout.Controls.Add(btnApplyDiscount);
            grpCheckout.Controls.Add(lblSubTotal);
            grpCheckout.Controls.Add(lblSubTotalValue);
            grpCheckout.Controls.Add(lblDiscount);
            grpCheckout.Controls.Add(lblDiscountValue);
            grpCheckout.Controls.Add(lblFinalTotal);
            grpCheckout.Controls.Add(lblFinalTotalValue);
            grpCheckout.Controls.Add(btnCreateInvoice);
            grpCheckout.CustomBorderColor = Color.FromArgb(255, 241, 118);
            grpCheckout.CustomizableEdges = customizableEdges25;
            grpCheckout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpCheckout.ForeColor = Color.FromArgb(198, 40, 40);
            grpCheckout.Location = new Point(640, 530);
            grpCheckout.Name = "grpCheckout";
            grpCheckout.ShadowDecoration.CustomizableEdges = customizableEdges26;
            grpCheckout.Size = new Size(610, 222);
            grpCheckout.TabIndex = 0;
            grpCheckout.Text = "Thanh toán";
            // 
            // cmbCustomer
            // 
            cmbCustomer.BackColor = Color.Transparent;
            cmbCustomer.CustomizableEdges = customizableEdges17;
            cmbCustomer.DrawMode = DrawMode.OwnerDrawFixed;
            cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomer.FocusedColor = Color.Empty;
            cmbCustomer.Font = new Font("Segoe UI", 10F);
            cmbCustomer.ForeColor = Color.FromArgb(68, 88, 112);
            cmbCustomer.ItemHeight = 30;
            cmbCustomer.Location = new Point(20, 45);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.ShadowDecoration.CustomizableEdges = customizableEdges18;
            cmbCustomer.Size = new Size(280, 36);
            cmbCustomer.TabIndex = 0;
            // 
            // cmbDiscount
            // 
            cmbDiscount.BackColor = Color.Transparent;
            cmbDiscount.BorderRadius = 10;
            cmbDiscount.CustomizableEdges = customizableEdges19;
            cmbDiscount.DrawMode = DrawMode.OwnerDrawFixed;
            cmbDiscount.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbDiscount.FocusedColor = Color.FromArgb(255, 167, 38);
            cmbDiscount.FocusedState.BorderColor = Color.FromArgb(255, 167, 38);
            cmbDiscount.Font = new Font("Segoe UI", 10F);
            cmbDiscount.ForeColor = Color.FromArgb(68, 88, 112);
            cmbDiscount.ItemHeight = 30;
            cmbDiscount.Location = new Point(310, 45);
            cmbDiscount.Name = "cmbDiscount";
            cmbDiscount.ShadowDecoration.CustomizableEdges = customizableEdges20;
            cmbDiscount.Size = new Size(170, 36);
            cmbDiscount.TabIndex = 1;
            cmbDiscount.SelectedIndexChanged += cmbDiscount_SelectedIndexChanged;
            // 
            // btnApplyDiscount
            // 
            btnApplyDiscount.BorderRadius = 8;
            btnApplyDiscount.CustomizableEdges = customizableEdges21;
            btnApplyDiscount.FillColor = Color.FromArgb(255, 167, 38);
            btnApplyDiscount.Font = new Font("Segoe UI", 9F);
            btnApplyDiscount.ForeColor = Color.Black;
            btnApplyDiscount.Location = new Point(490, 45);
            btnApplyDiscount.Name = "btnApplyDiscount";
            btnApplyDiscount.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btnApplyDiscount.Size = new Size(100, 36);
            btnApplyDiscount.TabIndex = 2;
            btnApplyDiscount.Text = "Áp mã";
            btnApplyDiscount.Click += btnApplyDiscount_Click;
            // 
            // lblSubTotal
            // 
            lblSubTotal.BackColor = Color.Transparent;
            lblSubTotal.Location = new Point(20, 100);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(64, 22);
            lblSubTotal.TabIndex = 3;
            lblSubTotal.Text = "Tạm tính:";
            // 
            // lblSubTotalValue
            // 
            lblSubTotalValue.BackColor = Color.Transparent;
            lblSubTotalValue.Location = new Point(130, 100);
            lblSubTotalValue.Name = "lblSubTotalValue";
            lblSubTotalValue.Size = new Size(24, 22);
            lblSubTotalValue.TabIndex = 4;
            lblSubTotalValue.Text = "0 đ";
            // 
            // lblDiscount
            // 
            lblDiscount.BackColor = Color.Transparent;
            lblDiscount.Location = new Point(20, 130);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(66, 22);
            lblDiscount.TabIndex = 5;
            lblDiscount.Text = "Giảm giá:";
            // 
            // lblDiscountValue
            // 
            lblDiscountValue.BackColor = Color.Transparent;
            lblDiscountValue.Location = new Point(130, 130);
            lblDiscountValue.Name = "lblDiscountValue";
            lblDiscountValue.Size = new Size(24, 22);
            lblDiscountValue.TabIndex = 6;
            lblDiscountValue.Text = "0 đ";
            // 
            // lblFinalTotal
            // 
            lblFinalTotal.BackColor = Color.Transparent;
            lblFinalTotal.Location = new Point(20, 160);
            lblFinalTotal.Name = "lblFinalTotal";
            lblFinalTotal.Size = new Size(75, 22);
            lblFinalTotal.TabIndex = 7;
            lblFinalTotal.Text = "Thành tiền:";
            // 
            // lblFinalTotalValue
            // 
            lblFinalTotalValue.BackColor = Color.Transparent;
            lblFinalTotalValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFinalTotalValue.ForeColor = Color.FromArgb(191, 54, 12);
            lblFinalTotalValue.Location = new Point(130, 154);
            lblFinalTotalValue.Name = "lblFinalTotalValue";
            lblFinalTotalValue.Size = new Size(37, 33);
            lblFinalTotalValue.TabIndex = 8;
            lblFinalTotalValue.Text = "0 đ";
            // 
            // btnCreateInvoice
            // 
            btnCreateInvoice.BorderRadius = 10;
            btnCreateInvoice.CustomizableEdges = customizableEdges23;
            btnCreateInvoice.FillColor = Color.FromArgb(198, 40, 40);
            btnCreateInvoice.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCreateInvoice.ForeColor = Color.White;
            btnCreateInvoice.Location = new Point(400, 145);
            btnCreateInvoice.Name = "btnCreateInvoice";
            btnCreateInvoice.ShadowDecoration.CustomizableEdges = customizableEdges24;
            btnCreateInvoice.Size = new Size(190, 55);
            btnCreateInvoice.TabIndex = 9;
            btnCreateInvoice.Text = "TẠO HÓA ĐƠN";
            btnCreateInvoice.Click += btnCreateInvoice_Click;
            // 
            // BanHangForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1262, 764);
            Controls.Add(grpCheckout);
            Controls.Add(grpCart);
            Controls.Add(grpProducts);
            Controls.Add(pnlHeader);
            Name = "BanHangForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WinMart+ - POS";
            Load += BanHangForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            grpProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            grpCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            grpCheckout.ResumeLayout(false);
            grpCheckout.PerformLayout();
            ResumeLayout(false);
        }
    }
}