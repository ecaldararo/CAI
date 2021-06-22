using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Entidades.Entidades;

namespace Entidades
{
    public class Adhesion
    {
        private DateTime _fechaHoraAdhesion;
        private Reclutadora _reclutadora;
        private Comercio _comercio;
        private static int id = 0;
        private int _nroOrden;

        public Adhesion()
        {
            id++;
            _nroOrden = id;
            _comercio = new Comercio();
            _reclutadora = new Reclutadora();
        }
        public Adhesion(Comercio comercio, Reclutadora reclutadora)
        {
            //id++;
            //_nroOrden = id;
            _comercio = comercio;
            _reclutadora = reclutadora;
            _fechaHoraAdhesion = DateTime.Now;
        }

        public int NroOrden { get => _nroOrden; set => _nroOrden = value; }
        public Comercio Comercio { get => _comercio; }

        public override string ToString()
        {
            return $"{_nroOrden} {_comercio.ToString()} está adherido a PagoMercado desde {_fechaHoraAdhesion.ToString("yyyy-MM-dd")}"; 
        }
    }
}
