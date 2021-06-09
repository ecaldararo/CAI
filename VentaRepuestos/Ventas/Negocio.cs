using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptions;
using Entidades;

namespace Negocio
{
    public class NegocioController
    {
        Comercio comercio;
        public NegocioController(string st1, string st2)
        {
            comercio = new Comercio(st1,st2);
        }

        public void AgregarRepuestoALista(Repuesto repuesto)
        {
            comercio.ListaProductos.Add(repuesto);
        }
        public void QuitarRepuesto(int codigo)
        {
            if (comercio.ListaProductos.Exists(x => x.Codigo == codigo))
            {
                comercio.ListaProductos.RemoveAll(x => x.Codigo == codigo);
            }
            else
            {
                throw new CodigoInvalidoException();
            }
        }

        public List<Repuesto> Listar()
        {
            return comercio.ListaProductos;
        }

        public void ModificarPrecio(int codigo, double precio)
        {
            if (comercio.ListaProductos.Exists(x => x.Codigo == codigo))
            {
                Repuesto producto = comercio.ListaProductos.First(x => x.Codigo == codigo);
                producto.Precio = precio;
            }
            else
            {
                throw new CodigoInvalidoException();
            }
        }

        public void AgregarStock(int codigo, int stock)
        {
            if (comercio.ListaProductos.Exists(x => x.Codigo == codigo))
            {
                Repuesto producto = comercio.ListaProductos.First(x => x.Codigo == codigo);
                producto.Stock += stock;
            }
            else
            {
                throw new CodigoInvalidoException();
            }
        }
        public void QuitarStock(int codigo, int stock)
        {
            if (comercio.ListaProductos.Exists(x => x.Codigo == codigo))
            {
                Repuesto producto = comercio.ListaProductos.First(x => x.Codigo == codigo);
                producto.Stock -= stock;
            }
            else
            {
                throw new CodigoInvalidoException();
            }
        }
        public List<Repuesto> TraerPorCategoria(int codcat)
        {
            return comercio.ListaProductos.FindAll(x => x.Categoria.Codigo == codcat);
        }

    }
}
