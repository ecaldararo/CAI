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

            // IR A EL REPOSITORIO DE DATOS (bd, file, webservice)

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
            n.Add("Linea", prestamo.Linea);
            n.Add("Plazo", prestamo.Plazo.ToString());
            n.Add("Monto", prestamo.Monto.ToString());
            //n.Add("CuotaTotal", prestamo.CuotaTotal.ToString());
            //n.Add("usuario", "825551");
            return n;
        }
    }
}
