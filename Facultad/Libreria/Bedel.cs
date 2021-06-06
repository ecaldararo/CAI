using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    internal sealed class Bedel : Empleado
    {
        private string apodo;

        public Bedel(string apodo, int legajo, string nombre, string apellido, DateTime fechaNac, DateTime fechaIng)
        {
            Apodo = apodo;
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNac;
            FechaIngreso = fechaIng;
            Salarios = new List<Salario>();

        }

        public string Apodo { get => apodo; set => apodo = value; }

        public override string GetNombreCompleto()
        {
            return $"Bedel {Apodo}";
        }
    }
}
