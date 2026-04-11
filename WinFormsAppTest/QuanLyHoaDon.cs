using System.Data;
using System.Drawing.Printing;
using Microsoft.Data.SqlClient;

namespace WinFormsAppTest
{
    public partial class QuanLyHoaDon : Form
    {
        private readonly string _connectionString = DatabaseConfig.ConnectionString;
        private string? _selectedInvoiceId;
        private DataTable _selectedInvoiceDetail = new();

        public QuanLyHoaDon()
        {
            InitializeComponent();
        }

        private void QuanLyHoaDon_Load(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today.AddDays(-7);
            dtpTo.Value = DateTime.Today;
            LoadInvoices();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadInvoices();
        }

        private void btnResetFilter_Click(object sender, EventArgs e)
        {
            dtpFrom.Value = DateTime.Today.AddDays(-7);
            dtpTo.Value = DateTime.Today;
            txtCustomerKeyword.Clear();
            LoadInvoices();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadInvoices();
        }

        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            LoadCurrentInvoiceDetail();
        }

        private void btnPrintInvoice_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_selectedInvoiceId))
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using PrintDocument doc = new();
            doc.DefaultPageSettings.PaperSize = new PaperSize("A5", 583, 827);
            doc.PrintPage += PrintInvoicePage;

            using PrintPreviewDialog preview = new()
            {
                Width = 1000,
                Height = 700,
                Document = doc
            };
            preview.ShowDialog(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            LoadCurrentInvoiceDetail();
        }

        private void dgvInvoices_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            LoadCurrentInvoiceDetail();
        }

        private void LoadInvoices()
        {
            try
            {
                const string sql = """
                    SELECT
                        hd.ma_hoa_don,
                        hd.ngay_gio_ban,
                        ISNULL(kh.ten_khach_hang, N'Khách lẻ') AS ten_khach_hang,
                        hd.tong_tien,
                        hd.giam_gia,
                        hd.thanh_tien_cuoi
                    FROM hoa_don hd
                    LEFT JOIN khach_hang kh ON kh.ma_khach_hang = hd.ma_khach_hang
                    WHERE CAST(hd.ngay_gio_ban AS DATE) BETWEEN @fromDate AND @toDate
                      AND (
                            @keyword = ''
                            OR ISNULL(kh.ten_khach_hang, N'Khách lẻ') LIKE N'%' + @keyword + N'%'
                            OR ISNULL(kh.so_dien_thoai, '') LIKE '%' + @keyword + '%'
                            OR ISNULL(hd.ma_khach_hang, '') LIKE '%' + @keyword + '%'
                          )
                    ORDER BY hd.ngay_gio_ban DESC;
                    """;

                using SqlConnection conn = new(_connectionString);
                using SqlDataAdapter da = new(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@fromDate", dtpFrom.Value.Date);
                da.SelectCommand.Parameters.AddWithValue("@toDate", dtpTo.Value.Date);
                da.SelectCommand.Parameters.AddWithValue("@keyword", txtCustomerKeyword.Text.Trim());

                DataTable dt = new();
                da.Fill(dt);
                dgvInvoices.DataSource = dt;

                FormatInvoiceGrid();

                if (dt.Rows.Count > 0)
                {
                    dgvInvoices.Rows[0].Selected = true;
                    LoadCurrentInvoiceDetail();
                }
                else
                {
                    _selectedInvoiceId = null;
                    _selectedInvoiceDetail = new DataTable();
                    dgvDetails.DataSource = null;
                    ClearSummary();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadCurrentInvoiceDetail()
        {
            if (dgvInvoices.CurrentRow is null) return;

            _selectedInvoiceId = Convert.ToString(dgvInvoices.CurrentRow.Cells["ma_hoa_don"].Value);
            if (string.IsNullOrWhiteSpace(_selectedInvoiceId)) return;

            LoadInvoiceDetails(_selectedInvoiceId);
            BindSummary();
        }

        private void LoadInvoiceDetails(string maHoaDon)
        {
            try
            {
                const string sql = """
                    SELECT
                        ct.ma_san_pham,
                        ISNULL(sp.ten_san_pham, ct.ma_san_pham) AS ten_san_pham,
                        ct.so_luong,
                        ct.don_gia,
                        ct.thanh_tien
                    FROM chi_tiet_hoa_don ct
                    LEFT JOIN san_pham sp ON sp.ma_san_pham = ct.ma_san_pham
                    WHERE ct.ma_hoa_don = @maHoaDon
                    ORDER BY ten_san_pham;
                    """;

                using SqlConnection conn = new(_connectionString);
                using SqlDataAdapter da = new(sql, conn);
                da.SelectCommand.Parameters.AddWithValue("@maHoaDon", maHoaDon);

                _selectedInvoiceDetail = new DataTable();
                da.Fill(_selectedInvoiceDetail);
                dgvDetails.DataSource = _selectedInvoiceDetail;

                FormatDetailGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải chi tiết hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BindSummary()
        {
            if (dgvInvoices.CurrentRow is null) return;

            lblMaHoaDonValue.Text = Convert.ToString(dgvInvoices.CurrentRow.Cells["ma_hoa_don"].Value) ?? "-";
            lblNgayValue.Text = Convert.ToDateTime(dgvInvoices.CurrentRow.Cells["ngay_gio_ban"].Value).ToString("dd/MM/yyyy HH:mm");
            lblKhachValue.Text = Convert.ToString(dgvInvoices.CurrentRow.Cells["ten_khach_hang"].Value) ?? "Khách lẻ";

            decimal tongTien = Convert.ToDecimal(dgvInvoices.CurrentRow.Cells["tong_tien"].Value);
            decimal giamGia = Convert.ToDecimal(dgvInvoices.CurrentRow.Cells["giam_gia"].Value);
            decimal thanhTien = Convert.ToDecimal(dgvInvoices.CurrentRow.Cells["thanh_tien_cuoi"].Value);

            lblTongTienValue.Text = $"{tongTien:N0} đ";
            lblGiamGiaValue.Text = $"{giamGia:N0} đ";
            lblThanhTienValue.Text = $"{thanhTien:N0} đ";
        }

        private void ClearSummary()
        {
            lblMaHoaDonValue.Text = "-";
            lblNgayValue.Text = "-";
            lblKhachValue.Text = "Khách lẻ";
            lblTongTienValue.Text = "0 đ";
            lblGiamGiaValue.Text = "0 đ";
            lblThanhTienValue.Text = "0 đ";
        }

        private void FormatInvoiceGrid()
        {
            if (!dgvInvoices.Columns.Contains("ma_hoa_don")) return;

            dgvInvoices.Columns["ma_hoa_don"].HeaderText = "Mã HĐ";
            dgvInvoices.Columns["ngay_gio_ban"].HeaderText = "Ngày bán";
            dgvInvoices.Columns["ten_khach_hang"].HeaderText = "Khách hàng";
            dgvInvoices.Columns["tong_tien"].HeaderText = "Tổng tiền";
            dgvInvoices.Columns["giam_gia"].HeaderText = "Giảm giá";
            dgvInvoices.Columns["thanh_tien_cuoi"].HeaderText = "Thành tiền";

            dgvInvoices.Columns["ngay_gio_ban"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            dgvInvoices.Columns["tong_tien"].DefaultCellStyle.Format = "N0";
            dgvInvoices.Columns["giam_gia"].DefaultCellStyle.Format = "N0";
            dgvInvoices.Columns["thanh_tien_cuoi"].DefaultCellStyle.Format = "N0";
        }

        private void FormatDetailGrid()
        {
            if (!dgvDetails.Columns.Contains("ma_san_pham")) return;

            dgvDetails.Columns["ma_san_pham"].HeaderText = "Mã SP";
            dgvDetails.Columns["ten_san_pham"].HeaderText = "Tên sản phẩm";
            dgvDetails.Columns["so_luong"].HeaderText = "SL";
            dgvDetails.Columns["don_gia"].HeaderText = "Đơn giá";
            dgvDetails.Columns["thanh_tien"].HeaderText = "Thành tiền";

            dgvDetails.Columns["don_gia"].DefaultCellStyle.Format = "N0";
            dgvDetails.Columns["thanh_tien"].DefaultCellStyle.Format = "N0";
        }

        private void PrintInvoicePage(object? sender, PrintPageEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_selectedInvoiceId) || dgvInvoices.CurrentRow is null)
            {
                e.HasMorePages = false;
                return;
            }

            Graphics g = e.Graphics;
            Rectangle b = e.MarginBounds;

            using Font fTitle = new("Segoe UI", 14, FontStyle.Bold);
            using Font fText = new("Segoe UI", 10, FontStyle.Regular);
            using Font fBold = new("Segoe UI", 10, FontStyle.Bold);

            int x = b.Left;
            int y = b.Top;
            const int line = 22;

            string maHd = Convert.ToString(dgvInvoices.CurrentRow.Cells["ma_hoa_don"].Value) ?? "";
            DateTime ngay = Convert.ToDateTime(dgvInvoices.CurrentRow.Cells["ngay_gio_ban"].Value);
            string kh = Convert.ToString(dgvInvoices.CurrentRow.Cells["ten_khach_hang"].Value) ?? "Khách lẻ";
            decimal tongTien = Convert.ToDecimal(dgvInvoices.CurrentRow.Cells["tong_tien"].Value);
            decimal giamGia = Convert.ToDecimal(dgvInvoices.CurrentRow.Cells["giam_gia"].Value);
            decimal thanhTien = Convert.ToDecimal(dgvInvoices.CurrentRow.Cells["thanh_tien_cuoi"].Value);

            g.DrawString("WINMART+ - HÓA ĐƠN BÁN HÀNG", fTitle, Brushes.Black, x, y); y += line + 4;
            g.DrawString($"Mã HĐ: {maHd}", fText, Brushes.Black, x, y); y += line;
            g.DrawString($"Ngày bán: {ngay:dd/MM/yyyy HH:mm}", fText, Brushes.Black, x, y); y += line;
            g.DrawString($"Khách hàng: {kh}", fText, Brushes.Black, x, y); y += line;

            g.DrawString(new string('-', 70), fText, Brushes.Black, x, y); y += line;

            foreach (DataRow row in _selectedInvoiceDetail.Rows)
            {
                string tenSp = Convert.ToString(row["ten_san_pham"]) ?? "";
                int sl = Convert.ToInt32(row["so_luong"]);
                decimal donGia = Convert.ToDecimal(row["don_gia"]);
                decimal thanhTienDong = Convert.ToDecimal(row["thanh_tien"]);

                g.DrawString(tenSp, fText, Brushes.Black, x, y); y += line;
                g.DrawString($"{sl} x {donGia:N0} = {thanhTienDong:N0}", fText, Brushes.Black, x + 10, y); y += line;
            }

            g.DrawString(new string('-', 70), fText, Brushes.Black, x, y); y += line;
            g.DrawString($"Tổng tiền: {tongTien:N0} đ", fText, Brushes.Black, x, y); y += line;
            g.DrawString($"Giảm giá: {giamGia:N0} đ", fText, Brushes.Black, x, y); y += line;
            g.DrawString($"Thành tiền: {thanhTien:N0} đ", fBold, Brushes.Black, x, y); y += line + 4;
            g.DrawString("Cảm ơn quý khách!", fBold, Brushes.Black, x, y);

            e.HasMorePages = false;
        }

        private void lblGiamGiaText_Click(object sender, EventArgs e)
        {

        }

        private void lblThanhTienText_Click(object sender, EventArgs e)
        {

        }
    }
}