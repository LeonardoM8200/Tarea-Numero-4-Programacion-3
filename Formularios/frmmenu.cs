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
    public partial class frmmenu : Form
    {
        public frmmenu()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btnautor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edwin Leonardo Molina");
        }

        private void btnsalario_Click(object sender, EventArgs e)
        {
            Formularios.frmsalario salario = new Formularios.frmsalario();
            salario.ShowDialog();
        }

        private void btncuota_Click(object sender, EventArgs e)
        {
            Formularios.frmcuotadeprestamo cuota = new Formularios.frmcuotadeprestamo();
            cuota.ShowDialog();

        }

        private void btnnewsalario_Click(object sender, EventArgs e)
        {
            Formularios.frmsalarionuevodeunempleado salarionuevo = new Formularios.frmsalarionuevodeunempleado();
            salarionuevo.ShowDialog();
        }

        private void btncuota2_Click(object sender, EventArgs e)
        {
            Formularios.frmproductocontado productoalcontado = new Formularios.frmproductocontado();
            productoalcontado.ShowDialog();
        }

        private void btntotalventas_Click(object sender, EventArgs e)
        {
            Formularios.frmtotalventas totalventas = new Formularios.frmtotalventas();
            totalventas.ShowDialog();
        }
    }
}
