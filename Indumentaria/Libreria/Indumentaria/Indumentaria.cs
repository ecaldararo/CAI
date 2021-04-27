using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public abstract class Indumentaria
    {
        private TipoIndumentaria tipo;
        private int codigo;
        private int stock;
        private string talle;
        private double precio;

        public int Codigo { get => codigo; set => codigo = value; }
        public TipoIndumentaria Tipo { get => tipo; set => tipo = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Talle { get => talle; set => talle = value; }
        public double Precio { get => precio; set => precio = value; }

        protected Indumentaria(TipoIndumentaria tipo, int codigo, int stock, string talle, double precio)
        {
            this.Tipo = tipo;
            this.Codigo = codigo;
            this.Stock = stock;
            this.Talle = talle;
            this.Precio = precio;
        }
    }
}
