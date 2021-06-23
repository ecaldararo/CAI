using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio1.CALDARARO.Entidades.Exceptions
{
    public class EquipoAlquiladoException : Exception
    {
        public EquipoAlquiladoException() : base("Equipo Alquilado")
        {
        }
    }
}
