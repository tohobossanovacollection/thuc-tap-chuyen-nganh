using System.Data;

namespace WinFormsAppTest
{
    public partial class QuanLyPhieuNhapForm : Form
    {
        public QuanLyPhieuNhapForm()
        {
            InitializeComponent();
            SeedPreviewData();
        }

        private void SeedPreviewData()
        {
            DataTable phieu = new DataTable();
            phieu.Columns.Add("ma_phieu_nhap");
            phieu.Columns.Add("ngay_nhap");
            phieu.Columns.Add("tong_tien");
            phieu.Rows.Add("PN01", DateTime.Today, 1200000);
            _dgvPhieuNhap.DataSource = phieu;

            DataTable ct = new DataTable();
            ct.Columns.Add("ma_san_pham");
            ct.Columns.Add("so_luong");
            ct.Columns.Add("gia_nhap");
            ct.Columns.Add("thanh_tien");
            ct.Rows.Add("SP01", 10, 12000, 120000);
            _dgvChiTiet.DataSource = ct;
        }

        private static void SetupGrid(DataGridView dgv)
        {
            dgv.Dock = DockStyle.Fill;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
    }
}
