using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas
{
    public class Repuesto
    {
        private int _codigo;
        private string _nombre;
        private double _precio;
        private int _stock;
        private Categoria _categoria;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public double Precio { get => _precio; set => _precio = value; }
        internal Categoria Categoria { get => _categoria; set => _categoria = value; }
        public int Stock { get => _stock; set => _stock = value; }

        public Repuesto(int codigo, string nombre, double precio, Categoria categoria, int stock)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Categoria = categoria;
            Stock = stock;
        }

        ~Repuesto()
        {
        }

        public string EliminarRepuesto(List<Repuesto> lista, int codigo)
        {
            Repuesto repuesto = lista.SingleOrDefault(x => x.Codigo == codigo);
            if (repuesto.Stock > 0)
                throw new ConStockException();
            else
                lista.Remove(repuesto);
            return "Repuesto Eliminado!";
            
        }

        public void ModificarRepuesto(int codigo, string nombre, double precio, Categoria categoria, int stock)
        {
            Codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Categoria = categoria;
            Stock = stock;
        }
    }
}
