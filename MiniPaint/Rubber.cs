using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint
{
    class Rubber : Step
    {
        public override void set_start(Point st, PictureBox _pbx, Pen _pen, Color back)
        {
            base.set_start(st, _pbx, _pen, back);
            Graphics gr = Graphics.FromImage(bmp);
            int width = (int)Pen.Width;
            
            SolidBrush brush = new SolidBrush(colorBack);
        
            gr.FillRectangle(brush, new Rectangle(start, new Size((int)Pen.Width, (int)Pen.Width)));
            
        }

        public override void Draw_end()
        { }

        public override void Draw_move(MouseEventArgs e)
        {
            //pbx.Refresh();
            Graphics gr = pbx.CreateGraphics();
            start = new Point(e.X, e.Y);
            SolidBrush brush = new SolidBrush(colorBack);

            gr.FillRectangle(brush, new Rectangle(start, new Size((int)Pen.Width, (int)Pen.Width)));
            Graphics grBmp = Graphics.FromImage(bmp);
            grBmp.FillRectangle(brush, new Rectangle(start, new Size((int)Pen.Width, (int)Pen.Width)));
            gr.Dispose();
        }

        public override Step GetNewObj()
        {
            return new Rubber();
        }
    }
}
