using System.Drawing.Drawing2D;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace Internet_Cafe_Manager_App.UI.CustomControl
{
    public class CircularIconPictureBox : IconPictureBox
    {
        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(pe);
        }
    }
}