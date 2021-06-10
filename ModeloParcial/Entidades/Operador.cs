using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operador
    {
        private List<Prestamo> _prestamos;
        private double _comision;
        private static double _procentajeComision = 15;

        public double Comision { get => _comision; }
        public double ProcentajeComision { get => _procentajeComision;  }
        public List<Prestamo> Prestamos { get => _prestamos;  }
    }
}
