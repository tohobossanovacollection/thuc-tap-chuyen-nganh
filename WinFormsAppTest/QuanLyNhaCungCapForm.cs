using System.Data;

namespace WinFormsAppTest
{
    public partial class QuanLyNhaCungCapForm : Form
    {
        public QuanLyNhaCungCapForm()
        {
            InitializeComponent();
            SeedPreview();
        }

        private void SeedPreview()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ma_nha_cung_cap");
            dt.Columns.Add("ten_nha_cung_cap");
            dt.Columns.Add("so_dien_thoai");
            dt.Rows.Add("NCC01", "Công ty ABC", "0909000001");
            _dgv.DataSource = dt;
        }

        private void btnCrud_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm/Sửa/Xóa nhà cung cấp");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void _top_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
