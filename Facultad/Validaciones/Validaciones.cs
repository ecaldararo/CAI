using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validaciones
{
    public static class Validaciones
    {
        public static Int32 GetAge(this DateTime dateOfBirth)
        {
            var today = DateTime.Today;

            var a = (today.Year * 100 + today.Month) * 100 + today.Day;
            var b = (dateOfBirth.Year * 100 + dateOfBirth.Month) * 100 + dateOfBirth.Day;

            return (a - b) / 10000;
        }
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

        public static bool ValidarStringNoVac(string str)
        {
            if (str == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
