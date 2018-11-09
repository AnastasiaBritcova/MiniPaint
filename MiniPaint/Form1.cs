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
        bool FlagText = false;
        bool flagTextEndEnter = false;
        TextBox textb; 

        public Form1()
        {
            InitializeComponent();
            buffer = new Buffer(pictureBox1, new Pen(leftChoiceBTN.BackColor, 5));
            buffer.ChangeStack += Buffer_ChangeStack;
            textb = new TextBox();
            textb.BackColor = SystemColors.Control; 

            textb.Visible = false;
            pictureBox1.Controls.Add(textb);
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

        private void button1_Click(object sender, EventArgs e) // это фон над выбранным цветом
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
            if (flagTextEndEnter)
                buffer.MouseUp(sender, (MouseEventArgs)e); // проверить, как это работает
            clickFigure();
            buffer.Selected_step_init(new Line()); /////// спросить, норм ли это
        }

        private void ColorBTN1_Click(object sender, EventArgs e)
        {
            ChangeColour(Color.White);
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
            if (flagTextEndEnter)
                buffer.MouseUp(sender, (MouseEventArgs)e); // проверить, как это работает

            clickFigure();
            buffer.Selected_step_init(new Elipse());
        }

        private void SquardToolsBTN_Click(object sender, EventArgs e)
        {
            if (flagTextEndEnter)
                buffer.MouseUp(sender, (MouseEventArgs)e); // проверить, как это работает
            clickFigure();
            buffer.Selected_step_init(new Square());
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (FlagText && flagTextEndEnter == false)
            {
                buffer.MouseDown(sender, e); // возможно сделать отдельный метод (или переименовать это)

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
                textb.Hide();
                buffer.MouseUp(sender, e);
                ClearTextBox();   
            }
            

        }

        private void TextToolsBTN_Click(object sender, EventArgs e)
        {
            FlagText = true;
            buffer.Selected_step_init(new TextElement());
        }

        private void ClearTextBox()
        {
            textb.Text = "";
            flagTextEndEnter = false;
        }
        private void clickFigure()
        {
            FlagText = false;
            textb.Visible = false;
            ClearTextBox();
        }

      

        private void ColorBTN2_Click(object sender, EventArgs e)
        {
            ChangeColour(Color.Red);
        }

        private void ColorBTN3_Click(object sender, EventArgs e)
        {
            ChangeColour(Color.Green);
        }

        private void ChangeColour(Color col) {
            if (rightRBTN.Checked)
            {
                RightChoiceBTN.BackColor = col;
                buffer.ChangeBackColour(col);
            }

            if (leftRBTN.Checked)
            {
                leftChoiceBTN.BackColor = col;
                buffer.ChangeFontColour(col);
            }
        }

        private void ColorBTN4_Click(object sender, EventArgs e)
        {
            ChangeColour(Color.Blue);
        }

        private void ColorBTN5_Click(object sender, EventArgs e)
        {
            ChangeColour(Color.Black);
        }

        private void ColorBTN6_Click(object sender, EventArgs e)
        {
            ChangeColour(Color.Magenta);
        }

        private void ColorBTN7_Click(object sender, EventArgs e)
        {
            ChangeColour(Color.Yellow);
        }

        private void ColorBTN8_Click(object sender, EventArgs e)
        {
            ChangeColour(Color.Aqua);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}