using System.Data;
using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsAppTest
{
    public partial class BaoCaoDoanhThuForm : Form
    {
        public BaoCaoDoanhThuForm()
        {
            InitializeComponent();
            SeedPreview();
        }

        private void SeedPreview()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Ky");
            dt.Columns.Add("DoanhThu", typeof(decimal));
            dt.Rows.Add("T2", 1200000m);
            dt.Rows.Add("T3", 950000m);
            dt.Rows.Add("T4", 1600000m);
            _dgv.DataSource = dt;

            foreach (DataRow row in dt.Rows)
            {
                _chart.Series[0].Points.AddXY(row["Ky"], row["DoanhThu"]);
            }
        }

        private void btnTongHop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tổng hợp doanh thu");
        }
    }
}
