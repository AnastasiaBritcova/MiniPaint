using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace MiniPaint
{
    [Serializable]
    class Buffer
    {
        public delegate void ChangeStackHandler(bool undo, bool redo);
        public event ChangeStackHandler ChangeStack;

        List<Step> steps;
        int index_current_state;
        Pen pen; // color font here
        Pen backPen;

        Step selected_step;
        PictureBox pbx;
        String way = "";

        public Pen Pen
        {
            get { return pen; }
            set { pen = value; }
        }

        public Pen BackPen
        {
            get { return backPen; }
            set { backPen = value; }
        }

        public Buffer(PictureBox _pbx, Pen _pen, Pen back)
        {
            steps = new List<Step>();
            index_current_state = -1;
            Pen = _pen;

            // здесь стандартный инструмент 
            selected_step = new Line();
            pbx = _pbx;
            InitBmp(pbx.Image as Bitmap);
            BackPen = back;
        }
        private void changeSteps()
        {
            if (index_current_state == -1 && steps.Count != 0)
                steps.Clear();

            else if (index_current_state < steps.Count - 1)
                clearListPart();

            index_current_state++;
        }


        public void MouseUp(MouseEventArgs e) 
        {
            if (e.Button == MouseButtons.Left && selected_step.Pen!=null)
            {
                selected_step.Draw_end();
                changeSteps();

                steps.Add(selected_step);

                if (ChangeStack != null)
                    CountChangeStack(steps.Count, index_current_state);

                selected_step = selected_step.GetNewObj();
            }
        }
         
        private void clearListPart()
        {
            int index = index_current_state+1;
            while (index < steps.Count)
                steps.RemoveAt(index);
        }


       public void MouseDown(MouseEventArgs e)
        {
               if (e.Button == MouseButtons.Left)
                    selected_step.set_start(e.Location, pbx, Pen, BackPen);
        }

        public void MouseMove(MouseEventArgs e)
        {
                if (e.Button == MouseButtons.Left && selected_step.Pen!=null)
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
            BackPen.Color = col;
        }

        public void ChangeBackPenWigth(float wigth)
        {
            BackPen.Width = wigth;
        }

        public void Save(SaveFileDialog saveFileDialog1)
        {
            if (way == "")
            {
                SaveAs(saveFileDialog1);
                way = saveFileDialog1.FileName;
            }
            else
                pbx.Image.Save(way);

        }
        public void SaveAs(SaveFileDialog saveFileDialog1)
        {
            saveFileDialog1.Filter = "Images|*.png;*.bmp;*.jpg";

            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                string format = path.Substring(path.Length - 3);
                System.Drawing.Imaging.ImageFormat fm = System.Drawing.Imaging.ImageFormat.Bmp;

                if (format == "jpg")
                    fm = System.Drawing.Imaging.ImageFormat.Jpeg;
                else if (format == "png")
                    fm = System.Drawing.Imaging.ImageFormat.Png;

                pbx.Image.Save(path, fm);
            }
        }

        private void InitBmp(Bitmap bmp)
        {
            Graphics gr = Graphics.FromImage(bmp);
            gr.Clear(Color.White);
            gr.Dispose();
        }

        public void SerealBuffer()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream FS = new FileStream(@"save.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(FS, steps);
            }
        }

        public void DeserealBuffer()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream FS = new FileStream(@"save.dat", FileMode.OpenOrCreate))
            {
                steps=(List<Step>)formatter.Deserialize(FS);
                pbx.Image = steps.Last().GetBitmap();
                index_current_state = steps.Count - 1;
                if (ChangeStack != null)
                    CountChangeStack(steps.Count, index_current_state);

            }
        }

        public void Open() {
            OpenFileDialog openDialog = new OpenFileDialog();
            DialogResult result = openDialog.ShowDialog();
            if (result == DialogResult.OK) {
                pbx.Image = Image.FromFile(openDialog.FileName);
                Step newStep = new OpenIMG();
                newStep.set_start(new Point(0,0),pbx, Pen, backPen );
                changeSteps();
                steps.Add(newStep);

                if (ChangeStack != null)
                    CountChangeStack(steps.Count, index_current_state);
            }
             
        }
    }
}
