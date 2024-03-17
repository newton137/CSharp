using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularArea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int área;
            int longitud;
            int ancho;
            longitud = 20;
            ancho = 10;
            área = longitud * ancho;
            string s = textBox1.Text;
            MessageBox.Show("El área es: " + Convert.ToString(área) + s);
            string s2 = "Alto";
            label1.Text = s2;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
