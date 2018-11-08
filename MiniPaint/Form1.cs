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
            buffer = new Buffer(pictureBox1, new Pen(leftChoiceBTN.BackColor, 5));
            buffer.ChangeStack += Buffer_ChangeStack;
       }

        private void Buffer_ChangeStack(int stack_count, int current)
        {
            if (stack_count == 0)
                MenuDo.Enabled = MenuUndo.Enabled = false;
            else if (current == stack_count-1)
            {
                MenuUndo.Enabled = true;
                MenuDo.Enabled = false;
            }
            else if (current==-1)
            {
                MenuDo.Enabled = true;
                MenuUndo.Enabled = false;
            }
            else if (current < stack_count-1)
                MenuDo.Enabled = MenuUndo.Enabled = true;
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

        private void LineToolsBTN_Click(object sender, EventArgs e)
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

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            buffer.MouseDown(sender, e);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            buffer.MouseMove(sender, e);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            buffer.MouseUp(sender, e);
        }

        private void MenuUndo_Click(object sender, EventArgs e)
        {
            buffer.UnDo();
        }

        private void MenuDo_Click(object sender, EventArgs e)
        {
            buffer.ReDo();
        }
    }
}


// это все пропадает из designer, возможно переместіть сюда

//this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(buffer.MouseDown);
//this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(buffer.MouseMove);
//this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(buffer.MouseUp);
//buffer = new Buffer(pictureBox1, new System.Drawing.Pen(leftChoiceBTN.BackColor, 5));