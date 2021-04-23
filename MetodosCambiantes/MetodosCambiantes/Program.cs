using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosCambiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            //-Realizar un método que afecte o cambien un estado(atributos).
            //-Realizar un método que se comporte de forma distinta dependiendo del estado(el valor de algún atributo).

            Artefactos primera = new Artefactos(1);
            Artefactos segunda = new Artefactos(2);
            Artefactos tercera = new Artefactos(3);


            Console.WriteLine("Tablero de control de Luz/n 1.Encender/Apagar /n 2.Salir");

            int entrada = 1;

            while (entrada == 1)
            {
                entrada = 0;
                entrada = Int32.Parse(Console.ReadLine());
                if (entrada == 1)
                {
                    primera.AccionarLlave();
                    segunda.AccionarLlave();
                    tercera.AccionarLlave();
                }
            }

            Console.ReadKey();


        }
    }
}
