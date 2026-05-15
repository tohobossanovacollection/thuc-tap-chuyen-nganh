namespace WinFormsAppTest
{
    public partial class SanPham : Form
    {
        private readonly string _connectionString = DatabaseConfig.ConnectionString;
        public ProductItemData? Result { get; private set; }

        public SanPham()
        {
            InitializeComponent();
            Text = "Thêm sản phẩm";
            LoadCategories();
        }

        public void SetMaSanPham(string maSanPham, bool readOnly)
        {
            txtMaSanPham.Text = maSanPham;
            txtMaSanPham.ReadOnly = readOnly;
        }

        public SanPham(ProductItemData existing)
        {
            InitializeComponent();
            Text = "Cập nhật sản phẩm";
            lblTitle.Text = "Cập nhật thông tin sản phẩm";
            LoadCategories();
            txtMaSanPham.Text = existing.MaSanPham;
            txtTenSanPham.Text = existing.TenSanPham;
            cboDanhMuc.SelectedItem = existing.DanhMuc;
            txtGiaNhap.Text = existing.GiaNhap.ToString("0.##");
            txtGiaBan.Text = existing.GiaBan.ToString("0.##");
            txtSoLuongTon.Text = existing.SoLuongTon.ToString();
            txtMoTa.Text = existing.MoTa;
        }

        private void LoadCategories()
        {
            using Microsoft.Data.SqlClient.SqlConnection conn = new Microsoft.Data.SqlClient.SqlConnection(_connectionString);
            using Microsoft.Data.SqlClient.SqlCommand cmd = new Microsoft.Data.SqlClient.SqlCommand("SELECT ten_danh_muc FROM danh_muc_san_pham ORDER BY ten_danh_muc", conn);
            conn.Open();
            using Microsoft.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader();
            cboDanhMuc.Items.Clear();
            while (reader.Read())
            {
                cboDanhMuc.Items.Add(reader["ten_danh_muc"].ToString());
            }
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
                DanhMuc = cboDanhMuc.SelectedItem?.ToString() ?? string.Empty,
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
                ShowInvalid("mã sản phẩm");
                txtMaSanPham.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTenSanPham.Text))
            {
                ShowInvalid("tên sản phẩm");
                txtTenSanPham.Focus();
                return false;
            }

            if (cboDanhMuc.SelectedItem == null)
            {
                ShowInvalid("danh mục");
                cboDanhMuc.Focus();
                return false;
            }

            if (!decimal.TryParse(txtGiaNhap.Text.Trim(), out giaNhap) || giaNhap < 0)
            {
                ShowInvalid("giá nhập");
                txtGiaNhap.Focus();
                return false;
            }

            if (!decimal.TryParse(txtGiaBan.Text.Trim(), out giaBan) || giaBan < 0)
            {
                ShowInvalid("giá bán");
                txtGiaBan.Focus();
                return false;
            }

            if (!int.TryParse(txtSoLuongTon.Text.Trim(), out soLuongTon) || soLuongTon < 0)
            {
                ShowInvalid("số lượng tồn");
                txtSoLuongTon.Focus();
                return false;
            }

            return true;
        }

        private static void ShowInvalid(string field)
        {
            MessageBox.Show($"Thông tin {field} không hợp lệ vui lòng nhập lại.");
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