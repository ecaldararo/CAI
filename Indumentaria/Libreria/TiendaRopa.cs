using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class TiendaRopa
    {
        private List<Indumentaria> _inventario;

        public List<Indumentaria> Inventario { get => _inventario; set => _inventario = value; }

        public TiendaRopa()
        {
            Inventario = new List<Indumentaria>();
        }

        
    }
}
