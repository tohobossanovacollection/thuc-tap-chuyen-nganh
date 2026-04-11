using System.Data;

namespace WinFormsAppTest
{
    public partial class QuanLyDanhMucForm : Form
    {
        public QuanLyDanhMucForm()
        {
            InitializeComponent();
            SeedPreviewData();
        }

        private void SeedPreviewData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ma_danh_muc");
            dt.Columns.Add("ten_danh_muc");
            dt.Rows.Add("DM01", "Nước uống");
            dt.Rows.Add("DM02", "Đồ ăn nhanh");
            _dgv.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm danh mục");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sửa danh mục");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa danh mục");
        }

        private void btnGan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mở chức năng gán danh mục cho sản phẩm");
        }
    }
}
