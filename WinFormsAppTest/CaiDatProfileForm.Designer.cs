namespace WinFormsAppTest
{
    partial class CaiDatProfileForm
    {
        private System.ComponentModel.IContainer components = null;
        private Guna.UI2.WinForms.Guna2Panel _mainPanel;
        private Label _lblGreeting;
        private Label _lblUserNameTitle;
        private Label _lblUserNameValue;
        private Label _lblMaNhanVienTitle;
        private Label _lblMaNhanVienValue;
        private Label _lblHoTenTitle;
        private Guna.UI2.WinForms.Guna2TextBox _txtHoTen;
        private Label _lblNgaySinhTitle;
        private Guna.UI2.WinForms.Guna2DateTimePicker _dtpNgaySinh;
        private Label _lblDiaChiTitle;
        private Guna.UI2.WinForms.Guna2TextBox _txtDiaChi;
        private Label _lblSoDienThoaiTitle;
        private Guna.UI2.WinForms.Guna2TextBox _txtSoDienThoai;
        private Label _lblEmailTitle;
        private Guna.UI2.WinForms.Guna2TextBox _txtEmail;
        private Label _lblChucVuTitle;
        private Label _lblChucVuValue;
        private Label _lblOldPassTitle;
        private Guna.UI2.WinForms.Guna2TextBox _txtOldPass;
        private Label _lblNewPassTitle;
        private Guna.UI2.WinForms.Guna2TextBox _txtNewPass;
        private Label _lblConfirmPassTitle;
        private Guna.UI2.WinForms.Guna2TextBox _txtConfirmPass;
        private Guna.UI2.WinForms.Guna2Button _btnCapNhat;
        private Guna.UI2.WinForms.Guna2Button _btnDoiMatKhau;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            _mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            _lblGreeting = new Label();
            _lblUserNameTitle = new Label();
            _lblUserNameValue = new Label();
            _lblMaNhanVienTitle = new Label();
            _lblMaNhanVienValue = new Label();
            _lblHoTenTitle = new Label();
            _txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            _lblNgaySinhTitle = new Label();
            _dtpNgaySinh = new Guna.UI2.WinForms.Guna2DateTimePicker();
            _lblDiaChiTitle = new Label();
            _txtDiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            _lblSoDienThoaiTitle = new Label();
            _txtSoDienThoai = new Guna.UI2.WinForms.Guna2TextBox();
            _lblEmailTitle = new Label();
            _txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            _lblChucVuTitle = new Label();
            _lblChucVuValue = new Label();
            _lblOldPassTitle = new Label();
            _txtOldPass = new Guna.UI2.WinForms.Guna2TextBox();
            _lblNewPassTitle = new Label();
            _txtNewPass = new Guna.UI2.WinForms.Guna2TextBox();
            _lblConfirmPassTitle = new Label();
            _txtConfirmPass = new Guna.UI2.WinForms.Guna2TextBox();
            _btnCapNhat = new Guna.UI2.WinForms.Guna2Button();
            _btnDoiMatKhau = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // _mainPanel
            // 
            _mainPanel.BorderColor = Color.FromArgb(198, 40, 40);
            _mainPanel.BorderRadius = 15;
            _mainPanel.BorderThickness = 2;
            _mainPanel.Controls.Add(_lblGreeting);
            _mainPanel.Controls.Add(_lblUserNameTitle);
            _mainPanel.Controls.Add(_lblUserNameValue);
            _mainPanel.Controls.Add(_lblMaNhanVienTitle);
            _mainPanel.Controls.Add(_lblMaNhanVienValue);
            _mainPanel.Controls.Add(_lblHoTenTitle);
            _mainPanel.Controls.Add(_txtHoTen);
            _mainPanel.Controls.Add(_lblNgaySinhTitle);
            _mainPanel.Controls.Add(_dtpNgaySinh);
            _mainPanel.Controls.Add(_lblDiaChiTitle);
            _mainPanel.Controls.Add(_txtDiaChi);
            _mainPanel.Controls.Add(_lblSoDienThoaiTitle);
            _mainPanel.Controls.Add(_txtSoDienThoai);
            _mainPanel.Controls.Add(_lblEmailTitle);
            _mainPanel.Controls.Add(_txtEmail);
            _mainPanel.Controls.Add(_lblChucVuTitle);
            _mainPanel.Controls.Add(_lblChucVuValue);
            _mainPanel.Controls.Add(_lblOldPassTitle);
            _mainPanel.Controls.Add(_txtOldPass);
            _mainPanel.Controls.Add(_lblNewPassTitle);
            _mainPanel.Controls.Add(_txtNewPass);
            _mainPanel.Controls.Add(_lblConfirmPassTitle);
            _mainPanel.Controls.Add(_txtConfirmPass);
            _mainPanel.Controls.Add(_btnCapNhat);
            _mainPanel.Controls.Add(_btnDoiMatKhau);
            _mainPanel.Location = new Point(50, 20);
            _mainPanel.Name = "_mainPanel";
            _mainPanel.Size = new Size(1000, 680);
            _mainPanel.TabIndex = 0;
            // 
            // _lblGreeting
            // 
            _lblGreeting.AutoSize = true;
            _lblGreeting.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            _lblGreeting.ForeColor = Color.FromArgb(198, 40, 40);
            _lblGreeting.Location = new Point(30, 20);
            _lblGreeting.Name = "_lblGreeting";
            _lblGreeting.Size = new Size(280, 54);
            _lblGreeting.Text = "Xin chào, ...";
            // 
            // _lblUserNameTitle
            // 
            _lblUserNameTitle.Location = new Point(40, 100);
            _lblUserNameTitle.Text = "Tên đăng nhập:";
            _lblUserNameTitle.Font = new Font("Segoe UI", 10F);
            _lblUserNameTitle.AutoSize = true;
            // 
            // _lblUserNameValue
            // 
            _lblUserNameValue.Location = new Point(180, 100);
            _lblUserNameValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            _lblUserNameValue.Size = new Size(200, 25);
            // 
            // _lblMaNhanVienTitle
            // 
            _lblMaNhanVienTitle.Location = new Point(400, 100);
            _lblMaNhanVienTitle.Text = "Mã nhân viên:";
            _lblMaNhanVienTitle.Font = new Font("Segoe UI", 10F);
            _lblMaNhanVienTitle.AutoSize = true;
            // 
            // _lblMaNhanVienValue
            // 
            _lblMaNhanVienValue.Location = new Point(540, 100);
            _lblMaNhanVienValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            _lblMaNhanVienValue.Size = new Size(200, 25);
            // 
            // _lblHoTenTitle
            // 
            _lblHoTenTitle.Location = new Point(40, 150);
            _lblHoTenTitle.Text = "Họ và tên:";
            _lblHoTenTitle.Font = new Font("Segoe UI", 10F);
            _lblHoTenTitle.AutoSize = true;
            // 
            // _txtHoTen
            // 
            _txtHoTen.BorderRadius = 8;
            _txtHoTen.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            _txtHoTen.Location = new Point(180, 140);
            _txtHoTen.Size = new Size(300, 40);
            _txtHoTen.TabIndex = 1;
            // 
            // _lblNgaySinhTitle
            // 
            _lblNgaySinhTitle.Location = new Point(40, 210);
            _lblNgaySinhTitle.Text = "Ngày sinh:";
            _lblNgaySinhTitle.Font = new Font("Segoe UI", 10F);
            _lblNgaySinhTitle.AutoSize = true;
            // 
            // _dtpNgaySinh
            // 
            _dtpNgaySinh.BorderRadius = 8;
            _dtpNgaySinh.FillColor = Color.White;
            _dtpNgaySinh.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            _dtpNgaySinh.Format = DateTimePickerFormat.Short;
            _dtpNgaySinh.Location = new Point(180, 200);
            _dtpNgaySinh.Size = new Size(300, 40);
            _dtpNgaySinh.TabIndex = 2;
            // 
            // _lblDiaChiTitle
            // 
            _lblDiaChiTitle.Location = new Point(40, 270);
            _lblDiaChiTitle.Text = "Địa chỉ:";
            _lblDiaChiTitle.Font = new Font("Segoe UI", 10F);
            _lblDiaChiTitle.AutoSize = true;
            // 
            // _txtDiaChi
            // 
            _txtDiaChi.BorderRadius = 8;
            _txtDiaChi.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            _txtDiaChi.Location = new Point(180, 260);
            _txtDiaChi.Size = new Size(780, 40);
            _txtDiaChi.TabIndex = 3;
            // 
            // _lblSoDienThoaiTitle
            // 
            _lblSoDienThoaiTitle.Location = new Point(40, 330);
            _lblSoDienThoaiTitle.Text = "Điện thoại:";
            _lblSoDienThoaiTitle.Font = new Font("Segoe UI", 10F);
            _lblSoDienThoaiTitle.AutoSize = true;
            // 
            // _txtSoDienThoai
            // 
            _txtSoDienThoai.BorderRadius = 8;
            _txtSoDienThoai.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            _txtSoDienThoai.Location = new Point(180, 320);
            _txtSoDienThoai.Size = new Size(300, 40);
            _txtSoDienThoai.TabIndex = 4;
            // 
            // _lblEmailTitle
            // 
            _lblEmailTitle.Location = new Point(520, 330);
            _lblEmailTitle.Text = "Email:";
            _lblEmailTitle.Font = new Font("Segoe UI", 10F);
            _lblEmailTitle.AutoSize = true;
            // 
            // _txtEmail
            // 
            _txtEmail.BorderRadius = 8;
            _txtEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            _txtEmail.Location = new Point(660, 320);
            _txtEmail.Size = new Size(300, 40);
            _txtEmail.TabIndex = 5;
            // 
            // _lblChucVuTitle
            // 
            _lblChucVuTitle.Location = new Point(40, 390);
            _lblChucVuTitle.Text = "Chức vụ:";
            _lblChucVuTitle.Font = new Font("Segoe UI", 10F);
            _lblChucVuTitle.AutoSize = true;
            // 
            // _lblChucVuValue
            // 
            _lblChucVuValue.Location = new Point(180, 390);
            _lblChucVuValue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            _lblChucVuValue.Size = new Size(300, 25);
            // 
            // _lblOldPassTitle
            // 
            _lblOldPassTitle.AutoSize = true;
            _lblOldPassTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            _lblOldPassTitle.ForeColor = Color.FromArgb(198, 40, 40);
            _lblOldPassTitle.Location = new Point(40, 440);
            _lblOldPassTitle.Text = "BẢO MẬT - ĐỔI MẬT KHẨU";
            // 
            // _txtOldPass
            // 
            _txtOldPass.BorderRadius = 8;
            _txtOldPass.Font = new Font("Segoe UI", 10F);
            _txtOldPass.Location = new Point(180, 475);
            _txtOldPass.PasswordChar = '●';
            _txtOldPass.PlaceholderText = "Mật khẩu hiện tại";
            _txtOldPass.Size = new Size(300, 40);
            _txtOldPass.TabIndex = 8;
            // 
            // _lblNewPassTitle
            // 
            _lblNewPassTitle.AutoSize = true;
            _lblNewPassTitle.Location = new Point(40, 535);
            _lblNewPassTitle.Text = "Mật khẩu mới:";
            _lblNewPassTitle.Font = new Font("Segoe UI", 10F);
            // 
            // _txtNewPass
            // 
            _txtNewPass.BorderRadius = 8;
            _txtNewPass.Font = new Font("Segoe UI", 10F);
            _txtNewPass.Location = new Point(180, 525);
            _txtNewPass.PasswordChar = '●';
            _txtNewPass.PlaceholderText = "Mật khẩu mới";
            _txtNewPass.Size = new Size(300, 40);
            _txtNewPass.TabIndex = 9;
            // 
            // _lblConfirmPassTitle
            // 
            _lblConfirmPassTitle.AutoSize = true;
            _lblConfirmPassTitle.Location = new Point(520, 535);
            _lblConfirmPassTitle.Text = "Xác nhận:";
            _lblConfirmPassTitle.Font = new Font("Segoe UI", 10F);
            // 
            // _txtConfirmPass
            // 
            _txtConfirmPass.BorderRadius = 8;
            _txtConfirmPass.Font = new Font("Segoe UI", 10F);
            _txtConfirmPass.Location = new Point(660, 525);
            _txtConfirmPass.PasswordChar = '●';
            _txtConfirmPass.PlaceholderText = "Xác nhận mật khẩu";
            _txtConfirmPass.Size = new Size(300, 40);
            _txtConfirmPass.TabIndex = 10;
            // 
            // _btnCapNhat
            // 
            _btnCapNhat.BorderRadius = 10;
            _btnCapNhat.FillColor = Color.FromArgb(198, 40, 40);
            _btnCapNhat.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            _btnCapNhat.ForeColor = Color.White;
            _btnCapNhat.Location = new Point(740, 600);
            _btnCapNhat.Size = new Size(220, 50);
            _btnCapNhat.TabIndex = 11;
            _btnCapNhat.Text = "CẬP NHẬT HỒ SƠ";
            _btnCapNhat.Click += btnCapNhat_Click;
            // 
            // _btnDoiMatKhau
            // 
            _btnDoiMatKhau.BorderRadius = 10;
            _btnDoiMatKhau.BorderThickness = 1;
            _btnDoiMatKhau.BorderColor = Color.FromArgb(198, 40, 40);
            _btnDoiMatKhau.FillColor = Color.White;
            _btnDoiMatKhau.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            _btnDoiMatKhau.ForeColor = Color.FromArgb(198, 40, 40);
            _btnDoiMatKhau.Location = new Point(500, 600);
            _btnDoiMatKhau.Size = new Size(220, 50);
            _btnDoiMatKhau.TabIndex = 12;
            _btnDoiMatKhau.Text = "ĐỔI MẬT KHẨU";
            _btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // CaiDatProfileForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(1100, 720);
            Controls.Add(_mainPanel);
            Name = "CaiDatProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hồ sơ cá nhân";
            Load += CaiDatProfileForm_Load;
            ResumeLayout(false);
        }
    }
}
