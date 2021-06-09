using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Comercio
    {
        public List<Repuesto> _listaProductos;
        private string _nombreComercio;
        private string _direccion;

        public string NombreComercio { get => _nombreComercio; set => _nombreComercio = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public List<Repuesto> ListaProductos { get => _listaProductos; set => _listaProductos = value; }

        public Comercio(string nombreComercio, string direccion)
        {
            NombreComercio = nombreComercio;
            Direccion = direccion;
            ListaProductos = new List<Repuesto>();
        }
    }
}
