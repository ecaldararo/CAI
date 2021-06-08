using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class ClienteMapper
    {
        string json = "JSON";

        public Cliente TraerCliente(string json)
        {
            Cliente cli = JsonConvert.DeserializeObject<Cliente>(json);
            
            return cli;
        }
    }
    
}
