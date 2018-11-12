using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint
{
    class Fill : Step
    {
        public override void Draw_end()
        {
            throw new NotImplementedException();
        }

        public override void Draw_move(MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        public override Step GetNewObj()
        {
            return new Fill();
        }
    }
}
