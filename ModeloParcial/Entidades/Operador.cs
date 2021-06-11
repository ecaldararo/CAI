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

        public Operador()
        {
            _prestamos = new List<Prestamo>();
        }

        public double Comision { get => _comision; set => _comision = value; }
        public double ProcentajeComision { get => _procentajeComision;  }
        public List<Prestamo> Prestamos { get => _prestamos; set => _prestamos = value; }

        public double SetearComision()
        {
            this.Comision = this.ProcentajeComision / 100 * this.Prestamos.Sum(x => x.Monto);

            return this.Comision;
        }
    }
}
