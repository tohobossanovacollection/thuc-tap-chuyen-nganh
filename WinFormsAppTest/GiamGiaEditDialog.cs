using System.Windows.Forms;

namespace WinFormsAppTest
{
    // Dialog to add/edit discount code
    public class GiamGiaEditDialog : Form
    {
        private TextBox txtMa;
        private ComboBox cmbLoaiGiamGia;
        private NumericUpDown nudPhanTramGiam;
        private NumericUpDown nudSoTienGiam;
        private NumericUpDown nudSoLuongSuDung;
        private DateTimePicker dtpNgayBatDau;
        private DateTimePicker dtpNgayKetThuc;
        private ComboBox cmbTrangThai;
        private Button btnOk;
        private Button btnCancel;

        public string Ma { get => txtMa.Text; set => txtMa.Text = value; }
        public decimal PhanTramGiam { get => nudPhanTramGiam.Value; set => nudPhanTramGiam.Value = value; }
        public decimal SoTienGiam { get => nudSoTienGiam.Value; set => nudSoTienGiam.Value = value; }
        public int SoLuongSuDung { get => (int)nudSoLuongSuDung.Value; set => nudSoLuongSuDung.Value = value; }
        public DateTime NgayBatDau { get => dtpNgayBatDau.Value; set => dtpNgayBatDau.Value = value; }
        public DateTime NgayKetThuc { get => dtpNgayKetThuc.Value; set => dtpNgayKetThuc.Value = value; }
        public string TrangThai { get => cmbTrangThai.SelectedItem?.ToString() ?? "ACTIVE"; set => cmbTrangThai.SelectedItem = value; }
        public bool IsPercentDiscount => cmbLoaiGiamGia.SelectedItem?.ToString() == "Phần trăm";

        public void SetMaReadOnly(bool readOnly)
        {
            txtMa.Enabled = !readOnly;
        }

        public void SetLoaiGiamGia(bool isPercent)
        {
            cmbLoaiGiamGia.SelectedItem = isPercent ? "Phần trăm" : "Số tiền";
            UpdateDiscountTypeState();
        }

        public void EnableValueOnlyEdit()
        {
            foreach (Control ctrl in Controls)
            {
                if (ctrl is Button)
                {
                    continue;
                }

                ctrl.Enabled = false;
            }

            if (IsPercentDiscount)
            {
                nudPhanTramGiam.Enabled = true;
            }
            else
            {
                nudSoTienGiam.Enabled = true;
            }
        }

        public GiamGiaEditDialog()
        {
            Text = "Thêm/Sửa mã giảm giá";
            Width = 500;
            Height = 570;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterParent;
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = Color.White;

            var lbl1 = new Label() 
            { 
                Text = "Mã giảm giá", 
                Left = 20, 
                Top = 20, 
                Width = 150,
                Font = new Font("Segoe UI", 9F)
            };
            txtMa = new TextBox() 
            { 
                Left = 180, 
                Top = 16, 
                Width = 280,
                BorderStyle = BorderStyle.FixedSingle
            };

            var lbl2 = new Label() 
            { 
                Text = "Loại giảm giá", 
                Left = 20, 
                Top = 55, 
                Width = 150,
                Font = new Font("Segoe UI", 9F)
            };
            cmbLoaiGiamGia = new ComboBox()
            {
                Left = 180,
                Top = 51,
                Width = 280,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbLoaiGiamGia.Items.AddRange(new[] { "Phần trăm", "Số tiền" });
            cmbLoaiGiamGia.SelectedItem = "Phần trăm";

            var lbl3 = new Label() 
            { 
                Text = "Phần trăm giảm (%)", 
                Left = 20, 
                Top = 90, 
                Width = 150,
                Font = new Font("Segoe UI", 9F)
            };
            nudPhanTramGiam = new NumericUpDown() 
            { 
                Left = 180, 
                Top = 86, 
                Width = 280,
                Minimum = 0,
                Maximum = 100,
                DecimalPlaces = 2,
                BorderStyle = BorderStyle.FixedSingle
            };

            var lbl4 = new Label() 
            { 
                Text = "Số tiền giảm (VND)", 
                Left = 20, 
                Top = 125, 
                Width = 150,
                Font = new Font("Segoe UI", 9F)
            };
            nudSoTienGiam = new NumericUpDown() 
            { 
                Left = 180, 
                Top = 121, 
                Width = 280,
                Minimum = 0,
                Maximum = 999999999,
                DecimalPlaces = 2,
                BorderStyle = BorderStyle.FixedSingle
            };

            var lbl5 = new Label() 
            { 
                Text = "Số lượng sử dụng", 
                Left = 20, 
                Top = 160, 
                Width = 150,
                Font = new Font("Segoe UI", 9F)
            };
            nudSoLuongSuDung = new NumericUpDown() 
            { 
                Left = 180, 
                Top = 156, 
                Width = 280,
                Minimum = 0,
                Maximum = 999999,
                BorderStyle = BorderStyle.FixedSingle
            };

            var lbl6 = new Label() 
            { 
                Text = "Ngày bắt đầu", 
                Left = 20, 
                Top = 195, 
                Width = 150,
                Font = new Font("Segoe UI", 9F)
            };
            dtpNgayBatDau = new DateTimePicker() 
            { 
                Left = 180, 
                Top = 191, 
                Width = 280,
                Format = DateTimePickerFormat.Short
            };

            var lbl7 = new Label() 
            { 
                Text = "Ngày kết thúc", 
                Left = 20, 
                Top = 230, 
                Width = 150,
                Font = new Font("Segoe UI", 9F)
            };
            dtpNgayKetThuc = new DateTimePicker() 
            { 
                Left = 180, 
                Top = 226, 
                Width = 280,
                Format = DateTimePickerFormat.Short
            };

            var lbl8 = new Label() 
            { 
                Text = "Trạng thái", 
                Left = 20, 
                Top = 265, 
                Width = 150,
                Font = new Font("Segoe UI", 9F)
            };
            cmbTrangThai = new ComboBox() 
            { 
                Left = 180, 
                Top = 261, 
                Width = 280,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cmbTrangThai.Items.AddRange(new[] { "ACTIVE", "INACTIVE", "EXPIRED" });
            cmbTrangThai.SelectedItem = "ACTIVE";

            btnOk = new Button() 
            { 
                Text = "Lưu", 
                Left = 310, 
                Width = 70, 
                Top = 500,
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
                Left = 390, 
                Width = 70, 
                Top = 500,
                Height = 32,
                BackColor = Color.FromArgb(97, 97, 97),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F),
                DialogResult = DialogResult.Cancel,
                FlatStyle = FlatStyle.Flat
            };

            Controls.AddRange(new Control[] 
            { 
                lbl1, txtMa, lbl2, cmbLoaiGiamGia, lbl3, nudPhanTramGiam, lbl4, nudSoTienGiam, lbl5, nudSoLuongSuDung,
                lbl6, dtpNgayBatDau, lbl7, dtpNgayKetThuc, lbl8, cmbTrangThai, btnOk, btnCancel 
            });

            AcceptButton = btnOk;
            CancelButton = btnCancel;

            cmbLoaiGiamGia.SelectedIndexChanged += (_, _) => UpdateDiscountTypeState();
            btnOk.Click += OnOkClick;
            UpdateDiscountTypeState();
        }

        private void UpdateDiscountTypeState()
        {
            bool isPercent = IsPercentDiscount;
            nudPhanTramGiam.Enabled = isPercent;
            nudSoTienGiam.Enabled = !isPercent;

            if (isPercent)
            {
                nudSoTienGiam.Value = 0;
            }
            else
            {
                nudPhanTramGiam.Value = 0;
            }
        }

        private void OnOkClick(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMa.Text))
            {
                ShowInvalid("mã giảm giá");
                DialogResult = DialogResult.None;
                return;
            }

            if (IsPercentDiscount)
            {
                if (nudPhanTramGiam.Value <= 0)
                {
                    ShowInvalid("phần trăm giảm");
                    DialogResult = DialogResult.None;
                    return;
                }
            }
            else
            {
                if (nudSoTienGiam.Value <= 0)
                {
                    ShowInvalid("số tiền giảm");
                    DialogResult = DialogResult.None;
                    return;
                }
            }
        }

        private static void ShowInvalid(string field)
        {
            MessageBox.Show($"Thông tin {field} không hợp lệ vui lòng nhập lại.");
        }
    }
}
