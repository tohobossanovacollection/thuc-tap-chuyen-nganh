namespace WinFormsAppTest
{
    partial class QuanLyNhanVienForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView _dgv;
        private Panel _top;
        private Label _title;
        private Button btnThem;
        private Button btnGanTk;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyNhanVienForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            _dgv = new DataGridView();
            _top = new Panel();
            btnXoa = new Button();
            btnSua = new Button();
            _title = new Label();
            btnThem = new Button();
            btnGanTk = new Button();
            ((System.ComponentModel.ISupportInitialize)_dgv).BeginInit();
            _top.SuspendLayout();
            SuspendLayout();
            // 
            // _dgv
            // 
            _dgv.AllowUserToAddRows = false;
            _dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.White;
            _dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            _dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            _dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            _dgv.ColumnHeadersHeight = 29;
            _dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            _dgv.DefaultCellStyle = dataGridViewCellStyle3;
            _dgv.Dock = DockStyle.Fill;
            _dgv.EnableHeadersVisualStyles = false;
            _dgv.GridColor = Color.FromArgb(231, 229, 255);
            _dgv.Location = new Point(0, 91);
            _dgv.Name = "_dgv";
            _dgv.ReadOnly = true;
            _dgv.RowHeadersVisible = false;
            _dgv.RowHeadersWidth = 51;
            _dgv.RowTemplate.Height = 29;
            _dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgv.Size = new Size(1100, 559);
            _dgv.TabIndex = 0;
            // 
            // _top
            // 
            _top.BackColor = Color.FromArgb(255, 241, 118);
            _top.Controls.Add(btnXoa);
            _top.Controls.Add(btnSua);
            _top.Controls.Add(_title);
            _top.Controls.Add(btnThem);
            _top.Controls.Add(btnGanTk);
            _top.Dock = DockStyle.Top;
            _top.Location = new Point(0, 0);
            _top.Name = "_top";
            _top.Size = new Size(1100, 91);
            _top.TabIndex = 1;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(198, 40, 40);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(195, 55);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(85, 30);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Image = Icons.IconGenerator.GenerateDeleteIcon();
            btnXoa.ImageAlign = ContentAlignment.MiddleRight;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(198, 40, 40);
            btnSua.ForeColor = Color.White;
            btnSua.Image = Icons.IconGenerator.GenerateEditIcon();
            btnSua.ImageAlign = ContentAlignment.MiddleRight;
            btnSua.Location = new Point(104, 55);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(85, 30);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // _title
            // 
            _title.AutoSize = true;
            _title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _title.ForeColor = Color.FromArgb(198, 40, 40);
            _title.Location = new Point(12, 10);
            _title.Name = "_title";
            _title.Size = new Size(250, 37);
            _title.TabIndex = 0;
            _title.Text = "Quản lý Nhân viên";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(198, 40, 40);
            btnThem.ForeColor = Color.White;
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleRight;
            btnThem.Location = new Point(13, 55);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(85, 30);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnCrud_Click;
            // 
            // btnGanTk
            // 
            btnGanTk.BackColor = Color.FromArgb(198, 40, 40);
            btnGanTk.ForeColor = Color.White;
            btnGanTk.Location = new Point(286, 55);
            btnGanTk.Name = "btnGanTk";
            btnGanTk.Size = new Size(141, 30);
            btnGanTk.TabIndex = 2;
            btnGanTk.Text = "Gán tài khoản";
            btnGanTk.UseVisualStyleBackColor = false;
            btnGanTk.Click += btnGanTk_Click;
            // 
            // QuanLyNhanVienForm
            // 
            ClientSize = new Size(1100, 650);
            Controls.Add(_dgv);
            Controls.Add(_top);
            Name = "QuanLyNhanVienForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "10. Quản lý Nhân viên";
            ((System.ComponentModel.ISupportInitialize)_dgv).EndInit();
            _top.ResumeLayout(false);
            _top.PerformLayout();
            ResumeLayout(false);
        }

        private Button btnXoa;
        private Button btnSua;
    }
}
