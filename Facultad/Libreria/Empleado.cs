using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validaciones;


namespace Libreria
{
    public enum TipoEmpleado { Bedel = 1, Docente = 2, Directivo = 3 }
    public abstract class Empleado : Persona
    {
        protected DateTime _fechaIngreso;
        protected int _legajo;
        protected List<Salario> _salarios;

        public int Antiguedad { get => Validaciones.Validaciones.GetAge(_fechaIngreso); }
        public DateTime FechaIngreso { get => _fechaIngreso; set => _fechaIngreso = value; }
        public int Legajo { get => _legajo; set => _legajo = value; }
        internal List<Salario> Salarios { get => _salarios; set => _salarios = value; }
        public DateTime FechaNacimiento { get => _fechaNac; set => _fechaNac = value; }
        public Salario UltimoSalario { get => Salarios.LastOrDefault(); } // No entiendo cual sería el default, o qué haría si no encuentra ningún valor, tira error?

        public List<string> ListaSalarios(Empleado emp)
        {
            List<string> lista = new List<string>();

            foreach(Salario s in emp.Salarios)
            {
                lista.Add(s.Bruto.ToString() + "---" + s.Fecha.ToString());
            }
            return lista;
        }

        public void AgregarSalario(Salario sal)
        {
            _salarios.Add(sal);
        }
        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;
            if (!(obj is Empleado))
                return false;
            
            return this.Legajo == ((Empleado)obj).Legajo;
            
        }
        public override string GetCredencial()
        {
            if(Salarios.Count==0)
                return $"{this.Legajo} - {this.GetNombreCompleto()}, salario NA";
            else
                return $"{this.Legajo} - {this.GetNombreCompleto()}, salario {this.UltimoSalario.Bruto}";
        }
        public override string GetNombreCompleto()
        {
            return this.Apellido + " " + this.Nombre;
        }
        public override string ToString()
        {
            return GetCredencial();
        }

        
    }
}
