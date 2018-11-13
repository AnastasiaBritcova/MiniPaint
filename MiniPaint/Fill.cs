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
            
            FillNoRec(st.X, st.Y, bmp.GetPixel(st.X, st.Y), Pen.Color);
             //Recursion(st.X, st.Y, bmp.GetPixel(st.X, st.Y), pen.Color);
            //FillRecursion(st.X, st.Y, bmp.GetPixel(st.X, st.Y), pen.Color);
        }

        private void FillRecursion(int x, int y, Color begin, Color newCol) {
            if (x < 0 || y < 0 || x > pbx.Height || y > pbx.Width)
                return;

            if (bmp.GetPixel(x - 1, y) == begin)
            {
                bmp.SetPixel(x - 1, y, newCol);
                FillRecursion(x - 1, y, begin, newCol);
            }
            else return;
            if (bmp.GetPixel(x + 1, y) == begin)
            {
                bmp.SetPixel(x + 1, y, newCol);
                FillRecursion(x + 1, y, begin, newCol);
            }
           else return;
            if (bmp.GetPixel(x, y-1) == begin)
            {
                bmp.SetPixel(x , y-1, newCol);
                FillRecursion(x, y-1, begin, newCol);
            }
          else return;
            if (bmp.GetPixel(x, y+1) == begin)
            {
                bmp.SetPixel(x, y+1, newCol);
                FillRecursion(x, y+1, begin, newCol);
            }
            return;
        }

        private void Recursion(int x, int y, Color begin, Color newCol)
        {
            if (x >= 0 && y >= 0 && y <= pbx.Height && x <= pbx.Width && bmp.GetPixel(x, y)==begin&& bmp.GetPixel(x, y) !=newCol)           
            {
                    bmp.SetPixel(x, y, newCol);
                    Recursion(x - 1, y, begin, newCol);
                   Recursion(x + 1, y, begin, newCol);
                   Recursion(x, y - 1, begin, newCol);
                   Recursion(x, y + 1, begin, newCol);
            }
        }

        private void FillNoRec(int x, int y, Color begin, Color newCol)
        {
            Point start = new Point(x,y);
            FillYUp(x, y, begin, newCol);
            FillYDown(x, y+1, begin, newCol);

            x = start.X-1;
            y = start.Y;
            FillXLeft(x, y, begin, newCol);

            x = start.X+1;
            y = start.Y;
            FillXRight(x, y, begin, newCol);
        }

        private void FillYUp(int x, int y, Color begin, Color newCol)
        {
            while (x >= 0 && y >= 0 && y < pbx.Height && x < pbx.Width &&
                bmp.GetPixel(x, y) == begin && bmp.GetPixel(x, y) != newCol)
            {
                bmp.SetPixel(x, y, newCol);
                FillXLeft(x-1, y, begin, newCol);
                y -= 1;
            }            
        }
        
        private void FillYDown(int x, int y, Color begin, Color newCol)
        {
            while (x >= 0 && y >= 0 && y < pbx.Height && x < pbx.Width &&
                bmp.GetPixel(x, y) == begin && bmp.GetPixel(x, y) != newCol)
            {
                bmp.SetPixel(x, y, newCol);
                FillXRight(x + 1, y, begin, newCol);

                y += 1;
            }
        }

        private void FillXLeft(int x, int y, Color begin, Color newCol)
        {
            while (x >= 0 && y >= 0 && y < pbx.Height && x < pbx.Width &&
               bmp.GetPixel(x, y) == begin && bmp.GetPixel(x, y) != newCol)
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
               bmp.GetPixel(x, y) == begin && bmp.GetPixel(x, y) != newCol)
            {
                bmp.SetPixel(x, y, newCol);
                FillYUp(x, y - 1, begin, newCol);
                FillYDown(x, y + 1, begin, newCol);

                x += 1;
            }
        }
    }
}
