using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MiniPaint
{

    class Buffer
    {
        public delegate void ChangeStackHandler(int stack_count, int current);
        public event ChangeStackHandler ChangeStack;

        List<Step> steps;
        int index_current_state;
        Pen pen; // color font here
        Color color_back;
        Font font;
        Step selected_step;
        PictureBox pbx;

        public Buffer(PictureBox _pbx, Pen _pen)
        {
            steps = new List<Step>();
            index_current_state = -1;
            pen = _pen;
            selected_step = new Line();
            pbx = _pbx;
        }

        public void MouseUp(object sender, MouseEventArgs e) // оставила здесь сигнатуру обработчика событий если будем переделывать
        {
            if (e.Button == MouseButtons.Left)
            {
                selected_step.Draw_end();
                steps.Add(selected_step);
                index_current_state++;
                if (ChangeStack != null)
                    ChangeStack(steps.Count, index_current_state);

                selected_step = new Line();
            }
        }

       public void MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                selected_step.set_start(e.Location, pbx, pen);
        }

        public void MouseMove(object sender, MouseEventArgs e)
        {
                if (e.Button == MouseButtons.Left)
                    selected_step.Draw_move(e);
        }

        public void Selected_step_init(Step step) // лучше создавать степ здесь?
        {
            selected_step = step;
        }

        public void UnDo()
        {
            if (index_current_state == 0)
            {
                pbx.Image = new Bitmap(pbx.Width, pbx.Height);
                index_current_state--;
            }
            else
            {
                index_current_state--;
                pbx.Image = steps[index_current_state].GetBitmap();
            }

            if (ChangeStack != null)
                ChangeStack(steps.Count, index_current_state);
        }

        public void ReDo()
        {
            if (index_current_state!=steps.Count-1)
            {
                index_current_state++;
                pbx.Image = steps[index_current_state].GetBitmap();

                if (ChangeStack != null)
                    ChangeStack(steps.Count, index_current_state);
            }
        }
    }
}
