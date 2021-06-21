using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;


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

            Libreria.Facultad UBA = new Libreria.Facultad(15, "Universidad de Buenos Aires");

            UBA.AgregarAlumno(1, "Rosa", "Perez", new DateTime(2000, 5, 1, 8, 30, 52));
            UBA.AgregarAlumno(2, "Pepe", "Gonzalez", new DateTime(2001, 5, 1, 8, 30, 52));
            UBA.AgregarAlumno(3, "Franco", "Garibaldi", new DateTime(2002, 5, 1, 8, 30, 52));
            UBA.AgregarAlumno(4, "Lorenzo", "Lamas", new DateTime(2003, 5, 1, 8, 30, 52));

            UBA.AgregarEmpleado("Pepe",1,"José","Deluca", new DateTime(1960, 5, 1, 8, 30, 52), new DateTime(2003, 5, 1, 8, 30, 52),1);
            UBA.AgregarEmpleado("", 2, "Juan", "García", new DateTime(1961, 5, 1, 8, 30, 52), new DateTime(2003, 5, 1, 8, 30, 52), 2);
            UBA.AgregarEmpleado("", 3, "Juan José", "Garzón", new DateTime(1962, 5, 1, 8, 30, 52), new DateTime(2003, 5, 1, 8, 30, 52), 2);
            UBA.AgregarEmpleado("", 4, "John", "Abdala", new DateTime(1955, 5, 1, 8, 30, 52), new DateTime(2003, 5, 1, 8, 30, 52), 3);

            Menu(UBA);
            Console.ReadKey();

        }

        static void Menu(Libreria.Facultad fac)
        {
            int opcion;
            do
            {
                Console.WriteLine(fac.Nombre + "\n-----------MENU-----------" +
                "\n 1-Listar Alumnos" +
                "\n 2-Listar Empleados" +
                "\n 3-Agregar Alumno" +
                "\n 4-Agregar Bedel" +
                "\n 5-Agregar Docente" +
                "\n 6-Agregar Directivo" +
                "\n 7-Agregar Salario" +
                "\n 8-Salir" +
                "\n ------------------------");
                opcion = Perkins.PedirOpcion(1, 8);
                switch(opcion)
                {
                    case 1:
                        Console.WriteLine("Listado de Alumnos:");
                        List<Alumno> listaA = fac.TraerAlumnos();
                        foreach (Alumno i in listaA)
                        {
                            Console.WriteLine(i.ToString());
                        }
                        break;
                    case 2:
                        Console.WriteLine("Listado de Empleados:");
                        List<Empleado> listaE = fac.TraerEmpleados();
                        foreach (Empleado i in listaE)
                        {
                            Console.WriteLine(i.ToString());
                        }
                        break;
                    case 3:
                        Console.WriteLine("Agregar Alumno");
                        try
                        {
                            fac.AgregarAlumno(Perkins.PedirIntDesde(0), Perkins.PedirStringNoVac("un nombre"), Perkins.PedirStringNoVac("un apellido"), new DateTime(2000, 5, 1, 8, 30, 52));
                        }
                        catch (AlumnoExistenteException aex)
                        {
                            Console.WriteLine(aex.Message);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Agregar Bedel");
                        try
                        {
                            List<Empleado> listaEmp = fac.TraerEmpleados();
                            fac.AgregarEmpleado(Perkins.PedirStringNoVac(" un apodo"),Perkins.PedirIntDesde(listaEmp.Last().Legajo+1),Perkins.PedirStringNoVac("un nombre"), Perkins.PedirStringNoVac("un apellido"), new DateTime(1950, 5, 1, 8, 30, 52), new DateTime(2000, 5, 1, 8, 30, 52),(int)TipoEmpleado.Bedel);
                        }
                        catch (EmpleadoExistenteException eex)
                        {
                            Console.WriteLine(eex.Message);
                        }
                        break;
                    case 5:
                        Console.WriteLine("Agregar Docente");
                        try
                        {
                            List<Empleado> listaEmp = fac.TraerEmpleados();
                            fac.AgregarEmpleado("", Perkins.PedirIntDesde(listaEmp.Last().Legajo + 1), Perkins.PedirStringNoVac("un nombre"), Perkins.PedirStringNoVac("un apellido"), new DateTime(1950, 5, 1, 8, 30, 52), new DateTime(2000, 5, 1, 8, 30, 52), (int)TipoEmpleado.Docente);
                        }
                        catch (EmpleadoExistenteException eex)
                        {
                            Console.WriteLine(eex.Message);
                        }
                        break;
                    case 6:
                        Console.WriteLine("Agregar Directivo");
                        try
                        {
                            List<Empleado> listaEmp = fac.TraerEmpleados();
                            fac.AgregarEmpleado("", Perkins.PedirIntDesde(listaEmp.Last().Legajo), Perkins.PedirStringNoVac("un nombre"), Perkins.PedirStringNoVac("un apellido"), new DateTime(1950, 5, 1, 8, 30, 52), new DateTime(2000, 5, 1, 8, 30, 52), (int)TipoEmpleado.Directivo);
                        }
                        catch (EmpleadoExistenteException eex)
                        {
                            Console.WriteLine(eex.Message);
                        }
                        break;
                    case 7:
                        Console.WriteLine("Agregar Salario");
                        try
                        {
                            // pedir legajo
                            List<Empleado> listaEmp = fac.TraerEmpleados();
                            int legajo = 0;
                            bool flag = false;
                            while(flag == false)
                            {
                                legajo = Perkins.PedirIntDesde(0);
                                if (listaEmp.Exists(x => x.Legajo == legajo))
                                    flag = true;
                            }
                            // pedir datos salario (salario bruto, codigo transferencia)
                            double salario = Perkins.PedirSalario();
                            
                            fac.AgregarSalario(legajo,new Salario(salario,"2222",DateTime.Now));

                            
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                }
            } while (opcion != 8);
            
        }
    }
}
