using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaExpendedora
{
    public class DevolucionMaquina
    {
        double _vuelto;
        internal Lata _lata;

        public DevolucionMaquina(Lata lata)
        {
            _lata = lata;
        }

        public double Vuelto { get => _vuelto; set => _vuelto = value; }

        public override string ToString()
        {
            return $"Lata:{_lata.Nombre}-Vuelto: ${Vuelto}";
        }
    }
}
