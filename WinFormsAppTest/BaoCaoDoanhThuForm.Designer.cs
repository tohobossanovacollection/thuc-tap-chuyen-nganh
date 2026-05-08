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
        private DateTimePicker _dtpFrom;
        private DateTimePicker _dtpTo;
        private Label _lblFrom;
        private Label _lblTo;
        private Button _btnXemBieuDo;
        private SplitContainer _split;
        private SplitContainer _splitTop;
        private Chart _chartCategoryPie;
        private Label _lblRangeLine;
        private Label _lblRangePie;
        private Label _lblTotalRevenue;
        private Button _btnExportExcel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            _dgv = new DataGridView();
            _chart = new Chart();
            _top = new Panel();
            _title = new Label();
            _lblFrom = new Label();
            _dtpFrom = new DateTimePicker();
            _lblTo = new Label();
            _dtpTo = new DateTimePicker();
            _btnXemBieuDo = new Button();
            _split = new SplitContainer();
            _splitTop = new SplitContainer();
            _chartCategoryPie = new Chart();
            _lblRangeLine = new Label();
            _lblRangePie = new Label();
            _lblTotalRevenue = new Label();
            _btnExportExcel = new Button();
            ChartArea chartArea1 = new ChartArea();
            Legend legend1 = new Legend();
            Series series1 = new Series();
            ChartArea chartArea2 = new ChartArea();
            Legend legend2 = new Legend();
            Series series2 = new Series();
            ((System.ComponentModel.ISupportInitialize)_dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_chart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_chartCategoryPie).BeginInit();
            _top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_split).BeginInit();
            _split.Panel1.SuspendLayout();
            _split.Panel2.SuspendLayout();
            _split.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_splitTop).BeginInit();
            _splitTop.Panel1.SuspendLayout();
            _splitTop.Panel2.SuspendLayout();
            _splitTop.SuspendLayout();
            SuspendLayout();
            // 
            // _dgv
            // 
            _dgv.AllowUserToAddRows = false;
            _dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            _dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            _dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            _dgv.ColumnHeadersHeight = 29;
            _dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _dgv.DefaultCellStyle = dataGridViewCellStyle3;
            _dgv.Dock = DockStyle.Fill;
            _dgv.EnableHeadersVisualStyles = false;
            _dgv.GridColor = Color.FromArgb(231, 229, 255);
            _dgv.Location = new Point(0, 0);
            _dgv.Name = "_dgv";
            _dgv.ReadOnly = true;
            _dgv.RowHeadersVisible = false;
            _dgv.RowHeadersWidth = 51;
            _dgv.RowTemplate.Height = 29;
            _dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgv.Size = new Size(1200, 416);
            _dgv.TabIndex = 0;
            // 
            // _top
            // 
            _top.BackColor = Color.FromArgb(255, 241, 118);
            _top.Controls.Add(_title);
            _top.Controls.Add(_lblTotalRevenue);
            _top.Controls.Add(_lblFrom);
            _top.Controls.Add(_dtpFrom);
            _top.Controls.Add(_lblTo);
            _top.Controls.Add(_dtpTo);
            _top.Controls.Add(_btnXemBieuDo);
            _top.Controls.Add(_btnExportExcel);
            _top.Dock = DockStyle.Top;
            _top.Location = new Point(0, 0);
            _top.Name = "_top";
            _top.Size = new Size(1200, 113);
            _top.TabIndex = 1;
            _top.Paint += _top_Paint;
            // 
            // _title
            // 
            _title.AutoSize = true;
            _title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _title.ForeColor = Color.FromArgb(198, 40, 40);
            _title.Location = new Point(12, 10);
            _title.Name = "_title";
            _title.Size = new Size(501, 37);
            _title.TabIndex = 0;
            _title.Text = "Báo cáo doanh thu (ngày/tháng/năm)";
            // 
            // _lblFrom
            // 
            _lblFrom.AutoSize = true;
            _lblFrom.Location = new Point(11, 70);
            _lblFrom.Name = "_lblFrom";
            _lblFrom.Size = new Size(65, 20);
            _lblFrom.TabIndex = 1;
            _lblFrom.Text = "Từ ngày:";
            // 
            // _dtpFrom
            // 
            _dtpFrom.Format = DateTimePickerFormat.Short;
            _dtpFrom.Location = new Point(82, 70);
            _dtpFrom.Name = "_dtpFrom";
            _dtpFrom.Size = new Size(120, 27);
            _dtpFrom.TabIndex = 2;
            // 
            // _lblTo
            // 
            _lblTo.AutoSize = true;
            _lblTo.Location = new Point(237, 72);
            _lblTo.Name = "_lblTo";
            _lblTo.Size = new Size(75, 20);
            _lblTo.TabIndex = 3;
            _lblTo.Text = "Đến ngày:";
            // 
            // _dtpTo
            // 
            _dtpTo.Format = DateTimePickerFormat.Short;
            _dtpTo.Location = new Point(319, 69);
            _dtpTo.Name = "_dtpTo";
            _dtpTo.Size = new Size(120, 27);
            _dtpTo.TabIndex = 4;
            // 
            // _btnXemBieuDo
            // 
            _btnXemBieuDo.BackColor = Color.FromArgb(198, 40, 40);
            _btnXemBieuDo.ForeColor = Color.White;
            _btnXemBieuDo.Location = new Point(455, 67);
            _btnXemBieuDo.Name = "_btnXemBieuDo";
            _btnXemBieuDo.Size = new Size(110, 30);
            _btnXemBieuDo.TabIndex = 5;
            _btnXemBieuDo.Text = "Xem biểu đồ";
            _btnXemBieuDo.UseVisualStyleBackColor = false;
            _btnXemBieuDo.Click += btnXemBieuDo_Click;
            // 
            // _lblTotalRevenue
            // 
            _lblTotalRevenue.AutoSize = true;
            _lblTotalRevenue.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            _lblTotalRevenue.ForeColor = Color.FromArgb(198, 40, 40);
            _lblTotalRevenue.Location = new Point(720, 70);
            _lblTotalRevenue.Name = "_lblTotalRevenue";
            _lblTotalRevenue.Size = new Size(148, 23);
            _lblTotalRevenue.TabIndex = 6;
            _lblTotalRevenue.Text = "Tổng thành tiền: 0";
            // 
            // _btnExportExcel
            // 
            _btnExportExcel.BackColor = Color.FromArgb(76, 175, 80);
            _btnExportExcel.ForeColor = Color.White;
            _btnExportExcel.Location = new Point(575, 67);
            _btnExportExcel.Name = "_btnExportExcel";
            _btnExportExcel.Size = new Size(120, 30);
            _btnExportExcel.TabIndex = 7;
            _btnExportExcel.Text = "Xuất Excel";
            _btnExportExcel.UseVisualStyleBackColor = false;
            _btnExportExcel.Click += btnExportExcel_Click;
            // 
            // _split
            // 
            _split.Dock = DockStyle.Fill;
            _split.Location = new Point(0, 113);
            _split.Name = "_split";
            _split.Orientation = Orientation.Horizontal;
            // 
            // _split.Panel1
            // 
            _split.Panel1.Controls.Add(_splitTop);
            // 
            // _split.Panel2
            // 
            _split.Panel2.Controls.Add(_chart);
            _split.Panel2.Controls.Add(_lblRangeLine);
            _split.Size = new Size(1200, 587);
            _split.SplitterDistance = 380;
            _split.TabIndex = 0;
            // 
            // _splitTop
            // 
            _splitTop.Dock = DockStyle.Fill;
            _splitTop.Location = new Point(0, 0);
            _splitTop.Name = "_splitTop";
            // 
            // _splitTop.Panel1
            // 
            _splitTop.Panel1.Controls.Add(_dgv);
            // 
            // _splitTop.Panel2
            // 
            _splitTop.Panel2.Controls.Add(_chartCategoryPie);
            _splitTop.Panel2.Controls.Add(_lblRangePie);
            _splitTop.Size = new Size(1200, 380);
            _splitTop.SplitterDistance = 600;
            _splitTop.TabIndex = 0;
            // 
            // _chart
            // 
            chartArea1.Name = "ChartArea1";
            _chart.ChartAreas.Add(chartArea1);
            _chart.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            _chart.Legends.Add(legend1);
            _chart.Location = new Point(0, 0);
            _chart.Name = "_chart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "DoanhThu";
            series1.ChartType = SeriesChartType.Column;
            _chart.Series.Add(series1);
            _chart.Size = new Size(1200, 167);
            _chart.TabIndex = 0;
            _chart.Text = "chart1";
            // 
            // _chartCategoryPie
            // 
            chartArea2.Name = "PieArea";
            _chartCategoryPie.ChartAreas.Add(chartArea2);
            _chartCategoryPie.Dock = DockStyle.Fill;
            legend2.Name = "PieLegend";
            _chartCategoryPie.Legends.Add(legend2);
            _chartCategoryPie.Location = new Point(0, 0);
            _chartCategoryPie.Name = "_chartCategoryPie";
            series2.ChartArea = "PieArea";
            series2.ChartType = SeriesChartType.Pie;
            series2.Legend = "PieLegend";
            series2.Name = "TyLeDanhMuc";
            _chartCategoryPie.Series.Add(series2);
            _chartCategoryPie.Size = new Size(596, 380);
            _chartCategoryPie.TabIndex = 0;
            _chartCategoryPie.Text = "chart2";
            // 
            // _lblRangeLine
            // 
            _lblRangeLine.Dock = DockStyle.Bottom;
            _lblRangeLine.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            _lblRangeLine.ForeColor = Color.DimGray;
            _lblRangeLine.Height = 25;
            _lblRangeLine.TextAlign = ContentAlignment.MiddleCenter;
            _lblRangeLine.Text = "Từ ngày ... đến ngày ...";
            // 
            // _lblRangePie
            // 
            _lblRangePie.Dock = DockStyle.Bottom;
            _lblRangePie.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            _lblRangePie.ForeColor = Color.DimGray;
            _lblRangePie.Height = 25;
            _lblRangePie.TextAlign = ContentAlignment.MiddleCenter;
            _lblRangePie.Text = "Từ ngày ... đến ngày ...";
            // 
            // BaoCaoDoanhThuForm
            // 
            ClientSize = new Size(1200, 700);
            Controls.Add(_split);
            Controls.Add(_top);
            Name = "BaoCaoDoanhThuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "13. Báo cáo doanh thu";
            ((System.ComponentModel.ISupportInitialize)_dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)_chart).EndInit();
            ((System.ComponentModel.ISupportInitialize)_chartCategoryPie).EndInit();
            _top.ResumeLayout(false);
            _top.PerformLayout();
            _split.Panel1.ResumeLayout(false);
            _split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_split).EndInit();
            _split.ResumeLayout(false);
            _splitTop.Panel1.ResumeLayout(false);
            _splitTop.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_splitTop).EndInit();
            _splitTop.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
