using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [DataContract]
    public class Cuenta
    {
        private int nroCuenta;
        private string descripcion;
        private double saldo;
        private DateTime fechaApertura;
        private DateTime fechaModificacion;
        private bool activo;
        private int idCliente;
        private int id;

        public Cuenta()
        {

        }

        [DataMember(Name = "nroCuenta")]
        public int NroCuenta { get => nroCuenta; set => nroCuenta = value; }

        [DataMember(Name = "descripcion")]
        public string Descripcion { get => descripcion; set => descripcion = value; }

        [DataMember(Name = "saldo")]
        public double Saldo { get => saldo; set => saldo = value; }

        [DataMember(Name = "id")]
        public int Id { get => id; set => id = value; }

        [DataMember(Name = "idCliente")]
        public int IdCliente { get => idCliente; set => idCliente = value; }

        [DataMember(Name = "fechaApertura")]
        public DateTime FechaApertura { get => fechaApertura; set => fechaApertura = value; }

        [DataMember(Name = "fechaModificacion")]
        public DateTime FechaModificacion { get => fechaModificacion; set => fechaModificacion = value; }

        public override string ToString()
        {
            return $"Nro.Cuenta:{nroCuenta}, Descripción {descripcion}, Saldo: {saldo}";
        }

    }
}
