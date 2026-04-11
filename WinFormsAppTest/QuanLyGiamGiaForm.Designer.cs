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
            _dgv = new DataGridView();
            _top = new Panel();
            _btnStatus = new Button();
            _title = new Label();
            _btnTao = new Button();
            _btnSet = new Button();
            _btnTime = new Button();
            ((System.ComponentModel.ISupportInitialize)_dgv).BeginInit();
            _top.SuspendLayout();
            SuspendLayout();
            // 
            // _dgv
            // 
            _dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgv.ColumnHeadersHeight = 29;
            _dgv.Dock = DockStyle.Fill;
            _dgv.Location = new Point(0, 110);
            _dgv.Name = "_dgv";
            _dgv.ReadOnly = true;
            _dgv.RowHeadersVisible = false;
            _dgv.RowHeadersWidth = 51;
            _dgv.Size = new Size(1100, 540);
            _dgv.TabIndex = 0;
            // 
            // _top
            // 
            _top.BackColor = Color.FromArgb(255, 241, 118);
            _top.Controls.Add(_btnStatus);
            _top.Controls.Add(_title);
            _top.Controls.Add(_btnTao);
            _top.Controls.Add(_btnSet);
            _top.Controls.Add(_btnTime);
            _top.Dock = DockStyle.Top;
            _top.Location = new Point(0, 0);
            _top.Name = "_top";
            _top.Size = new Size(1100, 110);
            _top.TabIndex = 1;
            // 
            // _btnStatus
            // 
            _btnStatus.BackColor = Color.FromArgb(198, 40, 40);
            _btnStatus.ForeColor = Color.White;
            _btnStatus.Location = new Point(338, 61);
            _btnStatus.Name = "_btnStatus";
            _btnStatus.Size = new Size(152, 30);
            _btnStatus.TabIndex = 4;
            _btnStatus.Text = "Thay đổi trạng thái";
            _btnStatus.UseVisualStyleBackColor = false;
            // 
            // _title
            // 
            _title.AutoSize = true;
            _title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _title.ForeColor = Color.FromArgb(198, 40, 40);
            _title.Location = new Point(12, 10);
            _title.Name = "_title";
            _title.Size = new Size(235, 37);
            _title.TabIndex = 0;
            _title.Text = "Quản lý Giảm giá";
            // 
            // _btnTao
            // 
            _btnTao.BackColor = Color.FromArgb(198, 40, 40);
            _btnTao.ForeColor = Color.White;
            _btnTao.Location = new Point(12, 61);
            _btnTao.Name = "_btnTao";
            _btnTao.Size = new Size(85, 30);
            _btnTao.TabIndex = 1;
            _btnTao.Text = "Tạo mã";
            _btnTao.UseVisualStyleBackColor = false;
            _btnTao.Click += btnTao_Click;
            // 
            // _btnSet
            // 
            _btnSet.BackColor = Color.FromArgb(198, 40, 40);
            _btnSet.ForeColor = Color.White;
            _btnSet.Location = new Point(102, 61);
            _btnSet.Name = "_btnSet";
            _btnSet.Size = new Size(110, 30);
            _btnSet.TabIndex = 2;
            _btnSet.Text = "Set % / tiền";
            _btnSet.UseVisualStyleBackColor = false;
            _btnSet.Click += btnSet_Click;
            // 
            // _btnTime
            // 
            _btnTime.BackColor = Color.FromArgb(198, 40, 40);
            _btnTime.ForeColor = Color.White;
            _btnTime.Location = new Point(222, 61);
            _btnTime.Name = "_btnTime";
            _btnTime.Size = new Size(110, 30);
            _btnTime.TabIndex = 3;
            _btnTime.Text = "Set thời gian";
            _btnTime.UseVisualStyleBackColor = false;
            _btnTime.Click += btnTime_Click;
            // 
            // QuanLyGiamGiaForm
            // 
            ClientSize = new Size(1100, 650);
            Controls.Add(_dgv);
            Controls.Add(_top);
            Name = "QuanLyGiamGiaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "12. Quản lý Giảm giá";
            ((System.ComponentModel.ISupportInitialize)_dgv).EndInit();
            _top.ResumeLayout(false);
            _top.PerformLayout();
            ResumeLayout(false);
        }

        private Button _btnStatus;
    }
}
