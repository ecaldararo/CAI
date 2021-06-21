using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public sealed class Alumno : Persona
    {
        private int _codigo;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public DateTime FechaNacimiento { get => _fechaNac; set => _fechaNac = value; }
        //public int Credencial { get => _codigo; set => _codigo = value; }
        public Alumno(int codigo, string nombre, string apellido, DateTime fechaNac)
        {
            Codigo = codigo;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNac;
        }

        public override string GetCredencial()
        {
            return $"Código {Codigo}) {Apellido}, {Nombre}";
        }
        public override string ToString()
        {
            return GetCredencial();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Alumno))
            {
                if(this.Codigo == ((Alumno)obj).Codigo)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
