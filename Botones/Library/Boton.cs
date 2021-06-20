using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBotones
{
    public class Boton
    {
        private static int id = 0;
        private int idBoton;
        private string description;

        public string Description { get { return description; } }

        public int IdBoton { get => idBoton; }

        public Boton(string desc)
        {
            id += 1;
            idBoton = id;
            description = desc;
        }

        public void EditarDescripcion(string desc)
        {
            this.description = desc;
        }
        //Exception e
        

    }
}
