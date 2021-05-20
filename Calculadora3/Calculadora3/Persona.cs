using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora3
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;

        public Persona(string nom, string ape)
        {
            Nombre = nom;
            Apellido = ape;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
    }
}
