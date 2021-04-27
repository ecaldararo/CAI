using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Camisa : Indumentaria
    {
        private bool tieneEstampado;
        private string tipoManga;

        public Camisa(bool tieneEstampado, string tipoManga, TipoIndumentaria tipo, int codigo, int stock, string talle, double precio) : base(tipo, codigo, stock, talle, precio)
        {
            TieneEstampado = tieneEstampado;
            TipoManga = tipoManga;
            Codigo = codigo;
            Stock = stock;
            Talle = talle;
            Precio = precio;
        }



        public bool TieneEstampado { get => tieneEstampado; set => tieneEstampado = value; }
        public string TipoManga { get => tipoManga; set => tipoManga = value; }
    }
}
