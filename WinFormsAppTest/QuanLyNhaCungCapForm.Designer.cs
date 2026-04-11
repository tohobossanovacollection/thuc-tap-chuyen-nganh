namespace WinFormsAppTest
{
    partial class QuanLyNhaCungCapForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView _dgv;
        private Panel _top;
        private Label _title;
        private Button _btnCrud;

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

            ((System.ComponentModel.ISupportInitialize)_dgv).BeginInit();
            _top.SuspendLayout();
            SuspendLayout();

            Text = "8. Quản lý Nhà cung cấp";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(1000, 650);

            _top.Dock = DockStyle.Top;
            _top.Height = 80;
            _top.BackColor = Color.FromArgb(255, 241, 118);

            _title.Text = "Quản lý Nhà cung cấp";
            _title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _title.ForeColor = Color.FromArgb(198, 40, 40);
            _title.AutoSize = true;
            _title.Location = new Point(12, 10);

            _btnCrud.Text = "CRUD Nhà cung cấp";
            _btnCrud.Location = new Point(12, 42);
            _btnCrud.Size = new Size(150, 30);
            _btnCrud.BackColor = Color.FromArgb(198, 40, 40);
            _btnCrud.ForeColor = Color.White;
            _btnCrud.Click += btnCrud_Click;

            _top.Controls.AddRange(new Control[] { _title, _btnCrud });

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
