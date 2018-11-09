using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint
{
    class Square : Step
    {
        public override void Draw_end()
        {
            if (flag_draw)
            {
                Graphics gr = Graphics.FromImage(bmp);
                gr.DrawRectangle(pen, CreateRect(start, end));

                gr.Dispose();
            }
        }

        public override void Draw_move(MouseEventArgs e)
        {
            if (!flag_draw)
                flag_draw = true;
            pbx.Refresh();
            Graphics gr = pbx.CreateGraphics();

            end = new Point(e.X, e.Y);

            gr.DrawRectangle(pen, CreateRect(start, end));

            gr.Dispose();
        }

        public override Step GetNewObj()
        {
            return new Square();
        }

        private Rectangle CreateRect(Point start, Point end)
        {
            Point startPoint = new Point();
            if (end.X >= start.X && end.Y <= start.Y)
            {
                startPoint.X = start.X;
                startPoint.Y = end.Y;
                 
            }
            else if (end.X <= start.X && end.Y <= start.Y)
            {
                startPoint = end;
            }
            else if (end.X <= start.X && end.Y >= start.Y)
            {
                startPoint.X = end.X;
                startPoint.Y = start.Y;
            }
            else if (end.X >= start.X && end.Y >= start.Y)
            {
                startPoint = start;
            }

            int width = Math.Abs(end.X - start.X);
            int height = Math.Abs(end.Y - start.Y);

            return new Rectangle(startPoint.X, startPoint.Y, width, height);
        }
    }
}
