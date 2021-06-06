using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    internal sealed class Directivo : Empleado
    {
        public Directivo(int legajo, string nombre, string apellido, DateTime fechaNac, DateTime fechaIng)
        {
            Legajo = legajo;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNac;
            FechaIngreso = fechaIng;
            Salarios = new List<Salario>();
        }
        public override string GetNombreCompleto()
        {
            return $"Sr. Director {Apellido}";
        }
    }
}
