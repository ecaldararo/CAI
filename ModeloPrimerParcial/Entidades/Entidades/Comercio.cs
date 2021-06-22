using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validaciones;

namespace Entidades.Entidades
{
    public class Comercio : Empresa
    {
        private int _nroHabilitacion;

        protected int NroHabilitacion { set => _nroHabilitacion = value; }

        public string Cuit { get => _cuit; }

        internal override string Display()
        {
            return $"{_razonSocial}({_cuit}) - {_nroHabilitacion}";
        }

        // hereda el to string, innecesario
        public override string ToString()
        {
            return Display();
        }
    }
}
