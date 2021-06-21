using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validaciones;

namespace Entidades.Entidades
{
    public class ComercioOnline : Comercio
    {
        public ComercioOnline(int nroHab, string cuit, string razSoc)
        {
            NroHabilitacion = nroHab;
            _cuit = cuit;
            _razonSocial = razSoc;
        }
    }
}
