using System.Windows.Forms;

namespace WinFormsAppTest
{
    public sealed class NhanVienProfileDialog : Form
    {
        private TextBox txtHoTen;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtDiaChi;
        private TextBox txtSoDienThoai;
        private ComboBox cboPhongBan;
        private ComboBox cboChucVu;
        private Button btnOk;
        private Button btnCancel;

        public string HoTen { get => txtHoTen.Text; set => txtHoTen.Text = value; }
        public DateTime NgaySinh { get => dtpNgaySinh.Value; set => dtpNgaySinh.Value = value; }
        public string DiaChi { get => txtDiaChi.Text; set => txtDiaChi.Text = value; }
        public string SoDienThoai { get => txtSoDienThoai.Text; set => txtSoDienThoai.Text = value; }
        public string PhongBan { get => cboPhongBan.SelectedItem?.ToString() ?? string.Empty; set => cboPhongBan.SelectedItem = value; }
        public string ChucVu { get => cboChucVu.SelectedItem?.ToString() ?? string.Empty; set => cboChucVu.SelectedItem = value; }

        public NhanVienProfileDialog()
        {
            Text = "Cập nhật thông tin nhân viên";
            Width = 520;
            Height = 420;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = Color.White;

            int y = 15;
            const int labelWidth = 140;
            const int inputWidth = 320;
            const int labelX = 20;
            const int inputX = 170;
            const int rowHeight = 40;

            Controls.Add(CreateLabel("Họ và tên", labelX, y, labelWidth));
            txtHoTen = CreateTextBox(inputX, y, inputWidth);
            Controls.Add(txtHoTen);
            y += rowHeight;

            Controls.Add(CreateLabel("Ngày sinh", labelX, y, labelWidth));
            dtpNgaySinh = new DateTimePicker { Left = inputX, Top = y - 2, Width = inputWidth, Format = DateTimePickerFormat.Short };
            Controls.Add(dtpNgaySinh);
            y += rowHeight;

            Controls.Add(CreateLabel("Địa chỉ", labelX, y, labelWidth));
            txtDiaChi = CreateTextBox(inputX, y, inputWidth);
            Controls.Add(txtDiaChi);
            y += rowHeight;

            Controls.Add(CreateLabel("Số điện thoại", labelX, y, labelWidth));
            txtSoDienThoai = CreateTextBox(inputX, y, inputWidth);
            Controls.Add(txtSoDienThoai);
            y += rowHeight;

            Controls.Add(CreateLabel("Chức vụ", labelX, y, labelWidth));
            cboChucVu = new ComboBox
            {
                Left = inputX,
                Top = y - 2,
                Width = inputWidth,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 9F)
            };
            cboChucVu.Items.AddRange(new[] { "Giam doc", "Quan ly cua hang", "Nhan vien" });
            Controls.Add(cboChucVu);
            y += rowHeight;

            Controls.Add(CreateLabel("Phòng ban", labelX, y, labelWidth));
            cboPhongBan = new ComboBox
            {
                Left = inputX,
                Top = y - 2,
                Width = inputWidth,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 9F)
            };
            Controls.Add(cboPhongBan);
            y += rowHeight + 10;

            btnOk = new Button
            {
                Text = "Lưu",
                Left = 300,
                Width = 80,
                Top = y,
                Height = 32,
                BackColor = Color.FromArgb(198, 40, 40),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F),
                DialogResult = DialogResult.OK,
                FlatStyle = FlatStyle.Flat
            };
            btnCancel = new Button
            {
                Text = "Hủy",
                Left = 390,
                Width = 80,
                Top = y,
                Height = 32,
                BackColor = Color.FromArgb(97, 97, 97),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F),
                DialogResult = DialogResult.Cancel,
                FlatStyle = FlatStyle.Flat
            };

            Controls.Add(btnOk);
            Controls.Add(btnCancel);

            AcceptButton = btnOk;
            CancelButton = btnCancel;

            cboChucVu.SelectedIndexChanged += (_, _) => UpdatePhongBanOptions();
            btnOk.Click += OnOkClick;

            cboChucVu.SelectedItem = "Nhan vien";
        }

        private void UpdatePhongBanOptions()
        {
            string? selected = cboChucVu.SelectedItem?.ToString();
            cboPhongBan.Items.Clear();

            if (selected is "Giam doc" or "Quan ly cua hang")
            {
                cboPhongBan.Items.Add("Ban quan ly");
                cboPhongBan.SelectedItem = "Ban quan ly";
                cboPhongBan.Enabled = false;
            }
            else
            {
                cboPhongBan.Items.AddRange(new[] { "Ban hang", "Kho", "Ke toan" });
                cboPhongBan.SelectedIndex = 0;
                cboPhongBan.Enabled = true;
            }
        }

        private void OnOkClick(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text)
                || string.IsNullOrWhiteSpace(txtDiaChi.Text)
                || string.IsNullOrWhiteSpace(txtSoDienThoai.Text)
                || cboChucVu.SelectedItem is null
                || cboPhongBan.SelectedItem is null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.");
                DialogResult = DialogResult.None;
                return;
            }

            if (!InputValidator.IsValidName(txtHoTen.Text))
            {
                ShowInvalid("họ tên");
                DialogResult = DialogResult.None;
                return;
            }

            if (DateTime.Today < dtpNgaySinh.Value.Date.AddYears(18))
            {
                MessageBox.Show("Thông tin ngày sinh không hợp lệ vui lòng nhập lại.");
                DialogResult = DialogResult.None;
                return;
            }

            if (!InputValidator.IsValidPhone(txtSoDienThoai.Text))
            {
                ShowInvalid("số điện thoại");
                DialogResult = DialogResult.None;
                return;
            }
        }

        private static Label CreateLabel(string text, int x, int y, int width)
        {
            return new Label
            {
                Text = text,
                Left = x,
                Top = y + 3,
                Width = width,
                Font = new Font("Segoe UI", 9F),
                AutoSize = false
            };
        }

        private static TextBox CreateTextBox(int x, int y, int width)
        {
            return new TextBox
            {
                Left = x,
                Top = y,
                Width = width,
                BorderStyle = BorderStyle.FixedSingle,
                Font = new Font("Segoe UI", 9F)
            };
        }

        private static void ShowInvalid(string field)
        {
            MessageBox.Show($"Thông tin {field} không hợp lệ vui lòng nhập lại.");
        }
    }
}
