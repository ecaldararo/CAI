using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Newtonsoft.Json;

namespace Datos
{
    public class PlazoFijoMapper
    {
        public List<PlazoFijo> TraerTodos()
        {
            string json = WebHelper.Get("/PlazoFijo/" + ConfigurationManager.AppSettings["NRO_REGISTRO"]);

            List<PlazoFijo> lista = JsonConvert.DeserializeObject<List<PlazoFijo>>(json);

            return lista;
        }

        public TransactionResult Alta(PlazoFijo plazoFijo)
        {
            NameValueCollection obj = ReverseMap(plazoFijo);

            string json = WebHelper.Post("/PlazoFijo", obj);

            TransactionResult rdo = JsonConvert.DeserializeObject<TransactionResult>(json);

            return rdo;
        }

        private NameValueCollection ReverseMap(PlazoFijo pf)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("idCliente", "1");
            n.Add("id", "1");
            n.Add("Tipo", pf.TipoPlazoFijo.Id.ToString()); //
            n.Add("CapitalInicial", pf.CapitalInicial.ToString("0.00"));
            n.Add("Dias", pf.Dias.ToString());
            n.Add("Tasa", pf.Tasa.ToString("0.00"));
            n.Add("Interes", pf.Interes.ToString("0.00"));
            n.Add("Usuario", ConfigurationManager.AppSettings["NRO_REGISTRO"]);
            return n;


        }


    }
}
