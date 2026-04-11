namespace WinFormsAppTest
{
    partial class QuanLyPhieuNhapForm
    {
        private System.ComponentModel.IContainer components = null;
        private DataGridView _dgvPhieuNhap;
        private DataGridView _dgvChiTiet;
        private Panel _top;
        private Label _title;
        private Button _btnTao;
        private Button _btnThemSP;
        private Button _btnTong;
        private Button _btnTon;
        private SplitContainer _split;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            _dgvPhieuNhap = new DataGridView();
            _dgvChiTiet = new DataGridView();
            _top = new Panel();
            _title = new Label();
            _btnTao = new Button();
            _btnThemSP = new Button();
            _btnTong = new Button();
            _btnTon = new Button();
            _split = new SplitContainer();

            ((System.ComponentModel.ISupportInitialize)_dgvPhieuNhap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_dgvChiTiet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_split).BeginInit();
            _split.Panel1.SuspendLayout();
            _split.Panel2.SuspendLayout();
            _split.SuspendLayout();
            _top.SuspendLayout();
            SuspendLayout();

            Text = "7. Quản lý Phiếu nhập";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(1200, 700);

            _top.Dock = DockStyle.Top;
            _top.Height = 80;
            _top.BackColor = Color.FromArgb(255, 241, 118);

            _title.Text = "Quản lý Phiếu nhập";
            _title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _title.ForeColor = Color.FromArgb(198, 40, 40);
            _title.AutoSize = true;
            _title.Location = new Point(12, 10);

            _btnTao.Text = "Tạo phiếu";
            _btnTao.SetBounds(12, 42, 85, 30);
            _btnTao.BackColor = Color.FromArgb(198, 40, 40);
            _btnTao.ForeColor = Color.White;
            _btnTao.Click += btnTao_Click;

            _btnThemSP.Text = "Thêm sản phẩm";
            _btnThemSP.SetBounds(102, 42, 120, 30);
            _btnThemSP.BackColor = Color.FromArgb(198, 40, 40);
            _btnThemSP.ForeColor = Color.White;
            _btnThemSP.Click += btnThemSP_Click;

            _btnTong.Text = "Tính tổng";
            _btnTong.SetBounds(232, 42, 85, 30);
            _btnTong.BackColor = Color.FromArgb(198, 40, 40);
            _btnTong.ForeColor = Color.White;
            _btnTong.Click += btnTong_Click;

            _btnTon.Text = "Cập nhật tồn kho";
            _btnTon.SetBounds(322, 42, 120, 30);
            _btnTon.BackColor = Color.FromArgb(198, 40, 40);
            _btnTon.ForeColor = Color.White;
            _btnTon.Click += btnTon_Click;

            _top.Controls.AddRange(new Control[] { _title, _btnTao, _btnThemSP, _btnTong, _btnTon });

            _split.Dock = DockStyle.Fill;
            _split.Orientation = Orientation.Horizontal;
            _split.SplitterDistance = 300;

            SetupGrid(_dgvPhieuNhap);
            SetupGrid(_dgvChiTiet);
            _split.Panel1.Controls.Add(_dgvPhieuNhap);
            _split.Panel2.Controls.Add(_dgvChiTiet);

            Controls.Add(_split);
            Controls.Add(_top);

            _top.ResumeLayout(false);
            _top.PerformLayout();
            _split.Panel1.ResumeLayout(false);
            _split.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_split).EndInit();
            _split.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_dgvPhieuNhap).EndInit();
            ((System.ComponentModel.ISupportInitialize)_dgvChiTiet).EndInit();
            ResumeLayout(false);
        }
    }
}
