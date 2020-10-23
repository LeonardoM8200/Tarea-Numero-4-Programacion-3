using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_EdwinLeonardoMolina.Formularios
{
    public partial class frmproductocontado : Form
    {
        Clases.productoalcontado PC = new Clases.productoalcontado();
        public frmproductocontado()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtaumento.Clear();
            txtcuotamensual.Clear();
            txtplazoanual.Clear();
            txtporcentaje.Clear();
            txtprecioalcontado.Clear();
            txtproducto.Clear();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double preciobase, porcentaje,aumento,plazoanual;
            preciobase = Convert.ToDouble(txtprecioalcontado.Text);
            porcentaje = Convert.ToDouble(txtporcentaje.Text);
            txtaumento.Text = PC.aumento(preciobase, porcentaje).ToString();
            aumento = Convert.ToDouble(txtaumento.Text);
            txtplazoanual.Text = PC.plazoanual(preciobase, aumento).ToString();
            plazoanual = Convert.ToDouble(txtplazoanual.Text);
            txtcuotamensual.Text = (plazoanual / 12).ToString();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
