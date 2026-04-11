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
            components = new System.ComponentModel.Container();
            _dgvTonKho = new DataGridView();
            _dgvSapHet = new DataGridView();
            _top = new Panel();
            _title = new Label();
            _split = new SplitContainer();

            ((System.ComponentModel.ISupportInitialize)_dgvTonKho).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_dgvSapHet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_split).BeginInit();
            _split.Panel1.SuspendLayout();
            _split.Panel2.SuspendLayout();
            _split.SuspendLayout();
            _top.SuspendLayout();
            SuspendLayout();

            Text = "14. Báo cáo tồn kho";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(1200, 700);

            _top.Dock = DockStyle.Top;
            _top.Height = 80;
            _top.BackColor = Color.FromArgb(255, 241, 118);

            _title.Text = "Báo cáo tồn kho";
            _title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _title.ForeColor = Color.FromArgb(198, 40, 40);
            _title.AutoSize = true;
            _title.Location = new Point(12, 10);
            _top.Controls.Add(_title);

            _split.Dock = DockStyle.Fill;
            _split.Orientation = Orientation.Horizontal;
            _split.SplitterDistance = 320;

            SetupGrid(_dgvTonKho);
            SetupGrid(_dgvSapHet);
            _split.Panel1.Controls.Add(_dgvTonKho);
            _split.Panel2.Controls.Add(_dgvSapHet);

            Controls.Add(_split);
            Controls.Add(_top);

            _top.ResumeLayout(false);
            _top.PerformLayout();
            _split.Panel1.ResumeLayout(false);
            _split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_split).EndInit();
            _split.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgvTonKho).EndInit();
            ((System.ComponentModel.ISupportInitialize)_dgvSapHet).EndInit();
            ResumeLayout(false);
        }
    }
}
