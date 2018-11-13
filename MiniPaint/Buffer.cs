﻿using System;
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
        public delegate void ChangeStackHandler(bool undo, bool redo);
        public event ChangeStackHandler ChangeStack;

        List<Step> steps;
        int index_current_state;

        Pen pen; // color font here
        Color colorBack; //цвет ластика
        Step selected_step;
        PictureBox pbx;

        public Pen Pen
        {
            get { return pen; }
            set { pen = value; }
        }

        public Buffer(PictureBox _pbx, Pen _pen, Color back)
        {
            steps = new List<Step>();
            index_current_state = -1;
            Pen = _pen;

            // здесь стандартный инструмент 
            selected_step = new Line();
            pbx = _pbx;
            InitBmp(pbx.Image as Bitmap);
            colorBack = back;
        }

        public void MouseUp(MouseEventArgs e) 
        {
            if (e.Button == MouseButtons.Left)
            {
                selected_step.Draw_end();
                if (index_current_state == -1 && steps.Count != 0)
                    steps.Clear();

                steps.Add(selected_step);
                index_current_state++;

                if (ChangeStack != null)
                    CountChangeStack(steps.Count, index_current_state);

                selected_step = selected_step.GetNewObj();
            }
        }

       public void MouseDown(MouseEventArgs e)
        {
               if (e.Button == MouseButtons.Left)
                selected_step.set_start(e.Location, pbx, Pen, colorBack);
        }

        public void MouseMove(MouseEventArgs e)
        {
                if (e.Button == MouseButtons.Left)
                    selected_step.Draw_move(e);
        }

        public void Selected_step_init(Step step) 
        {
            selected_step = step;
        }

        public void UnDo()
        {
            if (index_current_state == 0)
            {
                pbx.Image = new Bitmap(pbx.Width, pbx.Height);
                InitBmp(pbx.Image as Bitmap);
                index_current_state--;
            }
            else
            {
                index_current_state--;
                pbx.Image = steps[index_current_state].GetBitmap();
            }

            if (ChangeStack != null)
                CountChangeStack(steps.Count, index_current_state);
        }

        public void ReDo()
        {
            if (index_current_state!=steps.Count-1)
            {
                index_current_state++;
                pbx.Image = steps[index_current_state].GetBitmap();
            }
            if (ChangeStack != null)
                CountChangeStack(steps.Count, index_current_state);
        }

        private void CountChangeStack(int stack_count, int current)
        {
            if (stack_count == 0)
                ChangeStack(false, false);

            else if (current == stack_count - 1)
                ChangeStack(true, false);

            else if (current == -1)
                ChangeStack(false, true);

            else if (current < stack_count - 1)
                ChangeStack(true, true);
        }


        public void ChangePenColour(Color col)
        {
            Pen.Color = col;
            
        }
        public void ChangePenWigth(float wigth)
        {
            Pen.Width = wigth;
        }

        public void ChangeBackColour(Color col)
        {
            colorBack = col;
        }

        public void Save()
        {

        }
        public void SaveAs(string path)
        {
            string format = path.Substring(path.Length - 3);
            System.Drawing.Imaging.ImageFormat fm = System.Drawing.Imaging.ImageFormat.Bmp;

            if(format == "jpg")
                fm = System.Drawing.Imaging.ImageFormat.Jpeg;
            else if (format == "png")
                fm = System.Drawing.Imaging.ImageFormat.Png;
           
            pbx.Image.Save(path, fm);  
        }

        private void InitBmp(Bitmap bmp)
        {
            Graphics gr = Graphics.FromImage(bmp);
            gr.Clear(Color.White);
            gr.Dispose();
        }
    }
}
