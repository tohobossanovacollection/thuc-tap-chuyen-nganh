namespace WinFormsAppTest
{
    partial class QuanLyNhanVienForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView _dgv;
        private Panel _top;
        private Label _title;
        private Button _btnCrud;
        private Button _btnGanTk;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            _dgv = new DataGridView();
            _top = new Panel();
            _title = new Label();
            _btnCrud = new Button();
            _btnGanTk = new Button();

            ((System.ComponentModel.ISupportInitialize)_dgv).BeginInit();
            _top.SuspendLayout();
            SuspendLayout();

            Text = "10. Quản lý Nhân viên";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(1100, 650);

            _top.Dock = DockStyle.Top;
            _top.Height = 80;
            _top.BackColor = Color.FromArgb(255, 241, 118);

            _title.Text = "Quản lý Nhân viên";
            _title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _title.ForeColor = Color.FromArgb(198, 40, 40);
            _title.AutoSize = true;
            _title.Location = new Point(12, 10);

            _btnCrud.Text = "CRUD";
            _btnCrud.SetBounds(12, 42, 85, 30);
            _btnCrud.BackColor = Color.FromArgb(198, 40, 40);
            _btnCrud.ForeColor = Color.White;
            _btnCrud.Click += btnCrud_Click;

            _btnGanTk.Text = "Gán tài khoản";
            _btnGanTk.SetBounds(102, 42, 100, 30);
            _btnGanTk.BackColor = Color.FromArgb(198, 40, 40);
            _btnGanTk.ForeColor = Color.White;
            _btnGanTk.Click += btnGanTk_Click;

            _top.Controls.AddRange(new Control[] { _title, _btnCrud, _btnGanTk });

            _dgv.Dock = DockStyle.Fill;
            _dgv.ReadOnly = true;
            _dgv.RowHeadersVisible = false;
            _dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            Controls.Add(_dgv);
            Controls.Add(_top);

            _top.ResumeLayout(false);
            _top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_dgv).EndInit();
            ResumeLayout(false);
        }
    }
}
