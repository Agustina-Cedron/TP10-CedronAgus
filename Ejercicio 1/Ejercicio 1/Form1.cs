﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int suma = num1 + num2;
            int resta = num1 - num2;

            if (radioButton1.Checked == true)
            {
                label2.Text = "La resta es: " + resta; 
            }
            else if (radioButton2.Checked == true)
            {
                label2.Text = "La suma es: " + suma;
            }
        }
    }
}

    

