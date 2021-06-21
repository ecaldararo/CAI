using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public static class Perkins
    {
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
        public static string PedirStringNoVac(string mensaje)
        {
            Console.WriteLine("Ingrese "+ mensaje);
            string texto;
            do
            {
                texto = Console.ReadLine();
                if (String.IsNullOrEmpty(texto))

                {
                    Console.WriteLine("Error. No ingresó nada. Vuelva a intentarlo.");
                    texto = "";
                }
            } while (texto == "");

            return texto;
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
                else if (numero <= desde)
                {
                    Console.WriteLine("Opción inválida. Debe ingresar un número mayor a " + desde);
                }
            } while (numero <= desde);

            return numero;
        }

        public static double PedirSalario()
        {
            Console.WriteLine("Ingrese un salario..");
            double salario = -1;
            while (salario < 0)
            {
                if (!Double.TryParse(Console.ReadLine(), out salario))
                {
                    Console.WriteLine("Ingreso inválido. Ingrese un número. Debe ser positivo.");
                }
            };

            return salario;
        }
    }
}
