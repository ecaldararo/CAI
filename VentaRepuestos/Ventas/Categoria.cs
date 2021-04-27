using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas
{
    public class Categoria
    {
        private int _codigo;
        private string _nombre;
        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public Categoria(string nombre)
        {
            _codigo ++;
            Codigo = _codigo;
            Nombre = nombre;
        }


        


    }
}
