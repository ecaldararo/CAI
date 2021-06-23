using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio1.CALDARARO.Entidades.Entidades
{
    public class Tabla : EquipoMovil
    {
        public Tabla(int nroSerie) : base(nroSerie)
        {
            _nroSerie = nroSerie;
        }

        public Tabla(int nroSerie, int bateria, double precioHora, string obs) : base(nroSerie)
        {
            _bateria = bateria;
            PrecioPorHora = precioHora;
            _observacion = obs;
        }
    }
}
