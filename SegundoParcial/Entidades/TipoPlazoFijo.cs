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

        public TipoPlazoFijo()
        {

        }

        public int Id { get => _id; set => _id = value; }
        public double Tasa { get => _tasa; set => _tasa = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }

        public override string ToString()
        {
            return $"ID:{Id}){Descripcion}";
        }
    }
}
