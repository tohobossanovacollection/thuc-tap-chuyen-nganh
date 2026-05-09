namespace WinFormsAppTest
{
    partial class BaoCaoMainForm
    {
        private System.ComponentModel.IContainer components = null;
        private Panel pnlTop;
        private Label lblTitle;
        private GroupBox grpMain;
        private Button btnDoanhThu;
        private Button btnTonKho;
        private Button btnNhapHang;
        private Label lblFlow;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pnlTop = new Panel();
            lblTitle = new Label();
            grpMain = new GroupBox();
            btnDoanhThu = new Button();
            btnTonKho = new Button();
            btnNhapHang = new Button();
            lblFlow = new Label();

            pnlTop.SuspendLayout();
            grpMain.SuspendLayout();
            SuspendLayout();

            Text = "Báo cáo";
            StartPosition = FormStartPosition.CenterScreen;
            ClientSize = new Size(760, 420);
            BackColor = Color.White;

            pnlTop.Dock = DockStyle.Top;
            pnlTop.Height = 78;
            pnlTop.BackColor = Color.FromArgb(198, 40, 40);

            lblTitle.Text = "Báo cáo";
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(255, 241, 118);
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(16, 18);
            pnlTop.Controls.Add(lblTitle);

            grpMain.Text = "Chọn loại báo cáo";
            grpMain.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            grpMain.ForeColor = Color.FromArgb(198, 40, 40);
            grpMain.SetBounds(20, 96, 720, 300);

            btnDoanhThu.Text = "Doanh thu";
            btnDoanhThu.BackColor = Color.FromArgb(198, 40, 40);
            btnDoanhThu.ForeColor = Color.White;
            btnDoanhThu.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDoanhThu.SetBounds(35, 78, 200, 90);
            btnDoanhThu.Click += btnDoanhThu_Click;

            btnTonKho.Text = "Tồn kho";
            btnTonKho.BackColor = Color.FromArgb(198, 40, 40);
            btnTonKho.ForeColor = Color.White;
            btnTonKho.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnTonKho.SetBounds(260, 78, 200, 90);
            btnTonKho.Click += btnTonKho_Click;

            btnNhapHang.Text = "Nhập hàng";
            btnNhapHang.BackColor = Color.FromArgb(198, 40, 40);
            btnNhapHang.ForeColor = Color.White;
            btnNhapHang.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNhapHang.SetBounds(485, 78, 200, 90);
            btnNhapHang.Click += btnNhapHang_Click;

            lblFlow.Text = "[Báo cáo] → [Doanh thu: xem biểu đồ] | [Tồn kho: xem sản phẩm] | [Nhập hàng: xem nhập]";
            lblFlow.SetBounds(35, 200, 680, 40);
            lblFlow.ForeColor = Color.FromArgb(97, 97, 97);

            grpMain.Controls.Add(btnDoanhThu);
            grpMain.Controls.Add(btnTonKho);
            grpMain.Controls.Add(btnNhapHang);
            grpMain.Controls.Add(lblFlow);

            Controls.Add(grpMain);
            Controls.Add(pnlTop);

            grpMain.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
        }
    }
}
