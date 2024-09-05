using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                this.Width = 800;
                this.Height = 500;
            }
            else if (radioButton2.Checked == true)
            {
                this.Width = 600;
                this.Height = 400;
            }
            else if (radioButton3.Checked == true)
            {
                this.Width = 1200;
                this.Height = 700;
            }
        }
    }
}
