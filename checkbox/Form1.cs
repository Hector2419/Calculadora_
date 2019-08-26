using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkbox
{
    public partial class curso : Form
    {
        public curso()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Curso_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            curso formulario = new curso();
            formulario.Visible = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int conteo = 0;
            string seleccion;
            if (checkBox1.Checked==true)
            {
                conteo++;
            }
            if (checkBox2.Checked==true)
            {
                conteo++;
            }
            if (targeta.Checked==true)
            {
                seleccion = "Tarjeta de Crédito";
                    
            }
            else
            {
                seleccion = "Paypal";
            }
            MessageBox.Show("haz seleccionado " + conteo + " cursos y tu método de pago es " + seleccion);  


        }
    }
}
