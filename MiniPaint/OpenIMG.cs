using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiniPaint
{
    class OpenIMG : Step
    {
        public override void Draw_end()
        {   }

        public override void Draw_move(MouseEventArgs e)
        {    }

        public override Step GetNewObj()
        {
            return new OpenIMG();
        }

        public override void set_start(Point st, PictureBox _pbx, Pen _pen, Pen back)
        {
            base.set_start(st, _pbx, _pen, back);
        }
    }
}
