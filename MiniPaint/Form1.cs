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
    }
}
