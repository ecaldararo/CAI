using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBotones
{
    public class Boton
    {
        private int id;
        private string description;

        public int Id { get { return id;  } set { id = value; } }
        public string Description { get { return description; } set { description = value; } }

        public Boton(int id, string desc)
        {
            Id = id;
            Description = desc;
        }
        public void CrearBoton(int id, string description)
        {

        }

    }
}
