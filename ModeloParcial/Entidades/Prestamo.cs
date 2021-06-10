using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Prestamo
    {
        private string _linea;
        private double _TNA;
        private int _plazo;
        private double _monto;
        private string _usuario;
        private int _id;
        private double _cuotaTotal;

        public string Linea { get => _linea; set => _linea = value; }
        public double TNA { get => _TNA; set => _TNA = value; }
        public int Plazo { get => _plazo; set => _plazo = value; }
        public double Monto { get => _monto; set => _monto = value; }
        public string Usuario { get => _usuario; set => _usuario = value; }
        public int Id { get => _id; set => _id = value; }
        public double CuotaTotal { get => _cuotaTotal; set => _cuotaTotal = value; }

        public override string ToString()
        {
            return $"Días {Plazo} - ARS CapitalInicial(interés Interés) – tipo o(desc del tipo plazo fijo) - )";
        }
    }
}
