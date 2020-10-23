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
    public partial class frmcuotadeprestamo : Form
    {
        Clases.cuotamensual CM = new Clases.cuotamensual();

        public frmcuotadeprestamo()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtaños.Clear();
            txtcantidadprestada.Clear();
            txtcuotamensual.Clear();
            txtinteres.Clear();
            txtinteresmensual.Clear();
            txtinterespromedio.Clear();
            txtnombre.Clear();
            txtplazomensual.Clear();
            txtplazosdeaños.Clear();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double cantidadprestada, años, interespromedio,interes,plazos;
            cantidadprestada = Convert.ToDouble(txtcantidadprestada.Text);
            años = Convert.ToDouble(txtaños.Text);
            interespromedio = Convert.ToDouble(txtinterespromedio.Text);
            interes = años * interespromedio;
            txtplazosdeaños.Text = CM.plazoenaños(años, cantidadprestada).ToString();
            plazos = Convert.ToDouble(txtplazosdeaños.Text);
            txtinteres.Text = CM.interesanual(plazos,interespromedio).ToString();

            double plazomensual, plazoanual;
            plazoanual = Convert.ToDouble(txtplazosdeaños.Text);
            plazomensual = plazoanual / 12;
            txtplazomensual.Text = CM.plazomensual(plazoanual, plazomensual).ToString();

            double interesmensual, interesanual,interestotal;
            interesanual = Convert.ToDouble(txtinteres.Text);
            interesmensual = 12;
            txtinteresmensual.Text = CM.interesmensual(interesanual, interesmensual).ToString();
            interestotal = Convert.ToDouble(txtinteresmensual.Text);
            txtcuotamensual.Text = CM.cuotamensual1(plazomensual, interestotal).ToString();
        }
    }
}
