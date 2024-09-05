using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_6
{
    public partial class Form1 : Form
    {
        private int numero;
        private string operacion;
        private int aux;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text + "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            numero = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            numero = int.Parse(textBox2.Text);
            textBox2.Text = " ";
            operacion = "suma";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            aux = int.Parse(textBox2.Text);
            if (operacion == "suma")
            {
                textBox2.Text = (numero + aux).ToString();
            }
            aux = 0;
            aux = int.Parse(textBox2.Text);
            if (operacion == "resta")
            {
                textBox2.Text = (numero - aux).ToString();
            }
            aux = 0;
            if (operacion=="mul")
            {
                textBox2.Text = (numero*aux).ToString();
            }
            aux = 0;
            if (operacion == "div")
            {
                textBox2.Text = (numero / aux).ToString();
            }
            aux = 0;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            numero = int.Parse(textBox2.Text);
            textBox2.Text = " ";
            operacion = "resta";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            numero = int.Parse(textBox2.Text);
            textBox2.Text = " ";
            operacion = "mul";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            numero = int.Parse(textBox2.Text);
            textBox2.Text = "";
            operacion = "div";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
