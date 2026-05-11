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
            _dgv.AllowUserToAddRows = false;
            _dgv.AllowUserToDeleteRows = false;
            _dgv.BackgroundColor = Color.White;
            _dgv.BorderStyle = BorderStyle.None;
            _dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;

            DataGridViewCellStyle headerStyle = new DataGridViewCellStyle();
            headerStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            headerStyle.BackColor = Color.FromArgb(100, 88, 255);
            headerStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            headerStyle.ForeColor = Color.White;
            headerStyle.SelectionBackColor = Color.FromArgb(100, 88, 255);
            headerStyle.SelectionForeColor = Color.White;
            headerStyle.WrapMode = DataGridViewTriState.True;
            _dgv.ColumnHeadersDefaultCellStyle = headerStyle;

            _dgv.ColumnHeadersHeight = 35;
            _dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cellStyle.BackColor = Color.White;
            cellStyle.Font = new Font("Segoe UI", 9F);
            cellStyle.ForeColor = Color.FromArgb(71, 69, 94);
            cellStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            cellStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            cellStyle.WrapMode = DataGridViewTriState.False;
            _dgv.DefaultCellStyle = cellStyle;

            _dgv.Dock = DockStyle.Fill;
            _dgv.EnableHeadersVisualStyles = false;
            _dgv.GridColor = Color.FromArgb(231, 229, 255);
            _dgv.Location = new Point(0, 110);
            _dgv.Name = "_dgv";
            _dgv.ReadOnly = true;
            _dgv.RowHeadersVisible = false;
            _dgv.RowHeadersWidth = 51;
            _dgv.RowTemplate.Height = 35;
            _dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgv.Size = new Size(1100, 540);
            _dgv.TabIndex = 0;
            // 
            // _top
            // 
            _top.BackColor = Color.FromArgb(198, 40, 40);
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
            _btnStatus.BackColor = Color.FromArgb(255, 167, 38);
            _btnStatus.ForeColor = Color.Black;
            _btnStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            _btnStatus.Location = new Point(338, 60);
            _btnStatus.Name = "_btnStatus";
            _btnStatus.Size = new Size(130, 32);
            _btnStatus.TabIndex = 4;
            _btnStatus.Text = "Thay đổi trạng thái";
            _btnStatus.UseVisualStyleBackColor = false;
            _btnStatus.Click += btnStatus_Click;
            // 
            // _title
            // 
            _title.AutoSize = true;
            _title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _title.ForeColor = Color.FromArgb(255, 241, 118);
            _title.Location = new Point(12, 10);
            _title.Name = "_title";
            _title.Size = new Size(235, 37);
            _title.TabIndex = 0;
            _title.Text = "Quản lý Giảm giá";
            // 
            // _btnTao
            // 
            _btnTao.BackColor = Color.FromArgb(255, 167, 38);
            _btnTao.ForeColor = Color.Black;
            _btnTao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            _btnTao.Location = new Point(30, 60);
            _btnTao.Name = "_btnTao";
            _btnTao.Size = new Size(85, 32);
            _btnTao.TabIndex = 1;
            _btnTao.Text = "Tạo mã";
            _btnTao.UseVisualStyleBackColor = false;
            _btnTao.Click += btnTao_Click;
            // 
            // _btnSet
            // 
            _btnSet.BackColor = Color.FromArgb(255, 167, 38);
            _btnSet.ForeColor = Color.Black;
            _btnSet.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            _btnSet.Location = new Point(120, 60);
            _btnSet.Name = "_btnSet";
            _btnSet.Size = new Size(100, 32);
            _btnSet.TabIndex = 2;
            _btnSet.Text = "Set % / tiền";
            _btnSet.UseVisualStyleBackColor = false;
            _btnSet.Click += btnSet_Click;
            // 
            // _btnTime
            // 
            _btnTime.BackColor = Color.FromArgb(255, 167, 38);
            _btnTime.ForeColor = Color.Black;
            _btnTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            _btnTime.Location = new Point(225, 60);
            _btnTime.Name = "_btnTime";
            _btnTime.Size = new Size(100, 32);
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
            Load += QuanLyGiamGiaForm_Load;
            ((System.ComponentModel.ISupportInitialize)_dgv).EndInit();
            _top.ResumeLayout(false);
            _top.PerformLayout();
            ResumeLayout(false);
        }

        private Button _btnStatus;
    }
}
