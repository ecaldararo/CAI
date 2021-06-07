using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public static class EmpresaController
    {
        public static void AgregarEmpresa()
        {
            //
        }

        public static List<Cliente> GetLista(Empresa e)
        {
            List<Cliente> lista = Empresa.GetLista(e);
            return lista;
        }
    }
}
