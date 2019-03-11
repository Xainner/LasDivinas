using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UI.Utilities
{
    class RoundButtons : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.AddEllipse(1, 1, ClientSize.Width, ClientSize.Height);
            Region = new System.Drawing.Region(graphicsPath);
            base.OnPaint(pevent);
        }
    }
}
