using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas;
using Validadores;
using Exceptions;

namespace ProyectoVentaRepuestos
{
    class Program
    {
        static void Main(string[] args)
        {
            //. Solucion en 2 capas(proyecto consola y proyecto libreria de clases)
            //.Generar al menos 2 exceptions custom 
            //. Validar todos los inputs de usuario
            //. Controlar exceptions
            //. Modulariazar
            //.ABM de repuestos(Si el repuesto tiene stock, no puede ser eliminado del inventario)
            //.Listar repuestos por categorias
            //.Agregar stock de un repuesto
            //.Quitar stock de un repuesto

            Comercio comercio1 = new Comercio("VentaRepuestos","Ambrosetti 991");
            Menu(comercio1);

        }

        static void Menu(Comercio comercio)
        {
            bool menu = true;
            do
            {
                Console.WriteLine(
                "--------Menu-------\n" +
                " 1- Nuevo Repuesto \n" +
                " 2- Quitar Repuesto \n" +
                " 3- Listar Repuestos \n" +
                " 4- Agregar Stock \n" +
                " 5- Quitar Stock \n" +
                " 6- Salir \n" +
                "--------------------");

                Console.WriteLine("Eliga una opción...");

                int opcion = Val.PedirOpcion(1, 6);

                switch (opcion)
                {
                    case 1:
                        AgregarRepuesto(comercio);
                        break;
                    case 2:
                        QuitarRepuesto(comercio);
                        break;
                    case 3:
                        ListarProductos(comercio);
                        break;
                    case 4:
                        AgregarStock(comercio);
                        break;
                    case 5:
                        QuitarStock(comercio);
                        break;
                    case 6:
                        menu = false;
                        break;

                }
            } while (menu == true);
            
        }
        static void AgregarRepuesto(Comercio comercio)
        {
            Console.WriteLine("Agregando Nuevo Repuesto...");
            Repuesto rep = new Repuesto(Val.PedirCodigoDesde(0), Val.PedirNombre(), Val.PedirPrecio(), new Categoria(PedirCategoria()), Val.PedirCantidad());
            comercio.AgregarRepuesto(rep);
        }
        static void QuitarRepuesto(Comercio comercio)
        {
            Console.WriteLine("Quitando Repuesto...");
            comercio.QuitarRepuesto(Val.PedirIntDesde(0));
        }
        static string PedirCategoria()
        {
            Console.WriteLine("Ingrese el nombre de la categoría");
            return Val.PedirNombre();

        }
        static void ListarProductos(Comercio comercio)
        {
            Console.WriteLine("Listando Productos...");
            foreach (Repuesto i in comercio.ListaProductos)
            {
                Console.WriteLine("Cod: " + i.Codigo + " Nombre: " + i.Nombre + " Cantidad: " + i.Stock);
            }

        }
        static void AgregarStock(Comercio comercio)
        {
            Console.WriteLine("Agregar Stock");
            bool flag = false;
            do
            {
                try
                {
                    comercio.AgregarStock(Val.PedirIntDesde(0), Val.PedirCantidad());
                    flag = true;
                }
                catch (CodigoInvalidoException cie)
                {
                    Console.WriteLine(cie.Message);
                }
            } while (flag == false);
            
        }
        static void QuitarStock(Comercio comercio)
        {
            Console.WriteLine("Quitar Stock");
            bool flag = false;
            do
            {
                try
                {
                    comercio.QuitarStock(Val.PedirIntDesde(0), Val.PedirCantidad());
                    flag = true;
                }
                catch (CodigoInvalidoException cie)
                {
                    Console.WriteLine(cie.Message);
                }
            } while (flag == false);

        }
    }
}
