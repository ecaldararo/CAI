using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validaciones;
using Entidades.Entidades;
using Entidades;
using Entidades.Exceptions;

namespace Entidades
{
    public class PlataformaPago
    {
        private List<Reclutadora> _reclutadoras;
        private List<Comercio> _comercios;
        private List<Adhesion> _adhesiones;
        private string _nombrePlataforma;
        public List<Comercio> Comercios { get => _comercios;  }
        public PlataformaPago(string nombrePlat)
        {
            _nombrePlataforma = nombrePlat;

            _comercios = new List<Comercio>();
            _reclutadoras = new List<Reclutadora>();
            _adhesiones = new List<Adhesion>();

            _comercios.Add(new ComercioPresencial(5001, "30-40123456-8", "Juarez SRL", "Moldes 123"));
            _comercios.Add(new ComercioPresencial(5002, "30-40854451-1", "Moda SA", "Vidal 456"));
            _comercios.Add(new ComercioPresencial(5003, "30-40853352-9", "Ronda SA", "Vidt 887"));
            _comercios.Add(new ComercioPresencial(5004, "30-20663323-7", "Andina Inc.", "Ugarte 2020"));
            _comercios.Add(new ComercioOnline(4040, "30-18512524-3", "TodoVenta.com"));
            _comercios.Add(new ComercioOnline(4041, "30-35112685-4", "AlqInmuebles.com.ar"));
            _comercios.Add(new ComercioOnline(4042, "30-28512571-2", "DeCarpinteros.com"));
            _reclutadoras.Add(new Reclutadora(101, "Agencia Ramos SRL", "30-55123456-1"));
        }

        private bool ExisteEmpresa(string cuit)
        {
            //if (_comercios.Exists(x => x.Cuit == cuit) || _reclutadoras.Exists(x => x.Cuit == cuit))
            if (_comercios.Exists(x => x.Cuit == cuit))
                return true;
            else
                return false;
        }

        private int GetUltimoNroOrden()
        {
            if (_adhesiones.Count > 0)
                return _adhesiones.LastOrDefault().NroOrden;
            else
                return 0;
        }

        public Reclutadora GetReclutadoraLogueada()
        {
            return _reclutadoras.SingleOrDefault(); // en este caso va a funcionar
        }

        public bool ConsultarAdhesion(string cuit)
        {
            if (_adhesiones.Exists(x => x.Comercio.Cuit == cuit))
                return true;
            else
                throw new Exception("No existe el comercio");
        }

        public List<Adhesion> GetListaAdhesiones()
        {
            if (_adhesiones.Count == 0)
                throw new Exception("No hay comercios adheridos");
            else
                return _adhesiones;
        }
        public void AgregarAdhesion(Adhesion ad)
        {
            if (ad.Comercio.GetType() == typeof(ComercioOnline))
                throw new AdhesionNoPermitidaException();
            if (_adhesiones.Exists(x => x.Comercio == ad.Comercio))
                throw new AdhesionExistenteException();
            else
            {
                int nro = GetUltimoNroOrden();
                ad.NroOrden = nro+1;
                _adhesiones.Add(ad);
            }
        }

        public void EliminarAdhesion(string cuit)
        {
            if (ExisteEmpresa(cuit))
            {
                Comercio com = _comercios.Find(x => x.Cuit == cuit);
                _adhesiones.RemoveAll(x => x.Comercio == com);
            }
                
            else
                throw new EmpresaNoExistenteException();
        }
        
    }
}
