using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Konvertues_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string binar = textBox1.Text.ToString();
            string baze10 = Convert.ToInt32(binar, 2).ToString();
            textBox2.Text = baze10;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string baze10 = textBox3.Text.ToString();
            int numri = Convert.ToInt32(baze10);
            int vlera;
            string a = "";

            while (numri >= 1)
            {
                vlera = numri / 2;
                a += (numri % 2).ToString();
                numri = vlera;
            }
            string vleraBinare = "";

            for (int i = a.Length - 1; i >= 0; i--)
            {
                vleraBinare = vleraBinare + a[i];
                textBox4.Text = vleraBinare;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
        }
    }
}
