using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Métodos
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
            Pen miLápiz = new Pen(Color.Black);
            DibujarLogo(papel, miLápiz, 10, 20);
            DibujarLogo(papel, miLápiz, 100, 100);
            MostrarSuma(label1, 3, 4);
            MostrarSuma(label2, 5, 456);
        }
        private void DibujarLogo(Graphics áreaDibujo, Pen lápizAUsar, int posX, int posY)
        {
            áreaDibujo.DrawRectangle(lápizAUsar, posX, posY, 60, 60);
            áreaDibujo.DrawRectangle(lápizAUsar, posX, posY, 40, 40);
            áreaDibujo.DrawRectangle(lápizAUsar, posX, posY, 20, 20);
        }
        private void MostrarSuma(Label muestraResultado, int a, int b)
        {
            muestraResultado.Text = Convert.ToString(a + b);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
