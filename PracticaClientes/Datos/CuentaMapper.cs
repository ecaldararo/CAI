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
    public class CuentaMapper
    {
        private Cuenta _cuenta;
        public CuentaMapper()
        {
            _cuenta = new Cuenta();
        }

        public List<Cuenta> TraerTodos()
        {
            // IR A EL REPOSITORIO DE DATOS (bd, file, webservice)

            string json2 = WebHelper.Get("/cuenta");

            List<Cuenta> cuentas = MappearLista(json2);

            return cuentas;
        }

        private List<Cuenta> MappearLista(string json)
        {
            List<Cuenta> resultado = JsonConvert.DeserializeObject<List<Cuenta>>(json);
            return resultado;
        }

        public Cuenta TraerPorId(int id)
        {
            // IR A EL REPOSITORIO DE DATOS (bd, file, webservice)

            string json2 = WebHelper.Get("/cuenta/"+id);

            Cuenta cuenta = MappearCuenta(json2);

            return cuenta;
        }

        private Cuenta MappearCuenta(string json)
        {
            Cuenta resultado = JsonConvert.DeserializeObject<Cuenta>(json);
            return resultado;
        }

        public TransactionResult Insertar(Cuenta nuevaCuenta)
        {
            NameValueCollection obj = ReverseMap(nuevaCuenta);

            string json = WebHelper.Post("/cuenta", obj);

            TransactionResult resultado = JsonConvert.DeserializeObject<TransactionResult>(json);

            return resultado;
        }

        private NameValueCollection ReverseMap(Cuenta cuenta)
        {
            NameValueCollection n = new NameValueCollection();
            n.Add("id", cuenta.Id.ToString());
            n.Add("descripcion", cuenta.Descripcion);
            n.Add("nroCuenta", cuenta.NroCuenta.ToString());
            n.Add("fechaApertura", cuenta.FechaApertura.ToString("yyyy-MM-dd"));//cuenta.FechaNacimiento.ToString("yyyy-MM-dd")
            n.Add("fechaModificacion", cuenta.FechaModificacion.ToString("yyyy-MM-dd"));//cuenta.FechaNacimiento.ToString("yyyy-MM-dd")
            n.Add("usuario", "825551");
            return n;
        }
    }
}
