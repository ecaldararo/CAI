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
            _codigo = codigo;
            _nombre = nombre;
            _cantidad = cantidad;
            _volumen = 200;
            _precio = 50;
        }

        private double GetPrecioPorLitro()
        {
            if (_volumen != 0)
                return _precio / _volumen;
            else
                return 0;
        }

        public override string ToString()
        {
            return $"CO{Codigo}) {Nombre} | Cantidad: {Cantidad} | Precio: {Precio}";
        }

    }
}
