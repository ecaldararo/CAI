using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class AdmCliente
    {
        private ClienteMapper _clienteMapper;
        private CuentaMapper _cuentaMapper;
        private List<Cliente> _listaClientes;
        private List<Cuenta> _listaCuentas;

        public AdmCliente()
        {
            _clienteMapper = new ClienteMapper();
            _cuentaMapper = new CuentaMapper();
            _listaClientes = new List<Cliente>();
            _listaCuentas = new List<Cuenta>();
        }

        public List<Cliente> TraerTodos()
        {
            _listaClientes = _clienteMapper.TraerTodos();
            _listaCuentas = _cuentaMapper.TraerTodos();

            foreach(Cliente cli in _listaClientes)
            {
                cli.Cuenta = _listaCuentas.SingleOrDefault(x => x.IdCliente == cli.Id);
            }

            return _listaClientes;
        }

        public List<Cliente> TraerTodosOrdenada()
        {
            _listaClientes = _clienteMapper.TraerTodos();

            List<Cliente> listaOrdenada = new List<Cliente>();
            listaOrdenada.AddRange(_listaClientes.OrderByDescending(x => x.Id));

            return listaOrdenada;
        }

        public string Agregar(Cliente clienteNuevo)
        {
            TransactionResult resultado = _clienteMapper.Insertar(clienteNuevo);

            if (resultado == null)
            {
                return "Error";
            }
            else
            {
                return "OK";
            }

        }

        public string Actualizar(Cliente cliente)
        {
            TransactionResult resultado = _clienteMapper.Actualizar(cliente);

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
