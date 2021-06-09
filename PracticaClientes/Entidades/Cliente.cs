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

        public Cliente()
        {
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
        public int Id { get => id; set => id = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }

        public override string ToString()
        {
            return $"DNI:{Dni}-{Apellido},{Nombre},Dirección:{Direccion}"; 
        }
    }
}
