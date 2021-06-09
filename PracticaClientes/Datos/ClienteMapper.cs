using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Newtonsoft.Json;

namespace Datos
{
    public class ClienteMapper
    {
        private List<Cliente> _clientes;
        public ClienteMapper()
        {
            _clientes = new List<Cliente>();
        }

        public List<Cliente> TraerTodos()
        {
            // IR A EL REPOSITORIO DE DATOS (bd, file, webservice)

            string json2 = WebHelper.Get("/cliente");

            List<Cliente> clientes = MappearLista(json2);

            return clientes;
        }

        private List<Cliente> MappearLista(string json)
        {
            List<Cliente> resultado = JsonConvert.DeserializeObject<List<Cliente>>(json);
            return resultado;
        }

        public TransactionResult Insertar(Cliente nuevoCliente)
        {
            NameValueCollection obj = ReverseMap(nuevoCliente);

            string json = WebHelper.Post("/cliente", obj);
                
            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);

            return resultado;
        }

        private NameValueCollection ReverseMap(Cliente cliente)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", cliente.Id.ToString());
            n.Add("nombre", cliente.Nombre);
            n.Add("apellido", cliente.Apellido);
            n.Add("direccion", cliente.Direccion);
            n.Add("DNI", cliente.Dni.ToString());//cliente.Dni.ToString()
            n.Add("fechaNacimiento", cliente.FechaNacimiento.ToString("yyyy-MM-dd"));//cliente.FechaNacimiento.ToString("yyyy-MM-dd")
            n.Add("usuario", "825551");
            return n;
        }
    }
}
