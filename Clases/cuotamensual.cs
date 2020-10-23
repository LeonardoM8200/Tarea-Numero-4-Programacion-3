using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4_EdwinLeonardoMolina.Clases
{
    class cuotamensual
    {
        public double plazoenaños(double años, double cantidadprestada)
        {
            double plazo;
            plazo = cantidadprestada / años;
            return plazo;

        }
        public double interesanual(double interes1, double cantidadporaño)
        {
            double interes;
            interes = cantidadporaño * interes1;
            return interes;

        }
        public double plazomensual(double plazosdeaños, double plazomensual)
        {
            double plazomensual1;
            plazomensual1 = plazosdeaños / 12;
            return plazomensual1;
        }
        public double interesmensual(double interes,double interesmensual)
        {
            double interesmensual1;
            interesmensual1 = interes / interesmensual;
            return interesmensual1;

        }
        public double cuotamensual1(double plazomensual,double interesmensual)
        {
            double total;
            total = plazomensual + interesmensual;
            return total;
        }
        

    }
}
