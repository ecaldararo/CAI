using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            //Además, les dejamos la consigna del ejercicio "Calculadora":
            //- Tomar variables(número A, número B, operador)
            //- Hacer validaciones(tienen que estar en el otro proyecto)
            //- Procesar esas variables en un archivo que este en otro proyecto
            //- Mantener la consola viva, es decir, que el programa no termine hasta que el usuario ingrese una X

            string ingreso = "";

            do
            {
                Console.WriteLine("--CALCULADORA-- /n 1. Multiplicar/n 2.Sumar /n X.Salir");

                string entrada = Console.ReadLine();

                if (entrada != "X")
                {
                    int operacion = Menu(1, 2, entrada);

                    switch (operacion)
                    {
                        case 1:
                            double resultadosuma = Multiplicar();
                            Console.WriteLine("El resultado de la multiplicación es:" + resultadosuma);
                            break;
                        case 2:
                            double resultadomultiplicacion = Sumar();
                            Console.WriteLine("El resultado de la suma es:" + resultadomultiplicacion);
                            break;
                    }
                } 
                else
                {
                    ingreso = "X";
                }
                
            } while (ingreso != "X");
            
            Console.ReadKey();

        }

        public static double Multiplicar()
        {
            Console.WriteLine("Va a mutiplicar 2 números");
            int numero1 = PedirInt();
            int numero2 = PedirInt();
            return numero1 * numero2;
        }
        public static double Sumar()
        {
            Console.WriteLine("Va a Sumar 2 números");
            int numero1 = PedirInt();
            int numero2 = PedirInt();
            return numero1 + numero2;
        }
        public static int Menu(int min, int max, string entr)
        {
            int entrada = -1;

            while (entrada == -1)
            {
                Console.WriteLine("Ingrese un número");
                while (!Int32.TryParse(entr, out entrada))
                {
                    Console.WriteLine("No ingresó un número válido, ingrese un número.");
                    entr = Console.ReadLine();
                }
                if (entrada < min && entrada > max)
                {
                    Console.WriteLine("En número ingresado no corresponde a una opción del menú.");
                    entr = Console.ReadLine();
                    entrada = -1;
                }

            }

            return entrada;
        }
        public static int PedirInt()
        {
            int numero;

            Console.WriteLine("Ingrese un número.");

            while (!Int32.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("No ingresó un número válido, ingrese un número.");
            }
            return numero;
        }
        /*public static void PedirDosNumeros()
        {
            Console.WriteLine("Ingrese un número");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese otro número");
            int numero2 = Convert.ToInt32(Console.ReadLine());
        }*/
    }


}
