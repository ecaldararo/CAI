using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        private static int _id = 0;
        private int codigo;
        private string _nombre;
        public int Codigo { get => codigo; set => codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public Categoria(string nombre)
        {
            _id += 1;
            Codigo = _id;
            Nombre = nombre;
        }

        public override string ToString()
        {
            return $"{Nombre}({Codigo})";
        }





    }
}
