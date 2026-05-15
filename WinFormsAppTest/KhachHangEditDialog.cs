using System.Windows.Forms;

namespace WinFormsAppTest
{
    // small dialog to add/edit customer
    public class KhachHangEditDialog : Form
    {
        private TextBox txtMa;
        private TextBox txtTen;
        private TextBox txtDienThoai;
        private TextBox txtDiaChi;
        private Button btnOk;
        private Button btnCancel;

        public string Ma { get => txtMa.Text; set => txtMa.Text = value; }
        public string Ten { get => txtTen.Text; set => txtTen.Text = value; }
        public string DienThoai { get => txtDienThoai.Text; set => txtDienThoai.Text = value; }
        public string DiaChi { get => txtDiaChi.Text; set => txtDiaChi.Text = value; }

        public void SetMaReadOnly(bool readOnly)
        {
            txtMa.ReadOnly = readOnly;
        }

        public KhachHangEditDialog()
        {
            Text = "Thêm/Sửa khách hàng";
            Width = 450;
            Height = 320;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = Color.White;

            var lbl1 = new Label() 
            { 
                Text = "Mã khách hàng", 
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
                Text = "Tên khách hàng", 
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
                Text = "Địa chỉ", 
                Left = 20, 
                Top = 125, 
                Width = 120,
                Font = new Font("Segoe UI", 9F)
            };
            txtDiaChi = new TextBox() 
            { 
                Left = 150, 
                Top = 121, 
                Width = 260,
                Height = 60,
                Multiline = true,
                BorderStyle = BorderStyle.FixedSingle
            };

            btnOk = new Button() 
            { 
                Text = "Lưu", 
                Left = 260, 
                Width = 70, 
                Top = 250,
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
                Top = 250,
                Height = 32,
                BackColor = Color.FromArgb(97, 97, 97),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F),
                DialogResult = DialogResult.Cancel,
                FlatStyle = FlatStyle.Flat
            };

            Controls.AddRange(new Control[] { lbl1, txtMa, lbl2, txtTen, lbl3, txtDienThoai, lbl4, txtDiaChi, btnOk, btnCancel });

            AcceptButton = btnOk;
            CancelButton = btnCancel;

            btnOk.Click += OnOkClick;
        }

        private void OnOkClick(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text))
            {
                ShowInvalid("mã khách hàng");
                DialogResult = DialogResult.None;
                return;
            }

            if (!InputValidator.IsValidName(txtTen.Text))
            {
                ShowInvalid("tên khách hàng");
                DialogResult = DialogResult.None;
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtDienThoai.Text) && !InputValidator.IsValidPhone(txtDienThoai.Text))
            {
                ShowInvalid("số điện thoại");
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
