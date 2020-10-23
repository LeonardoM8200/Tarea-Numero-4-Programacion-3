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
    public partial class frmtotalventas : Form
    {
        public frmtotalventas()
        {
            InitializeComponent();
        }


        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnlimpiar_Click_1(object sender, EventArgs e)
        {
            txtlunes.Clear();
            txtmartes.Clear();
            txtmiercoles.Clear();
            txtjueves.Clear();
            txtviernes.Clear();
            txtporcentaje.Clear();
            txtsalario.Clear();
            txttotalganancia.Clear();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
           double lunes,martes,miercoles,jueves,viernes, totalganancia, porcentaje, salario;
            lunes = Convert.ToDouble(txtlunes.Text);
            martes = Convert.ToDouble(txtmartes.Text);
            miercoles = Convert.ToDouble(txtmiercoles.Text);
            jueves = Convert.ToDouble(txtjueves.Text);
            viernes = Convert.ToDouble(txtviernes.Text);
            
            totalganancia = (lunes + martes + miercoles + jueves + viernes);
            txttotalganancia.Text = totalganancia.ToString();
            porcentaje = Convert.ToDouble(txtporcentaje.Text);
            salario = totalganancia * porcentaje;
            txtsalario.Text = salario.ToString();
        }
        
        
    }
}
