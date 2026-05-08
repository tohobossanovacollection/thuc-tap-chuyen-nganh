namespace WinFormsAppTest
{
    public partial class BaoCaoMainForm : Form
    {
        private readonly string _phongBan;

        public BaoCaoMainForm(string phongBan)
        {
            InitializeComponent();
            _phongBan = phongBan;
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            if (!IsAllowed("Ban hang", "Ke toan"))
            {
                ShowPermissionDenied();
                return;
            }

            using BaoCaoDoanhThuForm form = new BaoCaoDoanhThuForm();
            form.ShowDialog(this);
        }

        private void btnTonKho_Click(object sender, EventArgs e)
        {
            if (!IsAllowed("Ban hang", "Kho"))
            {
                ShowPermissionDenied();
                return;
            }

            using BaoCaoTonKhoForm form = new BaoCaoTonKhoForm();
            form.ShowDialog(this);
        }

        private bool IsAllowed(params string[] allowedDepartments)
        {
            if (string.Equals(_phongBan, "Ban quan ly", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            return allowedDepartments.Any(department =>
                string.Equals(_phongBan, department, StringComparison.OrdinalIgnoreCase));
        }

        private static void ShowPermissionDenied()
        {
            MessageBox.Show("Bạn không có quyền truy cập báo cáo này.", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
