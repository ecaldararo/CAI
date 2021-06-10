using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [DataContract]
    public class Cliente
    {
        private int dni;
        private string nombre;
        private string apellido;
        private string direccion;
        private string email;
        private string telefono;
        private DateTime fechaNacimiento;
        private DateTime fechaAlta;
        private bool activo;
        private int id;

        private Cuenta _cuenta;

        public Cliente()
        {
            _cuenta = new Cuenta();
        }

        public Cliente(int Dni, string nom, string ape)
        {
            dni = Dni;
            nombre = nom;
            apellido = ape;

        }
        [DataMember(Name = "DNI")]
        public int Dni { get => dni; set => dni = value; }

        [DataMember(Name = "nombre")]
        public string Nombre { get => nombre; set => nombre = value; }

        [DataMember(Name = "apellido")]
        public string Apellido { get => apellido; set => apellido = value; }

        [DataMember(Name = "direccion")]
        public string Direccion { get => direccion; set => direccion = value; }
        
        [DataMember(Name = "id")]
        public int Id { get => id; set => id = value; }
        
        [DataMember(Name = "fechaNacimiento")]
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public Cuenta Cuenta { get => _cuenta; set => _cuenta = value; }

        public override string ToString()
        {
            if(Cuenta == null)
                return $"ID:{Id}\tDNI:{Dni}-{Apellido},{Nombre} || Cuenta:Sin Cuenta"; 
            else
                return $"ID:{Id}\tDNI:{Dni}-{Apellido},{Nombre} || Cuenta:{Cuenta.Descripcion}";
        }
    }
}
