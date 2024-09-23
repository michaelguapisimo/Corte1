using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Corte1_
{
    public partial class Form1 : Form
    {
        private Registro registro = new Registro();
        private Operacion operacion = new Operacion();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona
            {
                nombre = txtNombres.Text,
                apellido = txtApellidos.Text,
                fechadenacimiento = dateTimePicker1.Value,
                ciudad = cboxCiudad.SelectedItem.ToString()
            };
            registro.AgregarPersona(persona);
            MessageBox.Show("Persona agregada.");
        }

        private void btnCalcularEdad_Click(object sender, EventArgs e)
        {
            if (registro.MostrarPersonas().Length > 0)
            {
                Persona persona = registro.MostrarPersonas()[0]; // Cambiar según la persona que se seleccione
                int edad = operacion.CalcularEdad(persona);
                bool esMayor = operacion.EsMayorDeEdad(persona);
                MessageBox.Show($"La edad de {persona.nombre} es {edad} y es {(esMayor ? "mayor" : "menor")} de edad.");
            }
        }
    }
}
