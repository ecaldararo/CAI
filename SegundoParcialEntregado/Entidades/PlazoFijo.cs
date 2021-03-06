using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class PlazoFijo
    {
        //[DataContract]
        int id;
        int idCliente;
        //int tipo;
        double tasa;
        int dias;
        double capitalInicial;
        double interes;
        double montoFinal;
        string usuario;

        TipoPlazoFijo tipo;

        public PlazoFijo()
        {
        }

        public int Id { get => id; set => id = value; }
        public int IdCliente { get => idCliente; set => idCliente = value; }
        public TipoPlazoFijo Tipo { get => tipo;  }
        public double Tasa { get => tasa; set => tasa = value; }
        public int Dias { get => dias; set => dias = value; }
        public double CapitalInicial { get => capitalInicial; set => capitalInicial = value; }
        public double Interes { get => (CapitalInicial * Tasa / 365);  }
        public double MontoFinal { get => CapitalInicial + Interes;  }
        public string Usuario { get => usuario; set => usuario = value; }

        public override string ToString()
        {
            return $"{Id} {Dias} días - ARS {CapitalInicial.ToString("0.00")} (Interés {Interes.ToString("0.00")} - tipo o ()";
        }
    }
}
