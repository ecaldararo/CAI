using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias
{
    public class AlumnoOyente : Alumno
    {
        public AlumnoOyente(int registro, string nombre, string apellido)
        {
            Registro = registro;
            _nombre = nombre;
            _apellido = apellido;
        }
        

    }
}
