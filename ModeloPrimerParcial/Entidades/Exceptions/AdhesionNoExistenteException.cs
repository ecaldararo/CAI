using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
    public class AdhesionNoExistenteException : Exception
    {
        public AdhesionNoExistenteException() : base("Adhesion No Existente")
        {
        }

    }
}
