using System.Drawing;

namespace WinFormsAppTest.Icons
{
    public static class IconGenerator
    {
        private const int IconSize = 20;
        private const int PadSize = 2;

        public static Bitmap GenerateShoppingIcon()
        {
            var bmp = new Bitmap(IconSize, IconSize);
            using var g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.Transparent);
            
            // Shopping bag
            var pen = new Pen(Color.White, 2f);
            g.DrawRectangle(pen, 3, 6, 14, 10);
            g.DrawLine(pen, 5, 6, 5, 2);
            g.DrawLine(pen, 15, 6, 15, 2);
            g.DrawArc(pen, 4, 0, 2, 4, 0, 180);
            g.DrawArc(pen, 14, 0, 2, 4, 0, 180);
            
            pen.Dispose();
            return bmp;
        }

        public static Bitmap GenerateProductIcon()
        {
            var bmp = new Bitmap(IconSize, IconSize);
            using var g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.Transparent);
            
            // Box/Package
            var pen = new Pen(Color.White, 2f);
            g.DrawRectangle(pen, 2, 5, 16, 11);
            g.DrawLine(pen, 2, 9, 18, 9);
            g.DrawLine(pen, 10, 5, 10, 16);
            
            pen.Dispose();
            return bmp;
        }

        public static Bitmap GenerateImportIcon()
        {
            var bmp = new Bitmap(IconSize, IconSize);
            using var g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.Transparent);
            
            // Arrow down into box
            var pen = new Pen(Color.White, 2f);
            g.DrawRectangle(pen, 3, 10, 14, 6);
            g.DrawLine(pen, 10, 2, 10, 10);
            g.DrawLine(pen, 7, 8, 10, 11);
            g.DrawLine(pen, 13, 8, 10, 11);
            
            pen.Dispose();
            return bmp;
        }

        public static Bitmap GenerateCustomerIcon()
        {
            var bmp = new Bitmap(IconSize, IconSize);
            using var g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.Transparent);
            
            // User
            var brush = new SolidBrush(Color.White);
            g.FillEllipse(brush, 7, 2, 6, 6);
            g.FillRectangle(brush, 3, 9, 14, 8);
            
            brush.Dispose();
            return bmp;
        }

        public static Bitmap GenerateStaffIcon()
        {
            var bmp = new Bitmap(IconSize, IconSize);
            using var g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.Transparent);
            
            // Multiple users
            var brush = new SolidBrush(Color.White);
            g.FillEllipse(brush, 2, 2, 5, 5);
            g.FillEllipse(brush, 12, 2, 5, 5);
            g.FillRectangle(brush, 1, 8, 6, 8);
            g.FillRectangle(brush, 12, 8, 6, 8);
            
            brush.Dispose();
            return bmp;
        }

        public static Bitmap GenerateDiscountIcon()
        {
            var bmp = new Bitmap(IconSize, IconSize);
            using var g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.Transparent);
            
            // Percentage sign
            var pen = new Pen(Color.White, 1.5f);
            g.DrawEllipse(pen, 2, 2, 5, 5);
            g.DrawEllipse(pen, 12, 11, 5, 5);
            g.DrawLine(pen, 15, 3, 5, 16);
            
            pen.Dispose();
            return bmp;
        }

        public static Bitmap GenerateReportIcon()
        {
            var bmp = new Bitmap(IconSize, IconSize);
            using var g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.Transparent);
            
            // Chart/Report
            var pen = new Pen(Color.White, 1.5f);
            g.DrawRectangle(pen, 2, 2, 16, 14);
            g.DrawLine(pen, 4, 12, 4, 6);
            g.DrawLine(pen, 8, 12, 8, 4);
            g.DrawLine(pen, 12, 12, 12, 7);
            g.DrawLine(pen, 16, 12, 16, 3);
            
            pen.Dispose();
            return bmp;
        }

        public static Bitmap GenerateSupplierIcon()
        {
            var bmp = new Bitmap(IconSize, IconSize);
            using var g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.Transparent);
            
            // Building
            var pen = new Pen(Color.White, 2f);
            g.DrawRectangle(pen, 3, 7, 14, 9);
            g.DrawRectangle(pen, 5, 3, 10, 4);
            g.DrawLine(pen, 10, 7, 10, 16);
            
            var innerPen = new Pen(Color.White, 1f);
            g.DrawRectangle(innerPen, 6, 9, 2, 2);
            g.DrawRectangle(innerPen, 10, 9, 2, 2);
            g.DrawRectangle(innerPen, 12, 9, 2, 2);
            
            pen.Dispose();
            innerPen.Dispose();
            return bmp;
        }

        public static Bitmap GenerateInvoiceIcon()
        {
            var bmp = new Bitmap(IconSize, IconSize);
            using var g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.Transparent);
            
            // Document/Invoice
            var pen = new Pen(Color.White, 2f);
            g.DrawRectangle(pen, 4, 2, 12, 16);
            g.DrawLine(pen, 6, 6, 14, 6);
            g.DrawLine(pen, 6, 9, 14, 9);
            g.DrawLine(pen, 6, 12, 12, 12);
            
            pen.Dispose();
            return bmp;
        }

        public static Bitmap GenerateSettingIcon()
        {
            var bmp = new Bitmap(IconSize, IconSize);
            using var g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.Transparent);
            
            // Gear
            var pen = new Pen(Color.White, 2f);
            g.DrawEllipse(pen, 8, 8, 4, 4);
            g.DrawRectangle(pen, 9, 1, 2, 3);
            g.DrawRectangle(pen, 9, 16, 2, 3);
            g.DrawRectangle(pen, 1, 9, 3, 2);
            g.DrawRectangle(pen, 16, 9, 3, 2);
            
            pen.Dispose();
            return bmp;
        }

        public static Bitmap GenerateManageIcon()
        {
            var bmp = new Bitmap(IconSize, IconSize);
            using var g = Graphics.FromImage(bmp);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.Transparent);
            
            // Folder/Management
            var pen = new Pen(Color.White, 2f);
            g.DrawRectangle(pen, 2, 4, 16, 12);
            g.DrawRectangle(pen, 2, 4, 6, 2);
            
            pen.Dispose();
            return bmp;
        }
    }
}
