using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Entidades;

namespace Negocio
{
    public class AdmPrestamo
    {
        PrestamoMapper _prestamoMapper;

        public AdmPrestamo()
        {
            _prestamoMapper = new PrestamoMapper();
        }

        public string IngresarPrestamo(Prestamo pre)
        {
            return _prestamoMapper.Alta(pre);
        }

        public List<Prestamo> GetPrestamos()
        {
            return _prestamoMapper.TraerLista();
        }
    }
}
