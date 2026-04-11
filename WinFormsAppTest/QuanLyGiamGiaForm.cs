using System.Data;

namespace WinFormsAppTest
{
    public partial class QuanLyGiamGiaForm : Form
    {
        public QuanLyGiamGiaForm()
        {
            InitializeComponent();
            SeedPreview();
        }

        private void SeedPreview()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ma_giam_gia");
            dt.Columns.Add("phan_tram_giam");
            dt.Columns.Add("so_tien_giam");
            dt.Columns.Add("trang_thai");
            dt.Rows.Add("GG10", 10, 0, "ACTIVE");
            _dgv.DataSource = dt;
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tạo mã giảm giá");
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thiết lập phần trăm/tiền giảm");
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thiết lập thời gian hiệu lực");
        }
    }
}
