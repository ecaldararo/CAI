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
        List<Cuenta> _cuentas;

        public AdmCuenta()
        {
            _cuentaMapper = new CuentaMapper();
            _cuentas = new List<Cuenta>();
        }

        public Cuenta Traer(int idCliente)
        {
            return _cuentaMapper.TraerPorId(idCliente);
        }

        public List<Cuenta> TraerTodos()
        {
            _cuentas = _cuentaMapper.TraerTodos();

            //List<Cliente> listaOrdenada = new List<Cliente>();
            //listaOrdenada.AddRange(_listaClientes.OrderByDescending(x => x.Id));

            return _cuentas;
        }

        public string Agregar(Cuenta cuenta)
        {
            TransactionResult resultado = _cuentaMapper.Insertar(cuenta);

            if (resultado == null)
            {
                return "Error";
            }
            else
            {
                return "OK";
            }

        }

        public string Modificar(Cuenta cuenta)
        {
            TransactionResult resultado = _cuentaMapper.Actualizar(cuenta);

            if (resultado == null)
            {
                return "Error";
            }
            else
            {
                return "OK";
            }

        }
    }
}
