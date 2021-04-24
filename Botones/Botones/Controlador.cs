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
                Console.WriteLine("Código: " + item.Id + "\t Descripción: " + item.Description);
            }
        }
        public static void Agregar(List<Boton> lista)
        {
            Console.WriteLine("Ingrese una descripción.");
            string descripcion = Program.Validadores.PedirString();

            Console.WriteLine("Ingrese un código.");
            int codigo = Program.Validadores.PedirInt();
            while (Controlador.Agregar(lista, codigo, descripcion) == false)
            {
                Console.WriteLine("Código inválido, ingrese otro código.");
                codigo = Program.Validadores.PedirInt();
            }
        }
        public static void Eliminar(List<Boton> lista)
        {
            int codigo;
            do
            {
                codigo = Program.Validadores.PedirInt();
            } while (!lista.Exists(item => item.Id == codigo));
            lista.RemoveAll(item => item.Id == codigo);
        }
        public static void MostrarDescripcion(List<Boton> lista)
        {
            int codigo = Program.Validadores.PedirInt();
            while (!lista.Exists(item => item.Id == codigo))
            {
                Console.WriteLine("\n**Botón inexistente** \nIngrese otro código:");
                codigo = Program.Validadores.PedirInt();
            }
            Console.WriteLine("La descripción es: " + lista.Find(item => item.Id == codigo).Description);
        }
    }
}
}
