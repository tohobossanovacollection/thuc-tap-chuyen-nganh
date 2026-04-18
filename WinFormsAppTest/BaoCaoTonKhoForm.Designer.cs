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
            _top = new Panel();
            _title = new Label();
            ((System.ComponentModel.ISupportInitialize)_dgvTonKho).BeginInit();
            _top.SuspendLayout();
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
            _dgvTonKho.EnableHeadersVisualStyles = false;
            _dgvTonKho.GridColor = Color.FromArgb(231, 229, 255);
            _dgvTonKho.Location = new Point(0, 102);
            _dgvTonKho.Name = "_dgvTonKho";
            _dgvTonKho.ReadOnly = true;
            _dgvTonKho.RowHeadersVisible = false;
            _dgvTonKho.RowHeadersWidth = 51;
            _dgvTonKho.RowTemplate.Height = 29;
            _dgvTonKho.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvTonKho.Size = new Size(1200, 598);
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
            // _top
            // 
            _top.BackColor = Color.FromArgb(255, 241, 118);
            _top.Controls.Add(_title);
            _top.Controls.Add(_lblTrangThai);
            _top.Controls.Add(_cmbTrangThai);
            _top.Controls.Add(_btnXem);
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
            // 
            // BaoCaoTonKhoForm
            // 
            ClientSize = new Size(1200, 700);
            Controls.Add(_dgvTonKho);
            Controls.Add(_top);
            Name = "BaoCaoTonKhoForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "14. Báo cáo tồn kho";
            ((System.ComponentModel.ISupportInitialize)_dgvTonKho).EndInit();
            _top.ResumeLayout(false);
            _top.PerformLayout();
            ResumeLayout(false);
        }
    }
}
