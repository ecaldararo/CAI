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

            
        }

        private static void IngresarLata(Expendedora expendedora)
        {
            expendedora.AgregarLata(new Lata());
        }

        private static void ExtraerLata(Expendedora expendedora)
        {
            expendedora.ExtraerLata(Validadores.PedirCodigo(), Validadores.PedirDinero() );
        }

        private static void ObtenerBalance(Expendedora expendedora)
        {
            expendedora.GetBalance();
        }
        private static void MostrarStock(Expendedora expendedora)
        {
            foreach (Lata element in expendedora._latas)
            {
                element.Codigo.ToString();
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
    }
}
