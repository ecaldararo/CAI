using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Librerias;

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
            foreach(Alumno i in lista)
            {
                i.ToString();
            }
            // para cada alumno solo preguntar si está presente
            foreach (Alumno i in lista)
            {
                i.ToString();
            }
            // agrego la lista de asistencia
            // Error: mostrar el error y que luego muestre el menú nuevamente
        }
        static void MostrarAsistencia()
        {
            // ingreso fecha
            string fecha = Val.PedirFecha();
            // muestro el toString de cada asistencia
        }


    }
}
