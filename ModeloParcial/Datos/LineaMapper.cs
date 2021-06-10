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
    public class LineaMapper
    {
        private List<TipoPrestamo> _tipoPrestamos;
        public LineaMapper()
        {
            _tipoPrestamos = new List<TipoPrestamo>();
        }

        public List<TipoPrestamo> TraerTodos()
        {
            // IR A EL REPOSITORIO DE DATOS (bd, file, webservice)

            string json2 = WebHelper.Get("/prestamotipo");

            List<TipoPrestamo> prestamos = MappearLista(json2);

            return prestamos;
        }

        private List<TipoPrestamo> MappearLista(string json)
        {
            List<TipoPrestamo> resultado = JsonConvert.DeserializeObject<List<TipoPrestamo>>(json);
            return resultado;
        }

        public TransactionResult Insertar(TipoPrestamo nuevoTipoPrestamo)
        {
            NameValueCollection obj = ReverseMap(nuevoTipoPrestamo);

            string json = WebHelper.Post("/prestamotipo", obj);

            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);
            return resultado;
        }

        private NameValueCollection ReverseMap(TipoPrestamo prestamo)
        {
            NameValueCollection n = new NameValueCollection();
            //n.Add("id", prestamo.id.ToString());
            //n.Add("fechaNacimiento", prestamo.FechaNacimiento.ToString("yyyy-MM-dd"));//prestamo.FechaNacimiento.ToString("yyyy-MM-dd")
            //n.Add("usuario", "825551");
            return n;
        }
    }
}
