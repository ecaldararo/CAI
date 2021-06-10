using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CapacidadInsuficienteException : Exception
    {
        public CapacidadInsuficienteException(string msg) : base(msg)
        {

        }

        public CapacidadInsuficienteException() : base("Capacidad Insuficiente")
        {

        }
    }
}
