namespace WinFormsAppTest
{
    public partial class CaiDatProfileForm : Form
    {
        public CaiDatProfileForm()
        {
            InitializeComponent();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đổi mật khẩu thành công (demo)");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cập nhật profile thành công (demo)");
        }
    }
}
