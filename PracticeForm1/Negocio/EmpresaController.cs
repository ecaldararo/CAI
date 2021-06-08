using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public class EmpresaController
    {
        public void AgregarEmpresa()
        {
            //
        }

        public List<Cliente> GetLista(Empresa e)
        {
            List<Cliente> lista = e.GetLista(e);
            return lista;
        }
    }
}
