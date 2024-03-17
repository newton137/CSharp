using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Objetos
{
    public partial class Form1 : Form
    {
        private int cuentaAutos = 0;
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Convert.ToString(cuentaAutos);
        }
        SqlConnection conexion = new SqlConnection("server=LAPTOP-ATJPD55L\\SQLEXPRESS; database=BDAdmonFin4, integrated security = true");
        private void button1_Click(object sender, EventArgs e)
        {
            cuentaAutos = cuentaAutos + 1;
            textBox1.Text = Convert.ToString(cuentaAutos);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cuentaAutos = cuentaAutos - 1;
            textBox1.Text = Convert.ToString(cuentaAutos);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
