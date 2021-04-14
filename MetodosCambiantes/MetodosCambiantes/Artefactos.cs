using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosCambiantes
{
    class Artefactos
    {
        int id = 0;
        bool estado;

        public Artefactos()
        {
            id = id++;
            estado = false;
        }
        public void AccionarLlave()
        {
            if (estado == false)
            {
                estado = true;
                Console.WriteLine("Luz encendida");
            }
            else
            {
                estado = false;
                Console.WriteLine("Luz apagada");
            }
        }
    }
}
