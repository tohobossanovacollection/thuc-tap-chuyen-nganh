using System.Data;

namespace WinFormsAppTest
{
    public partial class QuanLyTaiKhoanForm : Form
    {
        public QuanLyTaiKhoanForm()
        {
            InitializeComponent();
            SeedPreview();
        }

        private void SeedPreview()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ma_tai_khoan");
            dt.Columns.Add("ten_dang_nhap");
            dt.Columns.Add("quyen_han");
            dt.Rows.Add("TK01", "admin", "ADMIN");
            _dgv.DataSource = dt;
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tạo tài khoản");
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phân quyền");
        }
    }
}
