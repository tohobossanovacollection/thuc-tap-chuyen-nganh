using System.Data;

namespace WinFormsAppTest
{
    public partial class QuanLyPhieuNhapForm : Form
    {
        public QuanLyPhieuNhapForm()
        {
            InitializeComponent();
            _dgvPhieuNhap.CellClick += dgvPhieuNhap_CellClick;
            SeedPreviewData();
        }

        private void SeedPreviewData()
        {
            DataTable phieu = new DataTable();
            phieu.Columns.Add("ma_phieu_nhap");
            phieu.Columns.Add("ngay_nhap");
            phieu.Columns.Add("ma_nha_cung_cap");
            phieu.Columns.Add("tong_tien");
            phieu.Rows.Add("PN01", DateTime.Today, "NCC01", 1200000);
            phieu.Rows.Add("PN02", DateTime.Today.AddDays(-1), "NCC02", 850000);
            _dgvPhieuNhap.DataSource = phieu;

            DataTable ct = new DataTable();
            ct.Columns.Add("ma_san_pham");
            ct.Columns.Add("so_luong");
            ct.Columns.Add("gia_nhap");
            ct.Columns.Add("thanh_tien");
            ct.Rows.Add("SP01", 10, 12000, 120000);
            ct.Rows.Add("SP02", 5, 30000, 150000);
            _dgvChiTiet.DataSource = ct;

            FormatPhieuNhapGrid();
            FormatChiTietGrid();
            BindSummary();
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
        }

        private void BindSummary()
        {
            if (_dgvPhieuNhap.CurrentRow is null)
            {
                lblMaPhieuValue.Text = "-";
                lblNgayNhapValue.Text = "-";
                lblTongTienValue.Text = "0 đ";
                return;
            }

            lblMaPhieuValue.Text = Convert.ToString(_dgvPhieuNhap.CurrentRow.Cells["ma_phieu_nhap"].Value) ?? "-";
            lblNgayNhapValue.Text = Convert.ToDateTime(_dgvPhieuNhap.CurrentRow.Cells["ngay_nhap"].Value).ToString("dd/MM/yyyy");
            decimal tongTien = Convert.ToDecimal(_dgvPhieuNhap.CurrentRow.Cells["tong_tien"].Value);
            lblTongTienValue.Text = $"{tongTien:N0} đ";
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tạo phiếu nhập");
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
    }
}
