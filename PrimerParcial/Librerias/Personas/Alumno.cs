using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias
{
    public abstract class Alumno : Persona
    {
        protected int _registro;

        public int Registro { get => _registro; }

        internal override string Display()
        {
            return $"{this._nombre} ({this._registro})";
        }
    }
}
