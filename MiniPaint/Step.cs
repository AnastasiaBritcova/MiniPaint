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
        protected Color colorBack;
        protected Point start;
        protected Point end;
        protected Bitmap bmp;

        [NonSerialized()]
        protected PictureBox pbx;
        protected bool flag_draw;

        protected Pen Pen
        {
            get { return pen; }
            set { pen = value; }
        }

        public Bitmap GetBitmap()
        { return bmp; }

        public virtual void set_start(Point st, PictureBox _pbx, Pen _pen, Color color) // maybe abstract
        {
            start = st;
            pbx = _pbx;
            Pen = _pen;
            bmp = new Bitmap(pbx.Image, pbx.Width, pbx.Height);
            pbx.Image = bmp;
            colorBack = color;
        }
        
        public abstract void Draw_move(MouseEventArgs e);
        public abstract void Draw_end();
        public abstract Step GetNewObj();
        
    }
}
