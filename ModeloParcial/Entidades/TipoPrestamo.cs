using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [DataContract]
    public class TipoPrestamo
    {
        private string _linea;
        private double _TNA;
        private int _id;

        public TipoPrestamo()
        {
        }

        [DataMember(Name = "Linea")]
        public string Linea { get => _linea; set => _linea = value; }

        [DataMember(Name = "TNA")]
        public double TNA { get => _TNA; set => _TNA = value; }

        [DataMember(Name = "id")]
        public int Id { get => _id; set => _id = value; }

        public override string ToString()
        {
            return $"Linea: {Linea} (TNA:{TNA})";
        }
    }
}
