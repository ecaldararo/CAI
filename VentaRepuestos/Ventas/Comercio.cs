using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptions;

namespace Ventas
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
        public void AgregarRepuesto(Repuesto repuesto)
        {
            this.ListaProductos.Add(repuesto);
        }
        public void QuitarRepuesto(int codigo)
        {
            if (ListaProductos.Exists(x => x.Codigo == codigo))
            {
                ListaProductos.RemoveAll(x => x.Codigo == codigo);
            }
            else
            {
                throw new CodigoInvalidoException();
            }
        }

        public void ModificarPrecio(int codigo, double precio)
        {
            if (ListaProductos.Exists(x => x.Codigo == codigo))
            {
                Repuesto producto = ListaProductos.First(x => x.Codigo == codigo);
                producto.Precio = precio;
            }
            else
            {
                throw new CodigoInvalidoException();
            }
        }

        public void AgregarStock(int codigo, int stock)
        {
            if (ListaProductos.Exists(x => x.Codigo == codigo))
            {
                Repuesto producto = ListaProductos.First(x => x.Codigo == codigo);
                producto.Stock += stock;
            }
            else
            {
                throw new CodigoInvalidoException();
            }
        }
        public void QuitarStock(int codigo, int stock)
        {
            if (ListaProductos.Exists(x => x.Codigo == codigo))
            {
                Repuesto producto = ListaProductos.First(x => x.Codigo == codigo);
                producto.Stock -= stock;
            }
            else
            {
                throw new CodigoInvalidoException();
            }
        }
        public List<Repuesto> TraerPorCategoria(int codcat)
        {
            return ListaProductos.FindAll(x => x.Categoria.Codigo == codcat);
        }
    }
}
