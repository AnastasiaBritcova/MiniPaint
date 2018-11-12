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
             Recursion(st.X, st.Y, bmp.GetPixel(st.X, st.Y), pen.Color);
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
            List <Point> listik = new List<Point>();
            List<Point> listik_2 = new List<Point>();
            listik.Add(new Point(x, y));

            while (listik.Count > 0)
            {
                x = listik[0].X;
                y = listik[0].Y;
                if (x > 0 && y > 0 && x< pbx.Height && y< pbx.Width && bmp.GetPixel(x, y) == begin && bmp.GetPixel(x, y) != newCol)
                {
                    bmp.SetPixel(x, y, newCol);                    
                    if(!listik.Contains(new Point(x - 1, y))&& !listik_2.Contains(new Point(x - 1, y)))
                    listik.Add(new Point(x - 1, y));
                    if (!listik.Contains(new Point(x + 1, y)) && !listik_2.Contains(new Point(x + 1, y)))
                        listik.Add(new Point(x+1, y));
                    if (!listik.Contains(new Point(x, y-1)) && !listik_2.Contains(new Point(x, y-1)))
                        listik.Add(new Point(x, y-1));
                    if (!listik.Contains(new Point(x, y+1)) && !listik_2.Contains(new Point(x, y+1)))
                        listik.Add(new Point(x, y+1));
                }
                listik_2.Add(new Point(x, y));
                listik.RemoveAt(0);
                //listik.Remove(new Point (x,y));
            }
        }
    }
}
