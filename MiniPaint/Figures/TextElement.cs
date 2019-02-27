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
    class TextElement : Step
    {
        public override void Draw_end()
        {
            TextBox textb = pbx.Controls[0] as TextBox;
            if (textb!=null)
            {
                Graphics gr = Graphics.FromImage(bmp);
                gr.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

                TextFormatFlags flags = TextFormatFlags.WordBreak;
                TextRenderer.DrawText(gr, textb.Text, textb.Font, new Rectangle(textb.Location, new Size(textb.Width, textb.Height)), Pen.Color, flags);
                gr.Dispose();
                pbx.Refresh();
            }
        }

        public override Step GetNewObj()
        {
            return new TextElement();
        }
    }
}
