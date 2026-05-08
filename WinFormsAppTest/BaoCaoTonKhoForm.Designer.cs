namespace WinFormsAppTest
{
    partial class BaoCaoTonKhoForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView _dgvTonKho;
        private Panel _top;
        private Label _title;
        private Label _lblTrangThai;
        private ComboBox _cmbTrangThai;
        private Button _btnXem;
        private SplitContainer _split;
        private System.Windows.Forms.DataVisualization.Charting.Chart _chartLowStock;
        private Label _lblWarning;
        private Button _btnExportExcel;
        private TableLayoutPanel _tlpDashboard;

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
            _dgvTonKho = new DataGridView();
            _lblTrangThai = new Label();
            _cmbTrangThai = new ComboBox();
            _btnXem = new Button();
            _btnExportExcel = new Button();
            _top = new Panel();
            _title = new Label();
            _split = new SplitContainer();
            _chartLowStock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            _lblWarning = new Label();
            _tlpDashboard = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)_dgvTonKho).BeginInit();
            _top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_split).BeginInit();
            _split.Panel1.SuspendLayout();
            _split.Panel2.SuspendLayout();
            _split.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_chartLowStock).BeginInit();
            SuspendLayout();
            // 
            // _dgvTonKho
            // 
            _dgvTonKho.AllowUserToAddRows = false;
            _dgvTonKho.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            _dgvTonKho.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            _dgvTonKho.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _dgvTonKho.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _dgvTonKho.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            _dgvTonKho.ColumnHeadersHeight = 29;
            _dgvTonKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _dgvTonKho.DefaultCellStyle = dataGridViewCellStyle3;
            _dgvTonKho.Dock = DockStyle.Fill;
            _dgvTonKho.EnableHeadersVisualStyles = false;
            _dgvTonKho.GridColor = Color.FromArgb(231, 229, 255);
            _dgvTonKho.Location = new Point(0, 0);
            _dgvTonKho.Name = "_dgvTonKho";
            _dgvTonKho.ReadOnly = true;
            _dgvTonKho.RowHeadersVisible = false;
            _dgvTonKho.RowHeadersWidth = 51;
            _dgvTonKho.RowTemplate.Height = 29;
            _dgvTonKho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvTonKho.Size = new Size(600, 604);
            _dgvTonKho.TabIndex = 0;
            // 
            // _lblTrangThai
            // 
            _lblTrangThai.AutoSize = true;
            _lblTrangThai.Location = new Point(11, 58);
            _lblTrangThai.Name = "_lblTrangThai";
            _lblTrangThai.Size = new Size(78, 20);
            _lblTrangThai.TabIndex = 1;
            _lblTrangThai.Text = "Trạng thái:";
            // 
            // _cmbTrangThai
            // 
            _cmbTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            _cmbTrangThai.Location = new Point(92, 54);
            _cmbTrangThai.Name = "_cmbTrangThai";
            _cmbTrangThai.Size = new Size(150, 28);
            _cmbTrangThai.TabIndex = 2;
            // 
            // _btnXem
            // 
            _btnXem.BackColor = Color.FromArgb(198, 40, 40);
            _btnXem.ForeColor = Color.White;
            _btnXem.Location = new Point(254, 53);
            _btnXem.Name = "_btnXem";
            _btnXem.Size = new Size(80, 30);
            _btnXem.TabIndex = 3;
            _btnXem.Text = "Xem";
            _btnXem.UseVisualStyleBackColor = false;
            _btnXem.Click += btnXem_Click;
            // 
            // _btnExportExcel
            // 
            _btnExportExcel.BackColor = Color.FromArgb(76, 175, 80);
            _btnExportExcel.ForeColor = Color.White;
            _btnExportExcel.Location = new Point(340, 53);
            _btnExportExcel.Name = "_btnExportExcel";
            _btnExportExcel.Size = new Size(120, 30);
            _btnExportExcel.TabIndex = 4;
            _btnExportExcel.Text = "Xuất Excel";
            _btnExportExcel.UseVisualStyleBackColor = false;
            _btnExportExcel.Click += btnExportExcel_Click;
            // 
            // _top
            // 
            _top.BackColor = Color.FromArgb(255, 241, 118);
            _top.Controls.Add(_title);
            _top.Controls.Add(_lblTrangThai);
            _top.Controls.Add(_cmbTrangThai);
            _top.Controls.Add(_btnXem);
            _top.Controls.Add(_btnExportExcel);
            _top.Dock = DockStyle.Top;
            _top.Location = new Point(0, 0);
            _top.Name = "_top";
            _top.Size = new Size(1200, 96);
            _top.TabIndex = 1;
            // 
            // _title
            // 
            _title.AutoSize = true;
            _title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _title.ForeColor = Color.FromArgb(198, 40, 40);
            _title.Location = new Point(12, 8);
            _title.Name = "_title";
            _title.Size = new Size(224, 37);
            _title.TabIndex = 0;
            _title.Text = "Báo cáo tồn kho";
            // _split
            // 
            _split.Dock = DockStyle.Fill;
            _split.Location = new Point(0, 96);
            _split.Name = "_split";
            // 
            // _split.Panel1
            // 
            _split.Panel1.Controls.Add(_dgvTonKho);
            // 
            // _split.Panel2
            // 
            _split.Panel2.Controls.Add(_tlpDashboard);
            _split.Panel2.Padding = new Padding(10);
            _split.Size = new Size(1200, 604);
            _split.SplitterDistance = 600;
            _split.TabIndex = 2;
            // 
            // _tlpDashboard
            // 
            _tlpDashboard.ColumnCount = 2;
            _tlpDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            _tlpDashboard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            _tlpDashboard.Controls.Add(_lblWarning, 0, 0);
            _tlpDashboard.Controls.Add(_chartLowStock, 0, 1);
            _tlpDashboard.Dock = DockStyle.Fill;
            _tlpDashboard.Location = new Point(10, 10);
            _tlpDashboard.Name = "_tlpDashboard";
            _tlpDashboard.RowCount = 2;
            _tlpDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            _tlpDashboard.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            _tlpDashboard.Size = new Size(576, 584);
            _tlpDashboard.TabIndex = 0;
            _tlpDashboard.SetColumnSpan(_lblWarning, 2);
            _tlpDashboard.SetColumnSpan(_chartLowStock, 2);
            // 
            // _chartLowStock
            // 
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            chartArea1.Name = "ChartArea1";
            _chartLowStock.ChartAreas.Add(chartArea1);
            _chartLowStock.Dock = DockStyle.Fill;
            _chartLowStock.Location = new Point(3, 236);
            _chartLowStock.Name = "_chartLowStock";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Stock";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            _chartLowStock.Series.Add(series1);
            _chartLowStock.Size = new Size(570, 345);
            _chartLowStock.TabIndex = 0;
            // 
            // _lblWarning
            // 
            _lblWarning.Dock = DockStyle.Fill;
            _lblWarning.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            _lblWarning.ForeColor = Color.FromArgb(198, 40, 40);
            _lblWarning.Location = new Point(3, 0);
            _lblWarning.Name = "_lblWarning";
            _lblWarning.Text = "CẢNH BÁO HÀNG SẮP HẾT:\n...";
            _lblWarning.TextAlign = ContentAlignment.TopLeft;
            // 
            // BaoCaoTonKhoForm
            // 
            ClientSize = new Size(1200, 700);
            Controls.Add(_split);
            Controls.Add(_top);
            Name = "BaoCaoTonKhoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "14. Báo cáo tồn kho";
            ((System.ComponentModel.ISupportInitialize)_dgvTonKho).EndInit();
            _top.ResumeLayout(false);
            _top.PerformLayout();
            _split.Panel1.ResumeLayout(false);
            _split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_split).EndInit();
            _split.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_chartLowStock).EndInit();
            ResumeLayout(false);
        }
    }
}
