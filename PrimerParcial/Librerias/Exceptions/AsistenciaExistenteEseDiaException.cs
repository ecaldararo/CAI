using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class AsistenciaExistenteEseDiaException : Exception
    {
        public AsistenciaExistenteEseDiaException(string msg) : base(msg)
        {

        }

        public AsistenciaExistenteEseDiaException() : base("Asistencia Existente Ese Día.")
        {
            
        }
    }

}
