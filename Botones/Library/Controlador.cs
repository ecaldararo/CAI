using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBotones
{
    public class Controlador
    {
        public static bool Agregar(List<Boton> lista, int codigo, string descripcion)
        {
            if (!lista.Exists(item => item.Id == codigo) )
            {
                lista.Add(new Boton(codigo, descripcion));
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    
}
