using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validaciones;

namespace Entidades.Entidades
{
    public class ComercioPresencial : Comercio
    {
        private string _direccion;

        public ComercioPresencial(int nroHab, string cuit, string razSoc,  string dire)
        {
            NroHabilitacion = nroHab;
            _cuit = cuit;
            _razonSocial = razSoc;
            _direccion = dire;
        }
    }
}
