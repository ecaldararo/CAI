using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validaciones;

namespace Entidades.Entidades
{
    public class Reclutadora : Empresa
    {
        private int _registro;

        public string Cuit { get => _cuit; }

        public Reclutadora()
        {

        }

        public Reclutadora(int reg, string razSoc, string cuit)
        {
            _registro = reg;
            _razonSocial = razSoc;
            _cuit = cuit;
        }

        internal override string Display()
        {
            return $"{_registro} - {_razonSocial}";
        }
    }
}
