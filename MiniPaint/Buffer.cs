using System;
using System.Collections.Generic;
using System.Linq;
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
        int currentStateIndex;
        Pen pen; // color font here
        Pen backPen;

        Step selectedStep;
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
            currentStateIndex = -1;
            Pen = _pen;

            // Здесь стандартный инструмент.
            selectedStep = new Line();
            pbx = _pbx;
            InitBmp(pbx.Image as Bitmap);
            BackPen = back;
        }
        private void changeSteps()
        {
            if (currentStateIndex == -1 && steps.Count != 0)
                steps.Clear();

            else if (currentStateIndex < steps.Count - 1)
                clearListPart();

            currentStateIndex++;
        }


        public void MouseUp(MouseEventArgs e) 
        {
            if (e.Button == MouseButtons.Left && selectedStep.Pen!=null)
            {
                selectedStep.DrawEnd();
                changeSteps();

                steps.Add(selectedStep);

                if (ChangeStack != null)
                    CountChangeStack(steps.Count, currentStateIndex);

                selectedStep = selectedStep.GetNewObj();
            }
        }
         
        private void clearListPart()
        {
            int index = currentStateIndex+1;
            while (index < steps.Count)
                steps.RemoveAt(index);
        }


       public void MouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                selectedStep.SetStart(e.Location, pbx, Pen, BackPen);
        }

        public void MouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && selectedStep.Pen!=null)
                selectedStep.DrawMove(e);
        }

        public void InitSelectedStep(Step step) 
        {
            selectedStep = step;
        }

        public void UnDo()
        {
            if (currentStateIndex == 0)
            {
                pbx.Image = new Bitmap(pbx.Width, pbx.Height);
                InitBmp(pbx.Image as Bitmap);
                currentStateIndex--;
            }
            else
            {
                currentStateIndex--;
                pbx.Image = steps[currentStateIndex].GetBitmap();
            }

            if (ChangeStack != null)
                CountChangeStack(steps.Count, currentStateIndex);
        }

        public void ReDo()
        {
            if (currentStateIndex!=steps.Count-1)
            {
                currentStateIndex++;
                pbx.Image = steps[currentStateIndex].GetBitmap();
            }
            if (ChangeStack != null)
                CountChangeStack(steps.Count, currentStateIndex);
        }

        private void CountChangeStack(int stackCount, int current)
        {
            if (stackCount == 0)
                ChangeStack(false, false);

            else if (current == stackCount - 1)
                ChangeStack(true, false);

            else if (current == -1)
                ChangeStack(false, true);

            else if (current < stackCount - 1)
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
                currentStateIndex = steps.Count - 1;
                if (ChangeStack != null)
                    CountChangeStack(steps.Count, currentStateIndex);
            }
        }

        public void Open()
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            DialogResult result = openDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                pbx.Image = Image.FromFile(openDialog.FileName);
                Step newStep = new OpenIMG();
                newStep.SetStart(new Point(0,0),pbx, Pen, backPen );
                changeSteps();
                steps.Add(newStep);

                if (ChangeStack != null)
                    CountChangeStack(steps.Count, currentStateIndex);
            }
             
        }
    }
}
