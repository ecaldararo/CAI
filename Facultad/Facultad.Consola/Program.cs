using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultad.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //. Solucion en 2 capas(proyecto consola y proyecto libreria de clases)
            //
            //.ABM y listado de[Alumno] y[Empleado - abstracta -].Ambas entidades tiene una generalización[Persona]. 
            //  . [Empleado -abstracta -] tiene subtipos especializados(Docente, Bedel o Directivo).
            //
            //
            // .Generar al menos 4 exceptions custom(ej.AlumnoExistenteException)
            //
            //. Cuando se lista persona o empleado se debe utilizar el metodo.ToString().
            //  .En caso de alumno, el metodo ToString invoca el metodo GetCredencial que devuelve un string con este template "Código {codigo}) {apellido}, {nombre}"
            // .Empleado a su vez implementa GetCredencial devolviendo el string con el siguiente template: "{legajo} - {nombreCompleto} salario $ {ultimoSalarioNeto}"
            //.Los subtipos de empleado REDEFINEN el comportamiento de GetNombreCompleto
            //    . Bedel => "Bedel {apodo}"
            //    .Docente   => "Docente {nombre}"
            //   .Directivo => "Sr. Director {apellido}"
            //
            //.Sobrecarga de metodos para AgregarAlumno o AgregarEmpleado(por ejemplo, en lugar de pasar un Objeto, pasar los input y que el obj se instancie dentro del metodo Agregar)
            //
            //. Validar existencia de Alumno o empleado utilizando el metodo Equals(hacer override en empleado donde en caso de que el legajo sea igual retorne true).
            //
            //. Algunos constructores sobrecargados
            //
            //.Al menos una clase sellada y una clase estatica(que no sea program)
            //
            //. Utilizar todas las visibilidades(private, protected, protected internal, internal, public)
            //
            //. Validar todos los inputs de usuario
            //
            //.Controlar exceptions
            //
            //.Modulariazar
            //
            //.NO puede haber console.write o console.read en ninguna clase del paquete de libreria de clases.
        }
    }
}
