using System.Data;
using System.Drawing.Printing;
using System.Globalization;
using Guna.UI2.WinForms;
using Microsoft.Data.SqlClient;

namespace WinFormsAppTest
{
    public partial class BanHangForm : Form
    {
        private readonly string _connectionString = DatabaseConfig.ConnectionString;
        private string _maNhanVien;
        private readonly DataTable _cartTable = new();
        private bool _isInitialLoading = true;

        private DataTable? _productsTable;
        private string? _appliedDiscountCode;
        private decimal _discountAmount;
        private decimal _discountPercent;
        private decimal _discountFixed;

        private PrintInvoiceSnapshot? _lastInvoiceSnapshot;

        public BanHangForm(string maNhanVien)
        {
            InitializeComponent();
            _maNhanVien = maNhanVien;
        }

        private void BanHangForm_Load(object sender, EventArgs e)
        {
            InitializeCartTable();
            LoadProducts();
            LoadCustomers();
            LoadDiscounts();

            ConfigureGrids();
            SetupShortcuts();
            EventHandledControls();

            FormBorderStyle = FormBorderStyle.Sizable;
            MinimumSize = new Size(1200, 760);

            UpdateTotals();
            _isInitialLoading = false;
        }

        #region Setup

        private void InitializeCartTable()
        {
            _cartTable.Columns.Add("ma_san_pham", typeof(string));
            _cartTable.Columns.Add("ten_san_pham", typeof(string));
            _cartTable.Columns.Add("don_gia", typeof(decimal));
            _cartTable.Columns.Add("so_luong", typeof(int));
            _cartTable.Columns.Add("thanh_tien", typeof(decimal), "don_gia * so_luong");

            dgvCart.DataSource = _cartTable;
        }

        private void ConfigureGrids()
        {
            dgvProducts.MultiSelect = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.ReadOnly = true;
            dgvProducts.CellDoubleClick += (_, _) => AddCurrentProductToCart((int)numQuantity.Value);

            dgvCart.MultiSelect = false;
            dgvCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCart.ReadOnly = false;
            dgvCart.DataBindingComplete += (_, _) =>
            {
                if (dgvCart.Columns.Contains("ma_san_pham")) dgvCart.Columns["ma_san_pham"].ReadOnly = true;
                if (dgvCart.Columns.Contains("ten_san_pham")) dgvCart.Columns["ten_san_pham"].ReadOnly = true;
                if (dgvCart.Columns.Contains("don_gia")) dgvCart.Columns["don_gia"].ReadOnly = true;
                if (dgvCart.Columns.Contains("thanh_tien")) dgvCart.Columns["thanh_tien"].ReadOnly = true;
                if (dgvCart.Columns.Contains("so_luong")) dgvCart.Columns["so_luong"].ReadOnly = false;
            };
            dgvCart.CellEndEdit += dgvCart_CellEndEdit;
            dgvCart.DataError += (_, _) => MessageBox.Show("Giá trị không hợp lệ.");
        }

        private void SetupShortcuts()
        {
            KeyPreview = true;
            KeyDown += BanHangForm_KeyDown;

            txtSearch.KeyDown += (_, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (dgvProducts.Rows.Count > 0)
                    {
                        AddCurrentProductToCart((int)numQuantity.Value);
                        e.SuppressKeyPress = true;
                    }
                }
            };
        }

        private void EventHandledControls()
        {
            _txtBarcode.KeyDown += (_, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ScanBarcodeAndAdd();
                    e.SuppressKeyPress = true;
                }
            };

            _btnScanBarcode.Click += (_, _) => ScanBarcodeAndAdd();
            _btnHoldBill.Click += (_, _) => HoldCurrentBill();
            _btnResumeBill.Click += (_, _) => ResumeSelectedBill();
            _btnFindCustomer.Click += (_, _) => FindCustomerByPhone();
            _btnQuickCustomer.Click += (_, _) => QuickCreateCustomer();
            _txtCashReceived.TextChanged += (_, _) => UpdateTotals();
        }

        #endregion

        #region Data loading

        private void LoadProducts()
        {
            const string query = """
                SELECT ma_san_pham, ten_san_pham, gia_ban, so_luong_ton
                FROM san_pham
                ORDER BY ten_san_pham;
                """;

            using SqlConnection conn = new(_connectionString);
            using SqlDataAdapter da = new(query, conn);
            _productsTable = new DataTable();
            da.Fill(_productsTable);
            dgvProducts.DataSource = _productsTable;
        }

        private void LoadCustomers(string? selectCustomerId = null)
        {
            const string query = """
                SELECT ma_khach_hang, ten_khach_hang, so_dien_thoai
                FROM khach_hang
                ORDER BY ten_khach_hang;
                """;

            using SqlConnection conn = new(_connectionString);
            using SqlDataAdapter da = new(query, conn);
            DataTable dt = new();
            da.Fill(dt);

            DataRow retail = dt.NewRow();
            retail["ma_khach_hang"] = DBNull.Value;
            retail["ten_khach_hang"] = "Khách lẻ";
            retail["so_dien_thoai"] = "";
            dt.Rows.InsertAt(retail, 0);

            cmbCustomer.DataSource = dt;
            cmbCustomer.DisplayMember = "ten_khach_hang";
            cmbCustomer.ValueMember = "ma_khach_hang";

            if (!string.IsNullOrWhiteSpace(selectCustomerId))
            {
                cmbCustomer.SelectedValue = selectCustomerId;
            }
            else
            {
                cmbCustomer.SelectedIndex = 0;
            }
        }

        private void LoadDiscounts()
        {
            const string query = """
                SELECT ma_giam_gia, 
                       CASE 
                           WHEN phan_tram_giam > 0 THEN ma_giam_gia + ' (' + CAST(CAST(phan_tram_giam AS float) AS varchar) + ' %)'
                           ELSE ma_giam_gia + ' (' + FORMAT(so_tien_giam, 'N0') + ' đ)'
                       END AS hien_thi
                FROM giam_gia
                WHERE trang_thai = 'ACTIVE'
                  AND SYSDATETIME() BETWEEN ngay_bat_dau AND ngay_ket_thuc
                ORDER BY ma_giam_gia;
                """;

            using SqlConnection conn = new(_connectionString);
            using SqlDataAdapter da = new(query, conn);
            DataTable dt = new();
            da.Fill(dt);

            DataRow none = dt.NewRow();
            none["ma_giam_gia"] = "";
            none["hien_thi"] = "-- Không áp dụng --";
            dt.Rows.InsertAt(none, 0);

            cmbDiscount.DisplayMember = "hien_thi";
            cmbDiscount.ValueMember = "ma_giam_gia";
            cmbDiscount.DataSource = dt;
            cmbDiscount.SelectedIndex = 0;
        }

        #endregion

        #region Product/cart actions

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (_productsTable is null) return;
            string keyword = txtSearch.Text.Trim().Replace("'", "''");
            _productsTable.DefaultView.RowFilter =
                $"ten_san_pham LIKE '%{keyword}%' OR ma_san_pham LIKE '%{keyword}%'";
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            AddCurrentProductToCart((int)numQuantity.Value);
        }

        private void AddCurrentProductToCart(int quantity)
        {
            if (dgvProducts.CurrentRow is null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm.");
                return;
            }

            string maSp = dgvProducts.CurrentRow.Cells["ma_san_pham"].Value?.ToString() ?? string.Empty;
            AddProductToCart(maSp, quantity);
        }

        private void AddProductToCart(string maSp, int soLuong)
        {
            if (_productsTable is null) return;

            DataRow[] rows = _productsTable.Select($"ma_san_pham = '{maSp.Replace("'", "''")}'");
            if (rows.Length == 0)
            {
                MessageBox.Show("Không tìm thấy sản phẩm.");
                return;
            }

            DataRow product = rows[0];
            string tenSp = product.Field<string>("ten_san_pham") ?? string.Empty;
            decimal giaBan = product.Field<decimal>("gia_ban");
            int tonKho = product.Field<int>("so_luong_ton");

            if (soLuong <= 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0.");
                return;
            }

            DataRow? existing = _cartTable.AsEnumerable()
                .FirstOrDefault(r => string.Equals(r.Field<string>("ma_san_pham"), maSp, StringComparison.OrdinalIgnoreCase));

            int currentQty = existing is null ? 0 : existing.Field<int>("so_luong");
            if (currentQty + soLuong > tonKho)
            {
                MessageBox.Show($"Tồn kho không đủ. Còn {tonKho}.");
                return;
            }

            if (existing is null)
            {
                _cartTable.Rows.Add(maSp, tenSp, giaBan, soLuong);
            }
            else
            {
                existing["so_luong"] = currentQty + soLuong;
            }

            UpdateTotals();
        }

        private void ScanBarcodeAndAdd()
        {
            string code = _txtBarcode.Text.Trim();
            if (string.IsNullOrWhiteSpace(code)) return;

            AddProductToCart(code, 1);
            _txtBarcode.Clear();
            _txtBarcode.Focus();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (dgvCart.CurrentRow is null) return;
            dgvCart.Rows.RemoveAt(dgvCart.CurrentRow.Index);
            UpdateTotals();
        }

        private void btnClearCart_Click(object sender, EventArgs e)
        {
            _cartTable.Clear();
            ClearDiscount();
            UpdateTotals();
        }

        private void dgvCart_CellEndEdit(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || !dgvCart.Columns.Contains("so_luong") || dgvCart.Columns[e.ColumnIndex].Name != "so_luong")
                return;

            DataGridViewRow row = dgvCart.Rows[e.RowIndex];
            string maSp = row.Cells["ma_san_pham"].Value?.ToString() ?? string.Empty;

            if (!int.TryParse(Convert.ToString(row.Cells["so_luong"].Value), out int soLuongMoi) || soLuongMoi <= 0)
            {
                MessageBox.Show("Số lượng không hợp lệ.");
                row.Cells["so_luong"].Value = 1;
                UpdateTotals();
                return;
            }

            int tonKho = GetStock(maSp);
            if (soLuongMoi > tonKho)
            {
                MessageBox.Show($"Tồn kho không đủ. Còn {tonKho}.");
                row.Cells["so_luong"].Value = tonKho;
            }

            UpdateTotals();
        }

        private int GetStock(string maSp)
        {
            if (_productsTable is null) return 0;
            DataRow[] rows = _productsTable.Select($"ma_san_pham = '{maSp.Replace("'", "''")}'");
            return rows.Length == 0 ? 0 : rows[0].Field<int>("so_luong_ton");
        }

        #endregion

        #region Discount

        private void btnApplyDiscount_Click(object sender, EventArgs e)
        {
            ApplyDiscount(cmbDiscount.SelectedValue?.ToString() ?? string.Empty);
        }

        private void cmbDiscount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_isInitialLoading && cmbDiscount.SelectedIndex >= 0)
            {
                ApplyDiscount(cmbDiscount.SelectedValue?.ToString() ?? string.Empty);
            }
        }

        private void ApplyDiscount(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                ClearDiscount();
                UpdateTotals();
                return;
            }

            const string query = """
                SELECT TOP 1 ma_giam_gia, phan_tram_giam, so_tien_giam
                FROM giam_gia
                WHERE ma_giam_gia = @code
                  AND trang_thai = 'ACTIVE'
                  AND SYSDATETIME() BETWEEN ngay_bat_dau AND ngay_ket_thuc;
                """;

            using SqlConnection conn = new(_connectionString);
            using SqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@code", code);
            conn.Open();

            using SqlDataReader rd = cmd.ExecuteReader();
            if (!rd.Read())
            {
                MessageBox.Show("Mã giảm giá không hợp lệ hoặc hết hạn.");
                ClearDiscount();
                UpdateTotals();
                return;
            }

            _appliedDiscountCode = code;
            _discountPercent = rd.GetDecimal(rd.GetOrdinal("phan_tram_giam"));
            _discountFixed = rd.GetDecimal(rd.GetOrdinal("so_tien_giam"));

            RecalculateDiscount();
            UpdateTotals();
        }

        private void RecalculateDiscount()
        {
            if (string.IsNullOrWhiteSpace(_appliedDiscountCode))
            {
                _discountAmount = 0;
                return;
            }

            decimal subtotal = GetSubTotal();
            decimal value = subtotal * _discountPercent / 100m + _discountFixed;
            _discountAmount = Math.Min(value, subtotal);
        }

        private void ClearDiscount()
        {
            _appliedDiscountCode = null;
            _discountAmount = 0;
            _discountPercent = 0;
            _discountFixed = 0;
            if (cmbDiscount.Items.Count > 0) cmbDiscount.SelectedIndex = 0;
        }

        #endregion

        #region Customer quick actions

        private void FindCustomerByPhone()
        {
            string phone = _txtCustomerPhone.Text.Trim();
            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Nhập số điện thoại khách.");
                return;
            }

            const string query = """
                SELECT TOP 1 ma_khach_hang
                FROM khach_hang
                WHERE so_dien_thoai = @phone;
                """;

            using SqlConnection conn = new(_connectionString);
            using SqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@phone", phone);
            conn.Open();

            object? result = cmd.ExecuteScalar();
            if (result is null || result == DBNull.Value)
            {
                MessageBox.Show("Không tìm thấy khách hàng.");
                return;
            }

            cmbCustomer.SelectedValue = Convert.ToString(result);
            MessageBox.Show("Đã chọn khách hàng theo SĐT.");
        }

        private void QuickCreateCustomer()
        {
            (string name, string phone)? data = ShowQuickCustomerDialog(_txtCustomerPhone.Text);
            if (data is null) return;

            string maKh = $"KH{DateTime.Now:yyyyMMddHHmmssfff}";
            const string insert = """
                INSERT INTO khach_hang (ma_khach_hang, ten_khach_hang, so_dien_thoai, dia_chi)
                VALUES (@id, @name, @phone, NULL);
                """;

            try
            {
                using SqlConnection conn = new(_connectionString);
                using SqlCommand cmd = new(insert, conn);
                cmd.Parameters.AddWithValue("@id", maKh);
                cmd.Parameters.AddWithValue("@name", data.Value.name);
                cmd.Parameters.AddWithValue("@phone", string.IsNullOrWhiteSpace(data.Value.phone) ? (object)DBNull.Value : data.Value.phone);

                conn.Open();
                cmd.ExecuteNonQuery();

                LoadCustomers(maKh);
                _txtCustomerPhone.Text = data.Value.phone;

                MessageBox.Show("Thêm khách hàng nhanh thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể thêm khách hàng: {ex.Message}");
            }
        }

        private (string name, string phone)? ShowQuickCustomerDialog(string? phonePreset)
        {
            using Form f = new()
            {
                Text = "Thêm khách hàng nhanh",
                StartPosition = FormStartPosition.CenterParent,
                ClientSize = new Size(360, 190),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label lblName = new() { Text = "Tên khách:", Left = 15, Top = 20, Width = 90 };
            TextBox txtName = new() { Left = 110, Top = 18, Width = 220 };

            Label lblPhone = new() { Text = "SĐT:", Left = 15, Top = 60, Width = 90 };
            TextBox txtPhone = new() { Left = 110, Top = 58, Width = 220, Text = phonePreset ?? string.Empty };

            Button btnOk = new() { Text = "Lưu", Left = 170, Top = 110, Width = 75, DialogResult = DialogResult.OK };
            Button btnCancel = new() { Text = "Hủy", Left = 255, Top = 110, Width = 75, DialogResult = DialogResult.Cancel };

            f.Controls.AddRange(new Control[] { lblName, txtName, lblPhone, txtPhone, btnOk, btnCancel });
            f.AcceptButton = btnOk;
            f.CancelButton = btnCancel;

            if (f.ShowDialog(this) != DialogResult.OK)
                return null;

            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Tên khách không được để trống.");
                return null;
            }

            return (name, phone);
        }

        #endregion

        #region Hold/resume bills (multi tabs)

        private void HoldCurrentBill()
        {
            if (_cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Không có bill để giữ.");
                return;
            }

            PendingBill bill = CaptureCurrentBill();

            TabPage page = new($"Bill {_tabHeldBills.TabPages.Count + 1}") { Tag = bill };
            _tabHeldBills.TabPages.Add(page);
            _tabHeldBills.SelectedTab = page;

            ClearCurrentCartState();
            MessageBox.Show("Đã giữ bill tạm.");
        }

        private void ResumeSelectedBill()
        {
            if (_tabHeldBills.SelectedTab is null)
            {
                MessageBox.Show("Không có bill tạm được chọn.");
                return;
            }

            if (_cartTable.Rows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Giỏ hiện tại chưa trống. Ghi đè bill hiện tại?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dr != DialogResult.Yes) return;
            }

            if (_tabHeldBills.SelectedTab.Tag is not PendingBill bill) return;

            RestorePendingBill(bill);
            _tabHeldBills.TabPages.Remove(_tabHeldBills.SelectedTab);
            MessageBox.Show("Đã gọi lại bill.");
        }

        private PendingBill CaptureCurrentBill()
        {
            return new PendingBill(
                Cart: _cartTable.Copy(),
                CustomerId: cmbCustomer.SelectedValue is DBNull ? null : Convert.ToString(cmbCustomer.SelectedValue),
                DiscountCode: _appliedDiscountCode,
                DiscountPercent: _discountPercent,
                DiscountFixed: _discountFixed,
                CashText: _txtCashReceived.Text ?? string.Empty
            );
        }

        private void RestorePendingBill(PendingBill bill)
        {
            _cartTable.Clear();
            foreach (DataRow row in bill.Cart.Rows)
            {
                _cartTable.ImportRow(row);
            }

            if (!string.IsNullOrWhiteSpace(bill.CustomerId))
                cmbCustomer.SelectedValue = bill.CustomerId;
            else
                cmbCustomer.SelectedIndex = 0;

            _appliedDiscountCode = bill.DiscountCode;
            _discountPercent = bill.DiscountPercent;
            _discountFixed = bill.DiscountFixed;
            if (!string.IsNullOrWhiteSpace(bill.DiscountCode))
                cmbDiscount.SelectedValue = bill.DiscountCode;
            else
                cmbDiscount.SelectedIndex = 0;

            _txtCashReceived.Text = bill.CashText;

            UpdateTotals();
        }

        private void ClearCurrentCartState()
        {
            _cartTable.Clear();
            cmbCustomer.SelectedIndex = 0;
            ClearDiscount();
            _txtCashReceived.Clear();
            UpdateTotals();
        }

        #endregion

        #region Invoice create + print

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            if (_cartTable.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống.");
                return;
            }

            if (!EnsureValidEmployeeId())
            {
                return;
            }

            decimal tongTien = GetSubTotal();
            decimal giamGia = _discountAmount;
            decimal thanhTienCuoi = tongTien - giamGia;

            decimal cash = ParseMoney(_txtCashReceived.Text);
            if (cash < thanhTienCuoi)
            {
                MessageBox.Show("Tiền khách đưa chưa đủ.");
                return;
            }

            string maHoaDon = $"HD{DateTime.Now:yyyyMMddHHmmssfff}";
            object? maKhachHang = cmbCustomer.SelectedValue is DBNull ? null : cmbCustomer.SelectedValue;

            using SqlConnection conn = new(_connectionString);
            conn.Open();
            using SqlTransaction tx = conn.BeginTransaction();

            try
            {
                const string insertHoaDon = """
                    INSERT INTO hoa_don
                    (ma_hoa_don, ngay_gio_ban, tong_tien, ma_nhan_vien, ma_khach_hang, ma_giam_gia, giam_gia, thanh_tien_cuoi)
                    VALUES
                    (@ma_hoa_don, SYSDATETIME(), @tong_tien, @ma_nhan_vien, @ma_khach_hang, @ma_giam_gia, @giam_gia, @thanh_tien_cuoi);
                    """;

                using (SqlCommand cmd = new(insertHoaDon, conn, tx))
                {
                    cmd.Parameters.AddWithValue("@ma_hoa_don", maHoaDon);
                    cmd.Parameters.AddWithValue("@tong_tien", tongTien);
                    cmd.Parameters.AddWithValue("@ma_nhan_vien", _maNhanVien);
                    cmd.Parameters.AddWithValue("@ma_khach_hang", maKhachHang ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@ma_giam_gia", _appliedDiscountCode ?? (object)DBNull.Value);
                    cmd.Parameters.AddWithValue("@giam_gia", giamGia);
                    cmd.Parameters.AddWithValue("@thanh_tien_cuoi", thanhTienCuoi);
                    cmd.ExecuteNonQuery();
                }

                const string insertCthd = """
                    INSERT INTO chi_tiet_hoa_don
                    (ma_hoa_don, ma_san_pham, so_luong, don_gia, thanh_tien)
                    VALUES
                    (@ma_hoa_don, @ma_san_pham, @so_luong, @don_gia, @thanh_tien);
                    """;

                const string updateStock = """
                    UPDATE san_pham
                    SET so_luong_ton = so_luong_ton - @so_luong
                    WHERE ma_san_pham = @ma_san_pham
                      AND so_luong_ton >= @so_luong;
                    """;

                foreach (DataRow row in _cartTable.Rows)
                {
                    string maSp = row.Field<string>("ma_san_pham")!;
                    int soLuong = row.Field<int>("so_luong");
                    decimal donGia = row.Field<decimal>("don_gia");
                    decimal thanhTien = row.Field<decimal>("thanh_tien");

                    using (SqlCommand cmdCt = new(insertCthd, conn, tx))
                    {
                        cmdCt.Parameters.AddWithValue("@ma_hoa_don", maHoaDon);
                        cmdCt.Parameters.AddWithValue("@ma_san_pham", maSp);
                        cmdCt.Parameters.AddWithValue("@so_luong", soLuong);
                        cmdCt.Parameters.AddWithValue("@don_gia", donGia);
                        cmdCt.Parameters.AddWithValue("@thanh_tien", thanhTien);
                        cmdCt.ExecuteNonQuery();
                    }

                    using (SqlCommand cmdStock = new(updateStock, conn, tx))
                    {
                        cmdStock.Parameters.AddWithValue("@ma_san_pham", maSp);
                        cmdStock.Parameters.AddWithValue("@so_luong", soLuong);
                        if (cmdStock.ExecuteNonQuery() == 0)
                            throw new InvalidOperationException($"Không đủ tồn kho cho sản phẩm {maSp}.");
                    }
                }

                if (!string.IsNullOrWhiteSpace(_appliedDiscountCode))
                {
                    const string updateGg = """
                        UPDATE giam_gia
                        SET so_luong_su_dung = so_luong_su_dung + 1
                        WHERE ma_giam_gia = @ma;
                        """;
                    using SqlCommand cmdGg = new(updateGg, conn, tx);
                    cmdGg.Parameters.AddWithValue("@ma", _appliedDiscountCode);
                    cmdGg.ExecuteNonQuery();
                }

                tx.Commit();

                decimal change = cash - thanhTienCuoi;
                BuildLastInvoiceSnapshot(maHoaDon, tongTien, giamGia, thanhTienCuoi, cash, change);

                MessageBox.Show($"Tạo hóa đơn thành công: {maHoaDon}\nTiền thừa: {change:N0} đ");

                ClearCurrentCartState();
                LoadProducts();
            }
            catch (Exception ex)
            {
                tx.Rollback();
                MessageBox.Show($"Tạo hóa đơn thất bại: {ex.Message}");
            }
        }

        private bool EnsureValidEmployeeId()
        {
            const string query = "SELECT COUNT(1) FROM nhan_vien WHERE ma_nhan_vien = @ma";
            using SqlConnection conn = new(_connectionString);
            using SqlCommand cmd = new(query, conn);
            cmd.Parameters.AddWithValue("@ma", _maNhanVien);
            conn.Open();

            int exists = Convert.ToInt32(cmd.ExecuteScalar() ?? 0);
            if (exists > 0)
            {
                return true;
            }

            MessageBox.Show("Mã nhân viên không tồn tại. Vui lòng nhập lại.");

            using Form prompt = new()
            {
                Text = "Nhập mã nhân viên",
                StartPosition = FormStartPosition.CenterParent,
                ClientSize = new Size(320, 140),
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label lbl = new() { Text = "Mã nhân viên:", Left = 15, Top = 20, Width = 100 };
            TextBox txt = new() { Left = 120, Top = 18, Width = 170, Text = _maNhanVien };
            Button btnOk = new() { Text = "Xác nhận", Left = 120, Top = 70, Width = 80, DialogResult = DialogResult.OK };
            Button btnCancel = new() { Text = "Hủy", Left = 210, Top = 70, Width = 80, DialogResult = DialogResult.Cancel };

            prompt.Controls.AddRange(new Control[] { lbl, txt, btnOk, btnCancel });
            prompt.AcceptButton = btnOk;
            prompt.CancelButton = btnCancel;

            if (prompt.ShowDialog(this) != DialogResult.OK)
            {
                return false;
            }

            string newMa = txt.Text.Trim();
            if (string.IsNullOrWhiteSpace(newMa))
            {
                MessageBox.Show("Mã nhân viên không hợp lệ.");
                return false;
            }

            using SqlConnection connRetry = new(_connectionString);
            using SqlCommand cmdRetry = new(query, connRetry);
            cmdRetry.Parameters.AddWithValue("@ma", newMa);
            connRetry.Open();

            int existsRetry = Convert.ToInt32(cmdRetry.ExecuteScalar() ?? 0);
            if (existsRetry == 0)
            {
                MessageBox.Show("Mã nhân viên không tồn tại.");
                return false;
            }

            _maNhanVien = newMa;
            return true;
        }

        private void BuildLastInvoiceSnapshot(
            string maHoaDon,
            decimal tongTien,
            decimal giamGia,
            decimal thanhTienCuoi,
            decimal cash,
            decimal change)
        {
            List<InvoiceLine> lines = new();
            foreach (DataRow row in _cartTable.Rows)
            {
                lines.Add(new InvoiceLine(
                    Name: Convert.ToString(row["ten_san_pham"]) ?? "",
                    Qty: Convert.ToInt32(row["so_luong"]),
                    Price: Convert.ToDecimal(row["don_gia"]),
                    Amount: Convert.ToDecimal(row["thanh_tien"])));
            }

            _lastInvoiceSnapshot = new PrintInvoiceSnapshot(
                InvoiceNo: maHoaDon,
                CreatedAt: DateTime.Now,
                CashierId: _maNhanVien,
                CustomerName: cmbCustomer.Text,
                DiscountCode: _appliedDiscountCode,
                Subtotal: tongTien,
                Discount: giamGia,
                FinalTotal: thanhTienCuoi,
                Cash: cash,
                Change: change,
                Lines: lines);
        }

        private void PrintInvoice(string mode)
        {
            if (_lastInvoiceSnapshot is null)
            {
                MessageBox.Show("Chưa có hóa đơn để in.");
                return;
            }

            using PrintDocument doc = new();
            if (mode == "K80")
                doc.DefaultPageSettings.PaperSize = new PaperSize("K80", 315, 1200); // 80mm
            else
                doc.DefaultPageSettings.PaperSize = new PaperSize("A5", 583, 827);

            doc.PrintPage += (s, e) => DrawInvoice(e.Graphics, e.MarginBounds, _lastInvoiceSnapshot, mode);

            using PrintPreviewDialog preview = new()
            {
                Width = 1000,
                Height = 700,
                Document = doc
            };
            preview.ShowDialog(this);
        }

        private static void DrawInvoice(Graphics g, Rectangle bounds, PrintInvoiceSnapshot invoice, string mode)
        {
            using Font fTitle = new("Segoe UI", mode == "K80" ? 10 : 14, FontStyle.Bold);
            using Font fText = new("Segoe UI", mode == "K80" ? 8 : 10);
            using Font fBold = new("Segoe UI", mode == "K80" ? 8 : 10, FontStyle.Bold);

            int x = bounds.Left;
            int y = bounds.Top;
            int line = mode == "K80" ? 16 : 20;

            g.DrawString("WINMART+ POS", fTitle, Brushes.Black, x, y); y += line;
            g.DrawString($"HĐ: {invoice.InvoiceNo}", fText, Brushes.Black, x, y); y += line;
            g.DrawString($"Ngày: {invoice.CreatedAt:dd/MM/yyyy HH:mm}", fText, Brushes.Black, x, y); y += line;
            g.DrawString($"Thu ngân: {invoice.CashierId}", fText, Brushes.Black, x, y); y += line;
            g.DrawString($"KH: {invoice.CustomerName}", fText, Brushes.Black, x, y); y += line;

            g.DrawString(new string('-', 45), fText, Brushes.Black, x, y); y += line;

            foreach (InvoiceLine item in invoice.Lines)
            {
                g.DrawString(item.Name, fText, Brushes.Black, x, y); y += line;
                g.DrawString($"{item.Qty} x {item.Price:N0} = {item.Amount:N0}", fText, Brushes.Black, x, y); y += line;
            }

            g.DrawString(new string('-', 45), fText, Brushes.Black, x, y); y += line;
            g.DrawString($"Tạm tính: {invoice.Subtotal:N0}", fText, Brushes.Black, x, y); y += line;
            g.DrawString($"Giảm giá: {invoice.Discount:N0}", fText, Brushes.Black, x, y); y += line;
            g.DrawString($"Thành tiền: {invoice.FinalTotal:N0}", fBold, Brushes.Black, x, y); y += line;
            g.DrawString($"Tiền khách: {invoice.Cash:N0}", fText, Brushes.Black, x, y); y += line;
            g.DrawString($"Tiền thừa: {invoice.Change:N0}", fBold, Brushes.Black, x, y); y += line;

            if (!string.IsNullOrWhiteSpace(invoice.DiscountCode))
            {
                g.DrawString($"Mã GG: {invoice.DiscountCode}", fText, Brushes.Black, x, y); y += line;
            }

            y += 4;
            g.DrawString("Cảm ơn quý khách!", fBold, Brushes.Black, x, y);
        }

        #endregion

        #region Totals + shortcuts

        private decimal GetSubTotal()
        {
            return _cartTable.AsEnumerable().Sum(r => r.Field<decimal>("thanh_tien"));
        }

        private void UpdateTotals()
        {
            RecalculateDiscount();

            decimal subtotal = GetSubTotal();
            decimal finalTotal = Math.Max(0, subtotal - _discountAmount);

            lblSubTotalValue.Text = $"{subtotal:N0} đ";
            lblDiscountValue.Text = $"{_discountAmount:N0} đ";
            lblFinalTotalValue.Text = $"{finalTotal:N0} đ";

            decimal cash = ParseMoney(_txtCashReceived.Text);
            decimal change = Math.Max(0, cash - finalTotal);
            _lblChangeValue.Text = $"{change:N0} đ";
        }

        private static decimal ParseMoney(string? input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return 0;

            string s = input
                .Replace("đ", "", StringComparison.OrdinalIgnoreCase)
                .Replace(".", "")
                .Replace(",", "")
                .Trim();

            return decimal.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal value)
                ? value
                : 0;
        }

        private void BanHangForm_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                cmbDiscount.Focus();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F4)
            {
                cmbCustomer.Focus();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F8)
            {
                HoldCurrentBill();
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.F9)
            {
                btnCreateInvoice.PerformClick();
                e.SuppressKeyPress = true;
            }
            else if (e.Control && e.KeyCode == Keys.P)
            {
                PrintInvoice("K80");
                e.SuppressKeyPress = true;
            }
        }

        #endregion

        private void grpCheckout_Click(object sender, EventArgs e)
        {

        }

        private sealed record PendingBill(
            DataTable Cart,
            string? CustomerId,
            string? DiscountCode,
            decimal DiscountPercent,
            decimal DiscountFixed,
            string CashText);

        private sealed record InvoiceLine(string Name, int Qty, decimal Price, decimal Amount);

        private sealed record PrintInvoiceSnapshot(
            string InvoiceNo,
            DateTime CreatedAt,
            string CashierId,
            string CustomerName,
            string? DiscountCode,
            decimal Subtotal,
            decimal Discount,
            decimal FinalTotal,
            decimal Cash,
            decimal Change,
            List<InvoiceLine> Lines);
    }
}