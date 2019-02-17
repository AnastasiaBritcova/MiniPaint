using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MiniPaint
{
    [Serializable]
    abstract class Step
    {
        [NonSerialized()]
        private Pen pen;

        [NonSerialized()]
        private Pen backPen;
        protected Point start;
        protected Point end;
        protected Bitmap bmp;

        [NonSerialized()]
        protected PictureBox pbx;
        protected bool flag_draw;

        public Pen Pen
        {
            get { return pen; }
            set { pen = value; }
        }

        protected Pen BackPen
        {
            get { return backPen; }
            set { backPen = value; }
        }

        public Bitmap GetBitmap()
        { return bmp; }

        public virtual void set_start(Point st, PictureBox _pbx, Pen _pen, Pen back) 
        {
            start = st;
            pbx = _pbx;
            Pen = _pen;
            bmp = new Bitmap(pbx.Image, pbx.Width, pbx.Height);
            pbx.Image = bmp;
            BackPen = back;
        }
        
        public abstract void Draw_move(MouseEventArgs e);
        public abstract void Draw_end();
        public abstract Step GetNewObj();
        protected Rectangle CreateRect(Point start, Point end)
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
