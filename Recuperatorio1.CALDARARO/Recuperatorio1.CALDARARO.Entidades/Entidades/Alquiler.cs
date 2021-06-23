using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorio1.CALDARARO.Entidades.Entidades
{
    public class Alquiler
    {
        private int _nroAlquiler;
        private int _dni;
        private PuntoAlquiler _puntoAlquiler;
        private EquipoMovil _equipoMovil;
        private bool _devuelto;
        private double _montoTotal;
        private int _horas;

        public Alquiler(int dni, PuntoAlquiler punto, EquipoMovil equipo, int horas)
        {
            _dni = dni;
            _puntoAlquiler = punto;
            _equipoMovil = equipo;
            _devuelto = false;
            _horas = horas;

        }

        public int Horas { get => _horas; }
        internal EquipoMovil EquipoMovil { get => _equipoMovil;  }
        internal bool Devuelto { get => _devuelto; set => _devuelto = value; }
        internal int Dni { get => _dni;  }
        internal int NroAlquiler { get => _nroAlquiler; set => _nroAlquiler = value; }

        public override string ToString()
        {
            string dev = "NO está";
            if (_devuelto == true)
                dev = "está";

            return $"{ NroAlquiler} { EquipoMovil.ToString() } lo alquió { _dni} y {dev} devuelto - Importe “{ _montoTotal.ToString("0.00")}";
            
        }
    }
}
