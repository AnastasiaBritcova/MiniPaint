using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonColors_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics gr = ColorBox.CreateGraphics();
            Point loc_temp = ((Button)sender).Location;
            loc_temp.X -= 2;
            loc_temp.Y -= 2;

            gr.FillRectangle(Brushes.Aqua, new Rectangle(loc_temp.X, loc_temp.Y, 36, 36));

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void ColorBTN1_Click(object sender, EventArgs e)
        {
            if (rightRBTN.Checked) {
                RightChoiceBTN.BackColor = Color.White;
            }

            if (leftRBTN.Checked)
            {
                leftChoiceBTN.BackColor = Color.White;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            Graphics gr = pictureBox1.CreateGraphics();
            gr.DrawLine(pen, 20, 10, 300, 100);
        }
    }
}

