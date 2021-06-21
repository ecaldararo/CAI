using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    public abstract class Empresa
    {
        protected string _razonSocial;
        protected string _cuit;

        public override string ToString()
        {
            return base.ToString();
        }

        internal abstract string Display();
    }
}
