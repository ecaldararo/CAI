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
        private List<Venta> _ventas;
        private int _ultimoCodigo;


        public TiendaRopa()
        {
            _inventario = new List<Indumentaria>();
            _ventas = new List<Venta>();

        }


        
    }
}
