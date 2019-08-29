using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class CALCULADORA : Form
    {
        double numer1;
        double numer2;
        double resulta;
        string op;
        public CALCULADORA()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void B7_Click(object sender, EventArgs e)
        {
            ventana.Text = ventana.Text + "7";
        }

        private void B3_Click(object sender, EventArgs e)
        {

        }

        private void Bp_Click(object sender, EventArgs e)
        {
            ventana.Text = ventana.Text + ".";
        }

        private void B1_Click(object sender, EventArgs e)
        {
            ventana.Text = ventana.Text + "1";
        }

        private void B2_Click(object sender, EventArgs e)
        {
            ventana.Text = ventana.Text + "2";
        }

        private void B3_Click_1(object sender, EventArgs e)
        {
            ventana.Text = ventana.Text + "3";
        }

        private void B4_Click(object sender, EventArgs e)
        {
            ventana.Text = ventana.Text + "4";
        }

        private void B5_Click(object sender, EventArgs e)
        {
            ventana.Text = ventana.Text + "5";
        }

        private void B6_Click(object sender, EventArgs e)
        {
            ventana.Text = ventana.Text + "6";
        }

        private void B8_Click(object sender, EventArgs e)
        {
            ventana.Text = ventana.Text + "8";
        }

        private void B9_Click(object sender, EventArgs e)
        {
            ventana.Text = ventana.Text + "9";
        }

        private void Dividir_Click(object sender, EventArgs e)
        {
            op = "/";
            numer1 = double.Parse(ventana.Text);
            ventana.Clear();
        }

        private void Mas_Click(object sender, EventArgs e)
        {
            op = "+";
            numer1 = double.Parse(ventana.Text);
            ventana.Clear();
        }

        private void Multiplicar_Click(object sender, EventArgs e)
        {
            op = "*";
            numer1 = double.Parse(ventana.Text);
            ventana.Clear();
        }

        private void Porcentaje_Click(object sender, EventArgs e)
        {
            op = "%";
            numer1 = double.Parse(ventana.Text);
            ventana.Clear();
        }

        private void Restar_Click(object sender, EventArgs e)
        {
            op = "-";
            numer1 = double.Parse(ventana.Text);
            ventana.Clear();
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            numer2 = double.Parse(ventana.Text);
            if (op=="+")
            {
                resulta = numer1 + numer2;
                ventana.Text = resulta.ToString();
            }
            else if (op=="-")
            {
                resulta = numer1 - numer2;
                ventana.Text = resulta.ToString();
            }
            else if (op=="*")
            {
                resulta = numer1 * numer2;
                ventana.Text = resulta.ToString();
            }
            else if (op=="/")
            {
                resulta = numer1 / numer2;
                ventana.Text = resulta.ToString();
            }
            else if (op=="%")
            {
                resulta = (numer1/100) * numer2;
                ventana.Text = resulta.ToString();
            }
        }

        private void Bc_Click(object sender, EventArgs e)
        {
            ventana.Clear();
        }

        private void Bce_Click(object sender, EventArgs e)
        {
            if (ventana.Text.Length==1)
            {
                ventana.Text = "";
            }
            else
            {
                ventana.Text = ventana.Text.Substring(0, ventana.Text.Length);
            }
        }
    }
}
