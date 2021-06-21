using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
    public class AdhesionExistenteException : Exception
    {
        public AdhesionExistenteException() : base("Adhesion Existente")
        {
        }
    }
}
