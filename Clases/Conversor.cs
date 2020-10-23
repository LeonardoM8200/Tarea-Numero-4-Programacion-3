using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea4_EdwinLeonardoMolina.Clases
{
    class Conversor
    {
     
        public double salarioextra2(double horas, double pagoxhoraextra)
        {
            double resultado;
            resultado = (horas * pagoxhoraextra);

            return resultado;
        
        }
  
        public double salarioneto(double salariobase, double salarioextra)
        {
            double salarioneto;
            salarioneto = (salariobase + salarioextra);
            return salarioneto;

        }
        public double total(double salarioneto, double deduccion)
        {
            double suma;
            
            suma = (salarioneto * deduccion);
            return suma;

        }
        public double total2(double resultado2, double resultado3)
        {
            double total;
            total = (resultado2 - resultado3);
            return total;
        }



    }
}
