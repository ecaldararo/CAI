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
    public class PrestamoMapper
    {

        public List<Prestamo> TraerLista()
        {
            string json = WebHelper.Get("/prestamo/825551");

            List<Prestamo> rta = JsonConvert.DeserializeObject<List<Prestamo>>(json);

            return rta;
        }
        public string Alta(Prestamo prestamoAIngresar)
        {
            NameValueCollection nv = ReverseMap(prestamoAIngresar);

            string json = WebHelper.Post("/prestamo", nv);

            TransactionResult rta = JsonConvert.DeserializeObject<TransactionResult>(json);

            if (rta.IsOk == true)
                return "Alta exitosa";
            else
                return "Error en el alta, intente nuevamente";

        }

        private NameValueCollection ReverseMap(Prestamo prestamoAIngresar)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("", "");
            return n;
        }
    }
}
