using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaBotones;

namespace ProyectoBotones
{
    public class ControladorProgram
    {
        public static void Listar(List<Boton> lista)
        {
            foreach (Boton item in lista)
            {
                Console.WriteLine("Código: " + item.IdBoton + "\t Descripción: " + item.Description);
            }
        }
        public static void Agregar(List<Boton> lista)
        {
            Console.WriteLine("Ingrese una descripción.");
            string descripcion = Validadores.PedirString();

            /*Console.WriteLine("Ingrese un código.");
            int codigo = Validadores.PedirInt();
            while (Controlador.Agregar(lista, descripcion) == false)
            {
                Console.WriteLine("Código inválido, ingrese otro código.");
                codigo = Validadores.PedirInt();
            }*/

            Controlador.Agregar(lista, descripcion);
        }
        public static void Eliminar(List<Boton> lista)
        {
            int codigo;
            do
            {
                codigo = Validadores.PedirInt();
            } while (!lista.Exists(item => item.IdBoton == codigo));
            lista.RemoveAll(item => item.IdBoton == codigo);
        }
        public static void MostrarDescripcion(List<Boton> lista)
        {
            int codigo = Validadores.PedirInt();
            while (!lista.Exists(item => item.IdBoton == codigo))
            {
                Console.WriteLine("\n**Botón inexistente** \nIngrese otro código:");
                codigo = Validadores.PedirInt();
            }
            Console.WriteLine("La descripción es: " + lista.Find(item => item.IdBoton == codigo).Description);
        }
    }
}

