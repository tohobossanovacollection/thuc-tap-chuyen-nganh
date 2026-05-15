using System.Windows.Forms;

namespace WinFormsAppTest
{
    // Dialog to add/edit supplier
    public class NhaCungCapEditDialog : Form
    {
        private TextBox txtMa;
        private TextBox txtTen;
        private TextBox txtDienThoai;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private Button btnOk;
        private Button btnCancel;

        public string Ma { get => txtMa.Text; set => txtMa.Text = value; }
        public string Ten { get => txtTen.Text; set => txtTen.Text = value; }
        public string DienThoai { get => txtDienThoai.Text; set => txtDienThoai.Text = value; }
        public string DiaChi { get => txtDiaChi.Text; set => txtDiaChi.Text = value; }
        public string Email { get => txtEmail.Text; set => txtEmail.Text = value; }

        public void SetMaReadOnly(bool readOnly)
        {
            txtMa.ReadOnly = readOnly;
        }

        public NhaCungCapEditDialog()
        {
            Text = "Thêm/Sửa nhà cung cấp";
            Width = 450;
            Height = 380;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = Color.White;

            var lbl1 = new Label() 
            { 
                Text = "Mã nhà cung cấp", 
                Left = 20, 
                Top = 20, 
                Width = 120,
                Font = new Font("Segoe UI", 9F)
            };
            txtMa = new TextBox() 
            { 
                Left = 150, 
                Top = 16, 
                Width = 260,
                BorderStyle = BorderStyle.FixedSingle
            };

            var lbl2 = new Label() 
            { 
                Text = "Tên nhà cung cấp", 
                Left = 20, 
                Top = 55, 
                Width = 120,
                Font = new Font("Segoe UI", 9F)
            };
            txtTen = new TextBox() 
            { 
                Left = 150, 
                Top = 51, 
                Width = 260,
                BorderStyle = BorderStyle.FixedSingle
            };

            var lbl3 = new Label() 
            { 
                Text = "Số điện thoại", 
                Left = 20, 
                Top = 90, 
                Width = 120,
                Font = new Font("Segoe UI", 9F)
            };
            txtDienThoai = new TextBox() 
            { 
                Left = 150, 
                Top = 86, 
                Width = 260,
                BorderStyle = BorderStyle.FixedSingle
            };

            var lbl4 = new Label() 
            { 
                Text = "Email", 
                Left = 20, 
                Top = 125, 
                Width = 120,
                Font = new Font("Segoe UI", 9F)
            };
            txtEmail = new TextBox() 
            { 
                Left = 150, 
                Top = 121, 
                Width = 260,
                BorderStyle = BorderStyle.FixedSingle
            };

            var lbl5 = new Label() 
            { 
                Text = "Địa chỉ", 
                Left = 20, 
                Top = 160, 
                Width = 120,
                Font = new Font("Segoe UI", 9F)
            };
            txtDiaChi = new TextBox() 
            { 
                Left = 150, 
                Top = 156, 
                Width = 260,
                Height = 80,
                Multiline = true,
                BorderStyle = BorderStyle.FixedSingle
            };

            btnOk = new Button() 
            { 
                Text = "Lưu", 
                Left = 260, 
                Width = 70, 
                Top = 310,
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
                Left = 340, 
                Width = 70, 
                Top = 310,
                Height = 32,
                BackColor = Color.FromArgb(97, 97, 97),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F),
                DialogResult = DialogResult.Cancel,
                FlatStyle = FlatStyle.Flat
            };

            Controls.AddRange(new Control[] { lbl1, txtMa, lbl2, txtTen, lbl3, txtDienThoai, lbl4, txtEmail, lbl5, txtDiaChi, btnOk, btnCancel });

            AcceptButton = btnOk;
            CancelButton = btnCancel;

            btnOk.Click += OnOkClick;
        }

        private void OnOkClick(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text))
            {
                ShowInvalid("mã nhà cung cấp");
                DialogResult = DialogResult.None;
                return;
            }

            if (!InputValidator.IsValidName(txtTen.Text))
            {
                ShowInvalid("tên nhà cung cấp");
                DialogResult = DialogResult.None;
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtDienThoai.Text) && !InputValidator.IsValidPhone(txtDienThoai.Text))
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
        }

        private static void ShowInvalid(string field)
        {
            MessageBox.Show($"Thông tin {field} không hợp lệ vui lòng nhập lại.");
        }
    }
}
