using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace HRManagementSystem
{
    public class RoundButton : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            var graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(graphicsPath);
            base.OnPaint(e);
        }
    }
}