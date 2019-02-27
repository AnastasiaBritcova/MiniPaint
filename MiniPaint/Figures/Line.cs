using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiniPaint
{
    [Serializable]
    class Line:Step
    {
        public override void DrawMove(MouseEventArgs e)
        {
            if (!isDrawing)
                isDrawing = true;
            pbx.Refresh();
            Graphics gr = pbx.CreateGraphics();
            end = new Point(e.X, e.Y);
            gr.DrawLine(Pen, start, end);
            
            gr.Dispose();
        }

        public override void DrawEnd()
        {
            if (isDrawing)
            {
                Graphics gr = Graphics.FromImage(bmp);
                gr.DrawLine(Pen, start, end);

                gr.Dispose();
            }
        }

        public override Step GetNewObj()
        {
            return new Line();
        }
    }
}
