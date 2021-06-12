using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoPlazoFijo
    {
        int _id;
        double _tasa;
        string _descripcion;

        public TipoPlazoFijo(int id, string descripcion, double tasa)
        {
            _id = id;
            _descripcion = descripcion;
            _tasa = tasa;
        }

        public int Id { get => _id;  }
        public double Tasa { get => _tasa;  }
        public string Descripcion { get => _descripcion;  }

        public override string ToString()
        {
            return $"ID:{Id}){Descripcion}";
        }
    }
}
