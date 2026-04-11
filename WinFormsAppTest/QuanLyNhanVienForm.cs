using System.Data;

namespace WinFormsAppTest
{
    public partial class QuanLyNhanVienForm : Form
    {
        public QuanLyNhanVienForm()
        {
            InitializeComponent();
            SeedPreview();
        }

        private void SeedPreview()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ma_nhan_vien");
            dt.Columns.Add("ho_ten");
            dt.Columns.Add("chuc_vu");
            dt.Columns.Add("ma_tai_khoan");
            dt.Rows.Add("NV01", "Trần Thị B", "Thu ngân", "TK01");
            _dgv.DataSource = dt;
        }

        private void btnCrud_Click(object sender, EventArgs e)
        {
            MessageBox.Show("CRUD nhân viên");
        }

        private void btnGanTk_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gán tài khoản cho nhân viên");
        }
    }
}
