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

        private Guna2TextBox _txtBarcode;
        private Guna2Button _btnScanBarcode;
        private Guna2Button _btnHoldBill;
        private Guna2Button _btnResumeBill;
        private System.Windows.Forms.TabControl _tabHeldBills;
        private Guna2TextBox _txtCustomerPhone;
        private Guna2Button _btnFindCustomer;
        private Guna2Button _btnQuickCustomer;
        private Guna2HtmlLabel lblCash;
        private Guna2TextBox _txtCashReceived;
        private Guna2HtmlLabel lblChange;
        private Guna2HtmlLabel _lblChangeValue;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges41 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges42 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges35 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges36 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges37 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges38 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges39 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges40 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnlHeader = new Guna2Panel();
            lblTitle = new Guna2HtmlLabel();
            lblSub = new Guna2HtmlLabel();
            grpProducts = new Guna2GroupBox();
            _txtBarcode = new Guna2TextBox();
            _btnScanBarcode = new Guna2Button();
            txtSearch = new Guna2TextBox();
            numQuantity = new Guna2NumericUpDown();
            btnAddToCart = new Guna2Button();
            dgvProducts = new Guna2DataGridView();
            grpCart = new Guna2GroupBox();
            _btnHoldBill = new Guna2Button();
            _btnResumeBill = new Guna2Button();
            _tabHeldBills = new TabControl();
            dgvCart = new Guna2DataGridView();
            btnRemoveItem = new Guna2Button();
            btnClearCart = new Guna2Button();
            grpCheckout = new Guna2GroupBox();
            btnSaveInvoice = new Guna2Button();
            _txtCustomerPhone = new Guna2TextBox();
            _btnFindCustomer = new Guna2Button();
            _btnQuickCustomer = new Guna2Button();
            lblCash = new Guna2HtmlLabel();
            _txtCashReceived = new Guna2TextBox();
            lblChange = new Guna2HtmlLabel();
            _lblChangeValue = new Guna2HtmlLabel();
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
            pnlHeader.Size = new Size(1405, 96);
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
            grpProducts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpProducts.BorderColor = Color.FromArgb(255, 167, 38);
            grpProducts.Controls.Add(_txtBarcode);
            grpProducts.Controls.Add(_btnScanBarcode);
            grpProducts.Controls.Add(txtSearch);
            grpProducts.Controls.Add(numQuantity);
            grpProducts.Controls.Add(btnAddToCart);
            grpProducts.Controls.Add(dgvProducts);
            grpProducts.CustomBorderColor = Color.FromArgb(255, 241, 118);
            grpProducts.CustomizableEdges = customizableEdges13;
            grpProducts.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpProducts.ForeColor = Color.FromArgb(198, 40, 40);
            grpProducts.Location = new Point(12, 102);
            grpProducts.Name = "grpProducts";
            grpProducts.ShadowDecoration.CustomizableEdges = customizableEdges14;
            grpProducts.Size = new Size(620, 650);
            grpProducts.TabIndex = 2;
            grpProducts.Text = "Danh sách sản phẩm";
            // 
            // _txtBarcode
            // 
            _txtBarcode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _txtBarcode.BorderRadius = 8;
            _txtBarcode.CustomizableEdges = customizableEdges3;
            _txtBarcode.DefaultText = "";
            _txtBarcode.Font = new Font("Segoe UI", 9F);
            _txtBarcode.Location = new Point(15, 86);
            _txtBarcode.Margin = new Padding(3, 4, 3, 4);
            _txtBarcode.Name = "_txtBarcode";
            _txtBarcode.PlaceholderText = "Quét / nhập mã sản phẩm...";
            _txtBarcode.SelectedText = "";
            _txtBarcode.ShadowDecoration.CustomizableEdges = customizableEdges4;
            _txtBarcode.Size = new Size(240, 36);
            _txtBarcode.TabIndex = 0;
            // 
            // _btnScanBarcode
            // 
            _btnScanBarcode.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnScanBarcode.BorderRadius = 8;
            _btnScanBarcode.CustomizableEdges = customizableEdges5;
            _btnScanBarcode.FillColor = Color.FromArgb(255, 167, 38);
            _btnScanBarcode.Font = new Font("Segoe UI", 9F);
            _btnScanBarcode.ForeColor = Color.Black;
            _btnScanBarcode.Location = new Point(260, 86);
            _btnScanBarcode.Name = "_btnScanBarcode";
            _btnScanBarcode.ShadowDecoration.CustomizableEdges = customizableEdges6;
            _btnScanBarcode.Size = new Size(151, 36);
            _btnScanBarcode.TabIndex = 1;
            _btnScanBarcode.Text = "Quét";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.BorderRadius = 8;
            txtSearch.CustomizableEdges = customizableEdges7;
            txtSearch.DefaultText = "";
            txtSearch.Font = new Font("Segoe UI", 9F);
            txtSearch.Location = new Point(15, 45);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Tìm theo mã hoặc tên sản phẩm...";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtSearch.Size = new Size(430, 38);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // numQuantity
            // 
            numQuantity.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            numQuantity.BackColor = Color.Transparent;
            numQuantity.CustomizableEdges = customizableEdges9;
            numQuantity.Font = new Font("Segoe UI", 9F);
            numQuantity.Location = new Point(455, 45);
            numQuantity.Margin = new Padding(3, 4, 3, 4);
            numQuantity.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.ShadowDecoration.CustomizableEdges = customizableEdges10;
            numQuantity.Size = new Size(70, 38);
            numQuantity.TabIndex = 1;
            numQuantity.UpDownButtonFillColor = Color.Transparent;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnAddToCart
            // 
            btnAddToCart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddToCart.BorderRadius = 8;
            btnAddToCart.CustomizableEdges = customizableEdges11;
            btnAddToCart.FillColor = Color.FromArgb(255, 167, 38);
            btnAddToCart.Font = new Font("Segoe UI", 9F);
            btnAddToCart.ForeColor = Color.Black;
            btnAddToCart.Location = new Point(531, 45);
            btnAddToCart.Name = "btnAddToCart";
            btnAddToCart.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnAddToCart.Size = new Size(75, 38);
            btnAddToCart.TabIndex = 2;
            btnAddToCart.Text = "Thêm";
            btnAddToCart.Click += btnAddToCart_Click;
            // 
            // dgvProducts
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProducts.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dgvProducts.Location = new Point(15, 129);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(591, 501);
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
            grpCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpCart.BorderColor = Color.FromArgb(255, 167, 38);
            grpCart.Controls.Add(_btnHoldBill);
            grpCart.Controls.Add(_btnResumeBill);
            grpCart.Controls.Add(_tabHeldBills);
            grpCart.Controls.Add(dgvCart);
            grpCart.Controls.Add(btnRemoveItem);
            grpCart.Controls.Add(btnClearCart);
            grpCart.CustomBorderColor = Color.FromArgb(255, 241, 118);
            grpCart.CustomizableEdges = customizableEdges23;
            grpCart.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpCart.ForeColor = Color.FromArgb(198, 40, 40);
            grpCart.Location = new Point(640, 102);
            grpCart.Name = "grpCart";
            grpCart.ShadowDecoration.CustomizableEdges = customizableEdges24;
            grpCart.Size = new Size(751, 328);
            grpCart.TabIndex = 1;
            grpCart.Text = "Giỏ hàng";
            // 
            // _btnHoldBill
            // 
            _btnHoldBill.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _btnHoldBill.BorderRadius = 8;
            _btnHoldBill.CustomizableEdges = customizableEdges15;
            _btnHoldBill.FillColor = Color.FromArgb(255, 167, 38);
            _btnHoldBill.Font = new Font("Segoe UI", 9F);
            _btnHoldBill.ForeColor = Color.Black;
            _btnHoldBill.Location = new Point(307, 254);
            _btnHoldBill.Name = "_btnHoldBill";
            _btnHoldBill.ShadowDecoration.CustomizableEdges = customizableEdges16;
            _btnHoldBill.Size = new Size(130, 34);
            _btnHoldBill.TabIndex = 0;
            _btnHoldBill.Text = "Giữ bill (F8)";
            // 
            // _btnResumeBill
            // 
            _btnResumeBill.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            _btnResumeBill.BorderRadius = 8;
            _btnResumeBill.CustomizableEdges = customizableEdges17;
            _btnResumeBill.FillColor = Color.FromArgb(198, 40, 40);
            _btnResumeBill.Font = new Font("Segoe UI", 9F);
            _btnResumeBill.ForeColor = Color.White;
            _btnResumeBill.Location = new Point(443, 254);
            _btnResumeBill.Name = "_btnResumeBill";
            _btnResumeBill.ShadowDecoration.CustomizableEdges = customizableEdges18;
            _btnResumeBill.Size = new Size(130, 34);
            _btnResumeBill.TabIndex = 1;
            _btnResumeBill.Text = "Gọi lại bill";
            // 
            // _tabHeldBills
            // 
            _tabHeldBills.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _tabHeldBills.Location = new Point(15, 292);
            _tabHeldBills.Name = "_tabHeldBills";
            _tabHeldBills.SelectedIndex = 0;
            _tabHeldBills.Size = new Size(720, 28);
            _tabHeldBills.TabIndex = 2;
            // 
            // dgvCart
            // 
            dataGridViewCellStyle4.BackColor = Color.White;
            dgvCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvCart.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
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
            dgvCart.Location = new Point(15, 60);
            dgvCart.Name = "dgvCart";
            dgvCart.ReadOnly = true;
            dgvCart.RowHeadersVisible = false;
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(726, 187);
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
            btnRemoveItem.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnRemoveItem.BorderRadius = 8;
            btnRemoveItem.CustomizableEdges = customizableEdges19;
            btnRemoveItem.FillColor = Color.FromArgb(211, 47, 47);
            btnRemoveItem.Font = new Font("Segoe UI", 9F);
            btnRemoveItem.ForeColor = Color.White;
            btnRemoveItem.Location = new Point(15, 253);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.ShadowDecoration.CustomizableEdges = customizableEdges20;
            btnRemoveItem.Size = new Size(140, 35);
            btnRemoveItem.TabIndex = 1;
            btnRemoveItem.Text = "Xóa dòng";
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnClearCart
            // 
            btnClearCart.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnClearCart.BorderRadius = 8;
            btnClearCart.CustomizableEdges = customizableEdges21;
            btnClearCart.FillColor = Color.FromArgb(97, 97, 97);
            btnClearCart.Font = new Font("Segoe UI", 9F);
            btnClearCart.ForeColor = Color.White;
            btnClearCart.Location = new Point(161, 253);
            btnClearCart.Name = "btnClearCart";
            btnClearCart.ShadowDecoration.CustomizableEdges = customizableEdges22;
            btnClearCart.Size = new Size(140, 35);
            btnClearCart.TabIndex = 2;
            btnClearCart.Text = "Xóa giỏ hàng";
            btnClearCart.Click += btnClearCart_Click;
            // 
            // grpCheckout
            // 
            grpCheckout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grpCheckout.BorderColor = Color.FromArgb(255, 167, 38);
            grpCheckout.Controls.Add(btnSaveInvoice);
            grpCheckout.Controls.Add(_txtCustomerPhone);
            grpCheckout.Controls.Add(_btnFindCustomer);
            grpCheckout.Controls.Add(_btnQuickCustomer);
            grpCheckout.Controls.Add(lblCash);
            grpCheckout.Controls.Add(_txtCashReceived);
            grpCheckout.Controls.Add(lblChange);
            grpCheckout.Controls.Add(_lblChangeValue);
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
            grpCheckout.CustomizableEdges = customizableEdges41;
            grpCheckout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grpCheckout.ForeColor = Color.FromArgb(198, 40, 40);
            grpCheckout.Location = new Point(640, 468);
            grpCheckout.Name = "grpCheckout";
            grpCheckout.ShadowDecoration.CustomizableEdges = customizableEdges42;
            grpCheckout.Size = new Size(751, 284);
            grpCheckout.TabIndex = 0;
            grpCheckout.Text = "Thanh toán";
            grpCheckout.Click += grpCheckout_Click;
            // 
            // btnSaveInvoice
            // 
            btnSaveInvoice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSaveInvoice.BorderRadius = 10;
            btnSaveInvoice.CustomizableEdges = customizableEdges25;
            btnSaveInvoice.FillColor = Color.FromArgb(255, 167, 38);
            btnSaveInvoice.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSaveInvoice.ForeColor = Color.White;
            btnSaveInvoice.Location = new Point(310, 209);
            btnSaveInvoice.Name = "btnSaveInvoice";
            btnSaveInvoice.ShadowDecoration.CustomizableEdges = customizableEdges26;
            btnSaveInvoice.Size = new Size(203, 55);
            btnSaveInvoice.TabIndex = 10;
            btnSaveInvoice.Text = "LƯU HÓA ĐƠN";
            // 
            // _txtCustomerPhone
            // 
            _txtCustomerPhone.BorderRadius = 8;
            _txtCustomerPhone.CustomizableEdges = customizableEdges27;
            _txtCustomerPhone.DefaultText = "";
            _txtCustomerPhone.Font = new Font("Segoe UI", 9F);
            _txtCustomerPhone.Location = new Point(310, 59);
            _txtCustomerPhone.Margin = new Padding(3, 4, 3, 4);
            _txtCustomerPhone.Name = "_txtCustomerPhone";
            _txtCustomerPhone.PlaceholderText = "SĐT khách...";
            _txtCustomerPhone.SelectedText = "";
            _txtCustomerPhone.ShadowDecoration.CustomizableEdges = customizableEdges28;
            _txtCustomerPhone.Size = new Size(134, 36);
            _txtCustomerPhone.TabIndex = 0;
            // 
            // _btnFindCustomer
            // 
            _btnFindCustomer.BorderRadius = 8;
            _btnFindCustomer.CustomizableEdges = customizableEdges29;
            _btnFindCustomer.FillColor = Color.FromArgb(255, 167, 38);
            _btnFindCustomer.Font = new Font("Segoe UI", 9F);
            _btnFindCustomer.ForeColor = Color.Black;
            _btnFindCustomer.Location = new Point(450, 59);
            _btnFindCustomer.Name = "_btnFindCustomer";
            _btnFindCustomer.ShadowDecoration.CustomizableEdges = customizableEdges30;
            _btnFindCustomer.Size = new Size(145, 36);
            _btnFindCustomer.TabIndex = 1;
            _btnFindCustomer.Text = "Tìm SĐT";
            // 
            // _btnQuickCustomer
            // 
            _btnQuickCustomer.BorderRadius = 8;
            _btnQuickCustomer.CustomizableEdges = customizableEdges31;
            _btnQuickCustomer.FillColor = Color.FromArgb(211, 47, 47);
            _btnQuickCustomer.Font = new Font("Segoe UI", 9F);
            _btnQuickCustomer.ForeColor = Color.White;
            _btnQuickCustomer.Location = new Point(601, 59);
            _btnQuickCustomer.Name = "_btnQuickCustomer";
            _btnQuickCustomer.ShadowDecoration.CustomizableEdges = customizableEdges32;
            _btnQuickCustomer.Size = new Size(140, 36);
            _btnQuickCustomer.TabIndex = 2;
            _btnQuickCustomer.Text = "Thêm KH nhanh";
            // 
            // lblCash
            // 
            lblCash.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCash.BackColor = Color.Transparent;
            lblCash.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCash.Location = new Point(429, 117);
            lblCash.Name = "lblCash";
            lblCash.Size = new Size(130, 25);
            lblCash.TabIndex = 3;
            lblCash.Text = "Tiền khách đưa:";
            // 
            // _txtCashReceived
            // 
            _txtCashReceived.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _txtCashReceived.BorderRadius = 8;
            _txtCashReceived.CustomizableEdges = customizableEdges33;
            _txtCashReceived.DefaultText = "";
            _txtCashReceived.Font = new Font("Segoe UI", 9F);
            _txtCashReceived.Location = new Point(567, 117);
            _txtCashReceived.Margin = new Padding(3, 4, 3, 4);
            _txtCashReceived.Name = "_txtCashReceived";
            _txtCashReceived.PlaceholderText = "0";
            _txtCashReceived.SelectedText = "";
            _txtCashReceived.ShadowDecoration.CustomizableEdges = customizableEdges34;
            _txtCashReceived.Size = new Size(153, 30);
            _txtCashReceived.TabIndex = 4;
            // 
            // lblChange
            // 
            lblChange.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblChange.BackColor = Color.Transparent;
            lblChange.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblChange.Location = new Point(429, 154);
            lblChange.Name = "lblChange";
            lblChange.Size = new Size(84, 25);
            lblChange.TabIndex = 5;
            lblChange.Text = "Tiền thừa:";
            // 
            // _lblChangeValue
            // 
            _lblChangeValue.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _lblChangeValue.BackColor = Color.Transparent;
            _lblChangeValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            _lblChangeValue.ForeColor = Color.FromArgb(27, 94, 32);
            _lblChangeValue.Location = new Point(547, 154);
            _lblChangeValue.Name = "_lblChangeValue";
            _lblChangeValue.Size = new Size(34, 30);
            _lblChangeValue.TabIndex = 6;
            _lblChangeValue.Text = "0 đ";
            // 
            // cmbCustomer
            // 
            cmbCustomer.BackColor = Color.Transparent;
            cmbCustomer.BorderRadius = 10;
            cmbCustomer.CustomizableEdges = customizableEdges35;
            cmbCustomer.DrawMode = DrawMode.OwnerDrawFixed;
            cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomer.FocusedColor = Color.Empty;
            cmbCustomer.Font = new Font("Segoe UI", 10F);
            cmbCustomer.ForeColor = Color.FromArgb(68, 88, 112);
            cmbCustomer.ItemHeight = 30;
            cmbCustomer.Location = new Point(20, 59);
            cmbCustomer.Name = "cmbCustomer";
            cmbCustomer.ShadowDecoration.CustomizableEdges = customizableEdges36;
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
            cmbDiscount.Location = new Point(20, 106);
            cmbDiscount.Name = "cmbDiscount";
            cmbDiscount.ShadowDecoration.CustomizableEdges = customizableEdges20;
            cmbDiscount.Size = new Size(225, 36);
            cmbDiscount.TabIndex = 1;
            cmbDiscount.TextAlign = HorizontalAlignment.Center;
            cmbDiscount.SelectedIndexChanged += cmbDiscount_SelectedIndexChanged;
            // 
            // btnApplyDiscount
            // 
            btnApplyDiscount.BorderRadius = 8;
            btnApplyDiscount.CustomizableEdges = customizableEdges37;
            btnApplyDiscount.FillColor = Color.FromArgb(255, 167, 38);
            btnApplyDiscount.Font = new Font("Segoe UI", 9F);
            btnApplyDiscount.ForeColor = Color.Black;
            btnApplyDiscount.Location = new Point(263, 106);
            btnApplyDiscount.Name = "btnApplyDiscount";
            btnApplyDiscount.ShadowDecoration.CustomizableEdges = customizableEdges38;
            btnApplyDiscount.Size = new Size(78, 36);
            btnApplyDiscount.TabIndex = 2;
            btnApplyDiscount.Text = "Áp mã";
            btnApplyDiscount.Click += btnApplyDiscount_Click;
            // 
            // lblSubTotal
            // 
            lblSubTotal.BackColor = Color.Transparent;
            lblSubTotal.Location = new Point(33, 162);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(64, 22);
            lblSubTotal.TabIndex = 3;
            lblSubTotal.Text = "Tạm tính:";
            // 
            // lblSubTotalValue
            // 
            lblSubTotalValue.BackColor = Color.Transparent;
            lblSubTotalValue.Location = new Point(144, 162);
            lblSubTotalValue.Name = "lblSubTotalValue";
            lblSubTotalValue.Size = new Size(24, 22);
            lblSubTotalValue.TabIndex = 4;
            lblSubTotalValue.Text = "0 đ";
            // 
            // lblDiscount
            // 
            lblDiscount.BackColor = Color.Transparent;
            lblDiscount.Location = new Point(33, 190);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(66, 22);
            lblDiscount.TabIndex = 5;
            lblDiscount.Text = "Giảm giá:";
            // 
            // lblDiscountValue
            // 
            lblDiscountValue.BackColor = Color.Transparent;
            lblDiscountValue.Location = new Point(144, 190);
            lblDiscountValue.Name = "lblDiscountValue";
            lblDiscountValue.Size = new Size(24, 22);
            lblDiscountValue.TabIndex = 6;
            lblDiscountValue.Text = "0 đ";
            // 
            // lblFinalTotal
            // 
            lblFinalTotal.BackColor = Color.Transparent;
            lblFinalTotal.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFinalTotal.Location = new Point(33, 231);
            lblFinalTotal.Name = "lblFinalTotal";
            lblFinalTotal.Size = new Size(124, 33);
            lblFinalTotal.TabIndex = 7;
            lblFinalTotal.Text = "Thành tiền:";
            // 
            // lblFinalTotalValue
            // 
            lblFinalTotalValue.BackColor = Color.Transparent;
            lblFinalTotalValue.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFinalTotalValue.ForeColor = Color.FromArgb(191, 54, 12);
            lblFinalTotalValue.Location = new Point(161, 231);
            lblFinalTotalValue.Name = "lblFinalTotalValue";
            lblFinalTotalValue.Size = new Size(37, 33);
            lblFinalTotalValue.TabIndex = 8;
            lblFinalTotalValue.Text = "0 đ";
            // 
            // btnCreateInvoice
            // 
            btnCreateInvoice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCreateInvoice.BorderRadius = 10;
            btnCreateInvoice.CustomizableEdges = customizableEdges39;
            btnCreateInvoice.FillColor = Color.FromArgb(198, 40, 40);
            btnCreateInvoice.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCreateInvoice.ForeColor = Color.White;
            btnCreateInvoice.Location = new Point(536, 209);
            btnCreateInvoice.Name = "btnCreateInvoice";
            btnCreateInvoice.ShadowDecoration.CustomizableEdges = customizableEdges40;
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
            ClientSize = new Size(1405, 764);
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

        private Guna2Button btnSaveInvoice;
    }
}