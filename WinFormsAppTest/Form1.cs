namespace WinFormsAppTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set default role selection
            cmbRole.SelectedIndex = 0;

            // Focus on username field
            txtUsername.Focus();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (cmbRole.SelectedIndex == -1 || cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn vai trò!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbRole.Focus();
                return;
            }

            // TODO: Implement actual login logic here
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = cmbRole.SelectedItem?.ToString() ?? string.Empty; // Null-safe access
            bool rememberMe = chkRemember.Checked;

            MessageBox.Show($"Đăng nhập thành công!\nTài khoản: {username}\nVai trò: {role}",
                "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Close login form and open main application
            this.Hide();
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            // TODO: Open registration form
            MessageBox.Show("Chức năng đăng ký sẽ được phát triển!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lnkForgotPassword_Click(object sender, EventArgs e)
        {
            // TODO: Open password recovery form
            MessageBox.Show("Chức năng quên mật khẩu sẽ được phát triển!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Remove this if not needed
        }
    }
}
