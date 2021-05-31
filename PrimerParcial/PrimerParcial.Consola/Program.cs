﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librerias;
using Exceptions;

namespace PrimerParcial.Consola
{
    public class Program
    {
        private static Presentismo _presentismo;

        static Program()
        {
            _presentismo = new Presentismo();
        }
        // modificar lo que corresponda para que solo finalice el
        // programa si el usuario presiona X en el menú
        static void Main(string[] args)
        {
            Preceptor preceptorActivo = _presentismo.GetPreceptorActivo();
            
            bool menu = false;
            do
            {
                DesplegarOpcionesMenu();
                string opcionMenu = Val.PedirOpcion("1", "2", "X"); // pedir el valor
                switch (opcionMenu)
                {
                    case "1":
                        TomarAsistencia(preceptorActivo);
                        break;
                    case "2":
                        MostrarAsistencia();
                        break;
                    case "X":
                        menu = true;
                        break;
                    default:
                        break;
                }
            } while (menu == false);
            
        }
        static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("1) Tomar Asistencia");
            Console.WriteLine("2) Mostrar Asistencia");
            Console.WriteLine("X: Terminar");
        }
        static void TomarAsistencia(Preceptor p)
        {
            // Ingreso fecha
            string fecha = Val.PedirFecha();
            // Listar los alumnos
            List<Alumno> lista = Presentismo.GetListaAlumnos();

            Console.WriteLine("---Lista de alumnos---");
            foreach (Alumno i in lista)
            {
                Console.WriteLine(i.ToString());
            }
            Console.WriteLine("---Fin lista de alumnos---");

            // para cada alumno solo preguntar si está presente
            List<Asistencia> listaHoy = new List<Asistencia>();
            foreach (Alumno i in lista)
            {
                Console.WriteLine("Tomar asistencia del alumno " + i.ToString());

                // Preguntar si asistió
                // Si asiste, agregar a listaHoy

                if (i is AlumnoOyente)
                {
                    Console.WriteLine("El alumno " + i.ToString() + " es oyente");
                }
                else
                {
                    bool rta = Val.PedirOpcionSINO();
                    Asistencia asist = new Asistencia(p, fecha, i, rta);
                    listaHoy.Add(asist);
                }
            }
            // agrego la lista de asistencia
            try
            {
                _presentismo.AgregarAsistencia(listaHoy);
                Console.WriteLine("Asistencias del día :" + fecha + " agregadas exitosamente");
            }
            catch (AsistenciaExistenteEseDiaException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch (AsistenciaInconsistenteException aie)
            {
                Console.WriteLine(aie.Message);
            }
            // Error: mostrar el error y que luego muestre el menú nuevamente
        }
        static void MostrarAsistencia()
        {
            // ingreso fecha
            string fecha = Val.PedirFecha();

            // muestro el toString de cada asistencia
            try
            {
                List<Asistencia> lista = _presentismo.GetAsistenciasPorFecha(fecha);
                Console.WriteLine("Asistencias del día " + fecha);
                foreach (Asistencia i in lista)
                {
                    Console.WriteLine(i.ToString());
                }
            }
            catch (SinAlumnosRegistradosException sex)
            {
                Console.WriteLine(sex.Message);
            }
            
        }


    }
}
