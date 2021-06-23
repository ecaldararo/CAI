using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recuperatorio1.CALDARARO.Entidades.Exceptions;

namespace Recuperatorio1.CALDARARO.Entidades.Entidades
{
    public abstract class EquipoMovil : EntidadInteligente
    {
        protected int _bateria;
        private double _precioPorHora;
        protected string _observacion;

        protected EquipoMovil(int nroSerie) : base(nroSerie)
        {
            _nroSerie = nroSerie;
        }

        public EquipoMovil(int nroSerie, int bateria, double precioHora, string obs) : base(nroSerie)
        {
            _nroSerie = nroSerie;
            _bateria = bateria;
            _precioPorHora = precioHora;
            _observacion = obs;
        }

        internal double PrecioPorHora { get => _precioPorHora; set => _precioPorHora = value; }

        internal int Bateria { get => _bateria; }

        protected override string Display()
        {
            return $"{GetType().Name} {NroSerie.ToString("0")} ) $ {PrecioPorHora.ToString("0.0")} ({Bateria.ToString()}%) - {_observacion}";
        }
    }
}
