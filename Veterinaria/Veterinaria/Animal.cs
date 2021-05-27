using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria
{
    class Animal
    {
        private string _nombre;
        private int _peso;
        private int _cantvacunas;
        private int _codigodueño;

        public Animal(string nombre, int codigodueño)
        {
            _nombre = nombre;
            _codigodueño = codigodueño;
        }

        public int AsignarPeso { set { _peso = value; } get { return _peso; } }
        public int Vacunas { set { _cantvacunas = value; } get { return _cantvacunas; } }

        public string DarVacuna()
        {
            try
            {
                this.Vacunas++;
                return "Se le dio una vacuna adicional a " + this._nombre;
            }
            catch (Exception)
            {
                return "Falló la asignación de vacunas a " + this;
            }
        }



    }
}