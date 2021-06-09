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
        private List<Cliente> _listaClientes;

        public AdmCliente()
        {
            _clienteMapper = new ClienteMapper();
            _listaClientes = new List<Cliente>();
        }

        public List<Cliente> TraerTodos()
        {
            _listaClientes = _clienteMapper.TraerTodos();

            return _listaClientes;
        }
    }
}
