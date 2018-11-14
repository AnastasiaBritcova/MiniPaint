using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint
{
    public partial class Form1 : Form
    {
        bool flagTextEndEnter = false;
        TextBox textb;
        enum Tools
        { line = 1, elipse, square, text, fill, rubber };

        Tools tools = Tools.line;

        public Form1()
        {
            InitializeComponent();

            buffer = new Buffer(pictureBox1, new Pen(leftChoiceBTN.BackColor, 1.5f), new Pen(RightChoiceBTN.BackColor, 3));
            buffer.ChangeStack += Buffer_ChangeStack;
            textb = new TextBox();
            textb.BackColor = SystemColors.Control;
            textb.WordWrap = true;
            textb.Size = new Size(200, 100);

            textb.Visible = false;
            pictureBox1.Controls.Add(textb);
            
            this.textb.TextChanged += delegate
            {
                Size oldSize = this.textb.Size;
                Size newSize = textb.GetPreferredSize(oldSize);
                this.textb.Height = newSize.Height;
                this.textb.Width = newSize.Width;
                Point loc = textb.Location;
                if (textb.Location.X + textb.Width >= pictureBox1.Width)
                    loc.X = pictureBox1.Width - textb.Width;
                if (textb.Location.Y + textb.Height >= pictureBox1.Height)
                    loc.Y = pictureBox1.Height - textb.Height;
                textb.Location = loc;
            };
            DoubleBuffered = true;

            LoadTips();
        }
         


        private void Buffer_ChangeStack(bool undo, bool redo)
        {
            MenuUndo.Enabled = undo;
            RedoBTN.Enabled = redo;
        }

        private void ButtonColors_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            ChangeColour(colorDialog1.Color);

        }

        private void LineToolsBTN_Click(object sender, EventArgs e)
        {
            if (flagTextEndEnter)
                buffer.MouseUp((MouseEventArgs)e); 
            clickFigure();
            LineToolsBTN.TabIndex = 0;
            buffer.Selected_step_init(new Line());
            tools = Tools.line;
            RubberOptionBox.Hide();
        }

        private void ColorBTN1_Click(object sender, EventArgs e)
        {
            ChangeColour(Color.White);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (tools != Tools.text && tools != Tools.fill)
                buffer.MouseDown(e);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tools != Tools.text && tools != Tools.fill)
                buffer.MouseMove(e);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (tools != Tools.text && tools != Tools.fill)
                buffer.MouseUp(e);
        }

        private void MenuUndo_Click(object sender, EventArgs e)
        {
            buffer.UnDo();
        }


        private void ElipseToolsBTN_Click(object sender, EventArgs e)
        {
            if (flagTextEndEnter)
                buffer.MouseUp((MouseEventArgs)e); 

            clickFigure();
            ElipseToolsBTN.TabIndex = 0;
            buffer.Selected_step_init(new Elipse());
            tools = Tools.elipse;
            RubberOptionBox.Hide();

        }

        private void SquardToolsBTN_Click(object sender, EventArgs e)
        {
            if (flagTextEndEnter)
                buffer.MouseUp((MouseEventArgs)e); 
            clickFigure();
            SquardToolsBTN.TabIndex = 0;
            buffer.Selected_step_init(new Square());
            tools = Tools.square;
            RubberOptionBox.Hide();

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (tools == Tools.text && flagTextEndEnter == false)
            {
                buffer.MouseDown(e);

                textb.Location = e.Location;
                textb.Size = new Size(200, 100);
                textb.Visible = true;
                textb.Multiline = true;
                textb.BorderStyle = BorderStyle.None;

                textb.Focus();
                flagTextEndEnter = true;
                LineBox.Hide();
                RubberOptionBox.Hide();
            }

            else if (tools == Tools.text && flagTextEndEnter)
            {
                textb.Visible = false;
                buffer.MouseUp(e);
                ClearTextBox();
            }
        }

        private void TextToolsBTN_Click(object sender, EventArgs e)
        {
            textb.Visible = false;
            if (flagTextEndEnter)
                buffer.MouseUp((MouseEventArgs)e);

            clickFigure();
            TextToolsBTN.TabIndex = 0;
            LineBox.Hide();
            RubberOptionBox.Hide();
            buffer.Selected_step_init(new TextElement());
            tools = Tools.text;
        }

        private void RubberToolsBTN_Click(object sender, EventArgs e)
        {
            if (flagTextEndEnter)
                buffer.MouseUp((MouseEventArgs)e);
            clickFigure();
            WidthLineBTN.Enabled = true;
            RubberToolsBTN.TabIndex = 0;
            buffer.Selected_step_init(new Rubber());
            tools = Tools.rubber;
            LineBox.Hide();

        }

        private void ClearTextBox()
        {
            textb.Text = "";
            flagTextEndEnter = false;
        }
        private void clickFigure()
        {
            textb.Visible = false;
            WidthLineBTN.Enabled = true;
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

        private void ChangeColour(Color col)
        {
            if (rightRBTN.Checked)
            {
                RightChoiceBTN.BackColor = col;
                buffer.ChangeBackColour(col);
            }

            if (leftRBTN.Checked)
            {
                leftChoiceBTN.BackColor = col;
                buffer.ChangePenColour(col);
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


        private void Line1BTN_Click(object sender, EventArgs e)
        {
            ChangeLineBackColor(sender as Button);
            buffer.ChangePenWigth(1.5f);

        }
        private void ChangeLineBackColor(Button butt)
        {
            Line1BTN.BackColor = SystemColors.ControlLight;
            Line2BTN.BackColor = SystemColors.ControlLight;
            Line3BTN.BackColor = SystemColors.ControlLight;
            Line4BTN.BackColor = SystemColors.ControlLight;

            butt.BackColor = Color.NavajoWhite;
        }

        private void Line2BTN_Click(object sender, EventArgs e)
        {
            ChangeLineBackColor(sender as Button);
            buffer.ChangePenWigth(3);
        }

        private void Line3BTN_Click(object sender, EventArgs e)
        {
            ChangeLineBackColor(sender as Button);
            buffer.ChangePenWigth(4.5f);
        }

        private void Line4BTN_Click(object sender, EventArgs e)
        {
            ChangeLineBackColor(sender as Button);
            buffer.ChangePenWigth(6);
        }

        private void FillToolsBTN_Click(object sender, EventArgs e)
        {
            WidthLineBTN.Enabled = false;
            buffer.Selected_step_init(new Fill());
            FillToolsBTN.TabIndex = 0;
            tools = Tools.fill;
            LineBox.Hide();
            RubberOptionBox.Hide();
        }

        private void clickPictureBox(object sender, EventArgs e)
        {
            if (tools == Tools.fill)
                buffer.MouseDown((MouseEventArgs)e);
        }

        private void WidthLineBTN_Click(object sender, EventArgs e)
        {
            if (tools == Tools.text)
            {
                RubberOptionBox.Hide();
                LineBox.Hide();
                fontDialog1.ShowDialog();
                textb.Font = fontDialog1.Font;
            }
            else if (tools == Tools.line || tools == Tools.elipse || tools == Tools.square)
            {
                RubberOptionBox.Hide();
                LineBox.Show();
            }
            else if (tools == Tools.rubber)
            {
                LineBox.Hide();;
                RubberOptionBox.Show();
            }
        }


        private void RubberPlusBTN_Click(object sender, EventArgs e)
        {

            if (buffer.BackPen.Width < 81)
            {
                buffer.ChangeBackPenWigth(buffer.BackPen.Width + 3);
                DrawRubber();
            }

        }
        private void RubberMinusBTN_Click(object sender, EventArgs e)
        {
            if (buffer.Pen.Width > 5)
            {
                buffer.ChangeBackPenWigth(buffer.BackPen.Width - 3);
                DrawRubber();
            }
        }


        private void DrawRubber()
        {

            Graphics RubberGraphics = RubberPictureBox.CreateGraphics();
            RubberGraphics.Clear(SystemColors.Control);
            Pen newPen = new Pen(Color.Black, 2);

            RubberGraphics.DrawRectangle(newPen, 45 - buffer.BackPen.Width / 2, 45 - buffer.BackPen.Width / 2, buffer.BackPen.Width, buffer.BackPen.Width);
            RubberGraphics.Dispose();
        }

        private void RubberPictureBox_Paint(object sender, PaintEventArgs e)
        {
            if (RubberOptionBox.Visible)
                DrawRubber();
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buffer.SaveAs(saveFileDialog1);
        }

        private void процессToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            buffer.DeserealBuffer();
        }

        private void процессToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buffer.SerealBuffer();
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(pictureBox1.Image, 0, 0);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LoadTips()
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.SetToolTip(this.LineToolsBTN, "Линия");
            toolTip1.SetToolTip(this.ElipseToolsBTN, "Элипс");
            toolTip1.SetToolTip(this.SquardToolsBTN, "Прямоугольник");
            toolTip1.SetToolTip(this.TextToolsBTN, "Текст");
            toolTip1.SetToolTip(this.FillToolsBTN, "Заливка");
            toolTip1.SetToolTip(this.RubberToolsBTN, "Ластик");
            toolTip1.SetToolTip(this.WidthLineBTN, "Опции");
        }

        private void SerialBTN_Click(object sender, EventArgs e)
        {
            buffer.SerealBuffer();
        }


        private void DeserialBTN_Click(object sender, EventArgs e)
        {
            buffer.DeserealBuffer();

        }

        private void изображениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buffer.Save(saveFileDialog1);
        }


        private void файлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buffer.Open();
        }

        private void RedoBTN_Click(object sender, EventArgs e)
        {
            buffer.ReDo();
        }
    }
}
