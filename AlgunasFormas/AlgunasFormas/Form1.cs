using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgunasFormas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics papel;
            papel = pictureBox1.CreateGraphics();
            Pen lápiz = new Pen(Color.Black);
            SolidBrush pincelRelleno = new SolidBrush(Color.Gray);
            papel.DrawRectangle(lápiz, 10, 10, 100, 50);
            papel.DrawLine(lápiz, 10, 10, 110, 60);
            papel.DrawRectangle(lápiz, 10, 80, 100, 50);
            papel.DrawEllipse(lápiz, 10, 80, 100, 50);
            papel.FillEllipse(pincelRelleno, 10, 150, 100, 50);
            papel.DrawRectangle(lápiz, 130, 10, 150, 150);
            papel.DrawLine(lápiz, 20, 80, 70, 10);
            papel.DrawLine(lápiz, 70, 10, 120, 80);
            papel.DrawLine(lápiz, 20, 80, 120, 80);
        }
    }
}
