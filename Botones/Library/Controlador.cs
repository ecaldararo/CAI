using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBotones
{
    public class Controlador
    {
        List<Boton> listaBotones;

        public List<Boton> ListaBotones { get => listaBotones; set => listaBotones = value; }

        public Controlador()
        {
            listaBotones = new List<Boton>();
        }

        public string Listar()
        {
            if (listaBotones.Count == 0)
                throw new Exception("No hay botones en la lista.");

            string lst = "\n--Lista de Botones--\n";

            foreach (Boton item in listaBotones)
            {
                lst += "Código: " + item.IdBoton + "\t Descripción: " + item.Description + "\n";
            }

            return lst;

        }

        public string Agregar(string desc)
        {
            if (ListaBotones.Exists(x => x.Description == desc))
            {
                throw new BotonExistenteException();
            }
            else
            {
                this.ListaBotones.Add(new Boton(desc));
                return "Botón agregado exitosamente";
            }

        }
        public bool Eliminar(int codigo)
        {
            
            if (!this.ListaBotones.Exists(item => item.IdBoton == codigo))
            {
                throw new BotonInexistenteException();
            }

            this.ListaBotones.RemoveAll(item => item.IdBoton == codigo);
            return true;
        }
        public string MostrarDescripcion(int codigo)
        {
            if (!this.ListaBotones.Exists(item => item.IdBoton == codigo))
            {
                throw new BotonInexistenteException();
            }

            return "La descripción es: " + this.ListaBotones.Find(item => item.IdBoton == codigo).Description;
        }

    }
    
}
