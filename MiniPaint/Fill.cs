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
        public override Step GetNewObj()
        {
            return new Fill();
        }
        public override void SetStart(Point st, PictureBox _pbx, Pen _pen, Pen back)
        {
            base.SetStart(st, _pbx, _pen, back);
            FillLines(st.X, st.Y, bmp.GetPixel(st.X, st.Y), Pen.Color);
        }

        private void FillLines(int x, int y, Color begin, Color newColor)
        {
            if (begin.ToArgb() == newColor.ToArgb())
                return;
            int argbBegin = begin.ToArgb();
            int argbNew = newColor.ToArgb();

            int tempX = x;
            int tempY = y;
            Stack<Point> stack = new Stack<Point>();
            bool pixelAbove, pixelBelow;
            stack.Push(new Point(tempX, y));
            while (stack.Count != 0)
            {
                Point current = stack.Pop();
                tempX = current.X;
                tempY = current.Y;
                while (tempX >= 0 && tempX < pbx.Width && bmp.GetPixel(tempX, tempY).ToArgb() == argbBegin)
                    --tempX;
                ++tempX;
                pixelAbove = pixelBelow = false;

                while (tempX < pbx.Width && bmp.GetPixel(tempX, tempY).ToArgb() == argbBegin)
                {
                    bmp.SetPixel(tempX, tempY, newColor);

                    if (!pixelAbove && tempY > 0 && bmp.GetPixel(tempX, tempY - 1).ToArgb() == argbBegin)
                    {
                        stack.Push(new Point(tempX, tempY - 1));
                        pixelAbove = true;
                    }
                    else if (pixelAbove && tempY > 0 && bmp.GetPixel(tempX, tempY - 1).ToArgb() != argbBegin)
                        pixelAbove = false;

                    if (!pixelBelow && tempY < pbx.Height - 1 && bmp.GetPixel(tempX, tempY + 1).ToArgb() == argbBegin)
                    {
                        stack.Push(new Point(tempX, tempY + 1));
                        pixelBelow = true;
                    }
                    else if (pixelBelow && tempY < pbx.Height - 1 && bmp.GetPixel(tempX, tempY + 1).ToArgb() != argbBegin)
                        pixelBelow = false;

                    ++tempX;
                }
            }
        }
    }
}
