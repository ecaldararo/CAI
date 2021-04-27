using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaExpendedora
{
    public class SinStockException : Exception
    {
        public SinStockException() : base("No hay stock disponible")
        {

        }
    }

    public class CapacidadInsuficienteException : Exception
    {
        public CapacidadInsuficienteException(string msg) : base (msg)
        {

        }

        public CapacidadInsuficienteException() : base("Capacidad Insuficiente")
        {

        }
    }

    public class DineroInsuficienteException : Exception
    {
        public DineroInsuficienteException() : base("Dinero Insuficiente")
        {

        }
    }

    public class CodigoInvalidoException : Exception
    {
        public CodigoInvalidoException() : base("Código Inválido")
        {

        }
    }
}
