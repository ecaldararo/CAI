using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public abstract class Persona
    {
        protected internal string _apellido;
        protected internal DateTime _fechaNac;
        protected internal string _nombre;

        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Edad { get => Validaciones.Validaciones.GetAge(this._fechaNac); }

        public abstract string GetCredencial();
        public virtual string GetNombreCompleto()
        {
            return $"{Apellido}, {Nombre}";
            
        }
    }
}
