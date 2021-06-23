using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recuperatorio1.CALDARARO.Entidades.Exceptions;

namespace Recuperatorio1.CALDARARO.Entidades.Entidades
{
    public class PuntoAlquiler : EntidadInteligente
    {
        protected string _direccion;
        private string _barrio;

        public PuntoAlquiler(int nroSerie, string dir, string bar) : base(nroSerie)
        {
            _nroSerie = nroSerie;
            _direccion = dir;
            _barrio = bar;
        }

        public string Barrio { get => _barrio;  }

        protected override string Display()
        {
            return $"Punto {NroSerie}";
        }
    }
}
