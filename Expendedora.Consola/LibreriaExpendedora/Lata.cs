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
        public string Nombre { get => _nombre; set => _nombre = value; }
        public double Precio { get { return _precio; } set { _precio = value; } }
        public int Cantidad { get { return _cantidad; } set { _cantidad = value; } }
        public string Sabor { get => _sabor; set => _sabor = value; }
        public double Volumen { get => _volumen; set => _volumen = value; }

        public Lata(string codigo, string nombre, int cantidad)
        {
            Codigo = codigo;
            Nombre = nombre;
            Cantidad = cantidad;
            Precio = 50;
        }

        private double GetPrecioPorLitro()
        {
            return _precio / _volumen ;
        }

        public override string ToString()
        {
            return $"{Codigo}).{Nombre}, {Precio}";
        }

    }
}
