using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Prestamo
    {
        private string _linea;
        double _monto;

        public string Linea { get => _linea; set => _linea = value; }
        public double Monto { get => _monto; set => _monto = value; }

        public override string ToString()
        {
            return $"Linea {Linea} - Monto {Monto}";
        }
    }
}
