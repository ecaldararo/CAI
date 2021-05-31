using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.Consola
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
        public static int PedirInt(int desde, int hasta)
        {
            //Console.WriteLine("Ingrese el número de opción");
            int opcion;
            do
            {
                if (!Int32.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Ingreso inválido. Vuelva a intentarlo.");
                }
                else if (opcion < desde || opcion > hasta)
                {
                    Console.WriteLine("Ingreso inválido. Debe ingresar un número entre el " + desde + " y el " + hasta + ".");
                }
            } while (opcion < desde || opcion > hasta);

            return opcion;
        }
        public static string PedirOpcion(string op1, string op2, string op3)
        {
            Console.WriteLine("Ingrese la opción deseada...");
            string opcion;
            do
            {
                opcion = Console.ReadLine();
                if (opcion == op1 || opcion == op2 || opcion == op3)
                    break;
                else
                    Console.WriteLine("Ingreso inválido. Vuelva a intentarlo.");
            } while (opcion != op1 && opcion != op2 && opcion != op3);

            return opcion;
        }
        public static int PedirIntDesde(string nombre, int desde)
        {
            Console.WriteLine("Ingrese un "+ nombre);
            int numero;
            do
            {
                if (!Int32.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Ingreso inválido. Ingrese un número.");
                }
                else if (numero < desde)
                {
                    Console.WriteLine("Opción inválida. Debe ingresar un número mayor a " + desde);
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
        public static string PedirFecha()
        {
           
            Console.WriteLine("Ingrese el año, mes y día, con el formato AAAA-MM-DD.");
            string fecha = Console.ReadLine();
            

            return fecha;

        }

        public static bool PedirOpcionSINO()
        {
            Console.WriteLine("Ingrese un el número de opción \n 1- SI \n 2- NO");
            int opcion;
            do
            {
                if (!Int32.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Ingreso inválido. Ingrese el número de opción");
                }
                else if (opcion < 0 || opcion > 3)
                {
                    Console.WriteLine("Opción inválida. Debe ingresar 1 para SI, o 2 para No. Ingrese el número de opción");
                }
            } while (opcion < 0 || opcion > 3);

            bool salida;
            if (opcion == 1)
                salida = true;
            else
                salida = false;

            return salida;
        }

        public static string GetStringInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (input == "")
            {
                Console.WriteLine("Debes ingresar un valor");
                return GetStringInput(message);
            }
            else
            {
                return input;
            }
        }

        public static double GetDoubleInput(string message)
        {

            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (double.TryParse(input, out double retorno))
            {
                return retorno;
            }
            else
            {
                Console.WriteLine("Debes ingresar un numero");
                return GetDoubleInput(message);
            }
        }

        public static int GetIntegerInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (int.TryParse(input, out int retorno))
            {
                return retorno;
            }
            else
            {
                Console.WriteLine("Debes ingresar un numero entero");
                return GetIntegerInput(message);
            }
        }

        public static DateTime GetDateInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();

            if (DateTime.TryParse(input, out DateTime retorno))
            {
                return retorno;
            }
            else
            {
                Console.WriteLine("Debes ingresar una fecha con formato valido");
                return GetDateInput(message);
            }
        }
    }
}

