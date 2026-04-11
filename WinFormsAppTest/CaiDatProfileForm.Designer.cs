namespace WinFormsAppTest
{
    partial class CaiDatProfileForm
    {
        private System.ComponentModel.IContainer components = null;
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
            _lblUser = new Label();
            _txtUser = new TextBox();
            _lblOld = new Label();
            _txtOld = new TextBox();
            _lblNew = new Label();
            _txtNew = new TextBox();
            _btnDoiMatKhau = new Button();
            _btnCapNhat = new Button();
            SuspendLayout();
            // 
            // _lblUser
            // 
            _lblUser.AutoSize = true;
            _lblUser.Location = new Point(34, 45);
            _lblUser.Name = "_lblUser";
            _lblUser.Size = new Size(110, 20);
            _lblUser.TabIndex = 1;
            _lblUser.Text = "Tên đăng nhập:";
            // 
            // _txtUser
            // 
            _txtUser.Location = new Point(154, 41);
            _txtUser.Name = "_txtUser";
            _txtUser.Size = new Size(220, 27);
            _txtUser.TabIndex = 2;
            _txtUser.Text = "user_demo";
            // 
            // _lblOld
            // 
            _lblOld.AutoSize = true;
            _lblOld.Location = new Point(34, 85);
            _lblOld.Name = "_lblOld";
            _lblOld.Size = new Size(92, 20);
            _lblOld.TabIndex = 3;
            _lblOld.Text = "Mật khẩu cũ:";
            // 
            // _txtOld
            // 
            _txtOld.Location = new Point(154, 81);
            _txtOld.Name = "_txtOld";
            _txtOld.Size = new Size(220, 27);
            _txtOld.TabIndex = 4;
            _txtOld.UseSystemPasswordChar = true;
            // 
            // _lblNew
            // 
            _lblNew.AutoSize = true;
            _lblNew.Location = new Point(34, 125);
            _lblNew.Name = "_lblNew";
            _lblNew.Size = new Size(103, 20);
            _lblNew.TabIndex = 5;
            _lblNew.Text = "Mật khẩu mới:";
            // 
            // _txtNew
            // 
            _txtNew.Location = new Point(154, 121);
            _txtNew.Name = "_txtNew";
            _txtNew.Size = new Size(220, 27);
            _txtNew.TabIndex = 6;
            _txtNew.UseSystemPasswordChar = true;
            // 
            // _btnDoiMatKhau
            // 
            _btnDoiMatKhau.BackColor = Color.FromArgb(198, 40, 40);
            _btnDoiMatKhau.ForeColor = Color.White;
            _btnDoiMatKhau.Location = new Point(154, 165);
            _btnDoiMatKhau.Name = "_btnDoiMatKhau";
            _btnDoiMatKhau.Size = new Size(120, 32);
            _btnDoiMatKhau.TabIndex = 7;
            _btnDoiMatKhau.Text = "Đổi mật khẩu";
            _btnDoiMatKhau.UseVisualStyleBackColor = false;
            _btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // _btnCapNhat
            // 
            _btnCapNhat.BackColor = Color.FromArgb(198, 40, 40);
            _btnCapNhat.ForeColor = Color.White;
            _btnCapNhat.Location = new Point(284, 165);
            _btnCapNhat.Name = "_btnCapNhat";
            _btnCapNhat.Size = new Size(120, 32);
            _btnCapNhat.TabIndex = 8;
            _btnCapNhat.Text = "Cập nhật profile";
            _btnCapNhat.UseVisualStyleBackColor = false;
            _btnCapNhat.Click += btnCapNhat_Click;
            // 
            // CaiDatProfileForm
            // 
            ClientSize = new Size(800, 500);
            Controls.Add(_lblUser);
            Controls.Add(_txtUser);
            Controls.Add(_lblOld);
            Controls.Add(_txtOld);
            Controls.Add(_lblNew);
            Controls.Add(_txtNew);
            Controls.Add(_btnDoiMatKhau);
            Controls.Add(_btnCapNhat);
            Name = "CaiDatProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "15. Cài đặt / Profile";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
