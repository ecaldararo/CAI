using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class TipoEmpleadoIncorrectoException : Exception
    {
        public TipoEmpleadoIncorrectoException() : base("Tipo de empleado incorrecto o inexistente.")
        {
        }
    }
}
