using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    class Program
    {
        static void Main(string[] args)
        {
            // En soluciones distintas, modelar un problema / negocio general(clase, propiedades, encapsulamiento, abstracción, que se pueda instanciar,
            // program con set y get) con los siguientes puntos(de ser posible, hacer las cinco soluciones).
            //- Veterinaria
            //- Restaurant
            //- Carta
            //- Deportista
            //- Almacén(tratar de no usar producto, que es el ejemplo visto en clase)

            Animal Rosa = new Animal("Rosa", 1);
            Rosa.AsignarPeso = 16;
            Rosa.Vacunas = 0;
            Console.WriteLine(Rosa.DarVacuna());
            Console.ReadKey();



        }
    }
}