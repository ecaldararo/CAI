using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaExpendedora
{
    public class Lata
    {
        private string _codigo;
        private string _nombre;
        private string _sabor;
        private double _precio;
        private double _volumen;
        private int _cantidad;

        public string Codigo { get { return _codigo; } set { _codigo = value; } }
        public double Precio { get { return _precio; } set { _precio = value; } }

        public Lata()
        {

        }

        private double GetPrecioPorLitro()
        {
            return _precio / _volumen ;
        }

        /*public override string ToString()
        {
            return value.ToString();
        }*/

    }
}
