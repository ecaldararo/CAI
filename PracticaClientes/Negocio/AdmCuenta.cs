using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class AdmCuenta
    {
        CuentaMapper _cuentaMapper;

        public AdmCuenta()
        {
            _cuentaMapper = new CuentaMapper();
        }

        public Cuenta Traer(int id)
        {
            return _cuentaMapper.TraerPorId(id);
        }


    }
}
