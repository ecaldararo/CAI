using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class EmpleadoInexistenteException : Exception
    {
        public EmpleadoInexistenteException() : base("El empleado no existe")
        {
        }
    }
}
