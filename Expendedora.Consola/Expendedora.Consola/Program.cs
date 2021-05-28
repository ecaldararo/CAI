using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaExpendedora;

namespace ProyectoExpendedora
{
    class Program
    {
        static void Main(string[] args)
        {
            Expendedora exp = new Expendedora(); // creo una instancia de expendedora
            Console.WriteLine("Máquina Expendedora\nPresione cualquier tecla para encenderla");
            Console.ReadKey();
            exp.EncenderMaquina(); // se enciende la máquina
            Console.WriteLine("***Máquina Encendida***");

            MenuPrincipal(exp);

            Console.ReadKey();

        }

        public static void MenuPrincipal(Expendedora exp)
        {
            int menu = 0;
            do
            {
                Console.WriteLine("Opciones\n" +
                "1-\tListar latas disponibles\n" +
                "2-\tInsertar Lata\n" +
                "3-\tElegir Lata\n" +
                "4-\tObtener Balance\n" +
                "5-\tObtener Stock Detallado\n" +
                "6-\tApagar Máquina");

                int opcion = Validadores.PedirOpcion(1, 6);

                switch (opcion)
                {
                    case 1:
                        MostrarStock(exp);
                        break;
                    case 2:
                        IngresarLata(exp);
                        break;
                    case 3:
                        ExtraerLata(exp);
                        break;
                    case 4:
                        ObtenerBalance(exp);
                        break;
                    case 5:
                        break;
                    case 6:
                        Console.WriteLine("Vuelva Pronto!");
                        menu = 1;
                        break;
                }
            } while (menu == 0);


        }

        private static void IngresarLata(Expendedora expendedora)
        {
            
            Lata lata2 = new Lata("1", "Coca", 15);
            Lata lata3 = new Lata("2", "Sprite", 5);
            
            int other = 1;
            do
            {
                Console.WriteLine("Ingrese el código:");
                string codigo = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre:");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad:");
                int cantidad = Validadores.PedirIntDesde(0);
                Lata lata = new Lata(codigo, nombre, cantidad);

                try
                {
                    expendedora.AgregarLata(lata);
                }
                catch (CapacidadInsuficienteException cie)
                {
                    Console.WriteLine(cie.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ha ocurrido un error----->" + ex.Message);
                }
                Console.WriteLine("Desea agregar otra lata?");
                Console.WriteLine("Para Si, presione 1\n Para No, presione 0");
                other = Validadores.PedirOpcion(0, 1);
            } while (other == 1);
            

        }

        private static void ExtraerLata(Expendedora expendedora)
        {
            MostrarStock(expendedora);
            Lata lata;
            int flag = 0;
            while (flag == 0)
            {
                Console.WriteLine("Ingrese el código de la lata, y el dinero.");
                try
                {
                    lata = expendedora.ExtraerLata(Validadores.PedirCodigo(), Validadores.PedirDinero());
                    lata.Cantidad += -1;
                    Console.WriteLine("Lata extraída exitosamente.");
                    flag = 1;
                }
                catch (DineroInsuficienteException de)
                {
                    Console.WriteLine("Error." + de.Message);
                }
                catch (CodigoInvalidoException ce)
                {
                    Console.WriteLine("Error." + ce.Message);
                }
            }
            
            MostrarStock(expendedora);

        }

        private static void ObtenerBalance(Expendedora expendedora)
        {
            Console.WriteLine(expendedora.GetBalance());
        }
        private static void MostrarStock(Expendedora expendedora)
        {
            Console.WriteLine("Stock Disponible:");
            foreach (Lata element in expendedora._latas)
            {
                Console.WriteLine("CO"+element.Codigo+") "+element.Nombre+" ["+element.Cantidad+"]");
            }
        }
        
    }
    class Validadores
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
        public static int PedirOpcion(int desde, int hasta)
        {
            Console.WriteLine("Ingrese el número de opción");
            int opcion;
            do
            {
                if (!Int32.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Ingreso inválido. Ingrese el número de opción");
                } else if (opcion < desde || opcion > hasta)
                {
                    Console.WriteLine("Opción inválida. Debe ingresar un número entre el " + desde + " y el " + hasta + ". Ingrese el número de opción");
                }
            } while (opcion < desde || opcion > hasta);
            
            return opcion;
        }
        public static int PedirIntDesde(int desde)
        {
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
    }
}
