using System.Data;
using System.Globalization;
using Microsoft.Data.SqlClient;

namespace WinFormsAppTest
{
    public partial class QuanLyPhieuNhapForm : Form
    {
        private readonly string _connectionString = DatabaseConfig.ConnectionString;
        private readonly string _maNhanVien;

        public QuanLyPhieuNhapForm(string maNhanVien)
        {
            InitializeComponent();
            _maNhanVien = maNhanVien;
            _dgvPhieuNhap.CellClick += dgvPhieuNhap_CellClick;
            _btnTim.Click += btnTim_Click;
            grpFilter.Resize += (_, _) => AdjustFilterLayout();
            AdjustFilterLayout();
            LoadPhieuNhap();
        }

        private void AdjustFilterLayout()
        {
            int left = _btnTim.Right + 12;
            int maxLeft = grpFilter.ClientSize.Width - _btnTao.Width - 12;
            _btnTao.Left = Math.Max(12, Math.Min(left, maxLeft));
        }

        private static void SetupGrid(DataGridView dgv)
        {
            dgv.Dock = DockStyle.Fill;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormatPhieuNhapGrid()
        {
            if (!_dgvPhieuNhap.Columns.Contains("ma_phieu_nhap"))
            {
                return;
            }

            _dgvPhieuNhap.Columns["ma_phieu_nhap"].HeaderText = "Mã phiếu";
            _dgvPhieuNhap.Columns["ngay_nhap"].HeaderText = "Ngày nhập";
            _dgvPhieuNhap.Columns["ma_nha_cung_cap"].HeaderText = "Nhà cung cấp";
            _dgvPhieuNhap.Columns["tong_tien"].HeaderText = "Tổng tiền";

            _dgvPhieuNhap.Columns["ngay_nhap"].DefaultCellStyle.Format = "dd/MM/yyyy";
            _dgvPhieuNhap.Columns["tong_tien"].DefaultCellStyle.Format = "N0";
        }

        private void FormatChiTietGrid()
        {
            if (!_dgvChiTiet.Columns.Contains("ma_san_pham"))
            {
                return;
            }

            _dgvChiTiet.Columns["ma_san_pham"].HeaderText = "Mã SP";
            if (_dgvChiTiet.Columns.Contains("ten_san_pham"))
                _dgvChiTiet.Columns["ten_san_pham"].HeaderText = "Tên sản phẩm";
            if (_dgvChiTiet.Columns.Contains("ten_danh_muc"))
                _dgvChiTiet.Columns["ten_danh_muc"].HeaderText = "Danh mục";
            _dgvChiTiet.Columns["so_luong"].HeaderText = "Số lượng";
            _dgvChiTiet.Columns["gia_nhap"].HeaderText = "Giá nhập";
            _dgvChiTiet.Columns["thanh_tien"].HeaderText = "Thành tiền";
            _dgvChiTiet.Columns["gia_nhap"].DefaultCellStyle.Format = "N0";
            _dgvChiTiet.Columns["thanh_tien"].DefaultCellStyle.Format = "N0";
        }

        private void dgvPhieuNhap_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            BindSummary();
            LoadChiTietPhieuNhap();
        }

        private void BindSummary()
        {
            if (_dgvPhieuNhap.CurrentRow is null)
            {
                lblMaPhieuValue.Text = "-";
                lblNgayNhapValue.Text = "-";
                lblNhanVienValue.Text = "-";
                lblTongTienValue.Text = "0 đ";
                return;
            }

            lblMaPhieuValue.Text = Convert.ToString(_dgvPhieuNhap.CurrentRow.Cells["ma_phieu_nhap"].Value) ?? "-";
            lblNgayNhapValue.Text = Convert.ToDateTime(_dgvPhieuNhap.CurrentRow.Cells["ngay_nhap"].Value).ToString("dd/MM/yyyy");
            if (_dgvPhieuNhap.Columns.Contains("nhan_vien_phu_trach"))
            {
                lblNhanVienValue.Text = Convert.ToString(_dgvPhieuNhap.CurrentRow.Cells["nhan_vien_phu_trach"].Value) ?? "-";
            }
            else
            {
                lblNhanVienValue.Text = "-";
            }
            decimal tongTien = Convert.ToDecimal(_dgvPhieuNhap.CurrentRow.Cells["tong_tien"].Value);
            lblTongTienValue.Text = $"{tongTien:N0} đ";
        }

        private void btnTim_Click(object? sender, EventArgs e)
        {
            LoadPhieuNhap();
        }

        private void LoadPhieuNhap()
        {
            string keyword = txtKeyword.Text.Trim();
            DateTime fromDate = dtpFrom.Value.Date;
            DateTime toDate = dtpTo.Value.Date;
            if (toDate < fromDate)
            {
                MessageBox.Show("Ngày đến phải lớn hơn hoặc bằng ngày từ.");
                return;
            }

            const string query = """
                SELECT p.ma_phieu_nhap,
                       p.ngay_nhap,
                       ncc.ten_nha_cung_cap AS ma_nha_cung_cap,
                       p.tong_tien,
                       nv.ho_ten AS nhan_vien_phu_trach
                FROM phieu_nhap_hang p
                JOIN nha_cung_cap ncc ON ncc.ma_nha_cung_cap = p.ma_nha_cung_cap
                JOIN nhan_vien nv ON nv.ma_nhan_vien = p.ma_nhan_vien
                WHERE CAST(p.ngay_nhap AS DATE) BETWEEN @from AND @to
                  AND (@keyword = '' OR p.ma_phieu_nhap LIKE '%' + @keyword + '%'
                       OR ncc.ten_nha_cung_cap LIKE '%' + @keyword + '%')
                ORDER BY p.ngay_nhap DESC;
                """;

            using SqlConnection conn = new(_connectionString);
            using SqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@from", fromDate);
            cmd.Parameters.AddWithValue("@to", toDate);
            cmd.Parameters.AddWithValue("@keyword", keyword);

            DataTable table = new();
            using SqlDataAdapter adapter = new(cmd);
            adapter.Fill(table);

            _dgvPhieuNhap.DataSource = table;
            FormatPhieuNhapGrid();
            if (_dgvPhieuNhap.Columns.Contains("nhan_vien_phu_trach"))
            {
                _dgvPhieuNhap.Columns["nhan_vien_phu_trach"].Visible = false;
            }

            if (table.Rows.Count > 0)
            {
                _dgvPhieuNhap.ClearSelection();
                _dgvPhieuNhap.Rows[0].Selected = true;
                _dgvPhieuNhap.CurrentCell = _dgvPhieuNhap.Rows[0].Cells[0];
            }

            BindSummary();
            LoadChiTietPhieuNhap();
        }

        private void LoadChiTietPhieuNhap()
        {
            if (_dgvPhieuNhap.CurrentRow is null)
            {
                _dgvChiTiet.DataSource = null;
                return;
            }

            string maPhieu = Convert.ToString(_dgvPhieuNhap.CurrentRow.Cells["ma_phieu_nhap"].Value) ?? string.Empty;
            if (string.IsNullOrWhiteSpace(maPhieu))
            {
                _dgvChiTiet.DataSource = null;
                return;
            }

            const string query = """
                SELECT ma_san_pham,
                       so_luong,
                       gia_nhap,
                       thanh_tien
                FROM chi_tiet_phieu_nhap
                WHERE ma_phieu_nhap = @maPhieu
                ORDER BY ma_san_pham;
                """;

            using SqlConnection conn = new(_connectionString);
            using SqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@maPhieu", maPhieu);

            DataTable table = new();
            using SqlDataAdapter adapter = new(cmd);
            adapter.Fill(table);

            _dgvChiTiet.DataSource = table;
            FormatChiTietGrid();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            PhieuNhapInput? input = ShowCreatePhieuNhapDialog();
            if (input is null)
            {
                return;
            }

            try
            {
                string maPhieu = CreatePhieuNhap(input);
                MessageBox.Show($"Tạo phiếu nhập thành công: {maPhieu}");
                LoadPhieuNhap();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Tạo phiếu nhập thất bại: {ex.Message}");
            }
        }

        private PhieuNhapInput? ShowCreatePhieuNhapDialog()
        {
            DataTable suppliers = LoadSuppliers();
            DataTable products = LoadProducts();

            if (suppliers.Rows.Count == 0 || products.Rows.Count == 0)
            {
                MessageBox.Show("Thiếu dữ liệu nhà cung cấp hoặc sản phẩm.");
                return null;
            }

            Dictionary<string, decimal> productPrices = products.AsEnumerable()
                .ToDictionary(r => r.Field<string>("ma_san_pham") ?? string.Empty,
                    r => r.Field<decimal>("gia_nhap"));

            using Form dialog = new()
            {
                Text = "Tạo phiếu nhập hàng",
                StartPosition = FormStartPosition.CenterParent,
                ClientSize = new Size(850, 650),
                FormBorderStyle = FormBorderStyle.None, // Custom border for premium look
                BackColor = Color.White
            };

            // Custom Border & Header
            Guna.UI2.WinForms.Guna2Panel pnlHeader = new()
            {
                Dock = DockStyle.Top,
                Height = 80,
                FillColor = Color.FromArgb(198, 40, 40)
            };
            Guna.UI2.WinForms.Guna2HtmlLabel lblHeader = new()
            {
                Text = "TẠO PHIẾU NHẬP HÀNG",
                Font = new Font("Segoe UI", 18F, FontStyle.Bold),
                ForeColor = Color.FromArgb(255, 241, 118),
                Location = new Point(20, 20)
            };
            
            Guna.UI2.WinForms.Guna2ControlBox btnClose = new()
            {
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                FillColor = Color.Transparent,
                IconColor = Color.White,
                Location = new Point(800, 10),
                Size = new Size(40, 30)
            };

            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Controls.Add(btnClose);

            // Container Panel with rounded edges
            Guna.UI2.WinForms.Guna2Panel pnlBody = new()
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(20)
            };

            // Labels and Inputs
            Guna.UI2.WinForms.Guna2HtmlLabel lblSupplier = new() { Text = "Nhà cung cấp", Location = new Point(20, 100), Font = new Font("Segoe UI", 10F, FontStyle.Bold) };
            Guna.UI2.WinForms.Guna2ComboBox cmbSupplier = new()
            {
                Location = new Point(20, 125),
                Width = 380,
                Height = 36,
                BorderRadius = 8,
                DataSource = suppliers,
                DisplayMember = "ten_nha_cung_cap",
                ValueMember = "ma_nha_cung_cap",
                Font = new Font("Segoe UI", 10F)
            };

            Guna.UI2.WinForms.Guna2HtmlLabel lblDate = new() { Text = "Ngày nhập", Location = new Point(420, 100), Font = new Font("Segoe UI", 10F, FontStyle.Bold) };
            Guna.UI2.WinForms.Guna2DateTimePicker dtpDate = new()
            {
                Location = new Point(420, 125),
                Width = 380,
                Height = 36,
                BorderRadius = 8,
                Format = DateTimePickerFormat.Custom,
                CustomFormat = "dd/MM/yyyy",
                FillColor = Color.White,
                Font = new Font("Segoe UI", 10F)
            };

            // Styled Grid
            Guna.UI2.WinForms.Guna2DataGridView grid = new()
            {
                Location = new Point(20, 180),
                Width = 780,
                Height = 330,
                Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default,
                BorderStyle = BorderStyle.None,
                CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal,
                ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None,
                GridColor = Color.FromArgb(231, 229, 255),
                AllowUserToAddRows = true,
                AllowUserToDeleteRows = true,
                RowHeadersVisible = false
            };

            grid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            grid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            grid.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            grid.ThemeStyle.RowsStyle.Height = 35;
            grid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            grid.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);

            DataGridViewComboBoxColumn colProduct = new()
            {
                Name = "ma_san_pham",
                HeaderText = "Sản phẩm",
                DataSource = products,
                DisplayMember = "ten_san_pham",
                ValueMember = "ma_san_pham",
                FlatStyle = FlatStyle.Flat
            };
            DataGridViewTextBoxColumn colQty = new() { Name = "so_luong", HeaderText = "Số lượng" };
            DataGridViewTextBoxColumn colPrice = new() { Name = "gia_nhap", HeaderText = "Giá nhập" };
            DataGridViewTextBoxColumn colAmount = new()
            {
                Name = "thanh_tien",
                HeaderText = "Thành tiền",
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N0", Alignment = DataGridViewContentAlignment.MiddleRight }
            };

            colQty.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            colPrice.DefaultCellStyle.Format = "N0";
            grid.Columns.AddRange(colProduct, colQty, colPrice, colAmount);

            // Summary
            Guna.UI2.WinForms.Guna2HtmlLabel lblTotalText = new() { Text = "TỔNG TIỀN:", Location = new Point(20, 525), Font = new Font("Segoe UI", 12F, FontStyle.Bold) };
            Guna.UI2.WinForms.Guna2HtmlLabel lblTotalValue = new()
            {
                Text = "0 đ",
                Location = new Point(130, 525),
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = Color.FromArgb(198, 40, 40)
            };

            // Buttons
            Guna.UI2.WinForms.Guna2Button btnOk = new()
            {
                Text = "Lưu phiếu",
                Location = new Point(540, 580),
                Width = 120,
                Height = 45,
                BorderRadius = 10,
                FillColor = Color.FromArgb(198, 40, 40),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                DialogResult = DialogResult.OK
            };
            Guna.UI2.WinForms.Guna2Button btnCancel = new()
            {
                Text = "Hủy bỏ",
                Location = new Point(680, 580),
                Width = 120,
                Height = 45,
                BorderRadius = 10,
                FillColor = Color.FromArgb(108, 117, 125),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                DialogResult = DialogResult.Cancel
            };

            // Event logic
            void UpdateRowAmount(int rowIndex)
            {
                if (rowIndex < 0 || rowIndex >= grid.Rows.Count) return;
                DataGridViewRow row = grid.Rows[rowIndex];
                if (row.IsNewRow) return;

                int qty = GetInt(row.Cells["so_luong"].Value);
                decimal price = GetDecimal(row.Cells["gia_nhap"].Value);
                row.Cells["thanh_tien"].Value = qty * price;
            }

            void UpdateTotal()
            {
                decimal total = 0;
                foreach (DataGridViewRow row in grid.Rows)
                {
                    if (row.IsNewRow) continue;
                    total += GetDecimal(row.Cells["thanh_tien"].Value);
                }
                lblTotalValue.Text = $"{total:N0} đ";
            }

            grid.CellValueChanged += (_, e) =>
            {
                if (e.RowIndex < 0) return;
                if (grid.Columns[e.ColumnIndex].Name == "ma_san_pham")
                {
                    string? maSp = Convert.ToString(grid.Rows[e.RowIndex].Cells["ma_san_pham"].Value);
                    if (!string.IsNullOrWhiteSpace(maSp) && productPrices.TryGetValue(maSp, out decimal giaNhap))
                    {
                        if (GetDecimal(grid.Rows[e.RowIndex].Cells["gia_nhap"].Value) <= 0)
                            grid.Rows[e.RowIndex].Cells["gia_nhap"].Value = giaNhap;
                    }
                }
                UpdateRowAmount(e.RowIndex);
                UpdateTotal();
            };

            grid.RowsRemoved += (_, _) => UpdateTotal();
            grid.CellEndEdit += (_, e) => { UpdateRowAmount(e.RowIndex); UpdateTotal(); };

            dialog.Controls.AddRange(new Control[]
            {
                pnlHeader, lblSupplier, cmbSupplier, lblDate, dtpDate, grid, lblTotalText, lblTotalValue, btnOk, btnCancel
            });

            // Ensure buttons trigger DialogResult
            btnOk.Click += (s, e) => { dialog.DialogResult = DialogResult.OK; dialog.Close(); };
            btnCancel.Click += (s, e) => { dialog.DialogResult = DialogResult.Cancel; dialog.Close(); };

            dialog.AcceptButton = btnOk;
            dialog.CancelButton = btnCancel;

            // Shadow and dragging
            Guna.UI2.WinForms.Guna2DragControl drag = new() { TargetControl = pnlHeader };
            Guna.UI2.WinForms.Guna2ShadowForm shadow = new() { TargetForm = dialog };

            if (dialog.ShowDialog(this) != DialogResult.OK) return null;

            List<PhieuNhapLine> lines = new();
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue;
                string maSp = Convert.ToString(row.Cells["ma_san_pham"].Value) ?? string.Empty;
                int qty = GetInt(row.Cells["so_luong"].Value);
                decimal price = GetDecimal(row.Cells["gia_nhap"].Value);
                if (string.IsNullOrWhiteSpace(maSp) || qty <= 0 || price <= 0)
                {
                    MessageBox.Show("Vui lòng nhập đủ sản phẩm, số lượng và giá nhập.");
                    return null;
                }

                decimal amount = qty * price;
                lines.Add(new PhieuNhapLine(maSp, qty, price, amount));
            }

            if (lines.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm ít nhất 1 sản phẩm.");
                return null;
            }

            decimal totalAmount = lines.Sum(l => l.ThanhTien);
            return new PhieuNhapInput(
                MaNhaCungCap: Convert.ToString(cmbSupplier.SelectedValue) ?? string.Empty,
                MaNhanVien: _maNhanVien,
                NgayNhap: dtpDate.Value.Date,
                TongTien: totalAmount,
                Lines: lines);
        }

        private void NumericKeyPress(object? sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar)) return;
            if (!char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private static int GetInt(object? value)
        {
            return int.TryParse(Convert.ToString(value), out int result) ? result : 0;
        }

        private static decimal GetDecimal(object? value)
        {
            if (value is decimal dec) return dec;
            if (decimal.TryParse(Convert.ToString(value), NumberStyles.Any, CultureInfo.InvariantCulture, out decimal parsed))
            {
                return parsed;
            }

            if (decimal.TryParse(Convert.ToString(value), out decimal parsedLocal))
            {
                return parsedLocal;
            }

            return 0;
        }

        private DataTable LoadSuppliers()
        {
            const string query = """
                SELECT ma_nha_cung_cap, ten_nha_cung_cap
                FROM nha_cung_cap
                ORDER BY ten_nha_cung_cap;
                """;

            using SqlConnection conn = new(_connectionString);
            using SqlDataAdapter adapter = new(query, conn);
            DataTable table = new();
            adapter.Fill(table);
            return table;
        }

        private DataTable LoadEmployees()
        {
            const string query = """
                SELECT ma_nhan_vien, ho_ten
                FROM nhan_vien
                WHERE trang_thai = 'ACTIVE'
                ORDER BY ho_ten;
                """;

            using SqlConnection conn = new(_connectionString);
            using SqlDataAdapter adapter = new(query, conn);
            DataTable table = new();
            adapter.Fill(table);
            return table;
        }

        private DataTable LoadProducts()
        {
            const string query = """
                SELECT ma_san_pham, ten_san_pham, gia_nhap
                FROM san_pham
                ORDER BY ten_san_pham;
                """;

            using SqlConnection conn = new(_connectionString);
            using SqlDataAdapter adapter = new(query, conn);
            DataTable table = new();
            adapter.Fill(table);
            return table;
        }

        private string CreatePhieuNhap(PhieuNhapInput input)
        {
            string maPhieu = $"PNH{DateTime.Now:yyyyMMddHHmmssfff}";

            using SqlConnection conn = new(_connectionString);
            conn.Open();
            using SqlTransaction tx = conn.BeginTransaction();

            try
            {
                const string insertPhieu = """
                    INSERT INTO phieu_nhap_hang (ma_phieu_nhap, ngay_nhap, tong_tien, ma_nha_cung_cap, ma_nhan_vien)
                    VALUES (@ma, @ngay, @tong, @ncc, @nv);
                    """;

                using (SqlCommand cmd = new(insertPhieu, conn, tx))
                {
                    cmd.Parameters.AddWithValue("@ma", maPhieu);
                    cmd.Parameters.AddWithValue("@ngay", input.NgayNhap);
                    cmd.Parameters.AddWithValue("@tong", input.TongTien);
                    cmd.Parameters.AddWithValue("@ncc", input.MaNhaCungCap);
                    cmd.Parameters.AddWithValue("@nv", input.MaNhanVien);
                    cmd.ExecuteNonQuery();
                }

                const string insertDetail = """
                    INSERT INTO chi_tiet_phieu_nhap (ma_phieu_nhap, ma_san_pham, so_luong, gia_nhap, thanh_tien)
                    VALUES (@ma, @sp, @qty, @gia, @thanh);
                    """;

                const string updateStock = """
                    UPDATE san_pham
                    SET so_luong_ton = so_luong_ton + @qty,
                        gia_nhap = @gia
                    WHERE ma_san_pham = @sp;
                    """;

                foreach (PhieuNhapLine line in input.Lines)
                {
                    using (SqlCommand cmdDetail = new(insertDetail, conn, tx))
                    {
                        cmdDetail.Parameters.AddWithValue("@ma", maPhieu);
                        cmdDetail.Parameters.AddWithValue("@sp", line.MaSanPham);
                        cmdDetail.Parameters.AddWithValue("@qty", line.SoLuong);
                        cmdDetail.Parameters.AddWithValue("@gia", line.GiaNhap);
                        cmdDetail.Parameters.AddWithValue("@thanh", line.ThanhTien);
                        cmdDetail.ExecuteNonQuery();
                    }

                    using (SqlCommand cmdStock = new(updateStock, conn, tx))
                    {
                        cmdStock.Parameters.AddWithValue("@sp", line.MaSanPham);
                        cmdStock.Parameters.AddWithValue("@qty", line.SoLuong);
                        cmdStock.Parameters.AddWithValue("@gia", line.GiaNhap);
                        cmdStock.ExecuteNonQuery();
                    }
                }

                tx.Commit();
                return maPhieu;
            }
            catch
            {
                tx.Rollback();
                throw;
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm sản phẩm vào phiếu");
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tính tổng tiền phiếu nhập");
        }

        private void btnTon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cập nhật tồn kho");
        }

        private void pnlSummary_Paint(object sender, PaintEventArgs e)
        {

        }

        private void _dgvChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private sealed record PhieuNhapLine(string MaSanPham, int SoLuong, decimal GiaNhap, decimal ThanhTien);

        private sealed record PhieuNhapInput(
            string MaNhaCungCap,
            string MaNhanVien,
            DateTime NgayNhap,
            decimal TongTien,
            List<PhieuNhapLine> Lines);
    }
}
