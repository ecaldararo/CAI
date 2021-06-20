using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    [DataContract]
    public class PlazoFijo
    {

        int id;
        int idCliente;
        [DataMember(Name = "Tipo")]
        int tipo;
        double tasa;
        int dias;
        double capitalInicial;
        [DataMember(Name ="Interes")]
        double interes;
        double montoFinal;
        string usuario;

        TipoPlazoFijo tipoPlazoFijo;

        public PlazoFijo()
        {
            tipoPlazoFijo = new TipoPlazoFijo();
        }

        [DataMember(Name = "id")]
        public int Id { get => id; set => id = value; }
        [DataMember(Name = "idCliente")]
        public int IdCliente { get => idCliente; set => idCliente = value; }

        
        public TipoPlazoFijo TipoPlazoFijo { get => tipoPlazoFijo; set => tipoPlazoFijo = value; }
        public int Tipo { get => tipo; set => tipo = value; }

        [DataMember(Name = "Tasa")]
        public double Tasa { get => tasa; set => tasa = value; }

        [DataMember(Name = "Dias")]
        public int Dias { get => dias; set => dias = value; }
        
        [DataMember(Name = "CapitalInicial")]
        public double CapitalInicial { get => capitalInicial; set => capitalInicial = value; }
        public double Interes { get => (CapitalInicial * Tasa * Dias / 365); }

        public double MontoFinal { get => CapitalInicial + Interes;  }

        [DataMember(Name = "Usuario")]
        public string Usuario { get => usuario; set => usuario = value; }
        

        public override string ToString()
        {
            return $"{Id} \t{Dias} días - \tARS {CapitalInicial.ToString("#,##0.00")} \t(Interés {interes.ToString("#,##0.00")} - Tasa:{TipoPlazoFijo.Tasa*100}% - tipo o ({TipoPlazoFijo.Descripcion})";
        }
    }
}
