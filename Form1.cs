using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panama_Impuesto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double precio = Convert.ToDouble(textBox1.Text);
            double impuesto = 7;
            double cantidad = Convert.ToDouble(textBox2.Text);
            double resultado = precio * impuesto / 100 + precio * cantidad;
            textBox4.Text = resultado.ToString();



            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            button2.Text = "";

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
