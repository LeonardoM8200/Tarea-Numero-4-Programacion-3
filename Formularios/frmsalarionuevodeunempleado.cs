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
    public partial class frmsalarionuevodeunempleado : Form
    {
        Clases.salarionuevo SN = new Clases.salarionuevo();
        public frmsalarionuevodeunempleado()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            double salariobase, porcentaje, suma,aumento;
            salariobase = Convert.ToDouble(txtsalariobase.Text);
            porcentaje = Convert.ToDouble(txtporcentaje.Text);
            txtaumento.Text = SN.Aumento(salariobase, porcentaje).ToString();
            aumento = Convert.ToDouble(txtaumento.Text);
            suma = salariobase + aumento;
            txtnuevosalario.Text = suma.ToString();


        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            txtaumento.Clear();
            txtnombre.Clear();
            txtnuevosalario.Clear();
            txtporcentaje.Clear();
            txtsalariobase.Clear();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
