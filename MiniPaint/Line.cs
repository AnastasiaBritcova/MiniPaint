using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint
{
    class Line:Step
    {
        public override void Draw_move(MouseEventArgs e)
        {
            if (!flag_draw)
                flag_draw = true;
            pbx.Refresh();
            Graphics gr = pbx.CreateGraphics();
            end = new Point(e.X, e.Y);
            gr.DrawLine(pen, start, end);
            
            gr.Dispose();
        }

        public override void Draw_end()
        {
            if (flag_draw)
            {
                Graphics gr = Graphics.FromImage(bmp);
                gr.DrawLine(pen, start, end);

                gr.Dispose();
            }
        }

        public override Step GetNewObj()
        {
            return new Line();
        }
    }
}
