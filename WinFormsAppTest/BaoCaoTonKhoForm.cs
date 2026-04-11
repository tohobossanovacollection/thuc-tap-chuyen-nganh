using System.Data;

namespace WinFormsAppTest
{
    public partial class BaoCaoTonKhoForm : Form
    {
        public BaoCaoTonKhoForm()
        {
            InitializeComponent();
            SeedPreview();
        }

        private void SeedPreview()
        {
            DataTable all = new DataTable();
            all.Columns.Add("ma_san_pham");
            all.Columns.Add("ten_san_pham");
            all.Columns.Add("so_luong_ton", typeof(int));
            all.Rows.Add("SP01", "Nước cam", 40);
            all.Rows.Add("SP02", "Bánh mì", 8);
            _dgvTonKho.DataSource = all;

            DataTable low = all.Clone();
            low.Rows.Add("SP02", "Bánh mì", 8);
            _dgvSapHet.DataSource = low;
        }

        private static void SetupGrid(DataGridView dgv)
        {
            dgv.Dock = DockStyle.Fill;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
