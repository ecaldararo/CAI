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
        static Expendedora exp;
        static void Main(string[] args)
        {
            exp = new Expendedora(); // creo una instancia de expendedora

            Lata lata1 = new Lata("1", "Coca", 35, 250, 69, "Dulce");
            Lata lata2 = new Lata("2", "Sprite", 25, 250, 59, "Dulce");
            Lata lata3 = new Lata("3", "Fanta", 15, 250, 49, "Dulce");

            exp._latas.Add(lata1);
            exp._latas.Add(lata2);
            exp._latas.Add(lata3);

            MenuPrincipal();

            Console.ReadKey();

        }

        static void MenuPrincipal()
        {
            int menu = 0;
            do
            {
                Console.WriteLine(
                "------------------------Opciones------------------------\n" +
                "0-\tEncender Máquina\n" +
                "1-\tListar latas disponibles\n" +
                "2-\tInsertar Lata\n" +
                "3-\tElegir Lata\n" +
                "4-\tObtener Balance\n" +
                "5-\tObtener Stock Detallado\n" +
                "6-\tApagar Máquina\n"+
                "-------------------------------------------------------\n");

                int opcion = Validadores.PedirOpcion(0, 6);

                switch (opcion)
                {
                    case 0:
                        EncenderMaquina();
                        break;
                    case 1:
                        if (exp.Encendida == true)
                            MostrarStock();
                        else
                            MaquinaApagada();
                        break;
                    case 2:
                        if (exp.Encendida == true)
                            IngresarLata();
                        else
                            MaquinaApagada();
                        break;
                    case 3:
                        if (exp.Encendida == true)
                            ExtraerLata();
                        else
                            MaquinaApagada();
                        break;
                    case 4:
                        if (exp.Encendida == true)
                            ObtenerBalance();
                        else
                            MaquinaApagada();
                        break;
                    case 5:
                        if (exp.Encendida == true)
                            ObtenerStockDetallado();
                        else
                            MaquinaApagada();
                        break;
                    case 6:
                        Console.WriteLine("Vuelva Pronto!");
                        menu = 1;
                        break;
                }
            } while (menu == 0);


        }

        private static void MaquinaApagada()
        {
            Console.WriteLine("Máquina apagada, debe encender la máquina primero");
        }

        private static void ObtenerStockDetallado()
        {
            foreach (Lata l in exp._latas)
            {
                Console.WriteLine($"CO{l.Codigo}-Nombre:{l.Nombre}/{l.Sabor}-${l.Precio}-Vol.{l.Volumen}-Cantidad:{l.Cantidad}");
            }
        }

        private static void EncenderMaquina()
        {
            exp.EncenderMaquina();
        }

        private static void IngresarLata()
        {
            int other = 1;
            do
            {
                Console.WriteLine("Ingrese el código:");
                string codigo = Console.ReadLine();
                Console.WriteLine("Ingrese el nombre:");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese la cantidad:");
                int cantidad = Validadores.PedirIntDesde(0);
                Console.WriteLine("Ingrese el volumen:");
                int volumen = Validadores.PedirIntDesde(0);
                Console.WriteLine("Ingrese el precio:");
                double precio = Validadores.PedirPrecio();
                Console.WriteLine("Ingrese el sabor:");
                string sabor = Console.ReadLine();

                Lata lata = new Lata(codigo, nombre, cantidad,volumen, precio, sabor);

                try
                {
                    exp.AgregarLata(lata);
                }
                catch (CapacidadInsuficienteException cie)
                {
                    Console.WriteLine(cie.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("**************Ha ocurrido un error----->" + ex.Message + "*************");
                }
                Console.WriteLine("Desea agregar otra lata?");
                Console.WriteLine("Para Si, presione 1\n Para No, presione 0");
                other = Validadores.PedirOpcion(0, 1);
            } while (other == 1);
            

        }

        private static void ExtraerLata()
        {
            MostrarStock();
            DevolucionMaquina devolucionMaquina;
            int flag = 0;
            while (flag == 0)
            {
                Console.WriteLine("Ingrese el código de la lata, y el dinero.");
                try
                {
                    devolucionMaquina = exp.ExtraerLata(Validadores.PedirCodigo(), Validadores.PedirDinero());
                    Console.WriteLine("========Lata extraída exitosamente.========");
                    Console.WriteLine(devolucionMaquina.ToString()); ;
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
            
            MostrarStock();

        }

        private static void ObtenerBalance()
        {
            Console.WriteLine(exp.GetBalance());
        }
        private static void MostrarStock()
        {
            Console.WriteLine("Stock Disponible:");
            foreach (Lata element in exp._latas)
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
        public static double PedirPrecio()
        {
            Console.WriteLine("Ingrese el precio");
            double precio = (Double)Int32.Parse(Console.ReadLine());
            return precio;
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
