namespace WinFormsAppTest
{
    partial class QuanLyGiamGiaForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView _dgv;
        private Panel _top;
        private Label _title;
        private Button _btnTao;
        private Button _btnSet;
        private Button _btnTime;

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
            _btnTao = new Button();
            _btnSet = new Button();
            _btnTime = new Button();

            ((System.ComponentModel.ISupportInitialize)_dgv).BeginInit();
            _top.SuspendLayout();
            SuspendLayout();

            Text = "12. Quản lý Giảm giá";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(1100, 650);

            _top.Dock = DockStyle.Top;
            _top.Height = 80;
            _top.BackColor = Color.FromArgb(255, 241, 118);

            _title.Text = "Quản lý Giảm giá";
            _title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _title.ForeColor = Color.FromArgb(198, 40, 40);
            _title.AutoSize = true;
            _title.Location = new Point(12, 10);

            _btnTao.Text = "Tạo mã";
            _btnTao.SetBounds(12, 42, 85, 30);
            _btnTao.BackColor = Color.FromArgb(198, 40, 40);
            _btnTao.ForeColor = Color.White;
            _btnTao.Click += btnTao_Click;

            _btnSet.Text = "Set % / tiền";
            _btnSet.SetBounds(102, 42, 110, 30);
            _btnSet.BackColor = Color.FromArgb(198, 40, 40);
            _btnSet.ForeColor = Color.White;
            _btnSet.Click += btnSet_Click;

            _btnTime.Text = "Set thời gian";
            _btnTime.SetBounds(222, 42, 110, 30);
            _btnTime.BackColor = Color.FromArgb(198, 40, 40);
            _btnTime.ForeColor = Color.White;
            _btnTime.Click += btnTime_Click;

            _top.Controls.AddRange(new Control[] { _title, _btnTao, _btnSet, _btnTime });

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
