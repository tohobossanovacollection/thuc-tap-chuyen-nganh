using System.Data;
using Microsoft.Data.SqlClient;

namespace WinFormsAppTest
{
    public partial class QuanLyGiamGiaForm : Form
    {
        private readonly string _connectionString = DatabaseConfig.ConnectionString;

        public QuanLyGiamGiaForm()
        {
            InitializeComponent();
            _dgv.CellClick += (s, e) => UpdateButtonStates();
        }

        private void QuanLyGiamGiaForm_Load(object sender, EventArgs e)
        {
            LoadDiscountCodes();
        }

        private void LoadDiscountCodes()
        {
            const string query = @"SELECT ma_giam_gia, phan_tram_giam, so_tien_giam, so_luong_su_dung, 
                                           ngay_bat_dau, ngay_ket_thuc, trang_thai 
                                    FROM giam_gia 
                                    ORDER BY ngay_bat_dau DESC";
            try
            {
                using SqlConnection conn = new SqlConnection(_connectionString);
                using SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                _dgv.AutoGenerateColumns = false;
                _dgv.ReadOnly = true;
                _dgv.Columns.Clear();

                _dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "ma_giam_gia", DataPropertyName = "ma_giam_gia", HeaderText = "Mã giảm giá", Width = 120 });
                _dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "phan_tram_giam", DataPropertyName = "phan_tram_giam", HeaderText = "% Giảm", Width = 100 });
                _dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "so_tien_giam", DataPropertyName = "so_tien_giam", HeaderText = "Số tiền giảm", Width = 130 });
                _dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "so_luong_su_dung", DataPropertyName = "so_luong_su_dung", HeaderText = "Lượng sử dụng", Width = 120 });
                _dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "ngay_bat_dau", DataPropertyName = "ngay_bat_dau", HeaderText = "Bắt đầu", Width = 140 });
                _dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "ngay_ket_thuc", DataPropertyName = "ngay_ket_thuc", HeaderText = "Kết thúc", Width = 140 });
                _dgv.Columns.Add(new DataGridViewTextBoxColumn { Name = "trang_thai", DataPropertyName = "trang_thai", HeaderText = "Trạng thái", Width = 100 });

                _dgv.DataSource = dt;
                UpdateButtonStates();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải mã giảm giá: {ex.Message}");
            }
        }

        private void UpdateButtonStates()
        {
            bool hasSelection = _dgv.SelectedRows.Count > 0;
            _btnSet.Enabled = hasSelection;
            _btnTime.Enabled = hasSelection;
            _btnStatus.Enabled = hasSelection;
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            using var dlg = new GiamGiaEditDialog();
            dlg.Ma = CodeGenerator.GetNextCode(_connectionString, "giam_gia", "ma_giam_gia", "GG");
            dlg.SetMaReadOnly(true);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                if (dlg.NgayKetThuc < dlg.NgayBatDau)
                {
                    MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu.");
                    return;
                }

                decimal phanTram = dlg.IsPercentDiscount ? dlg.PhanTramGiam : 0;
                decimal soTien = dlg.IsPercentDiscount ? 0 : dlg.SoTienGiam;

                const string query = @"INSERT INTO giam_gia (ma_giam_gia, phan_tram_giam, so_tien_giam, 
                                                             so_luong_su_dung, ngay_bat_dau, ngay_ket_thuc, trang_thai) 
                                       VALUES (@ma, @phanTram, @soTien, @soLuong, @ngayBatDau, @ngayKetThuc, @trangThai)";
                try
                {
                    using SqlConnection conn = new SqlConnection(_connectionString);
                    using SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma", dlg.Ma.Trim());
                    cmd.Parameters.AddWithValue("@phanTram", phanTram);
                    cmd.Parameters.AddWithValue("@soTien", soTien);
                    cmd.Parameters.AddWithValue("@soLuong", dlg.SoLuongSuDung);
                    cmd.Parameters.AddWithValue("@ngayBatDau", dlg.NgayBatDau);
                    cmd.Parameters.AddWithValue("@ngayKetThuc", dlg.NgayKetThuc);
                    cmd.Parameters.AddWithValue("@trangThai", dlg.TrangThai);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadDiscountCodes();
                    MessageBox.Show("Thêm mã giảm giá thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Thêm mã giảm giá thất bại: {ex.Message}");
                }
            }
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (_dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn mã giảm giá để cập nhật.");
                return;
            }

            var row = _dgv.SelectedRows[0];
            string ma = row.Cells["ma_giam_gia"].Value?.ToString() ?? "";
            decimal phanTram = Convert.ToDecimal(row.Cells["phan_tram_giam"].Value ?? 0);
            decimal soTien = Convert.ToDecimal(row.Cells["so_tien_giam"].Value ?? 0);
            int soLuong = Convert.ToInt32(row.Cells["so_luong_su_dung"].Value ?? 0);
            DateTime ngayBatDau = Convert.ToDateTime(row.Cells["ngay_bat_dau"].Value);
            DateTime ngayKetThuc = Convert.ToDateTime(row.Cells["ngay_ket_thuc"].Value);
            string trangThai = row.Cells["trang_thai"].Value?.ToString() ?? "ACTIVE";

            using var dlg = new GiamGiaEditDialog();
            dlg.Ma = ma;
            dlg.PhanTramGiam = phanTram;
            dlg.SoTienGiam = soTien;
            dlg.SoLuongSuDung = soLuong;
            dlg.NgayBatDau = ngayBatDau;
            dlg.NgayKetThuc = ngayKetThuc;
            dlg.TrangThai = trangThai;
            dlg.Text = "Cập nhật mã giảm giá";
            // Make Ma read-only for edits
            dlg.SetMaReadOnly(true);
            dlg.SetLoaiGiamGia(phanTram > 0);
            dlg.EnableValueOnlyEdit();

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                if (dlg.NgayKetThuc < dlg.NgayBatDau)
                {
                    MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu.");
                    return;
                }

                decimal updatedPhanTram = dlg.IsPercentDiscount ? dlg.PhanTramGiam : 0;
                decimal updatedSoTien = dlg.IsPercentDiscount ? 0 : dlg.SoTienGiam;

                const string query = @"UPDATE giam_gia 
                                       SET phan_tram_giam = @phanTram, so_tien_giam = @soTien, 
                                           so_luong_su_dung = @soLuong, ngay_bat_dau = @ngayBatDau, 
                                           ngay_ket_thuc = @ngayKetThuc, trang_thai = @trangThai
                                       WHERE ma_giam_gia = @ma";
                try
                {
                    using SqlConnection conn = new SqlConnection(_connectionString);
                    using SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma", ma);
                    cmd.Parameters.AddWithValue("@phanTram", updatedPhanTram);
                    cmd.Parameters.AddWithValue("@soTien", updatedSoTien);
                    cmd.Parameters.AddWithValue("@soLuong", dlg.SoLuongSuDung);
                    cmd.Parameters.AddWithValue("@ngayBatDau", dlg.NgayBatDau);
                    cmd.Parameters.AddWithValue("@ngayKetThuc", dlg.NgayKetThuc);
                    cmd.Parameters.AddWithValue("@trangThai", dlg.TrangThai);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadDiscountCodes();
                    MessageBox.Show("Cập nhật mã giảm giá thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Cập nhật mã giảm giá thất bại: {ex.Message}");
                }
            }
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            if (_dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn mã giảm giá để cập nhật thời gian.");
                return;
            }

            var row = _dgv.SelectedRows[0];
            string ma = row.Cells["ma_giam_gia"].Value?.ToString() ?? "";
            decimal phanTram = Convert.ToDecimal(row.Cells["phan_tram_giam"].Value ?? 0);
            decimal soTien = Convert.ToDecimal(row.Cells["so_tien_giam"].Value ?? 0);
            int soLuong = Convert.ToInt32(row.Cells["so_luong_su_dung"].Value ?? 0);
            DateTime ngayBatDau = Convert.ToDateTime(row.Cells["ngay_bat_dau"].Value);
            DateTime ngayKetThuc = Convert.ToDateTime(row.Cells["ngay_ket_thuc"].Value);
            string trangThai = row.Cells["trang_thai"].Value?.ToString() ?? "ACTIVE";

            using var dlg = new GiamGiaEditDialog();
            dlg.Ma = ma;
            dlg.PhanTramGiam = phanTram;
            dlg.SoTienGiam = soTien;
            dlg.SoLuongSuDung = soLuong;
            dlg.NgayBatDau = ngayBatDau;
            dlg.NgayKetThuc = ngayKetThuc;
            dlg.TrangThai = trangThai;
            dlg.Text = "Cập nhật thời gian giảm giá";
            dlg.SetLoaiGiamGia(phanTram > 0);

            // Disable all controls except date controls
            foreach (Control ctrl in dlg.Controls)
            {
                if (!(ctrl is DateTimePicker || ctrl is Button))
                {
                    ctrl.Enabled = false;
                }
            }

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                if (dlg.NgayKetThuc < dlg.NgayBatDau)
                {
                    MessageBox.Show("Ngày kết thúc không được nhỏ hơn ngày bắt đầu.");
                    return;
                }

                const string query = @"UPDATE giam_gia 
                                       SET ngay_bat_dau = @ngayBatDau, ngay_ket_thuc = @ngayKetThuc
                                       WHERE ma_giam_gia = @ma";
                try
                {
                    using SqlConnection conn = new SqlConnection(_connectionString);
                    using SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma", ma);
                    cmd.Parameters.AddWithValue("@ngayBatDau", dlg.NgayBatDau);
                    cmd.Parameters.AddWithValue("@ngayKetThuc", dlg.NgayKetThuc);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadDiscountCodes();
                    MessageBox.Show("Cập nhật thời gian thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Cập nhật thời gian thất bại: {ex.Message}");
                }
            }
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            if (_dgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn mã giảm giá để thay đổi trạng thái.");
                return;
            }

            var row = _dgv.SelectedRows[0];
            string ma = row.Cells["ma_giam_gia"].Value?.ToString() ?? "";
            string trangThai = row.Cells["trang_thai"].Value?.ToString() ?? "ACTIVE";

            using var dlg = new Form();
            dlg.Text = "Thay đổi trạng thái";
            dlg.Width = 350;
            dlg.Height = 180;
            dlg.FormBorderStyle = FormBorderStyle.FixedDialog;
            dlg.StartPosition = FormStartPosition.CenterParent;
            dlg.MaximizeBox = false;
            dlg.MinimizeBox = false;
            dlg.BackColor = Color.White;

            var lbl = new Label() { Text = "Chọn trạng thái:", Left = 20, Top = 20, Width = 150, Font = new Font("Segoe UI", 10F) };
            var cmb = new ComboBox() { Left = 20, Top = 50, Width = 300, DropDownStyle = ComboBoxStyle.DropDownList };
            cmb.Items.AddRange(new[] { "ACTIVE", "INACTIVE", "EXPIRED" });
            cmb.SelectedItem = trangThai;

            var btnOk = new Button() { Text = "Lưu", Left = 185, Top = 110, Width = 70, Height = 32, BackColor = Color.FromArgb(198, 40, 40), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, DialogResult = DialogResult.OK };
            var btnCancel = new Button() { Text = "Hủy", Left = 265, Top = 110, Width = 70, Height = 32, BackColor = Color.FromArgb(97, 97, 97), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, DialogResult = DialogResult.Cancel };

            dlg.Controls.AddRange(new Control[] { lbl, cmb, btnOk, btnCancel });
            dlg.AcceptButton = btnOk;
            dlg.CancelButton = btnCancel;

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                const string query = "UPDATE giam_gia SET trang_thai = @trangThai WHERE ma_giam_gia = @ma";
                try
                {
                    using SqlConnection conn = new SqlConnection(_connectionString);
                    using SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ma", ma);
                    cmd.Parameters.AddWithValue("@trangThai", cmb.SelectedItem?.ToString() ?? "ACTIVE");
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    LoadDiscountCodes();
                    MessageBox.Show("Thay đổi trạng thái thành công.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Thay đổi trạng thái thất bại: {ex.Message}");
                }
            }
        }
    }
}
