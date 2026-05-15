using Guna.UI2.WinForms;

namespace WinFormsAppTest
{
    partial class QuanLyGiamGiaForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView _dgv;
        private Panel _top;
        private Label _title;
        private Guna2Button _btnTao;
        private Guna2Button _btnSet;
        private Guna2Button _btnTime;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            _dgv = new DataGridView();
            _top = new Panel();
            _btnStatus = new Guna2Button();
            _title = new Label();
            _btnTao = new Guna2Button();
            _btnSet = new Guna2Button();
            _btnTime = new Guna2Button();
            ((System.ComponentModel.ISupportInitialize)_dgv).BeginInit();
            _top.SuspendLayout();
            SuspendLayout();
            // 
            // _dgv
            // 
            _dgv.AllowUserToAddRows = false;
            _dgv.AllowUserToDeleteRows = false;
            _dgv.AlternatingRowsDefaultCellStyle = new DataGridViewCellStyle { BackColor = Color.White };
            _dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

            _dgv.ColumnHeadersHeight = 29;
            _dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
            cellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            cellStyle.BackColor = Color.White;
            cellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            cellStyle.ForeColor = Color.FromArgb(71, 69, 94);
            cellStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            cellStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            cellStyle.WrapMode = DataGridViewTriState.False;
            _dgv.DefaultCellStyle = cellStyle;

            _dgv.Dock = DockStyle.Fill;
            _dgv.EnableHeadersVisualStyles = false;
            _dgv.GridColor = Color.FromArgb(231, 229, 255);
            _dgv.Location = new Point(0, 86);
            _dgv.Name = "_dgv";
            _dgv.ReadOnly = true;
            _dgv.RowHeadersVisible = false;
            _dgv.RowHeadersWidth = 51;
            _dgv.RowTemplate.Height = 29;
            _dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgv.Size = new Size(1200, 614);
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
            _top.Size = new Size(1200, 86);
            _top.TabIndex = 1;
            // 
            // _btnStatus
            // 
            _btnStatus.BorderColor = Color.White;
            _btnStatus.BorderRadius = 8;
            _btnStatus.BorderThickness = 1;
            _btnStatus.FillColor = Color.FromArgb(255, 167, 38);
            _btnStatus.ForeColor = Color.Black;
            _btnStatus.Font = new Font("Segoe UI", 9F);
            _btnStatus.Location = new Point(1020, 22);
            _btnStatus.Name = "_btnStatus";
            _btnStatus.Size = new Size(160, 40);
            _btnStatus.TabIndex = 4;
            _btnStatus.Text = "Thay đổi trạng thái";
            _btnStatus.Click += btnStatus_Click;
            // 
            // _title
            // 
            _title.AutoSize = true;
            _title.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            _title.ForeColor = Color.FromArgb(255, 241, 118);
            _title.Location = new Point(16, 20);
            _title.Name = "_title";
            _title.Size = new Size(235, 37);
            _title.TabIndex = 0;
            _title.Text = "Quản lý Giảm giá";
            // 
            // _btnTao
            // 
            _btnTao.BorderColor = Color.White;
            _btnTao.BorderRadius = 8;
            _btnTao.BorderThickness = 1;
            _btnTao.FillColor = Color.FromArgb(255, 167, 38);
            _btnTao.ForeColor = Color.Black;
            _btnTao.Font = new Font("Segoe UI", 9F);
            _btnTao.Location = new Point(640, 22);
            _btnTao.Name = "_btnTao";
            _btnTao.Size = new Size(110, 40);
            _btnTao.TabIndex = 1;
            _btnTao.Text = "Tạo mã";
            _btnTao.Click += btnTao_Click;
            // 
            // _btnSet
            // 
            _btnSet.BorderColor = Color.White;
            _btnSet.BorderRadius = 8;
            _btnSet.BorderThickness = 1;
            _btnSet.FillColor = Color.FromArgb(255, 167, 38);
            _btnSet.ForeColor = Color.Black;
            _btnSet.Font = new Font("Segoe UI", 9F);
            _btnSet.Location = new Point(760, 22);
            _btnSet.Name = "_btnSet";
            _btnSet.Size = new Size(110, 40);
            _btnSet.TabIndex = 2;
            _btnSet.Text = "Set % / tiền";
            _btnSet.Click += btnSet_Click;
            // 
            // _btnTime
            // 
            _btnTime.BorderColor = Color.White;
            _btnTime.BorderRadius = 8;
            _btnTime.BorderThickness = 1;
            _btnTime.FillColor = Color.FromArgb(255, 167, 38);
            _btnTime.ForeColor = Color.Black;
            _btnTime.Font = new Font("Segoe UI", 9F);
            _btnTime.Location = new Point(880, 22);
            _btnTime.Name = "_btnTime";
            _btnTime.Size = new Size(130, 40);
            _btnTime.TabIndex = 3;
            _btnTime.Text = "Set thời gian";
            _btnTime.Click += btnTime_Click;
            // 
            // QuanLyGiamGiaForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(1200, 700);
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

        private Guna2Button _btnStatus;
    }
}
