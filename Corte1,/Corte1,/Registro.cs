using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1_
{
    internal class Registro
    {
        string[] nombre = new string[30];
        private int indice = 0;
        private Persona[] persona;

        public void AgregarPersona(Persona persona)
        {
            if (indice < 30)
            {
                persona\[indice] = persona;
                indice++;
            }
        }

        public Persona[] MostrarPersonas()
        {
            return persona;
        }
    }
}
