using System.Data;

namespace WinFormsAppTest
{
    public partial class QuanLyKhachHangForm : Form
    {
        public QuanLyKhachHangForm()
        {
            InitializeComponent();
            SeedPreview();
        }

        private void SeedPreview()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ma_khach_hang");
            dt.Columns.Add("ten_khach_hang");
            dt.Columns.Add("so_dien_thoai");
            dt.Rows.Add("KH01", "Nguyễn Văn A", "0911222333");
            _dgv.DataSource = dt;
        }

        private void btnCrud_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CRUD khách hàng");
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xem lịch sử mua hàng");
        }
    }
}
