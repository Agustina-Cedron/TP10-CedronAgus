using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {
                label2.Text = "Google";
            }
            else if (checkBox1.Checked == false)
            {
                label2.Text = " ";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked==true)
            {
                label2.Text = "Brave";
            }
            else if (checkBox2.Checked==false)
            {
                label2.Text = " ";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked==true)
            {
                label2.Text = "Firefox";
            }
            else if (checkBox3.Checked == false)
            {
                label2.Text = " ";
            }
        }
    }
}
