using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsAppTest
{
    partial class BaoCaoNhapHangForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            _pnlTop = new Panel();
            _lblTitle = new Label();
            _lblFrom = new Label();
            _dtpFrom = new DateTimePicker();
            _lblTo = new Label();
            _dtpTo = new DateTimePicker();
            _btnXemBieuDo = new Button();
            _pnlCharts = new Panel();
            _chartProduct = new System.Windows.Forms.DataVisualization.Charting.Chart();
            _chartSupplier = new System.Windows.Forms.DataVisualization.Charting.Chart();
            _pnlTop.SuspendLayout();
            _pnlCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_chartProduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)_chartSupplier).BeginInit();
            SuspendLayout();
            // 
            // _pnlTop
            // 
            _pnlTop.BackColor = Color.White;
            _pnlTop.Controls.Add(_lblTitle);
            _pnlTop.Controls.Add(_lblFrom);
            _pnlTop.Controls.Add(_dtpFrom);
            _pnlTop.Controls.Add(_lblTo);
            _pnlTop.Controls.Add(_dtpTo);
            _pnlTop.Controls.Add(_btnXemBieuDo);
            _pnlTop.Dock = DockStyle.Top;
            _pnlTop.Location = new Point(0, 0);
            _pnlTop.Name = "_pnlTop";
            _pnlTop.Size = new Size(1200, 80);
            _pnlTop.TabIndex = 0;
            // 
            // _lblTitle
            // 
            _lblTitle.AutoSize = true;
            _lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            _lblTitle.ForeColor = Color.FromArgb(198, 40, 40);
            _lblTitle.Location = new Point(20, 15);
            _lblTitle.Name = "_lblTitle";
            _lblTitle.Size = new Size(309, 37);
            _lblTitle.TabIndex = 0;
            _lblTitle.Text = "BÁO CÁO NHẬP HÀNG";
            // 
            // _lblFrom
            // 
            _lblFrom.AutoSize = true;
            _lblFrom.Location = new Point(20, 50);
            _lblFrom.Name = "_lblFrom";
            _lblFrom.Size = new Size(65, 20);
            _lblFrom.TabIndex = 1;
            _lblFrom.Text = "Từ ngày:";
            // 
            // _dtpFrom
            // 
            _dtpFrom.Format = DateTimePickerFormat.Short;
            _dtpFrom.Location = new Point(80, 47);
            _dtpFrom.Name = "_dtpFrom";
            _dtpFrom.Size = new Size(120, 27);
            _dtpFrom.TabIndex = 2;
            
            // 
            // _lblTo
            // 
            _lblTo.AutoSize = true;
            _lblTo.Location = new Point(220, 50);
            _lblTo.Name = "_lblTo";
            _lblTo.Size = new Size(75, 20);
            _lblTo.TabIndex = 3;
            _lblTo.Text = "Đến ngày:";
            // 
            // _dtpTo
            // 
            _dtpTo.Format = DateTimePickerFormat.Short;
            _dtpTo.Location = new Point(290, 47);
            _dtpTo.Name = "_dtpTo";
            _dtpTo.Size = new Size(120, 27);
            _dtpTo.TabIndex = 4;
            // 
            // _btnXemBieuDo
            // 
            _btnXemBieuDo.BackColor = Color.FromArgb(198, 40, 40);
            _btnXemBieuDo.FlatStyle = FlatStyle.Flat;
            _btnXemBieuDo.ForeColor = Color.White;
            _btnXemBieuDo.Location = new Point(430, 45);
            _btnXemBieuDo.Name = "_btnXemBieuDo";
            _btnXemBieuDo.Size = new Size(110, 30);
            _btnXemBieuDo.TabIndex = 5;
            _btnXemBieuDo.Text = "Xem biểu đồ";
            _btnXemBieuDo.UseVisualStyleBackColor = false;
            _btnXemBieuDo.Click += BtnXemBieuDo_Click;
            // 
            // _pnlCharts
            // 
            _pnlCharts.Controls.Add(_chartProduct);
            _pnlCharts.Controls.Add(_chartSupplier);
            _pnlCharts.Dock = DockStyle.Fill;
            _pnlCharts.Location = new Point(0, 80);
            _pnlCharts.Name = "_pnlCharts";
            _pnlCharts.Size = new Size(1200, 620);
            _pnlCharts.TabIndex = 1;
            // 
            // _chartProduct
            // 
            chartArea1.Name = "MainArea";
            _chartProduct.ChartAreas.Add(chartArea1);
            _chartProduct.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            _chartProduct.Legends.Add(legend1);
            _chartProduct.Location = new Point(600, 0);
            _chartProduct.Name = "_chartProduct";
            series1.ChartArea = "MainArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "SoLuong";
            _chartProduct.Series.Add(series1);
            _chartProduct.Size = new Size(600, 620);
            _chartProduct.TabIndex = 1;
            _chartProduct.Text = "chart2";
            title1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            title1.Name = "Title1";
            title1.Text = "Top Mặt Hàng Nhập Nhiều Nhất";
            title1.Alignment = ContentAlignment.MiddleCenter;
            _chartProduct.Titles.Add(title1);
            // 
            // _chartSupplier
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.AxisX.Title = "Nhà cung cấp";
            chartArea2.AxisY.Title = "Tổng tiền (VNĐ)";
            chartArea2.Name = "MainArea";
            _chartSupplier.ChartAreas.Add(chartArea2);
            _chartSupplier.Dock = DockStyle.Right;
            _chartSupplier.Location = new Point(0, 0);
            _chartSupplier.Name = "_chartSupplier";
            series2.ChartArea = "MainArea";
            series2.Color = Color.FromArgb(66, 165, 245);
            series2.IsValueShownAsLabel = true;
            series2.Name = "TienNhap";
            _chartSupplier.Series.Add(series2);
            _chartSupplier.Size = new Size(600, 620);
            _chartSupplier.TabIndex = 0;
            _chartSupplier.Text = "chart1";
            title2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            title2.Name = "Title1";
            title2.Text = "Top Nhà Cung Cấp Nhập Nhiều Nhất";
            _chartSupplier.Titles.Add(title2);
            // 
            // BaoCaoNhapHangForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            Controls.Add(_pnlCharts);
            Controls.Add(_pnlTop);
            Name = "BaoCaoNhapHangForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Báo Cáo Nhập Hàng";
            _pnlTop.ResumeLayout(false);
            _pnlTop.PerformLayout();
            _pnlCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_chartProduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)_chartSupplier).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel _pnlTop;
        private System.Windows.Forms.Label _lblTitle;
        private System.Windows.Forms.Label _lblFrom;
        private System.Windows.Forms.DateTimePicker _dtpFrom;
        private System.Windows.Forms.Label _lblTo;
        private System.Windows.Forms.DateTimePicker _dtpTo;
        private System.Windows.Forms.Button _btnXemBieuDo;
        private System.Windows.Forms.Panel _pnlCharts;
        private System.Windows.Forms.DataVisualization.Charting.Chart _chartProduct;
        private System.Windows.Forms.DataVisualization.Charting.Chart _chartSupplier;
    }
}