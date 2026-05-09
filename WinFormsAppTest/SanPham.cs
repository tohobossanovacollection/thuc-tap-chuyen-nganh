namespace WinFormsAppTest
{
    public partial class SanPham : Form
    {
        public ProductItemData? Result { get; private set; }

        public SanPham()
        {
            InitializeComponent();
            Text = "Thêm sản phẩm";
        }

        public SanPham(ProductItemData existing)
        {
            InitializeComponent();
            Text = "Cập nhật sản phẩm";
            lblTitle.Text = "Cập nhật thông tin sản phẩm";
            txtMaSanPham.Text = existing.MaSanPham;
            txtTenSanPham.Text = existing.TenSanPham;
            txtDanhMuc.Text = existing.DanhMuc;
            txtGiaNhap.Text = existing.GiaNhap.ToString("0.##");
            txtGiaBan.Text = existing.GiaBan.ToString("0.##");
            txtSoLuongTon.Text = existing.SoLuongTon.ToString();
            txtMoTa.Text = existing.MoTa;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(out decimal giaNhap, out decimal giaBan, out int soLuongTon))
            {
                return;
            }

            Result = new ProductItemData
            {
                MaSanPham = txtMaSanPham.Text.Trim(),
                TenSanPham = txtTenSanPham.Text.Trim(),
                DanhMuc = txtDanhMuc.Text.Trim(),
                GiaNhap = giaNhap,
                GiaBan = giaBan,
                SoLuongTon = soLuongTon,
                MoTa = txtMoTa.Text.Trim()
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidateInput(out decimal giaNhap, out decimal giaBan, out int soLuongTon)
        {
            giaNhap = 0;
            giaBan = 0;
            soLuongTon = 0;

            if (string.IsNullOrWhiteSpace(txtMaSanPham.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm.");
                txtMaSanPham.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenSanPham.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm.");
                txtTenSanPham.Focus();
                return false;
            }

            if (!decimal.TryParse(txtGiaNhap.Text.Trim(), out giaNhap) || giaNhap < 0)
            {
                MessageBox.Show("Giá nhập không hợp lệ.");
                txtGiaNhap.Focus();
                return false;
            }

            if (!decimal.TryParse(txtGiaBan.Text.Trim(), out giaBan) || giaBan < 0)
            {
                MessageBox.Show("Giá bán không hợp lệ.");
                txtGiaBan.Focus();
                return false;
            }

            if (!int.TryParse(txtSoLuongTon.Text.Trim(), out soLuongTon) || soLuongTon < 0)
            {
                MessageBox.Show("Số lượng tồn không hợp lệ.");
                txtSoLuongTon.Focus();
                return false;
            }

            return true;
        }
    }

    public sealed class ProductItemData
    {
        public string MaSanPham { get; set; } = string.Empty;
        public string TenSanPham { get; set; } = string.Empty;
        public string DanhMuc { get; set; } = string.Empty;
        public decimal GiaNhap { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuongTon { get; set; }
        public string MoTa { get; set; } = string.Empty;
    }
}