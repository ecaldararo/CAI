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
        private int _capacidad; // funciona si no es static?
        private double _dinero; // funciona si no es static?
        private bool _encendida;

        public int Capacidad { get => _capacidad;  }
        public bool Encendida { get => _encendida;  }

        public Expendedora()
        {
            _proveedor = "Nombre Proveedor";
            _capacidad = 1000;
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

        public DevolucionMaquina ExtraerLata(string codigo, double dinero)
        {
            Lata lata;
            DevolucionMaquina devolucionMaquina;

            if (_latas.Exists(x => x.Codigo == codigo))
            {
                lata = _latas.First(x => x.Codigo == codigo);

                devolucionMaquina = new DevolucionMaquina(lata);

                if (lata.Precio <= dinero)
                {
                    if (lata.Cantidad > 0)
                    {
                        _dinero += lata.Precio;
                        lata.Cantidad += -1;
                        devolucionMaquina.Vuelto = dinero - lata.Precio;

                    }
                    else
                    {
                        throw new SinStockException();
                    }
                }
                else
                {
                    throw new DineroInsuficienteException();
                }
            } else
            {
                throw new CodigoInvalidoException();
            }

            return devolucionMaquina;
                
            
        }

        public string GetBalance()
        {
            int cant = 0;
            foreach (Lata i in _latas)
            {
                cant += i.Cantidad;
            }
            if (_encendida == true)
                return $"Dinero: {_dinero.ToString()} \tCantidad: {cant.ToString()}";
            else
                return "";
        }

        public int GetCapacidadRestante()
        {
            return Capacidad - _latas.Count();
        }

        public void EncenderMaquina()
        {
            this._encendida = true;
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
