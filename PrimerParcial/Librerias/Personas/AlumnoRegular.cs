using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias
{
    public class AlumnoRegular : Alumno
    {
        private string _email;
        public AlumnoRegular(int registro, string nombre, string apellido, string email)
        {
            _registro = registro;
            _nombre = nombre;
            _apellido = apellido;
            _email = email;
        }
        
    }
}
