using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class AdmPrestamo
    {
        private PrestamoMapper _prestamoMapper;
        public AdmPrestamo()
        {
            _prestamoMapper = new PrestamoMapper();
        }

        public List<Prestamo> TraerTodos()
        {
            return _prestamoMapper.TraerPorRegistro();
        }

        public string Alta(Prestamo prestamoAlta)
        {
            TransactionResult resultado = _prestamoMapper.Insertar(prestamoAlta);

            if (resultado.isok == true)
                return "Alta exitosa";
            else
                return "Error al dar de alta";
        }
    }
}
