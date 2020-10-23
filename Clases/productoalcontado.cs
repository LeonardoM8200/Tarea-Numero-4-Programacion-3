using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4_EdwinLeonardoMolina.Clases
{
    class productoalcontado
    {
        public double aumento(double preciobase, double porcentaje)
        {
            double aumento;
            aumento = preciobase * porcentaje;
            return aumento;

        }
        public double plazoanual(double preciobase, double aumento)
        {
            double plazo;
            plazo = preciobase + aumento;
            return plazo;

        }
    }
}
