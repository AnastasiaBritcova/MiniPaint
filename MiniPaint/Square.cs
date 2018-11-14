using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint
{
    [Serializable]
    class Square : Step
    {
        public override void Draw_end()
        {
            if (flag_draw)
            {
                Graphics gr = Graphics.FromImage(bmp);
                //Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                gr.DrawRectangle(Pen, CreateRect(start, end));
                gr.DrawRectangle(Pen, CreateRect(start, end));
                
                gr.Dispose();

                //Bitmap temp = bmp.Clone(CreateRect(start, end), System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
                //temp.Save("temp.bmp");
            }
        }

        public override void Draw_move(MouseEventArgs e)
        {
            if (!flag_draw)
                flag_draw = true;
                //Pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            pbx.Refresh();
            Graphics gr = pbx.CreateGraphics();

            end = new Point(e.X, e.Y);

            gr.DrawRectangle(Pen, CreateRect(start, end));
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
