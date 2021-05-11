using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias
{
    public abstract class Alumno : Persona
    {
        private int _registro;

        public int Registro { get => _registro; set => _registro = value; }

        internal override string Display()
        {
            return $"{this._nombre} ({this.Registro})";
        }
    }
}
