using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class Validaciones
    {
        public static double ValidarDouble(string numero)
        {
            double valor;
            if (!double.TryParse(numero, out valor))
            {
                valor = double.MaxValue;
            }
            if (valor == double.MaxValue)
            {
                throw new Exception("Debe ingresar un número");
            }
            return valor;
        }
        public static int ValidarInt(string numero)
        {
            int valor;
            if (!int.TryParse(numero, out valor))
            {
                valor = int.MaxValue;
            }
            if (valor == int.MaxValue)
            {
                throw new Exception("Debe ingresar un número");
            }
            return valor;
        }
        public static void ValidarOperador(string str)
        {
            if (str != "+" && str != "-" && str != "*" && str != "/")
            {
                throw new Exception("Operador inválido o vacío");
            }
        }
    }
}
