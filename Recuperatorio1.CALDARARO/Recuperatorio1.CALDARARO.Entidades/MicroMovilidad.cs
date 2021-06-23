using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recuperatorio1.CALDARARO.Entidades.Entidades;
using Recuperatorio1.CALDARARO.Entidades.Exceptions;

namespace Recuperatorio1.CALDARARO.Entidades
{
    public class MicroMovilidad
    {
        private List<EquipoMovil> _equipos;
        private List<PuntoAlquiler> _puntosAlquiler;
        private List<Alquiler> _alquileres;
        private string _nombreEmpresa;

        public MicroMovilidad(string nombre)
        {
            _nombreEmpresa = nombre;

            _equipos = new List<EquipoMovil>();
            _puntosAlquiler = new List<PuntoAlquiler>();
            _alquileres = new List<Alquiler>();

            _equipos.Add(new Bicicleta(5001, 90, 15, "Rodado 26"));
            _equipos.Add(new Bicicleta(5002, 25, 15, "Rodado 24"));
            _equipos.Add(new Monopatin(4003, 75, 18, "Mod. 2020"));
            _equipos.Add(new Monopatin(4004, 49, 12, "Batería dura poco"));
            _equipos.Add(new Monopatin(4040, 63, 15, "Sin guardabarro trasero"));
            _equipos.Add(new Tabla(3041, 79, 12, "Con luces"));
            _equipos.Add(new Tabla(3042, 65, 11, "Sin luces"));
            
            _puntosAlquiler.Add(new PuntoAlquiler(100013, "Roosevelt 1852", "Belgrano"));
            _puntosAlquiler.Add(new PuntoAlquiler(100014, "Soler 3055", "Palermo"));

        }

        public MicroMovilidad()
        {
            _equipos.Add(new Bicicleta(5001, 90, 15, "Rodado 26"));
            _equipos.Add(new Bicicleta(5002, 25, 15, "Rodado 24"));
            _equipos.Add(new Monopatin(4003, 75, 18, "Mod. 2020"));
            _equipos.Add(new Monopatin(4004, 49, 12, "Batería dura poco"));
            _equipos.Add(new Monopatin(4040, 63, 15, "Sin guardabarro trasero"));
            _equipos.Add(new Tabla(3041, 79, 12, "Con luces"));
            _equipos.Add(new Tabla(3042, 65, 11, "Sin luces"));

            _puntosAlquiler.Add(new PuntoAlquiler(100013, "Roosevelt 1852", "Belgrano"));
            _puntosAlquiler.Add(new PuntoAlquiler(100014, "Soler 3055", "Palermo"));

        }




        public List<Alquiler> Alquileres { get => _alquileres;  }
        public List<EquipoMovil> Equipos { get => _equipos;  }
        public string NombreEmpresa { get => _nombreEmpresa;  }

        private int GetUltimoNroAlquiler()
        {
            // si no hay alquileres, al primer alquiler se le asigna 1
            if (_alquileres.Count == 0)
                return 0;
            else
                return _alquileres.LastOrDefault().NroAlquiler;
        }

        private bool AlquilerEnCursoDNI(int dni)
        {
            if (_alquileres.Count == 0)
                throw new Exception("No hay alquileres para ese DNI");
            if (!_alquileres.Exists(x => x.Dni == dni))
                throw new AlquilerNoExistenteException();

            List<Alquiler> _alqDNI = _alquileres.Where(x => x.Dni == dni).ToList();
            if (_alqDNI.SingleOrDefault(x => x.Devuelto == false) == null)
                throw new AlquilerEnCursoException();
            else
                return false;

        }

        private bool AlquilerEnCursoEquipo(int nroSerie)
        {
            //if (_alquileres.Count == 0)
            //    throw new Exception("No hay alquileres de ese equipo");

            //if (_alquileres.Exists(x => x.EquipoMovil.NroSerie == nroSerie))

            List<Alquiler> _alqEquipos = _alquileres.Where(x => x.EquipoMovil.NroSerie == nroSerie).ToList();

            // si existe al menos un alquiler de este equipo que no esté devuelto, tira excepción;
            if (_alqEquipos.Exists(x => x.Devuelto == false))
                throw new EquipoAlquiladoException();
            else
                return false;
        }

        public PuntoAlquiler GetPuntoAlquiler(string barrio)
        {
            //if (_puntosAlquiler.Count == 0)
            //    throw new Exception("No hay puntos de alquiler cargados");
            if (!_puntosAlquiler.Exists(x => x.Barrio == barrio))
                throw new PuntoAlquilerNoExistenteException();
            else
                return _puntosAlquiler.FirstOrDefault(x => x.Barrio == barrio);
        }

        public void AltaAlquiler(Alquiler alquiler)
        {
            if (AlquilerEnCursoEquipo(alquiler.EquipoMovil.NroSerie) == false && AlquilerEnCursoDNI(alquiler.Dni) == false) 
                _alquileres.Add(alquiler);
            
        }

        public double BajaAlquiler(int dni, int bateria)
        {
            throw new NotImplementedException();
        }


    }
}
