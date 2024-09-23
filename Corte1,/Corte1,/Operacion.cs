using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1_
{
    internal class Operacion
    {
        public int CalcularEdad(Persona persona)
        {
            int edad = DateTime.Now.Year - persona.fechadenacimiento.Year;
            if (DateTime.Now.DayOfYear < persona.fechadenacimiento.DayOfYear)
            {
                edad--;
            }
            return edad;
        }

        public bool EsMayorDeEdad(Persona persona)
        {
            return CalcularEdad(persona) >= 18;
        }
    }
}
