using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validaciones;
using Entidades;
using Entidades.Entidades;
using Entidades.Exceptions;

namespace ModeloPrimerParcialPagoMercado.Consola
{
    public class Program
    {
        private static PlataformaPago _plataforma;

        static Program()
        {
            _plataforma = new PlataformaPago("PagoMercado");
        }
        static void Main(string[] args)
        {
            Reclutadora reclutadoraActiva = _plataforma.GetReclutadoraLogueada();

            
            bool exit = false;
            while (exit == false)
            {
                DesplegarOpcionesMenu();
                Console.WriteLine("Elija una opción del menú.");
                string opcionMenu = ValConsola.PedirStringNoVac(); // pedir el valor
                switch (opcionMenu)
                {
                    case "1":
                        ListarAdhesiones();
                        break;
                    case "2":
                        ConsultarAdhesion();
                        break;
                    case "3":
                        AltaAdhesion(reclutadoraActiva);
                        break;
                    case "4":
                        EliminarAdhesion();
                        break;

                    case "X":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Ingrese una opción válida del menú");
                        break;
                }
            }
        }
        static void DesplegarOpcionesMenu()
        {
            Console.WriteLine("1) Listar Adhesiones");
            Console.WriteLine("2) Consultar Adhesion");
            Console.WriteLine("3) Alta Adhesion");
            Console.WriteLine("4) Eliminar Adhesion");
            Console.WriteLine("X: Terminar");
        }

        static void ListarAdhesiones()
        {
            try
            {
                foreach (Adhesion i in _plataforma.GetListaAdhesiones())
                {
                    Console.WriteLine(i.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

        static void ConsultarAdhesion()
        {
            string cuit = ValConsola.PedirStringNoVac();
            // ingreso cuit
            try
            {
                if (_plataforma.ConsultarAdhesion(cuit))
                    Console.WriteLine("Adhesión existente!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            // consultar adhesion
        }

        static void AltaAdhesion(Reclutadora p)
        {
            // Listar comercios
            ListarComercios();

            // usuario selecciona el cuit que desea agregar
            string cuit = ValConsola.PedirCUIT();

            // Agregar adhesión
            if (_plataforma.Comercios.Exists(x => x.Cuit == cuit))
            {
                try
                {
                    Comercio com = _plataforma.Comercios.FirstOrDefault(x => x.Cuit == cuit);
                    _plataforma.AgregarAdhesion(new Adhesion(com, p));
                    Console.WriteLine("---ALTA EXITOSA---");
                }
                catch (AdhesionNoPermitidaException anpex)
                {
                    Console.WriteLine(anpex.Message);
                }
                catch (AdhesionExistenteException aeex)
                {
                    Console.WriteLine(aeex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
                Console.WriteLine("Comercio inexistente");
            
            
        }

        static void EliminarAdhesion()
        {
            // Listar comercios
            ListarComercios();

            // usuario selecciona el cuit que desea eliminar
            string cuit = ValConsola.PedirStringNoVac();
            if (!_plataforma.Comercios.Exists(x => x.Cuit == cuit))
                Console.WriteLine("Comercio inexistente");
            else
            {
                try
                {
                    _plataforma.EliminarAdhesion(cuit);
                    Console.WriteLine("---ELIMINACIÓN EXITOSA---");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            // Eliminar adhesión
        }

        static void ListarComercios()
        {
            List<Comercio> listaComercios = _plataforma.Comercios;
            foreach (Comercio c in listaComercios)
            {
                Console.WriteLine(c.ToString());
            }
        }


    }

}
