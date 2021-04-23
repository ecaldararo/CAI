using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosCambiantes
{
    class Artefactos
    {
        int _id;
        private int _idartefacto;
        bool estado;
        private string nombre;

        //public int IdArtefacto { get => this.idArtefacto; set => this.idArtefacto = value; }

        public int IdArtefacto { get; set; }
        public Artefactos(int id)
        {
            _id = id;
            _idartefacto ++;
            estado = 
                ;
        }

        public void AccionarLlave()
        {
            if (estado == false)
            {
                estado = true;
                Console.WriteLine("Luz encendida de artefacto " + _id);
            }
            else
            {
                estado = false;
                Console.WriteLine("Luz apagada de artefacto " + _id);
            }
        }
        
        
    }
}
