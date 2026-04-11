using System.Windows.Forms.DataVisualization.Charting;

namespace WinFormsAppTest
{
    partial class BaoCaoDoanhThuForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView _dgv;
        private Chart _chart;
        private Panel _top;
        private Label _title;
        private Button _btnTongHop;
        private SplitContainer _split;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            _dgv = new DataGridView();
            _chart = new Chart();
            _top = new Panel();
            _title = new Label();
            _btnTongHop = new Button();
            _split = new SplitContainer();

            ((System.ComponentModel.ISupportInitialize)_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_chart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_split).BeginInit();
            _split.Panel1.SuspendLayout();
            _split.Panel2.SuspendLayout();
            _split.SuspendLayout();
            _top.SuspendLayout();
            SuspendLayout();

            Text = "13. Báo cáo doanh thu";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(1200, 700);

            _top.Dock = DockStyle.Top;
            _top.Height = 80;
            _top.BackColor = Color.FromArgb(255, 241, 118);

            _title.Text = "Báo cáo doanh thu (ngày/tháng/năm)";
            _title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _title.ForeColor = Color.FromArgb(198, 40, 40);
            _title.AutoSize = true;
            _title.Location = new Point(12, 10);

            _btnTongHop.Text = "Tổng hợp";
            _btnTongHop.Location = new Point(12, 42);
            _btnTongHop.Size = new Size(100, 30);
            _btnTongHop.BackColor = Color.FromArgb(198, 40, 40);
            _btnTongHop.ForeColor = Color.White;
            _btnTongHop.Click += btnTongHop_Click;

            _top.Controls.AddRange(new Control[] { _title, _btnTongHop });

            _split.Dock = DockStyle.Fill;
            _split.Orientation = Orientation.Horizontal;
            _split.SplitterDistance = 260;

            _dgv.Dock = DockStyle.Fill;
            _dgv.ReadOnly = true;
            _dgv.RowHeadersVisible = false;
            _dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            _chart.Dock = DockStyle.Fill;
            ChartArea area = new ChartArea("main");
            _chart.ChartAreas.Add(area);
            Series s = new Series("Doanh thu");
            s.ChartType = SeriesChartType.Column;
            _chart.Series.Add(s);

            _split.Panel1.Controls.Add(_dgv);
            _split.Panel2.Controls.Add(_chart);

            Controls.Add(_split);
            Controls.Add(_top);

            _top.ResumeLayout(false);
            _top.PerformLayout();
            _split.Panel1.ResumeLayout(false);
            _split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_split).EndInit();
            _split.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)_chart).EndInit();
            ResumeLayout(false);
        }
    }
}
