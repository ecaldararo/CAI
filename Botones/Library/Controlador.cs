using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaBotones
{
    public class Controlador
    {
        public static bool Agregar(List<Boton> lista, string descripcion)
        {
            /*if (!lista.Exists(item => item.IdBoton == codigo) )
            {
                lista.Add(new Boton(descripcion));
                return true;
            }
            else
            {
                return false;
            }*/

            lista.Add(new Boton(descripcion));
            return true;
        }

    }
    
}
