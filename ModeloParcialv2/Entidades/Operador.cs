using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
    public class Operador
    {
        List<Prestamo> _prestamos;
        private static double _porcentajeComision = 15;

        public Operador()
        {
            _prestamos = new List<Prestamo>();
        }
    }
}
