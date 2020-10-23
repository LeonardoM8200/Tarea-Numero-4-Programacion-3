using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_EdwinLeonardoMolina.Formularios
{
    public partial class frmsalario : Form
    {
        Clases.Conversor SM = new Clases.Conversor();
        



        public frmsalario()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtnombre.Clear();
            
            txthorasextras.Clear();
            txtpagototal.Clear();
            txtpagoxhoraextra.Clear();
            txtsalariobase.Clear();
            txtsalarioextra.Clear();
            txtsalarioneto.Clear();
            txtdeduccion.Clear();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double horas, pagoxhoraextra, resultado1, salariobase, resultado2, resultado3, deduccion, deduccion1;
            deduccion = (0.05);
            horas = Convert.ToDouble(txthorasextras.Text);
            pagoxhoraextra = Convert.ToDouble(txtpagoxhoraextra.Text);
            salariobase = Convert.ToDouble(txtsalariobase.Text);
            txtsalarioextra.Text = SM.salarioextra2(horas, pagoxhoraextra).ToString();
            resultado1 = Convert.ToDouble(txtsalarioextra.Text);
            txtsalarioneto.Text = SM.salarioneto(salariobase, resultado1).ToString();
            resultado2 = Convert.ToDouble(txtsalarioneto.Text);

            deduccion1 = resultado2 * deduccion;
            txtdeduccion.Text = SM.total(deduccion, resultado2).ToString();
            resultado3 = Convert.ToDouble(txtdeduccion.Text);
            txtpagototal.Text = SM.total2(resultado2, resultado3).ToString();

       
        }
        
    }
}
