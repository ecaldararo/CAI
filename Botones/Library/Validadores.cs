using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Validadores
    {
        public static int PedirInt(int desde, int hasta)
        {

            Console.WriteLine("--- Ingrese un número del " + desde + " al " + hasta + " ---");
            int salida = 0;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out salida))
                {
                    Console.WriteLine("--- El ingreso es inválido, vuelva a intentarlo ---");
                }
                else if (salida < desde || salida > hasta)
                {
                    throw new IndexOutOfRangeException("Ingresó un número fuera del rango.");
                    //Console.WriteLine("--- Ingresó un número fuera del rango. Ingrese un número del " + desde + " al " + hasta + " ---");
                }

            } while (salida < desde || salida > hasta);

            return salida;

        }
        public static int PedirInt()
        {

            Console.WriteLine("--- Ingrese un número superior a cero ---");
            int salida = 0;
            do
            {
                if (!int.TryParse(Console.ReadLine(), out salida))
                {
                    Console.WriteLine("--- El ingreso es inválido, vuelva a intentarlo ---");
                }

            } while (salida <= 0);

            return salida;

        }
        public static string PedirString()
        {
            Console.WriteLine("--- Ingrese un texto ---");

            string salida = Console.ReadLine();

            return salida;

        }
    }
}
