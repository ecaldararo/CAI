using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public static class EstadoCivilController
    {
        public static List<EstadoCivil> GetLista()
        {
            List<EstadoCivil> ec = new List<EstadoCivil>();

            EstadoCivil sel = new EstadoCivil(0, "Seleccione");
            EstadoCivil sol = new EstadoCivil(1, "Soltero");
            EstadoCivil cas = new EstadoCivil(2, "Casado");

            ec.Add(sel);
            ec.Add(sol);
            ec.Add(cas);

            return ec;
        }
    }
}
