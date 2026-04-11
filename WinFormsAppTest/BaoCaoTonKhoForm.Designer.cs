namespace WinFormsAppTest
{
    partial class BaoCaoTonKhoForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView _dgvTonKho;
        private DataGridView _dgvSapHet;
        private Panel _top;
        private Label _title;
        private SplitContainer _split;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            _dgvTonKho = new DataGridView();
            _dgvSapHet = new DataGridView();
            _top = new Panel();
            _title = new Label();
            _split = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)_dgvTonKho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_dgvSapHet).BeginInit();
            _top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_split).BeginInit();
            _split.Panel1.SuspendLayout();
            _split.Panel2.SuspendLayout();
            _split.SuspendLayout();
            SuspendLayout();
            // 
            // _dgvTonKho
            // 
            _dgvTonKho.ColumnHeadersHeight = 29;
            _dgvTonKho.Location = new Point(0, 0);
            _dgvTonKho.Name = "_dgvTonKho";
            _dgvTonKho.RowHeadersWidth = 51;
            _dgvTonKho.Size = new Size(683, 259);
            _dgvTonKho.TabIndex = 0;
            // 
            // _dgvSapHet
            // 
            _dgvSapHet.ColumnHeadersHeight = 29;
            _dgvSapHet.Location = new Point(0, 0);
            _dgvSapHet.Name = "_dgvSapHet";
            _dgvSapHet.RowHeadersWidth = 51;
            _dgvSapHet.Size = new Size(695, 150);
            _dgvSapHet.TabIndex = 0;
            // 
            // _top
            // 
            _top.BackColor = Color.FromArgb(255, 241, 118);
            _top.Controls.Add(_title);
            _top.Dock = DockStyle.Top;
            _top.Location = new Point(0, 0);
            _top.Name = "_top";
            _top.Size = new Size(1200, 80);
            _top.TabIndex = 1;
            // 
            // _title
            // 
            _title.AutoSize = true;
            _title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _title.ForeColor = Color.FromArgb(198, 40, 40);
            _title.Location = new Point(12, 10);
            _title.Name = "_title";
            _title.Size = new Size(224, 37);
            _title.TabIndex = 0;
            _title.Text = "Báo cáo tồn kho";
            // 
            // _split
            // 
            _split.Dock = DockStyle.Fill;
            _split.Location = new Point(0, 80);
            _split.Name = "_split";
            _split.Orientation = Orientation.Horizontal;
            // 
            // _split.Panel1
            // 
            _split.Panel1.Controls.Add(_dgvTonKho);
            // 
            // _split.Panel2
            // 
            _split.Panel2.Controls.Add(_dgvSapHet);
            _split.Size = new Size(1200, 620);
            _split.SplitterDistance = 440;
            _split.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)_dgvSapHet).EndInit();
            _top.ResumeLayout(false);
            _top.PerformLayout();
            _split.Panel1.ResumeLayout(false);
            _split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_split).EndInit();
            _split.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
