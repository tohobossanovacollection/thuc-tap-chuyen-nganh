namespace WinFormsAppTest
{
    partial class CaiDatProfileForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label _lblUser;
        private TextBox _txtUser;
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
            _btnDoiMatKhau = new Button();
            _btnCapNhat = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            label6 = new Label();
            textBox6 = new TextBox();
            label7 = new Label();
            textBox7 = new TextBox();
            label8 = new Label();
            textBox8 = new TextBox();
            SuspendLayout();
            // 
            // _lblUser
            // 
            _lblUser.AutoSize = true;
            _lblUser.Location = new Point(32, 39);
            _lblUser.Name = "_lblUser";
            _lblUser.Size = new Size(110, 20);
            _lblUser.TabIndex = 1;
            _lblUser.Text = "Tên đăng nhập:";
            // 
            // _txtUser
            // 
            _txtUser.Location = new Point(152, 35);
            _txtUser.Name = "_txtUser";
            _txtUser.Size = new Size(220, 27);
            _txtUser.TabIndex = 2;
            _txtUser.Text = "user_demo";
            // 
            // _btnDoiMatKhau
            // 
            _btnDoiMatKhau.BackColor = Color.FromArgb(198, 40, 40);
            _btnDoiMatKhau.ForeColor = Color.White;
            _btnDoiMatKhau.Location = new Point(558, 35);
            _btnDoiMatKhau.Name = "_btnDoiMatKhau";
            _btnDoiMatKhau.Size = new Size(150, 56);
            _btnDoiMatKhau.TabIndex = 7;
            _btnDoiMatKhau.Text = "Đổi mật khẩu";
            _btnDoiMatKhau.UseVisualStyleBackColor = false;
            _btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // _btnCapNhat
            // 
            _btnCapNhat.BackColor = Color.FromArgb(198, 40, 40);
            _btnCapNhat.ForeColor = Color.White;
            _btnCapNhat.Location = new Point(558, 134);
            _btnCapNhat.Name = "_btnCapNhat";
            _btnCapNhat.Size = new Size(150, 56);
            _btnCapNhat.TabIndex = 8;
            _btnCapNhat.Text = "Cập nhật thông tin";
            _btnCapNhat.UseVisualStyleBackColor = false;
            _btnCapNhat.Click += btnCapNhat_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 85);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 9;
            label1.Text = "Mã nhân viên";
            label1.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 81);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 27);
            textBox1.TabIndex = 10;
            textBox1.Text = "user_demo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 137);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 11;
            label2.Text = "Họ tên";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(152, 133);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 27);
            textBox2.TabIndex = 12;
            textBox2.Text = "user_demo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 183);
            label3.Name = "label3";
            label3.Size = new Size(74, 20);
            label3.TabIndex = 13;
            label3.Text = "Ngày sinh";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(152, 179);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(220, 27);
            textBox3.TabIndex = 14;
            textBox3.Text = "user_demo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 232);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 15;
            label4.Text = "Địa chỉ";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(152, 228);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(220, 27);
            textBox4.TabIndex = 16;
            textBox4.Text = "user_demo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 283);
            label5.Name = "label5";
            label5.Size = new Size(97, 20);
            label5.TabIndex = 17;
            label5.Text = "Số điện thoại";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(152, 279);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(220, 27);
            textBox5.TabIndex = 18;
            textBox5.Text = "user_demo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 331);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 19;
            label6.Text = "Email";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(152, 327);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(220, 27);
            textBox6.TabIndex = 20;
            textBox6.Text = "user_demo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 386);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 21;
            label7.Text = "Chúc vụ";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(152, 382);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(220, 27);
            textBox7.TabIndex = 22;
            textBox7.Text = "user_demo";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 434);
            label8.Name = "label8";
            label8.Size = new Size(80, 20);
            label8.TabIndex = 23;
            label8.Text = "Phòng ban";
            // 
            // textBox8
            // 
            textBox8.Location = new Point(152, 430);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(220, 27);
            textBox8.TabIndex = 24;
            textBox8.Text = "user_demo";
            // 
            // CaiDatProfileForm
            // 
            ClientSize = new Size(800, 500);
            Controls.Add(label8);
            Controls.Add(textBox8);
            Controls.Add(label7);
            Controls.Add(textBox7);
            Controls.Add(label6);
            Controls.Add(textBox6);
            Controls.Add(label5);
            Controls.Add(textBox5);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(_lblUser);
            Controls.Add(_txtUser);
            Controls.Add(_btnDoiMatKhau);
            Controls.Add(_btnCapNhat);
            Name = "CaiDatProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "15. Cài đặt / Profile";
            Load += CaiDatProfileForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Label label6;
        private TextBox textBox6;
        private Label label7;
        private TextBox textBox7;
        private Label label8;
        private TextBox textBox8;
    }
}
