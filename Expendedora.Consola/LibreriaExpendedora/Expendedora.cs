using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaExpendedora
{
    public class Expendedora
    {
        public List<Lata> _latas;
        private string _proveedor;
        private int _capacidad = 100;
        private double _dinero;
        private bool _encendida;

        public int Capacidad { get => _capacidad; set => _capacidad = value; }

        public Expendedora()
        {
            _latas = new List<Lata>();
            _encendida = false;
        }

        public void AgregarLata(Lata lata)
        {
            
            if (_encendida == true)
                if (_latas.Count() >= Capacidad)
                {
                    throw new CapacidadInsuficienteException();
                }
                else
                {
                    _latas.Add(lata);
                }

        }

        public Lata ExtraerLata(string codigo, double dinero)
        {
            Lata lata;

            if (_latas.Exists(x => x.Codigo == codigo))
            {
                lata = _latas.First(x => x.Codigo == codigo);

                if (_latas.First(x => x.Codigo == codigo).Precio == dinero)
                {
                    _dinero += dinero;
                    //_latas.RemoveAll(x => x.Codigo == codigo);
                }
                else
                {
                    throw new DineroInsuficienteException();
                }
            } else
            {
                throw new CodigoInvalidoException();
            }

            return lata;
                
            
        }

        public string GetBalance()
        {
            int cant = 0;
            foreach (Lata i in _latas)
            {
                cant += i.Cantidad;
            }
            if (_encendida == true)
                return "Dinero: " + _dinero.ToString() + "\tCantidad: " + cant.ToString();
            else
                return "";
        }

        public int GetCapacidadRestante()
        {
            return Capacidad - _latas.Count();
        }

        public void EncenderMaquina()
        {
            _encendida = true;
        }

        public bool EstaVacia()
        {
            if (_latas.Count() == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

    }
}
