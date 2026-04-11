namespace WinFormsAppTest
{
    public partial class BaoCaoMainForm : Form
    {
        public BaoCaoMainForm()
        {
            InitializeComponent();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            using BaoCaoDoanhThuForm form = new BaoCaoDoanhThuForm();
            form.ShowDialog(this);
        }

        private void btnTonKho_Click(object sender, EventArgs e)
        {
            using BaoCaoTonKhoForm form = new BaoCaoTonKhoForm();
            form.ShowDialog(this);
        }
    }
}
