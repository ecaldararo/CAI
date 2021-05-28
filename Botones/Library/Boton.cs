using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBotones
{
    public class Boton
    {
        static private int id = 0;
        private int idBoton;
        private string description;

        public string Description { get { return description; } set { description = value; } }

        public int IdBoton { get => idBoton; set => idBoton = value; }

        public Boton(string desc)
        {
            id += 1;
            IdBoton = id;
            Description = desc;
        }
        //Exception e
        
        public void CrearBoton(int id, string description)
        {

        }

    }
}
