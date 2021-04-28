using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class AsistenciaInconsistenteException : Exception
    {
        public AsistenciaInconsistenteException(string msg) : base(msg)
        {

        }

        public AsistenciaInconsistenteException() : base("Asistencia Inconsistente.")
        {

        }
    }

}
