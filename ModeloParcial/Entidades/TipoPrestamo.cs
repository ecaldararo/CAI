using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoPrestamo
    {
        private string _linea;
        private double _TNA;
        private int _id;

        public string Linea { get => _linea; set => _linea = value; }
        public double TNA { get => _TNA; set => _TNA = value; }
        public int Id { get => _id; set => _id = value; }

        public override string ToString()
        {
            return $"Linea: {Linea} (TNA:{TNA})";
        }
    }
}
