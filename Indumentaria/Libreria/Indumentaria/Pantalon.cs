using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Pantalon : Indumentaria
    {
        public string Material;
        public bool TieneBolsillos;

        public Pantalon(TipoIndumentaria tipo, int codigo, int stock, string talle, double precio) : base(tipo, codigo, stock, talle, precio)
        {
        }
    }
}
