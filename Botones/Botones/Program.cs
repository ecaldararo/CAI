using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using LibreriaBotones;

namespace ProyectoBotones
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Solución en 2 proyectos.
            //- Consola: un menú donde el usuario pueda seleccionar la opción deseada entre(listar botones, agregar botón, eliminar botón, mostrar descripción, salir)
            //- Proyecto de librería: clase controlador, clase botón

            //- El programa sólo debe terminar si el usuario quiere salir.
            //- NO usar console.writeline en las clases dentro de libreria.Deben manejarlo con throw y try/catch en la consola.
            //- Hacer una exception custom(ej.BotonYaExistenteException)


            //List<Boton> listaBotones = new List<Boton>();
            Controlador controlador = new Controlador();

            controlador.ListaBotones.Add(new Boton("Primero"));
            controlador.ListaBotones.Add(new Boton("Segundo"));
            controlador.ListaBotones.Add(new Boton("Tercero"));
            controlador.ListaBotones.Add(new Boton("Cuarto"));

            Menu(controlador);

            Console.ReadKey();

        }
        public static void Menu(Controlador con)
        {
            bool exit = false;

            while (exit == false)
            {
                Console.WriteLine(
                    "***************Menu de Botones*************** \n" +
                    "\t1-\tListar Botones \n" +
                    "\t2-\tAgregar Botón \n" +
                    "\t3-\tEliminar Botón \n" +
                    "\t4-\tMostrar Descripción \n" +
                    "\t5-\tSalir \n" +
                    "*********************************************");

                int entrada = 0;
                bool menu = false;
                do
                {
                    try
                    {
                        entrada = Perkins.PedirInt(1, 5);
                        menu = true;
                    }
                    catch (Exception iex)
                    {
                        Console.WriteLine(iex.Message);
                    }
                } while (menu == false);



                switch (entrada)
                {
                    case 1:
                        try
                        {
                            Console.WriteLine(con.Listar());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case 2:
                        Console.WriteLine("\n---------- AGREGAR BOTÓN ----------");
                        bool flag = false;
                        string descripcion = "";
                        while (flag == false)
                        {
                            Console.WriteLine("\nIngrese la descripción del botón:");
                            descripcion = Perkins.PedirString();
                            flag = Validaciones.ValidarStringNoVac(descripcion);
                        }
                        
                        try
                        {
                            Console.WriteLine(con.Agregar(descripcion));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        
                        break;
                    case 3:
                        Console.WriteLine("\n---------- ELIMINAR BOTÓN ----------");
                        int codigo;
                        flag = false;
                        while(flag == false)
                        {
                            codigo = Perkins.PedirInt();
                            try
                            {
                                flag = con.Eliminar(codigo);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            
                        }
                        
                        break;
                    case 4:
                        Console.WriteLine("\n------------MOSTRAR DESCRIPCIÓN------------");
                        codigo = -1;
                        while (codigo == -1)
                        {
                            Console.WriteLine("**Ingrese un código**");
                            codigo = Perkins.PedirInt();
                            try
                            {
                                Console.WriteLine(con.MostrarDescripcion(codigo));
                            }
                            catch (Exception ex)
                            {
                                codigo = -1;
                                Console.WriteLine(ex.Message);
                            }
                        }
                        
                        break;
                    case 5:
                        exit = true;
                        Console.WriteLine("***Gracias por utilizar nuestros servicios.*** \nAprete cualquier tecla para salir.");
                        break;
                }


            }
        }
    }

    public class Perkins
    {
        public static string PedirString()
        {
            Console.WriteLine("--- Ingrese un texto ---");

            string salida = Console.ReadLine();

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
    }
    
}
