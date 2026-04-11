namespace WinFormsAppTest
{
    partial class QuanLyTaiKhoanForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView _dgv;
        private Panel _top;
        private Label _title;
        private Button _btnTao;
        private Button _btnPhanQuyen;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            _dgv = new DataGridView();
            _top = new Panel();
            _title = new Label();
            _btnTao = new Button();
            _btnPhanQuyen = new Button();

            ((System.ComponentModel.ISupportInitialize)_dgv).BeginInit();
            _top.SuspendLayout();
            SuspendLayout();

            Text = "11. Quản lý Tài khoản";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(1000, 620);

            _top.Dock = DockStyle.Top;
            _top.Height = 80;
            _top.BackColor = Color.FromArgb(255, 241, 118);

            _title.Text = "Quản lý Tài khoản";
            _title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _title.ForeColor = Color.FromArgb(198, 40, 40);
            _title.AutoSize = true;
            _title.Location = new Point(12, 10);

            _btnTao.Text = "Tạo tài khoản";
            _btnTao.Location = new Point(12, 42);
            _btnTao.Size = new Size(105, 30);
            _btnTao.BackColor = Color.FromArgb(198, 40, 40);
            _btnTao.ForeColor = Color.White;
            _btnTao.Click += btnTao_Click;

            _btnPhanQuyen.Text = "Phân quyền";
            _btnPhanQuyen.Location = new Point(122, 42);
            _btnPhanQuyen.Size = new Size(105, 30);
            _btnPhanQuyen.BackColor = Color.FromArgb(198, 40, 40);
            _btnPhanQuyen.ForeColor = Color.White;
            _btnPhanQuyen.Click += btnPhanQuyen_Click;

            _top.Controls.Add(_title);
            _top.Controls.Add(_btnTao);
            _top.Controls.Add(_btnPhanQuyen);

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
