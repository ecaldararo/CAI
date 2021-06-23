using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio1.CALDARARO.Entidades.Entidades
{
    public class Monopatin : EquipoMovil
    {
        public Monopatin(int nroSerie) : base(nroSerie)
        {
            _nroSerie = nroSerie;
        }

        public Monopatin(int nroSerie, int bateria, double precioHora, string obs) : base(nroSerie)
        {
            _bateria = bateria;
            PrecioPorHora = precioHora;
            _observacion = obs;
        }
    }
}
