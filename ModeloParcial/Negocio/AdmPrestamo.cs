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
        private Operador _operador;
        public AdmPrestamo()
        {
            _prestamoMapper = new PrestamoMapper();
            _operador = new Operador();
        }

        public List<Prestamo> TraerTodos()
        {
            _operador.Prestamos = _prestamoMapper.TraerPorRegistro();

            return _operador.Prestamos;
        }

        public string Alta(Prestamo prestamoAlta)
        {
            TransactionResult resultado = _prestamoMapper.Insertar(prestamoAlta);

            if (resultado.isok == true)
                return "Alta exitosa";
            else
                return "Error al dar de alta";
        }

        public double TraerComisiones()
        {
            _operador.Prestamos = _prestamoMapper.TraerPorRegistro();
            //_operador.Comision;

            return _operador.Comision;
        }
    }
}
