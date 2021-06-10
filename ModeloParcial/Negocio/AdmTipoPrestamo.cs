using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class AdmTipoPrestamo
    {
        LineaMapper _lineaMapper;
        public AdmTipoPrestamo()
        {
            _lineaMapper = new LineaMapper();
        }

        public List<TipoPrestamo> TraerTodos()
        {
            // puedo filtrar por usuario, o activo
            return _lineaMapper.TraerTodos();
        }
    }
}
