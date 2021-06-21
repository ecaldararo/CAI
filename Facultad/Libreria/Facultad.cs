using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Facultad
    {
        internal List<Alumno> _alumnos;
        private int _cantSedes;
        private List<Empleado> _empleados;
        private string _nombre;

        public Facultad(int cantSedes, string nombre)
        {
            _alumnos = new List<Alumno>();
            _cantSedes = cantSedes;
            _empleados = new List<Empleado>();
            _nombre = nombre;
        }

        public int CantSedes { get => _cantSedes; }
        public string Nombre { get => _nombre;  }

        public void AgregarAlumno(Alumno alu)
        {
            if (_alumnos.Contains(alu))
                throw new AlumnoExistenteException();
            else
                _alumnos.Add(alu);
        }
        public void AgregarEmpleado(Empleado emp)
        {
            
            /*if (_empleados.Contains(emp))
                throw new EmpleadoExistenteException();
            else
                _empleados.Add(emp);*/

            foreach(Empleado e in _empleados)
            {
                if (e.Equals(emp))
                {
                    throw new EmpleadoExistenteException();
                }
            }
            _empleados.Add(emp);
        }
        public void AgregarAlumno(int codigo, string nombre, string apellido, DateTime fechaNac)
        {
            if (_alumnos.Exists(x => x.Codigo == codigo))
                throw new AlumnoExistenteException();
            else
                _alumnos.Add(new Alumno(codigo, nombre,apellido, fechaNac));
        }
        public void AgregarEmpleado(string apodo, int legajo, string nombre, string apellido, DateTime fechaNac, DateTime fechaIng, int tipoEmpleado)
        {
            if (tipoEmpleado == (int)TipoEmpleado.Bedel)
            {
                Bedel bed = new Bedel(apodo, legajo, nombre, apellido, fechaNac, fechaIng);
                //Empleado emp = _empleados.FirstOrDefault(x => x.Legajo == legajo);
                foreach(Empleado e in _empleados)
                {
                    if (bed.Equals(e)) // Equals ?? Duplico el mismo chequeo.
                        throw new EmpleadoExistenteException();
                }

                _empleados.Add(bed);

            } 
            else if (tipoEmpleado == (int)TipoEmpleado.Docente)
            {
                Docente emp = new Docente(legajo, nombre, apellido, fechaNac, fechaIng);
                _empleados.Add(emp);
            }
            else if (tipoEmpleado == (int)TipoEmpleado.Directivo)
            {
                Directivo emp = new Directivo(legajo, nombre, apellido, fechaNac, fechaIng);
                _empleados.Add(emp);
            }
            else
            {
                throw new TipoEmpleadoIncorrectoException();
            }
            
        }
        public void AgregarSalario(int legajo, Salario sal)
        {
            if (_empleados.Exists(x => x.Legajo == legajo))
                _empleados.SingleOrDefault(x => x.Legajo == legajo).AgregarSalario(sal);
            else
                throw new EmpleadoInexistenteException();
        }
        public void EliminarAlumno(int codigo)
        {
            _alumnos.RemoveAll(x => x.Codigo == codigo);
        }
        public void EliminarEmpleado(int codigo)
        {
            _empleados.RemoveAll(x => x.Legajo == codigo);
        }
        public void ModificarEmpleado(Empleado emp)
        {
            _empleados.RemoveAll(x => x.Legajo == emp.Legajo);
            _empleados.Add(emp);
        }
        public List<Alumno> TraerAlumnos()
        {
            return _alumnos;
        }
        public Empleado TraerEmpleadoPorLegajo(int legajo)
        {
            return _empleados.FirstOrDefault(x => x.Legajo == legajo);
        }
        public List<Empleado> TraerEmpleados()
        {
            return _empleados;
        }
        public Empleado TraerEmpleadoPorNombre(string nom)
        {
            return _empleados.FirstOrDefault(x => x.Nombre == nom);
        }
    }
}
