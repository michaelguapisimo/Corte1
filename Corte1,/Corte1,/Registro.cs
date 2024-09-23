using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte1_
{
    internal class Registro
    {
        private Persona[] personas = new Persona[30];
        private int indice = 0;

        public void AgregarPersona(Persona persona)
        {
            if (indice < 30)
            {
                personas[indice] = persona;
                indice++;
            }
        }

        public Persona[] MostrarPersonas()
        {
            return personas;
        }

        
    }
}
