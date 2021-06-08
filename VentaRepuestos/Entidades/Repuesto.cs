using Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Repuesto
    {
        private static int id = 0;
        private int _codigo;
        private string _nombre;
        private double _precio;
        private int _stock;
        private Categoria _categoria;

        public int Codigo { get => _codigo;  }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public double Precio { get => _precio; set => _precio = value; }
        public Categoria Categoria { get => _categoria; set => _categoria = value; }
        public int Stock { get => _stock; set => _stock = value; }

        public Repuesto(string nombre, double precio, Categoria categoria, int stock)
        {
            id += 1;
            _codigo = id;
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
            _codigo = codigo;
            Nombre = nombre;
            Precio = precio;
            Categoria = categoria;
            Stock = stock;
        }

        public override string ToString()
        {
            return $"{Codigo}) {Categoria}-{Nombre}, Precio: {Precio}, Stock: {Stock}";

        }
    }
}
