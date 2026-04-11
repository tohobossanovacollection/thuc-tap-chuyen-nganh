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
            _dgv = new DataGridView();
            _top = new Panel();
            _title = new Label();
            _btnTao = new Button();
            _btnPhanQuyen = new Button();
            ((System.ComponentModel.ISupportInitialize)_dgv).BeginInit();
            _top.SuspendLayout();
            SuspendLayout();
            // 
            // _dgv
            // 
            _dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgv.ColumnHeadersHeight = 29;
            _dgv.Dock = DockStyle.Fill;
            _dgv.Location = new Point(0, 99);
            _dgv.Name = "_dgv";
            _dgv.ReadOnly = true;
            _dgv.RowHeadersVisible = false;
            _dgv.RowHeadersWidth = 51;
            _dgv.Size = new Size(1000, 521);
            _dgv.TabIndex = 0;
            // 
            // _top
            // 
            _top.BackColor = Color.FromArgb(255, 241, 118);
            _top.Controls.Add(_title);
            _top.Controls.Add(_btnTao);
            _top.Controls.Add(_btnPhanQuyen);
            _top.Dock = DockStyle.Top;
            _top.Location = new Point(0, 0);
            _top.Name = "_top";
            _top.Size = new Size(1000, 99);
            _top.TabIndex = 1;
            // 
            // _title
            // 
            _title.AutoSize = true;
            _title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _title.ForeColor = Color.FromArgb(198, 40, 40);
            _title.Location = new Point(12, 10);
            _title.Name = "_title";
            _title.Size = new Size(244, 37);
            _title.TabIndex = 0;
            _title.Text = "Quản lý Tài khoản";
            // 
            // _btnTao
            // 
            _btnTao.BackColor = Color.FromArgb(198, 40, 40);
            _btnTao.ForeColor = Color.White;
            _btnTao.Location = new Point(11, 59);
            _btnTao.Name = "_btnTao";
            _btnTao.Size = new Size(133, 30);
            _btnTao.TabIndex = 1;
            _btnTao.Text = "Tạo tài khoản";
            _btnTao.UseVisualStyleBackColor = false;
            _btnTao.Click += btnTao_Click;
            // 
            // _btnPhanQuyen
            // 
            _btnPhanQuyen.BackColor = Color.FromArgb(198, 40, 40);
            _btnPhanQuyen.ForeColor = Color.White;
            _btnPhanQuyen.Location = new Point(167, 59);
            _btnPhanQuyen.Name = "_btnPhanQuyen";
            _btnPhanQuyen.Size = new Size(133, 30);
            _btnPhanQuyen.TabIndex = 2;
            _btnPhanQuyen.Text = "Phân quyền";
            _btnPhanQuyen.UseVisualStyleBackColor = false;
            _btnPhanQuyen.Click += btnPhanQuyen_Click;
            // 
            // QuanLyTaiKhoanForm
            // 
            ClientSize = new Size(1000, 620);
            Controls.Add(_dgv);
            Controls.Add(_top);
            Name = "QuanLyTaiKhoanForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "11. Quản lý Tài khoản";
            ((System.ComponentModel.ISupportInitialize)_dgv).EndInit();
            _top.ResumeLayout(false);
            _top.PerformLayout();
            ResumeLayout(false);
        }
    }
}
