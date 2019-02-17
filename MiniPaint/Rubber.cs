using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiniPaint
{
    [Serializable]
    class Rubber : Step
    {
        public override void set_start(Point st, PictureBox _pbx, Pen _pen, Pen back)
        {
            base.set_start(st, _pbx, _pen, back);
            Graphics gr = Graphics.FromImage(bmp);            
            SolidBrush brush = new SolidBrush(BackPen.Color);
        
            gr.FillRectangle(brush, new Rectangle(start, new Size((int)BackPen.Width, (int)BackPen.Width)));
        }

        public override void Draw_end()
        { }

        public override void Draw_move(MouseEventArgs e)
        {
            Graphics gr = pbx.CreateGraphics();
            start = new Point(e.X, e.Y);
            SolidBrush brush = new SolidBrush(BackPen.Color);
            
            gr.FillRectangle(brush, new Rectangle(start, new Size((int)BackPen.Width, (int)BackPen.Width)));
            Graphics grBmp = Graphics.FromImage(bmp);
            grBmp.FillRectangle(brush, new Rectangle(start, new Size((int)BackPen.Width, (int)BackPen.Width)));
            gr.Dispose();
        }

        public override Step GetNewObj()
        {
            return new Rubber();
        }
    }
}
