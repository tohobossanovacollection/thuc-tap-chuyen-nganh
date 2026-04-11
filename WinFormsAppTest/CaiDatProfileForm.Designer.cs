namespace WinFormsAppTest
{
    partial class CaiDatProfileForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel _top;
        private Label _title;
        private Label _lblUser;
        private TextBox _txtUser;
        private Label _lblOld;
        private TextBox _txtOld;
        private Label _lblNew;
        private TextBox _txtNew;
        private Button _btnDoiMatKhau;
        private Button _btnCapNhat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            _top = new Panel();
            _title = new Label();
            _lblUser = new Label();
            _txtUser = new TextBox();
            _lblOld = new Label();
            _txtOld = new TextBox();
            _lblNew = new Label();
            _txtNew = new TextBox();
            _btnDoiMatKhau = new Button();
            _btnCapNhat = new Button();

            _top.SuspendLayout();
            SuspendLayout();

            Text = "15. Cài đặt / Profile";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(800, 500);

            _top.Dock = DockStyle.Top;
            _top.Height = 80;
            _top.BackColor = Color.FromArgb(255, 241, 118);

            _title.Text = "Trang cài đặt / profile";
            _title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _title.ForeColor = Color.FromArgb(198, 40, 40);
            _title.AutoSize = true;
            _title.Location = new Point(12, 10);
            _top.Controls.Add(_title);

            _lblUser.Text = "Tên đăng nhập:";
            _lblUser.Location = new Point(20, 110);
            _lblUser.AutoSize = true;
            _txtUser.Location = new Point(140, 106);
            _txtUser.Width = 220;
            _txtUser.Text = "user_demo";

            _lblOld.Text = "Mật khẩu cũ:";
            _lblOld.Location = new Point(20, 150);
            _lblOld.AutoSize = true;
            _txtOld.Location = new Point(140, 146);
            _txtOld.Width = 220;
            _txtOld.UseSystemPasswordChar = true;

            _lblNew.Text = "Mật khẩu mới:";
            _lblNew.Location = new Point(20, 190);
            _lblNew.AutoSize = true;
            _txtNew.Location = new Point(140, 186);
            _txtNew.Width = 220;
            _txtNew.UseSystemPasswordChar = true;

            _btnDoiMatKhau.Text = "Đổi mật khẩu";
            _btnDoiMatKhau.Location = new Point(140, 230);
            _btnDoiMatKhau.Size = new Size(120, 32);
            _btnDoiMatKhau.BackColor = Color.FromArgb(198, 40, 40);
            _btnDoiMatKhau.ForeColor = Color.White;
            _btnDoiMatKhau.Click += btnDoiMatKhau_Click;

            _btnCapNhat.Text = "Cập nhật profile";
            _btnCapNhat.Location = new Point(270, 230);
            _btnCapNhat.Size = new Size(120, 32);
            _btnCapNhat.BackColor = Color.FromArgb(198, 40, 40);
            _btnCapNhat.ForeColor = Color.White;
            _btnCapNhat.Click += btnCapNhat_Click;

            Controls.AddRange(new Control[] { _top, _lblUser, _txtUser, _lblOld, _txtOld, _lblNew, _txtNew, _btnDoiMatKhau, _btnCapNhat });

            _top.ResumeLayout(false);
            _top.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
