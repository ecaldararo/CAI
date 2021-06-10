using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [DataContract]
    public class Prestamo
    {
        private string _linea;
        private double _TNA;
        private int _idTipo;
        private int _plazo;
        private double _monto;
        private string _usuario;
        private int _id;
        private double _cuotaTotal;
        public TipoPrestamo _tipoPrestamo;

        public Prestamo()
        {
            _tipoPrestamo = new TipoPrestamo();
        }

        [DataMember(Name = "Linea")]
        public string Linea { get => _linea; set => _linea = value; }

        [DataMember(Name = "TNA")]
        public double TNA { get => _TNA; set => _TNA = value; }

        [DataMember(Name = "Plazo")]
        public int Plazo { get => _plazo; set => _plazo = value; }

        [DataMember(Name = "Monto")]
        public double Monto { get => _monto; set => _monto = value; }

        [DataMember(Name = "Usuario")]
        public string Usuario { get => _usuario; set => _usuario = value; }

        [DataMember(Name ="id")]
        public int Id { get => _id; set => _id = value; }


        public double CuotaCapital { get => Monto/Plazo;}
        public double CuotaInteres { get => CuotaCapital * TNA/12/100 ; }

        [DataMember(Name = "Cuota")]
        public double CuotaTotal { get => _cuotaTotal; set => _cuotaTotal = CuotaCapital + CuotaInteres; }

        [DataMember(Name = "idTipo")]
        public int IdTipo { get => _idTipo; set => _idTipo = value; }

        public override string ToString()
        {
            return $"Días {Plazo} - ARS Capital Inicial(interés Interés) – tipo o(desc del tipo plazo fijo) - )";
        }
    }
}
