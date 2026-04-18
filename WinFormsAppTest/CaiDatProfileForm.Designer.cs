namespace WinFormsAppTest
{
    partial class CaiDatProfileForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel _pnlHeader;
        private Label _lblGreeting;
        private Label _lblSubGreeting;
        private FlowLayoutPanel _flpInfoCards;
        private Panel _cardUserName;
        private Label _lblUserNameTitle;
        private Label _lblUserNameValue;
        private Panel _cardMaNhanVien;
        private Label _lblMaNhanVienTitle;
        private Label _lblMaNhanVienValue;
        private Panel _cardHoTen;
        private Label _lblHoTenTitle;
        private Label _lblHoTenValue;
        private Panel _cardNgaySinh;
        private Label _lblNgaySinhTitle;
        private Label _lblNgaySinhValue;
        private Panel _cardDiaChi;
        private Label _lblDiaChiTitle;
        private Label _lblDiaChiValue;
        private Panel _cardSoDienThoai;
        private Label _lblSoDienThoaiTitle;
        private Label _lblSoDienThoaiValue;
        private Panel _cardEmail;
        private Label _lblEmailTitle;
        private Label _lblEmailValue;
        private Panel _cardChucVuPhongBan;
        private Label _lblChucVuPhongBanTitle;
        private Label _lblChucVuPhongBanValue;
        private Button _btnDoiMatKhau;
        private Button _btnCapNhat;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            _pnlHeader = new Panel();
            _lblGreeting = new Label();
            _lblSubGreeting = new Label();
            _flpInfoCards = new FlowLayoutPanel();
            _cardUserName = new Panel();
            _lblUserNameTitle = new Label();
            _lblUserNameValue = new Label();
            _cardMaNhanVien = new Panel();
            _lblMaNhanVienTitle = new Label();
            _lblMaNhanVienValue = new Label();
            _cardHoTen = new Panel();
            _lblHoTenTitle = new Label();
            _lblHoTenValue = new Label();
            _cardNgaySinh = new Panel();
            _lblNgaySinhTitle = new Label();
            _lblNgaySinhValue = new Label();
            _cardDiaChi = new Panel();
            _lblDiaChiTitle = new Label();
            _lblDiaChiValue = new Label();
            _cardSoDienThoai = new Panel();
            _lblSoDienThoaiTitle = new Label();
            _lblSoDienThoaiValue = new Label();
            _cardEmail = new Panel();
            _lblEmailTitle = new Label();
            _lblEmailValue = new Label();
            _cardChucVuPhongBan = new Panel();
            _lblChucVuPhongBanTitle = new Label();
            _lblChucVuPhongBanValue = new Label();
            _btnDoiMatKhau = new Button();
            _btnCapNhat = new Button();
            _pnlHeader.SuspendLayout();
            _flpInfoCards.SuspendLayout();
            _cardUserName.SuspendLayout();
            _cardMaNhanVien.SuspendLayout();
            _cardHoTen.SuspendLayout();
            _cardNgaySinh.SuspendLayout();
            _cardDiaChi.SuspendLayout();
            _cardSoDienThoai.SuspendLayout();
            _cardEmail.SuspendLayout();
            _cardChucVuPhongBan.SuspendLayout();
            SuspendLayout();
            // 
            // _pnlHeader
            // 
            _pnlHeader.BackColor = Color.FromArgb(198, 40, 40);
            _pnlHeader.Controls.Add(_lblGreeting);
            _pnlHeader.Controls.Add(_lblSubGreeting);
            _pnlHeader.Dock = DockStyle.Top;
            _pnlHeader.Location = new Point(0, 0);
            _pnlHeader.Name = "_pnlHeader";
            _pnlHeader.Size = new Size(1100, 120);
            _pnlHeader.TabIndex = 0;
            // 
            // _lblGreeting
            // 
            _lblGreeting.AutoSize = true;
            _lblGreeting.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            _lblGreeting.ForeColor = Color.FromArgb(255, 241, 118);
            _lblGreeting.Location = new Point(28, 20);
            _lblGreeting.Name = "_lblGreeting";
            _lblGreeting.Size = new Size(280, 54);
            _lblGreeting.TabIndex = 0;
            _lblGreeting.Text = "Xin chào, ABC";
            // 
            // _lblSubGreeting
            // 
            _lblSubGreeting.AutoSize = true;
            _lblSubGreeting.Font = new Font("Segoe UI", 10F);
            _lblSubGreeting.ForeColor = Color.White;
            _lblSubGreeting.Location = new Point(32, 80);
            _lblSubGreeting.Name = "_lblSubGreeting";
            _lblSubGreeting.Size = new Size(270, 23);
            _lblSubGreeting.TabIndex = 1;
            _lblSubGreeting.Text = "Thông tin cá nhân và cài đặt tài khoản";
            // 
            // _flpInfoCards
            // 
            _flpInfoCards.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _flpInfoCards.Controls.Add(_cardUserName);
            _flpInfoCards.Controls.Add(_cardMaNhanVien);
            _flpInfoCards.Controls.Add(_cardHoTen);
            _flpInfoCards.Controls.Add(_cardNgaySinh);
            _flpInfoCards.Controls.Add(_cardDiaChi);
            _flpInfoCards.Controls.Add(_cardSoDienThoai);
            _flpInfoCards.Controls.Add(_cardEmail);
            _flpInfoCards.Controls.Add(_cardChucVuPhongBan);
            _flpInfoCards.Location = new Point(20, 140);
            _flpInfoCards.Name = "_flpInfoCards";
            _flpInfoCards.Size = new Size(1060, 330);
            _flpInfoCards.TabIndex = 1;
            // 
            // _cardUserName
            // 
            _cardUserName.BackColor = Color.FromArgb(255, 253, 231);
            _cardUserName.BorderStyle = BorderStyle.FixedSingle;
            _cardUserName.Controls.Add(_lblUserNameTitle);
            _cardUserName.Controls.Add(_lblUserNameValue);
            _cardUserName.Margin = new Padding(10);
            _cardUserName.Name = "_cardUserName";
            _cardUserName.Size = new Size(240, 90);
            _cardUserName.TabIndex = 0;
            // 
            // _lblUserNameTitle
            // 
            _lblUserNameTitle.AutoSize = true;
            _lblUserNameTitle.ForeColor = Color.FromArgb(198, 40, 40);
            _lblUserNameTitle.Location = new Point(14, 12);
            _lblUserNameTitle.Name = "_lblUserNameTitle";
            _lblUserNameTitle.Size = new Size(110, 20);
            _lblUserNameTitle.TabIndex = 0;
            _lblUserNameTitle.Text = "Tên đăng nhập";
            // 
            // _lblUserNameValue
            // 
            _lblUserNameValue.AutoSize = true;
            _lblUserNameValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            _lblUserNameValue.Location = new Point(14, 45);
            _lblUserNameValue.Name = "_lblUserNameValue";
            _lblUserNameValue.Size = new Size(92, 25);
            _lblUserNameValue.TabIndex = 1;
            _lblUserNameValue.Text = "user_demo";
            // 
            // _cardMaNhanVien
            // 
            _cardMaNhanVien.BackColor = Color.FromArgb(255, 253, 231);
            _cardMaNhanVien.BorderStyle = BorderStyle.FixedSingle;
            _cardMaNhanVien.Controls.Add(_lblMaNhanVienTitle);
            _cardMaNhanVien.Controls.Add(_lblMaNhanVienValue);
            _cardMaNhanVien.Margin = new Padding(10);
            _cardMaNhanVien.Name = "_cardMaNhanVien";
            _cardMaNhanVien.Size = new Size(240, 90);
            _cardMaNhanVien.TabIndex = 1;
            // 
            // _lblMaNhanVienTitle
            // 
            _lblMaNhanVienTitle.AutoSize = true;
            _lblMaNhanVienTitle.ForeColor = Color.FromArgb(198, 40, 40);
            _lblMaNhanVienTitle.Location = new Point(14, 12);
            _lblMaNhanVienTitle.Name = "_lblMaNhanVienTitle";
            _lblMaNhanVienTitle.Size = new Size(97, 20);
            _lblMaNhanVienTitle.TabIndex = 0;
            _lblMaNhanVienTitle.Text = "Mã nhân viên";
            // 
            // _lblMaNhanVienValue
            // 
            _lblMaNhanVienValue.AutoSize = true;
            _lblMaNhanVienValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            _lblMaNhanVienValue.Location = new Point(14, 45);
            _lblMaNhanVienValue.Name = "_lblMaNhanVienValue";
            _lblMaNhanVienValue.Size = new Size(55, 25);
            _lblMaNhanVienValue.TabIndex = 1;
            _lblMaNhanVienValue.Text = "NV01";
            // 
            // _cardHoTen
            // 
            _cardHoTen.BackColor = Color.FromArgb(255, 253, 231);
            _cardHoTen.BorderStyle = BorderStyle.FixedSingle;
            _cardHoTen.Controls.Add(_lblHoTenTitle);
            _cardHoTen.Controls.Add(_lblHoTenValue);
            _cardHoTen.Margin = new Padding(10);
            _cardHoTen.Name = "_cardHoTen";
            _cardHoTen.Size = new Size(240, 90);
            _cardHoTen.TabIndex = 2;
            // 
            // _lblHoTenTitle
            // 
            _lblHoTenTitle.AutoSize = true;
            _lblHoTenTitle.ForeColor = Color.FromArgb(198, 40, 40);
            _lblHoTenTitle.Location = new Point(14, 12);
            _lblHoTenTitle.Name = "_lblHoTenTitle";
            _lblHoTenTitle.Size = new Size(54, 20);
            _lblHoTenTitle.TabIndex = 0;
            _lblHoTenTitle.Text = "Họ tên";
            // 
            // _lblHoTenValue
            // 
            _lblHoTenValue.AutoSize = true;
            _lblHoTenValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            _lblHoTenValue.Location = new Point(14, 45);
            _lblHoTenValue.Name = "_lblHoTenValue";
            _lblHoTenValue.Size = new Size(130, 25);
            _lblHoTenValue.TabIndex = 1;
            _lblHoTenValue.Text = "Nguyễn Văn A";
            // 
            // _cardNgaySinh
            // 
            _cardNgaySinh.BackColor = Color.FromArgb(255, 253, 231);
            _cardNgaySinh.BorderStyle = BorderStyle.FixedSingle;
            _cardNgaySinh.Controls.Add(_lblNgaySinhTitle);
            _cardNgaySinh.Controls.Add(_lblNgaySinhValue);
            _cardNgaySinh.Margin = new Padding(10);
            _cardNgaySinh.Name = "_cardNgaySinh";
            _cardNgaySinh.Size = new Size(240, 90);
            _cardNgaySinh.TabIndex = 3;
            // 
            // _lblNgaySinhTitle
            // 
            _lblNgaySinhTitle.AutoSize = true;
            _lblNgaySinhTitle.ForeColor = Color.FromArgb(198, 40, 40);
            _lblNgaySinhTitle.Location = new Point(14, 12);
            _lblNgaySinhTitle.Name = "_lblNgaySinhTitle";
            _lblNgaySinhTitle.Size = new Size(74, 20);
            _lblNgaySinhTitle.TabIndex = 0;
            _lblNgaySinhTitle.Text = "Ngày sinh";
            // 
            // _lblNgaySinhValue
            // 
            _lblNgaySinhValue.AutoSize = true;
            _lblNgaySinhValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            _lblNgaySinhValue.Location = new Point(14, 45);
            _lblNgaySinhValue.Name = "_lblNgaySinhValue";
            _lblNgaySinhValue.Size = new Size(111, 25);
            _lblNgaySinhValue.TabIndex = 1;
            _lblNgaySinhValue.Text = "01/01/2000";
            // 
            // _cardDiaChi
            // 
            _cardDiaChi.BackColor = Color.FromArgb(255, 253, 231);
            _cardDiaChi.BorderStyle = BorderStyle.FixedSingle;
            _cardDiaChi.Controls.Add(_lblDiaChiTitle);
            _cardDiaChi.Controls.Add(_lblDiaChiValue);
            _cardDiaChi.Margin = new Padding(10);
            _cardDiaChi.Name = "_cardDiaChi";
            _cardDiaChi.Size = new Size(240, 90);
            _cardDiaChi.TabIndex = 4;
            // 
            // _lblDiaChiTitle
            // 
            _lblDiaChiTitle.AutoSize = true;
            _lblDiaChiTitle.ForeColor = Color.FromArgb(198, 40, 40);
            _lblDiaChiTitle.Location = new Point(14, 12);
            _lblDiaChiTitle.Name = "_lblDiaChiTitle";
            _lblDiaChiTitle.Size = new Size(55, 20);
            _lblDiaChiTitle.TabIndex = 0;
            _lblDiaChiTitle.Text = "Địa chỉ";
            // 
            // _lblDiaChiValue
            // 
            _lblDiaChiValue.AutoSize = true;
            _lblDiaChiValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            _lblDiaChiValue.Location = new Point(14, 45);
            _lblDiaChiValue.Name = "_lblDiaChiValue";
            _lblDiaChiValue.Size = new Size(104, 25);
            _lblDiaChiValue.TabIndex = 1;
            _lblDiaChiValue.Text = "TP.HCM, VN";
            // 
            // _cardSoDienThoai
            // 
            _cardSoDienThoai.BackColor = Color.FromArgb(255, 253, 231);
            _cardSoDienThoai.BorderStyle = BorderStyle.FixedSingle;
            _cardSoDienThoai.Controls.Add(_lblSoDienThoaiTitle);
            _cardSoDienThoai.Controls.Add(_lblSoDienThoaiValue);
            _cardSoDienThoai.Margin = new Padding(10);
            _cardSoDienThoai.Name = "_cardSoDienThoai";
            _cardSoDienThoai.Size = new Size(240, 90);
            _cardSoDienThoai.TabIndex = 5;
            // 
            // _lblSoDienThoaiTitle
            // 
            _lblSoDienThoaiTitle.AutoSize = true;
            _lblSoDienThoaiTitle.ForeColor = Color.FromArgb(198, 40, 40);
            _lblSoDienThoaiTitle.Location = new Point(14, 12);
            _lblSoDienThoaiTitle.Name = "_lblSoDienThoaiTitle";
            _lblSoDienThoaiTitle.Size = new Size(97, 20);
            _lblSoDienThoaiTitle.TabIndex = 0;
            _lblSoDienThoaiTitle.Text = "Số điện thoại";
            // 
            // _lblSoDienThoaiValue
            // 
            _lblSoDienThoaiValue.AutoSize = true;
            _lblSoDienThoaiValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            _lblSoDienThoaiValue.Location = new Point(14, 45);
            _lblSoDienThoaiValue.Name = "_lblSoDienThoaiValue";
            _lblSoDienThoaiValue.Size = new Size(110, 25);
            _lblSoDienThoaiValue.TabIndex = 1;
            _lblSoDienThoaiValue.Text = "0909xxxxxx";
            // 
            // _cardEmail
            // 
            _cardEmail.BackColor = Color.FromArgb(255, 253, 231);
            _cardEmail.BorderStyle = BorderStyle.FixedSingle;
            _cardEmail.Controls.Add(_lblEmailTitle);
            _cardEmail.Controls.Add(_lblEmailValue);
            _cardEmail.Margin = new Padding(10);
            _cardEmail.Name = "_cardEmail";
            _cardEmail.Size = new Size(240, 90);
            _cardEmail.TabIndex = 6;
            // 
            // _lblEmailTitle
            // 
            _lblEmailTitle.AutoSize = true;
            _lblEmailTitle.ForeColor = Color.FromArgb(198, 40, 40);
            _lblEmailTitle.Location = new Point(14, 12);
            _lblEmailTitle.Name = "_lblEmailTitle";
            _lblEmailTitle.Size = new Size(46, 20);
            _lblEmailTitle.TabIndex = 0;
            _lblEmailTitle.Text = "Email";
            // 
            // _lblEmailValue
            // 
            _lblEmailValue.AutoSize = true;
            _lblEmailValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            _lblEmailValue.Location = new Point(14, 45);
            _lblEmailValue.Name = "_lblEmailValue";
            _lblEmailValue.Size = new Size(163, 25);
            _lblEmailValue.TabIndex = 1;
            _lblEmailValue.Text = "abc@winmart.local";
            // 
            // _cardChucVuPhongBan
            // 
            _cardChucVuPhongBan.BackColor = Color.FromArgb(255, 253, 231);
            _cardChucVuPhongBan.BorderStyle = BorderStyle.FixedSingle;
            _cardChucVuPhongBan.Controls.Add(_lblChucVuPhongBanTitle);
            _cardChucVuPhongBan.Controls.Add(_lblChucVuPhongBanValue);
            _cardChucVuPhongBan.Margin = new Padding(10);
            _cardChucVuPhongBan.Name = "_cardChucVuPhongBan";
            _cardChucVuPhongBan.Size = new Size(240, 90);
            _cardChucVuPhongBan.TabIndex = 7;
            // 
            // _lblChucVuPhongBanTitle
            // 
            _lblChucVuPhongBanTitle.AutoSize = true;
            _lblChucVuPhongBanTitle.ForeColor = Color.FromArgb(198, 40, 40);
            _lblChucVuPhongBanTitle.Location = new Point(14, 12);
            _lblChucVuPhongBanTitle.Name = "_lblChucVuPhongBanTitle";
            _lblChucVuPhongBanTitle.Size = new Size(138, 20);
            _lblChucVuPhongBanTitle.TabIndex = 0;
            _lblChucVuPhongBanTitle.Text = "Chức vụ / Phòng ban";
            // 
            // _lblChucVuPhongBanValue
            // 
            _lblChucVuPhongBanValue.AutoSize = true;
            _lblChucVuPhongBanValue.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            _lblChucVuPhongBanValue.Location = new Point(14, 45);
            _lblChucVuPhongBanValue.Name = "_lblChucVuPhongBanValue";
            _lblChucVuPhongBanValue.Size = new Size(154, 25);
            _lblChucVuPhongBanValue.TabIndex = 1;
            _lblChucVuPhongBanValue.Text = "Nhân viên / Sales";
            // 
            // _btnDoiMatKhau
            // 
            _btnDoiMatKhau.BackColor = Color.FromArgb(198, 40, 40);
            _btnDoiMatKhau.FlatStyle = FlatStyle.Flat;
            _btnDoiMatKhau.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            _btnDoiMatKhau.ForeColor = Color.White;
            _btnDoiMatKhau.Location = new Point(680, 505);
            _btnDoiMatKhau.Name = "_btnDoiMatKhau";
            _btnDoiMatKhau.Size = new Size(180, 46);
            _btnDoiMatKhau.TabIndex = 2;
            _btnDoiMatKhau.Text = "Đổi mật khẩu";
            _btnDoiMatKhau.UseVisualStyleBackColor = false;
            _btnDoiMatKhau.Click += btnDoiMatKhau_Click;
            // 
            // _btnCapNhat
            // 
            _btnCapNhat.BackColor = Color.FromArgb(198, 40, 40);
            _btnCapNhat.FlatStyle = FlatStyle.Flat;
            _btnCapNhat.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            _btnCapNhat.ForeColor = Color.White;
            _btnCapNhat.Location = new Point(880, 505);
            _btnCapNhat.Name = "_btnCapNhat";
            _btnCapNhat.Size = new Size(200, 46);
            _btnCapNhat.TabIndex = 3;
            _btnCapNhat.Text = "Cập nhật thông tin";
            _btnCapNhat.UseVisualStyleBackColor = false;
            _btnCapNhat.Click += btnCapNhat_Click;
            // 
            // CaiDatProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1100, 580);
            Controls.Add(_btnCapNhat);
            Controls.Add(_btnDoiMatKhau);
            Controls.Add(_flpInfoCards);
            Controls.Add(_pnlHeader);
            Name = "CaiDatProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "15. Cài đặt / Profile";
            Load += CaiDatProfileForm_Load;
            _pnlHeader.ResumeLayout(false);
            _pnlHeader.PerformLayout();
            _flpInfoCards.ResumeLayout(false);
            _cardUserName.ResumeLayout(false);
            _cardUserName.PerformLayout();
            _cardMaNhanVien.ResumeLayout(false);
            _cardMaNhanVien.PerformLayout();
            _cardHoTen.ResumeLayout(false);
            _cardHoTen.PerformLayout();
            _cardNgaySinh.ResumeLayout(false);
            _cardNgaySinh.PerformLayout();
            _cardDiaChi.ResumeLayout(false);
            _cardDiaChi.PerformLayout();
            _cardSoDienThoai.ResumeLayout(false);
            _cardSoDienThoai.PerformLayout();
            _cardEmail.ResumeLayout(false);
            _cardEmail.PerformLayout();
            _cardChucVuPhongBan.ResumeLayout(false);
            _cardChucVuPhongBan.PerformLayout();
            ResumeLayout(false);
        }
    }
}
