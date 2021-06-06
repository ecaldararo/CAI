using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class Salario
    {
        private double _bruto;
        private string _codigoTransferencia;
        private double _descuentos;
        private DateTime _fecha;

        public Salario(double salarioBruto, string CodTransf, DateTime fecha)
        {
            Bruto = salarioBruto;
            Descuentos = 0.17;
            CodigoTransferencia = CodTransf;
            Fecha = fecha;
        }

        public double Bruto { get => _bruto; set => _bruto = value; }
        public string CodigoTransferencia { get => _codigoTransferencia; set => _codigoTransferencia = value; }
        public double Descuentos { get => _descuentos; set => _descuentos = value; }
        public DateTime Fecha { get => _fecha; set => _fecha = value; }

        public double GetSalarioNeto()
        {
            return this.Bruto * (1 - this.Descuentos);
        }

    }
}
