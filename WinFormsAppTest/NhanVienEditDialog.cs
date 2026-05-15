using System.Windows.Forms;

namespace WinFormsAppTest
{
    // Dialog to add/edit employee
    public class NhanVienEditDialog : Form
    {
        private TextBox txtMa;
        private TextBox txtHoTen;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtDiaChi;
        private TextBox txtSoDienThoai;
        private TextBox txtEmail;
        private TextBox txtChucVu;
        private TextBox txtPhongBan;
        private ComboBox cboTrangThai;
        private Button btnOk;
        private Button btnCancel;

        public string Ma { get => txtMa.Text; set => txtMa.Text = value; }
        public string HoTen { get => txtHoTen.Text; set => txtHoTen.Text = value; }
        public DateTime? NgaySinh { get => dtpNgaySinh.Value == DateTime.MinValue ? null : dtpNgaySinh.Value; set => dtpNgaySinh.Value = value ?? DateTime.Today; }
        public string DiaChi { get => txtDiaChi.Text; set => txtDiaChi.Text = value; }
        public string SoDienThoai { get => txtSoDienThoai.Text; set => txtSoDienThoai.Text = value; }
        public string Email { get => txtEmail.Text; set => txtEmail.Text = value; }
        public string ChucVu { get => txtChucVu.Text; set => txtChucVu.Text = value; }
        public string PhongBan { get => txtPhongBan.Text; set => txtPhongBan.Text = value; }
        public string TrangThai { get => cboTrangThai.SelectedItem?.ToString() ?? "ACTIVE"; set => cboTrangThai.SelectedItem = value; }

        public void SetMaReadOnly(bool readOnly)
        {
            txtMa.ReadOnly = readOnly;
        }

        public NhanVienEditDialog()
        {
            Text = "Thêm/Sửa nhân viên";
            Width = 500;
            Height = 550;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = Color.White;

            int y = 15;
            const int labelWidth = 120;
            const int inputWidth = 340;
            const int labelX = 20;
            const int inputX = 150;
            const int rowHeight = 35;

            // Mã nhân viên
            var lblMa = CreateLabel("Mã nhân viên", labelX, y, labelWidth);
            txtMa = CreateTextBox(inputX, y, inputWidth);
            y += rowHeight;

            // Họ tên
            var lblHoTen = CreateLabel("Họ tên", labelX, y, labelWidth);
            txtHoTen = CreateTextBox(inputX, y, inputWidth);
            y += rowHeight;

            // Ngày sinh
            var lblNgaySinh = CreateLabel("Ngày sinh", labelX, y, labelWidth);
            dtpNgaySinh = new DateTimePicker() { Left = inputX, Top = y - 2, Width = inputWidth, Format = DateTimePickerFormat.Short };
            y += rowHeight;

            // Địa chỉ
            var lblDiaChi = CreateLabel("Địa chỉ", labelX, y, labelWidth);
            txtDiaChi = CreateTextBox(inputX, y, inputWidth);
            y += rowHeight;

            // Số điện thoại
            var lblSoDienThoai = CreateLabel("Số điện thoại", labelX, y, labelWidth);
            txtSoDienThoai = CreateTextBox(inputX, y, inputWidth);
            y += rowHeight;

            // Email
            var lblEmail = CreateLabel("Email", labelX, y, labelWidth);
            txtEmail = CreateTextBox(inputX, y, inputWidth);
            y += rowHeight;

            // Chức vụ
            var lblChucVu = CreateLabel("Chức vụ", labelX, y, labelWidth);
            txtChucVu = CreateTextBox(inputX, y, inputWidth);
            y += rowHeight;

            // Phòng ban
            var lblPhongBan = CreateLabel("Phòng ban", labelX, y, labelWidth);
            txtPhongBan = CreateTextBox(inputX, y, inputWidth);
            y += rowHeight;

            // Trạng thái
            var lblTrangThai = CreateLabel("Trạng thái", labelX, y, labelWidth);
            cboTrangThai = new ComboBox() 
            { 
                Left = inputX, 
                Top = y - 2, 
                Width = inputWidth,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 9F)
            };
            cboTrangThai.Items.AddRange(new[] { "ACTIVE", "INACTIVE" });
            cboTrangThai.SelectedItem = "ACTIVE";
            y += rowHeight;

            // Buttons
            btnOk = new Button() 
            { 
                Text = "Lưu", 
                Left = 290, 
                Width = 70, 
                Top = y + 10,
                Height = 32,
                BackColor = Color.FromArgb(198, 40, 40),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F),
                DialogResult = DialogResult.OK,
                FlatStyle = FlatStyle.Flat
            };
            btnCancel = new Button() 
            { 
                Text = "Hủy", 
                Left = 370, 
                Width = 70, 
                Top = y + 10,
                Height = 32,
                BackColor = Color.FromArgb(97, 97, 97),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F),
                DialogResult = DialogResult.Cancel,
                FlatStyle = FlatStyle.Flat
            };

            Controls.AddRange(new Control[] 
            { 
                lblMa, txtMa, 
                lblHoTen, txtHoTen, 
                lblNgaySinh, dtpNgaySinh,
                lblDiaChi, txtDiaChi, 
                lblSoDienThoai, txtSoDienThoai, 
                lblEmail, txtEmail,
                lblChucVu, txtChucVu,
                lblPhongBan, txtPhongBan,
                lblTrangThai, cboTrangThai,
                btnOk, btnCancel 
            });

            AcceptButton = btnOk;
            CancelButton = btnCancel;

            btnOk.Click += OnOkClick;
        }

        private void OnOkClick(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text))
            {
                ShowInvalid("mã nhân viên");
                DialogResult = DialogResult.None;
                return;
            }

            if (!InputValidator.IsValidName(txtHoTen.Text))
            {
                ShowInvalid("họ tên");
                DialogResult = DialogResult.None;
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtSoDienThoai.Text) && !InputValidator.IsValidPhone(txtSoDienThoai.Text))
            {
                ShowInvalid("số điện thoại");
                DialogResult = DialogResult.None;
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !InputValidator.IsValidEmail(txtEmail.Text))
            {
                ShowInvalid("email");
                DialogResult = DialogResult.None;
                return;
            }

            if (DateTime.Today < dtpNgaySinh.Value.Date.AddYears(18))
            {
                MessageBox.Show("Thông tin ngày sinh không hợp lệ vui lòng nhập lại.");
                DialogResult = DialogResult.None;
            }
        }

        private static void ShowInvalid(string field)
        {
            MessageBox.Show($"Thông tin {field} không hợp lệ vui lòng nhập lại.");
        }

        private Label CreateLabel(string text, int x, int y, int width)
        {
            return new Label() 
            { 
                Text = text, 
                Left = x, 
                Top = y + 3, 
                Width = width,
                Font = new Font("Segoe UI", 9F),
                AutoSize = false
            };
        }

        private TextBox CreateTextBox(int x, int y, int width)
        {
            return new TextBox() 
            { 
                Left = x, 
                Top = y, 
                Width = width,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Segoe UI", 9F)
            };
        }
    }
}
