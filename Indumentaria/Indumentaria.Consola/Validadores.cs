using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indumentaria.Consola
{
    public class Val
    {
        public static string PedirCodigo()
        {
            Console.WriteLine("Ingrese el código");
            string codigo = Console.ReadLine();
            return codigo;
        }
        public static double PedirDinero()
        {
            Console.WriteLine("Ingrese el dinero");
            double dinero = (Double)Int32.Parse(Console.ReadLine());
            return dinero;
        }
        public static double PedirPrecio()
        {
            Console.WriteLine("Ingrese el precio");
            double precio;
            do
            {
                if (!Double.TryParse(Console.ReadLine(), out precio))
                {
                    Console.WriteLine("Ingreso inválido. Ingrese un número.");
                }
                else if (precio < 0)
                {
                    Console.WriteLine("Ingreso inválido. Debe ingresar un número mayor a 0. Ingrese un precio.");
                }
            } while (precio < 0);

            return precio;
        }
        public static int PedirCantidad()
        {
            Console.WriteLine("Ingrese la cantidad");
            int cantidad;
            do
            {
                if (!Int32.TryParse(Console.ReadLine(), out cantidad))
                {
                    Console.WriteLine("Ingreso inválido. Ingrese un número.");
                }
                else if (cantidad < 0)
                {
                    Console.WriteLine("Ingreso inválido. Debe ingresar un número mayor a 0. Ingrese una cantidad.");
                }
            } while (cantidad < 0);

            return cantidad;
        }
        public static string PedirNombre()
        {
            Console.WriteLine("Ingrese el nombre");
            string nombre = Console.ReadLine();
            return nombre;
        }
        public static int PedirOpcion(int desde, int hasta)
        {
            Console.WriteLine("Ingrese el número de opción");
            int opcion;
            do
            {
                if (!Int32.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Ingreso inválido. Ingrese el número de opción");
                }
                else if (opcion < desde || opcion > hasta)
                {
                    Console.WriteLine("Opción inválida. Debe ingresar un número entre el " + desde + " y el " + hasta + ". Ingrese el número de opción");
                }
            } while (opcion < desde || opcion > hasta);

            return opcion;
        }
        public static int PedirIntDesde(int desde)
        {
            Console.WriteLine("Ingrese un número..");
            int numero;
            do
            {
                if (!Int32.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Ingreso inválido. Ingrese un número.");
                }
                else if (numero < desde)
                {
                    Console.WriteLine("Opción inválida. Debe ingresar un número desde " + desde + ". Ingrese un número positivo.");
                }
            } while (numero < desde);

            return numero;
        }
        public static int PedirCodigoDesde(int desde)
        {
            Console.WriteLine("Ingrese un número de código...");
            int numero;
            do
            {
                if (!Int32.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Ingreso inválido. Ingrese un número.");
                    numero = -1;
                }
                else if (numero < desde)
                {
                    Console.WriteLine("Ingreso inválido. Debe ingresar un número desde " + desde + ". Ingrese un número positivo.");
                }
            } while (numero < desde);

            return numero;
        }
        public static string PedirStringNoVac()
        {
            // Console.WriteLine("Ingrese una palabra.");
            string texto = "";
            do
            {
                if (String.IsNullOrEmpty(Console.ReadLine()))
                {
                    Console.WriteLine("Error. No ingresó nada. Vuelva a intentarlo.");
                    texto = "";
                }
            } while (texto == "");

            return texto;
        }
    }
}
