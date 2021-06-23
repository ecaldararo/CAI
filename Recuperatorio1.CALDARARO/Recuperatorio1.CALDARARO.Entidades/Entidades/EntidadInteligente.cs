using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recuperatorio1.CALDARARO.Entidades.Exceptions;

namespace Recuperatorio1.CALDARARO.Entidades.Entidades
{
    public abstract class EntidadInteligente
    {
        protected int _nroSerie;

        public int NroSerie { get => _nroSerie; }

        public EntidadInteligente(int nroSerie)
        {
            _nroSerie = nroSerie;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override string ToString()
        {
            return Display();
        }

        protected abstract string Display();




    }
}
