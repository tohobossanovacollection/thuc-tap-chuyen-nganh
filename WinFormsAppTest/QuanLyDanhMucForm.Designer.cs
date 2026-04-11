namespace WinFormsAppTest
{
    partial class QuanLyDanhMucForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView _dgv;
        private TextBox _txtMa;
        private TextBox _txtTen;
        private Panel _top;
        private Label _title;
        private Button _btnThem;
        private Button _btnSua;
        private Button _btnXoa;
        private Button _btnGan;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            _dgv = new DataGridView();
            _txtMa = new TextBox();
            _txtTen = new TextBox();
            _top = new Panel();
            _title = new Label();
            _btnThem = new Button();
            _btnSua = new Button();
            _btnXoa = new Button();
            _btnGan = new Button();

            ((System.ComponentModel.ISupportInitialize)_dgv).BeginInit();
            _top.SuspendLayout();
            SuspendLayout();

            Text = "6. Quản lý Danh mục";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(1000, 650);

            _top.Dock = DockStyle.Top;
            _top.Height = 110;
            _top.BackColor = Color.FromArgb(255, 241, 118);

            _title.Text = "Quản lý Danh mục";
            _title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _title.ForeColor = Color.FromArgb(198, 40, 40);
            _title.AutoSize = true;
            _title.Location = new Point(12, 10);

            _txtMa.SetBounds(12, 55, 150, 30);
            _txtTen.SetBounds(170, 55, 250, 30);
            _txtMa.PlaceholderText = "Mã danh mục";
            _txtTen.PlaceholderText = "Tên danh mục";

            _btnThem.Text = "Thêm";
            _btnThem.SetBounds(430, 53, 85, 32);
            _btnThem.BackColor = Color.FromArgb(198, 40, 40);
            _btnThem.ForeColor = Color.White;
            _btnThem.Click += btnThem_Click;

            _btnSua.Text = "Sửa";
            _btnSua.SetBounds(520, 53, 85, 32);
            _btnSua.BackColor = Color.FromArgb(198, 40, 40);
            _btnSua.ForeColor = Color.White;
            _btnSua.Click += btnSua_Click;

            _btnXoa.Text = "Xóa";
            _btnXoa.SetBounds(610, 53, 85, 32);
            _btnXoa.BackColor = Color.FromArgb(198, 40, 40);
            _btnXoa.ForeColor = Color.White;
            _btnXoa.Click += btnXoa_Click;

            _btnGan.Text = "Gán cho sản phẩm";
            _btnGan.SetBounds(700, 53, 140, 32);
            _btnGan.BackColor = Color.FromArgb(198, 40, 40);
            _btnGan.ForeColor = Color.White;
            _btnGan.Click += btnGan_Click;

            _top.Controls.AddRange(new Control[] { _title, _txtMa, _txtTen, _btnThem, _btnSua, _btnXoa, _btnGan });

            _dgv.Dock = DockStyle.Fill;
            _dgv.ReadOnly = true;
            _dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgv.RowHeadersVisible = false;

            Controls.Add(_dgv);
            Controls.Add(_top);

            _top.ResumeLayout(false);
            _top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)_dgv).EndInit();
            ResumeLayout(false);
        }
    }
}
