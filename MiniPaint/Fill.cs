using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace MiniPaint
{
    class Fill : Step
    {
        public override void Draw_end()
        { }

        public override void Draw_move(MouseEventArgs e)
        { }

        public override Step GetNewObj()
        {
            return new Fill();
        }
        public override void set_start(Point st, PictureBox _pbx, Pen _pen, Color color)
        {           
            base.set_start(st, _pbx, _pen, color);
            
            FillMethod(st.X, st.Y, bmp.GetPixel(st.X, st.Y), Pen.Color);
        }


        private void FillMethod(int x, int y, Color begin, Color newCol)
        {
            Point start = new Point(x, y);
                FillYUp(x, y, begin, newCol);
                FillYDown(x, y + 1, begin, newCol);

                x = start.X - 1;
                y = start.Y;
                FillXLeft(x, y, begin, newCol);

                x = start.X + 1;
                y = start.Y;
                FillXRight(x, y, begin, newCol);
        }

        private void FillYUp(int x, int y, Color begin, Color newCol)
        {
            while (x >= 0 && y >= 0 && y < pbx.Height && x < pbx.Width &&
                bmp.GetPixel(x, y) == begin && bmp.GetPixel(x, y).ToArgb() != newCol.ToArgb())
            {
                bmp.SetPixel(x, y, newCol);
                FillXLeft(x-1, y, begin, newCol);
                y -= 1;
            }            
        }
        
        private void FillYDown(int x, int y, Color begin, Color newCol)
        {
            while (x >= 0 && y >= 0 && y < pbx.Height && x < pbx.Width &&
                bmp.GetPixel(x, y) == begin && bmp.GetPixel(x, y).ToArgb() != newCol.ToArgb())
            {
                bmp.SetPixel(x, y, newCol);
                FillXRight(x + 1, y, begin, newCol);

                y += 1;
            }
        }

        private void FillXLeft(int x, int y, Color begin, Color newCol)
        {
            while (x >= 0 && y >= 0 && y < pbx.Height && x < pbx.Width &&
               bmp.GetPixel(x, y) == begin && bmp.GetPixel(x, y).ToArgb() != newCol.ToArgb())
            {
                bmp.SetPixel(x, y, newCol);
                FillYUp(x, y - 1, begin, newCol);
                FillYDown(x, y + 1, begin, newCol);

                x -= 1;
            }
        }

        private void FillXRight(int x, int y, Color begin, Color newCol)
        {
            while (x >= 0 && y >= 0 && y < pbx.Height && x < pbx.Width &&
               bmp.GetPixel(x, y) == begin && bmp.GetPixel(x, y).ToArgb() != newCol.ToArgb())
            {
                bmp.SetPixel(x, y, newCol);
                FillYUp(x, y - 1, begin, newCol);
                FillYDown(x, y + 1, begin, newCol);

                x += 1;
            }
        }
    }
}
