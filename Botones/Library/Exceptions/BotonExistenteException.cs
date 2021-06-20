using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BotonExistenteException : Exception
    {
        public BotonExistenteException() : base("El botón ya existe.")
        {
        }
    }
}
