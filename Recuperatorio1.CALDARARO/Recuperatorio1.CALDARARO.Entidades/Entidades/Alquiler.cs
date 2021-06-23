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

        public Alquiler(int dni, PuntoAlquiler punto, EquipoMovil equipo, int horas)
        {
            _dni = dni;
            _puntoAlquiler = punto;
            _equipoMovil = equipo;
            _devuelto = false;

        }

        internal EquipoMovil EquipoMovil { get => _equipoMovil;  }
        internal bool Devuelto { get => _devuelto;  }
        internal int Dni { get => _dni;  }
        internal int NroAlquiler { get => _nroAlquiler;  }

        public override string ToString()
        {
            string dev = "NO está";
            _devuelto = false;
            if (_devuelto == true)
                dev = "está";

            return $"{ NroAlquiler} { EquipoMovil.ToString() } lo alquió { _dni} y {dev} devuelto - Importe “{ _montoTotal.ToString("0.00")}";
            
        }
    }
}
