using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internet_Cafe_Manager_App.CustomControls // Bạn có thể thay đổi namespace nếu muốn
{
    public class RoundedPanel : Panel
    {
        private int _cornerRadius = 10; // Bán kính bo góc mặc định

        public int CornerRadius
        {
            get { return _cornerRadius; }
            set
            {
                if (_cornerRadius != value)
                {
                    _cornerRadius = value;
                    this.Invalidate(); // Yêu cầu vẽ lại khi bán kính thay đổi
                }
            }
        }

        public RoundedPanel()
        {
            this.DoubleBuffered = true; // Giảm nhấp nháy khi vẽ lại
            this.BackColor = Color.FromArgb(42, 42, 48); // Màu nền mặc định như cardPanel của bạn
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e); // Gọi phương thức OnPaint của lớp cơ sở (Panel)

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias; // Cho đường bo mượt hơn

            Rectangle rect = new Rectangle(0, 0, this.Width - 1, this.Height - 1); // -1 để đường viền không bị cắt ở mép

            // Tạo GraphicsPath với các góc bo tròn
            GraphicsPath path = GetRoundedRectPath(rect, _cornerRadius);

            // Đặt Region cho Panel để các phần bên ngoài góc bo tròn trở nên trong suốt
            // và các sự kiện chuột cũng chỉ hoạt động bên trong vùng này.
            this.Region = new Region(path);

            // Vẽ nền cho Panel với các góc bo tròn
            // Bạn có thể dùng BackColor của Panel hoặc một màu khác
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                g.FillPath(brush, path);
            }

            // (Tùy chọn) Vẽ đường viền bo tròn
            // using (Pen pen = new Pen(Color.Gray, 1)) // Màu và độ dày viền tùy ý
            // {
            //     g.DrawPath(pen, path);
            // }
        }

        // Hàm trợ giúp để tạo GraphicsPath cho hình chữ nhật bo góc
        private GraphicsPath GetRoundedRectPath(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            if (radius <= 0)
            {
                path.AddRectangle(bounds);
                return path;
            }

            int diameter = radius * 2;
            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(bounds.Location, size);

            // Góc trên bên trái
            path.AddArc(arc, 180, 90);

            // Góc trên bên phải
            arc.X = bounds.Right - diameter;
            path.AddArc(arc, 270, 90);

            // Góc dưới bên phải
            arc.Y = bounds.Bottom - diameter;
            path.AddArc(arc, 0, 90);

            // Góc dưới bên trái
            arc.X = bounds.Left;
            path.AddArc(arc, 90, 90);

            path.CloseFigure();
            return path;
        }

        // Có thể cần xử lý OnResize để cập nhật lại Region nếu kích thước thay đổi
        // Tuy nhiên, vì OnPaint được gọi khi kích thước thay đổi, Region sẽ được cập nhật.
    }
}