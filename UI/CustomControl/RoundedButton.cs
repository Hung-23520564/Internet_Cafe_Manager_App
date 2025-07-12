// Tệp: CustomControls/RoundedButton.cs

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Internet_Cafe_Manager_App.CustomControls
{
    /// <summary>
    /// Một Button tùy chỉnh với các góc được bo tròn và hiệu ứng khi tương tác.
    /// </summary>
    public class RoundedButton : Button
    {
        // --- CÁC BIẾN NỘI BỘ ---
        private int _cornerRadius = 15;
        private Color _originalBackColor;

        // --- CÁC THUỘC TÍNH (PROPERTIES) ĐỂ TÙY CHỈNH ---

        /// <summary>
        /// Bán kính bo góc của nút.
        /// </summary>
        public int CornerRadius
        {
            get { return _cornerRadius; }
            set { _cornerRadius = value; Invalidate(); } // Invalidate() để vẽ lại nút khi thay đổi
        }

        /// <summary>
        /// Hàm dựng (Constructor) của RoundedButton.
        /// </summary>
        public RoundedButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.DoubleBuffered = true; // Giảm hiện tượng nhấp nháy khi vẽ lại

            // Lưu lại màu nền gốc khi nút được tạo
            _originalBackColor = this.BackColor;

            // Đăng ký các sự kiện chuột để tạo hiệu ứng
            this.MouseEnter += OnMouseEnter;
            this.MouseLeave += OnMouseLeave;
            this.MouseDown += OnMouseDown;
            this.MouseUp += OnMouseUp;
        }

        // --- CÁC HÀM XỬ LÝ SỰ KIỆN CHUỘT ---

        private void OnMouseEnter(object sender, EventArgs e)
        {
            _originalBackColor = this.BackColor; // Lưu lại màu hiện tại
            // Làm cho màu nền sáng hơn một chút khi di chuột vào
            this.BackColor = ControlPaint.Light(this._originalBackColor, 0.2f);
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            // Trả về màu nền gốc khi chuột rời đi
            this.BackColor = _originalBackColor;
        }

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            // Làm cho màu nền tối hơn một chút khi nhấn chuột
            this.BackColor = ControlPaint.Dark(this._originalBackColor, 0.2f);
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            // Trả về màu sáng hơn khi nhả chuột (hiệu ứng hover)
            this.BackColor = ControlPaint.Light(this._originalBackColor, 0.2f);
        }

        /// <summary>
        /// Hàm trợ giúp để tạo một đường dẫn (GraphicsPath) hình chữ nhật bo góc.
        /// </summary>
        private GraphicsPath GetRoundedPath(Rectangle rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            if (radius <= 0)
            {
                path.AddRectangle(rect);
                return path;
            }
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90);
            path.AddLine(rect.X + radius, rect.Y, rect.Right - radius, rect.Y);
            path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90);
            path.AddLine(rect.Right, rect.Y + radius, rect.Right, rect.Bottom - radius);
            path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddLine(rect.Right - radius, rect.Bottom, rect.X + radius, rect.Bottom);
            path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();
            return path;
        }

        /// <summary>
        /// Ghi đè phương thức OnPaint để vẽ lại nút theo ý muốn.
        /// </summary>
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectSurface = this.ClientRectangle;

            // Thiết lập vùng hiển thị của nút là hình chữ nhật bo góc
            if (_cornerRadius > 0)
            {
                using (GraphicsPath pathSurface = GetRoundedPath(rectSurface, _cornerRadius))
                {
                    this.Region = new Region(pathSurface);
                }
            }

            // Vẽ nền cho nút
            pevent.Graphics.Clear(this.Parent.BackColor);
            using (SolidBrush brush = new SolidBrush(this.BackColor))
            {
                pevent.Graphics.FillRectangle(brush, rectSurface);
            }

            // Vẽ chữ lên nút
            TextRenderer.DrawText(pevent.Graphics, this.Text, this.Font, rectSurface, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }
}