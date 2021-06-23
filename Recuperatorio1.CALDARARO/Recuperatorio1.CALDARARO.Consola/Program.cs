using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Recuperatorio1.CALDARARO.Entidades;
using Recuperatorio1.CALDARARO.Entidades.Entidades;
using Recuperatorio1.CALDARARO.Entidades.Exceptions;
using Recuperatorio1.CALDARARO.Validaciones;

namespace Recuperatorio1.CALDARARO.Consola
{
    public class Program
    {
        private static MicroMovilidad _empresa;
        //private static PuntoAlquiler punto;

        static Program()
        {
            _empresa = new MicroMovilidad("E - Mobility");
        }
        static void Main(string[] args)
        {

            PuntoAlquiler punto = _empresa.GetPuntoAlquiler("Belgrano");

            // sacar por pantalla >> Bienvenido [nombreEmpresa]
            Console.WriteLine("Bienvenido " + _empresa.NombreEmpresa);
            // sacar por pantalla >>  Punto de venta del barrio [barrio]
            Console.WriteLine("Punto de venta del barrio " + punto.Barrio);
            
            
            
            bool salir = false;
            while (salir == false)
            {
                DesplegarOpcionesMenu();
                string opcionMenu = ValidacionesConsola.PedirOpcion("1", "2", "3", "X"); // pedir el valor
                switch (opcionMenu)
                {
                    case "1":
                        ListarAlquileres();
                        break;
                    case "2":
                        AlquilarEquipo(punto);
                        break;
                    case "3":
                        DevolverEquipo();
                        break;

                    case "X":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Ingrese una opción del menú");
                        break;
                }
            }
            
        }
        static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("1) Listar Alquileres");
            Console.WriteLine("2) Alquilar Equipo");
            Console.WriteLine("3) Devolver Equipo");
            Console.WriteLine("X: Terminar");
        }


        static void ListarAlquileres()
        {
            // mostrar alquileres
            if (_empresa.Alquileres.Count == 0)
                Console.WriteLine("No hay alquileres");
            else
                foreach (Alquiler a in _empresa.Alquileres)
                {
                    Console.WriteLine(a.ToString());
                }
        }

        static void AlquilarEquipo(PuntoAlquiler punto)
        {
            // Pedir DNI cliente
            int DNI = ValidacionesConsola.PedirIntDesde(" DNI",0);
            // Listar equipos
            foreach (EquipoMovil a in _empresa.Equipos)
            {
                Console.WriteLine(a.ToString());
            }
            // Pedir NroSerie equipo
            bool ns = false;
            int nroSerie = 0;
            while (ns == false)
            {
                nroSerie = ValidacionesConsola.PedirIntDesde(" Nro. de Serie", 0);
                if (_empresa.Equipos.Exists(x => x.NroSerie == nroSerie))
                    ns = true;
                else
                    Console.WriteLine("Equipo No existente");
            }

            // Pedir Horas
            int horas = ValidacionesConsola.PedirIntDesde(" Horas", 0);
            
            // Con el Nro de serie traer el equipo de la lista
            EquipoMovil equipo = _empresa.Equipos.FirstOrDefault(x => x.NroSerie == nroSerie);

            try
            {
                PuntoAlquiler puntoAlq = _empresa.GetPuntoAlquiler(punto.Barrio);
            }
            catch (PuntoAlquilerNoExistenteException paneex)
            {
                Console.WriteLine(paneex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            // Generar Alquier con dni, punto, equipo, horas
            Alquiler alta = new Alquiler(DNI, punto, equipo, horas);
            
            // Alta Alquiler 

            try
            {
                _empresa.AltaAlquiler(alta);
                Console.WriteLine("Alta exitosa");
            }
            catch (EquipoAlquiladoException eaex)
            {
                Console.WriteLine(eaex.Message);
            }
            catch (AlquilerEnCursoException aecex)
            {
                Console.WriteLine(aecex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void DevolverEquipo()
        {
            // Ingreso DNI cliente
            int DNI = ValidacionesConsola.PedirIntDesde(" DNI", 0);
            // Ingreso batería
            int bateria = ValidacionesConsola.PedirIntDesde(" batería", 0);
            double monto;
            // BajaAlquier
            try
            {
                monto = _empresa.BajaAlquiler(DNI,bateria);
                Console.WriteLine("Baja exitosa");
                Console.WriteLine("Monto total a debitar: " + monto.ToString("0.00"));
            }
            catch (AlquilerNoExistenteException aneex)
            {
                Console.WriteLine(aneex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // Se le muestra el monto total a debitar en formato .ToString(“0.00”)
            


        }


    }
}
