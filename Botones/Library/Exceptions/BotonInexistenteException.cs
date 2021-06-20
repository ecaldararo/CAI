using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BotonInexistenteException : Exception
    {
        public BotonInexistenteException() : base("El botón no existe.")
        {
        }
    }
}
