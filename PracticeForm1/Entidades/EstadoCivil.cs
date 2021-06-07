using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EstadoCivil
    {
        private int _codigo;
        private string _descripcion;

        public EstadoCivil(int cod, string desc)
        {
            _codigo = cod;
            Descripcion = desc;
        }

        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int Codigo { get => _codigo; set => _codigo = value; }

        public override string ToString()
        {
            return this.Descripcion;
        }
    }
}
