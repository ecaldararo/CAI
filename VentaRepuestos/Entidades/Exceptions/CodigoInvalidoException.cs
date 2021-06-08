using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class CodigoInvalidoException : Exception
    {
        public CodigoInvalidoException() : base("Código Inválido")
        {

        }
    }

}
