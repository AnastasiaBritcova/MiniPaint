using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiniPaint
{
    class OpenIMG : Step
    {
        public override void DrawEnd()
        {   }

        public override void DrawMove(MouseEventArgs e)
        {    }

        public override Step GetNewObj()
        {
            return new OpenIMG();
        }

        public override void SetStart(Point st, PictureBox _pbx, Pen _pen, Pen back)
        {
            base.SetStart(st, _pbx, _pen, back);
        }
    }
}
