using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint
{
    class TextElement : Step
    {

        public override void Draw_end()
        {
            Graphics grImg = pbx.CreateGraphics();
            Graphics gr = Graphics.FromImage(bmp);
            TextBox textb = pbx.Controls[0] as TextBox;

            if (textb!=null)
            {
                TextRenderer.DrawText(grImg, textb.Text, textb.Font, textb.Location, Color.Black);
               // TextRenderer.DrawText(gr, textb.Text, textb.Font, textb.Location, Color.Black);
               // grImg.DrawString(textb.Text, textb.Font, Brushes.Black, pbx.Location);
                pbx.DrawToBitmap(bmp, pbx.DisplayRectangle);



                SaveFileDialog sfd = new SaveFileDialog();
                sfd.DefaultExt = "bmp";
                sfd.Filter = "Image files (*.bmp)|*.bmp|All files (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    bmp.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                }
            }


            grImg.Dispose();
            gr.Dispose();
        }

        public override void Draw_move(MouseEventArgs e)
        {
            
        }
        public override Step GetNewObj()
        {
            return new TextElement();
        }
    }
}
