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
    public class PrestamoMapper
    {
        private List<Prestamo> _prestamos;
        public PrestamoMapper()
        {
            _prestamos = new List<Prestamo>();
        }

        public List<Prestamo> TraerPorRegistro()
        {
            int registro = Convert.ToInt32(ConfigurationManager.AppSettings["NRO_REGISTRO"]);

            string json2 = WebHelper.Get("/prestamo/"+registro);

            List<Prestamo> prestamos = MappearLista(json2);

            return prestamos;
        }

        private List<Prestamo> MappearLista(string json)
        {
            List<Prestamo> resultado = JsonConvert.DeserializeObject<List<Prestamo>>(json);
            return resultado;
        }

        public TransactionResult Insertar(Prestamo nuevoPrestamo)
        {
            NameValueCollection obj = ReverseMap(nuevoPrestamo);

            string json = WebHelper.Post("/prestamo", obj);

            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }

        private NameValueCollection ReverseMap(Prestamo prestamo)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("TNA", prestamo._tipoPrestamo.TNA.ToString().Replace(",", "."));
            n.Add("Linea", prestamo._tipoPrestamo.Linea);
            n.Add("Plazo", prestamo.Plazo.ToString());
            n.Add("idCliente", "1");
            n.Add("idTipo", prestamo._tipoPrestamo.Id.ToString());
            n.Add("Monto", prestamo.Monto.ToString("0.00").Replace(",","."));
            n.Add("Cuota", prestamo.CuotaTotal.ToString("0.00").Replace(",", "."));
            n.Add("Usuario", "825551");
            n.Add("id", "0");

            //n.Add("TipoPrest.TNA", "0");
            //n.Add("TipoPrest.Linea", "0");
            //n.Add("TipoPrest.id", "0");

            //n.Add("TNA", "2");
            //n.Add("Linea", "2");
            //n.Add("Plazo", "2");
            //n.Add("idCliente", "1");
            //n.Add("idTipo", "2");
            //n.Add("Monto", "2");
            //n.Add("Cuota", "0.00");
            //n.Add("Usuario", "825551");
            return n;
        }
    }
}
