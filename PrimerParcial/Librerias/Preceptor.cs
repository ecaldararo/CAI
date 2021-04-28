using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias
{
    public class Preceptor : Persona
    {
        private int _legajo;
        private bool _activo;

        public Preceptor(int legajo, string nombre, string apellido, bool activo)
        {
            _legajo = legajo;
            _nombre = nombre;
            _apellido = apellido;
            _activo = activo;
        }

        public bool Activo { get => _activo;  }

        public override string ToString()
        {
            return $"{this._apellido} - {this._legajo}";
        }
        internal override string Display()
        {
            return "";
        }
    }
}
