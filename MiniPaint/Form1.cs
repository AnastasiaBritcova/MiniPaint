﻿using System;
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
            FlagText = false;
            buffer.Selected_step_init(new Line()); /////////// спросить, норм ли это
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
            if (!FlagText)
                buffer.MouseDown(sender, e);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!FlagText)
                buffer.MouseMove(sender, e);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!FlagText)
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

        private void ElipseToolsBTN_Click(object sender, EventArgs e)
        {
            FlagText = false;
        }

        private void SquardToolsBTN_Click(object sender, EventArgs e)
        {
            FlagText = false;
            buffer.Selected_step_init(new Square());
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (FlagText && flagTextEndEnter == false)
            {
                buffer.MouseDown(sender, e); // возможно сделать отдельный метод (или переименовать это)

                pictureBox1.Controls.Add(textb);
                textb.Location = e.Location;
                textb.Size = new Size(100, 100); // должен задаваться в зависимости от выбранного шрифта
                textb.Visible = true;
                textb.Multiline = true;
                textb.BorderStyle = BorderStyle.None;
                
                
                textb.ScrollBars = ScrollBars.Vertical;
                textb.Focus();
                flagTextEndEnter = true;
            }

            else if (FlagText && flagTextEndEnter)
            {
                buffer.MouseUp(sender, e);
                textb.Hide();
                textb.Text = "";
                flagTextEndEnter = false;
            }
            

        }

        private void TextToolsBTN_Click(object sender, EventArgs e)
        {
            FlagText = true;
            buffer.Selected_step_init(new TextElement());
        }


        bool FlagText = false;
        bool flagTextEndEnter = false;
        TextBox textb = new TextBox();
    }
}