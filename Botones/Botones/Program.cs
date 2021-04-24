﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaBotones;

namespace ProyectoBotones
{
    class Program
    {
        static void Main(string[] args)
        {


            //Solución en 2 proyectos.
            //- Consola: un menú donde el usuario pueda seleccionar la opción deseada entre(listar botones, agregar botón, eliminar botón, mostrar descripción, salir)
            //- Proyecto de librería: clase controlador, clase botón

            //- El programa sólo debe terminar si el usuario quiere salir.
            //- NO usar console.writeline en las clases dentro de libreria.Deben manejarlo con throw y try/catch en la consola.
            //- Hacer una exception custom(ej.BotonYaExistenteException)


            List<Boton> listaBotones = new List<Boton>();

            List<int> ids = new List<int>();

            Menu(listaBotones);

            Console.ReadKey();

        }
        public static void Menu(List<Boton> lista)
        {
            bool exit = false;

            while (exit == false)
            {
                Console.WriteLine(
                    "***Menu de Botones*** \n" +
                    "1-Listar Botones \n" +
                    "2-Agregar Botón \n" +
                    "3-Eliminar Botón \n" +
                    "4-Mostrar Descripción \n" +
                    "5-Salir");

                int entrada = Validadores.PedirInt(1, 5);

                switch (entrada)
                {
                    case 1:
                        //lista.Listar();
                        break;
                    case 2:
                        lista.Add(new Boton(Validadores.PedirInt(), Validadores.PedirString()));
                        break;
                    case 3:
                        //lista.EliminarBoton(id);
                        break;
                    case 4:
                        //lista.MostrarDescripcionBoton(id);
                        break;
                    case 5:
                        exit = true;
                        Console.WriteLine("***Gracias por utilizar nuestros servicios.*** \nAprete cualquier tecla para salir.");
                        break;
                }
                    

            }
        }
    }
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
                } else if (salida < desde || salida > hasta)
                {
                    Console.WriteLine("--- Ingresó un número fuera del rango. Ingrese un número del " + desde + " al " + hasta + " ---");
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
