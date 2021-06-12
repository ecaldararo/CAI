using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operador
    {
        public List<TipoPlazoFijo> _tiposPF;
        public List<PlazoFijo> _listaPlazosFijos;
        public Operador()
        {

            _listaPlazosFijos = new List<PlazoFijo>();

            //1, Plazo Fijo Web, 41%
            //2, Plazo Fijo UVA, 3%
        }

        public double MontoTotal { get => _listaPlazosFijos.Sum(x => x.MontoFinal);  }
        public double Comision { get => _listaPlazosFijos.Sum(x => x.MontoFinal) * 1/100 + 1;  }
    }
}
