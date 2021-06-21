using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librerias
{
    public class Asistencia
    {
        private string _fechaAsistencia;
        private DateTime _fechaHoraReal;
        private Preceptor _preceptor;
        private Alumno _alumno;
        private bool _estaPresente;

        public Asistencia(Preceptor preceptor, string fechaAsistencia, Alumno alumno, bool estaPresente )
        {
            _preceptor = preceptor;
            _fechaAsistencia = fechaAsistencia;
            _alumno = alumno;
            _estaPresente = estaPresente;
            _fechaHoraReal = DateTime.Now;

        }

        public string FechaAsistencia { get => _fechaAsistencia; set => _fechaAsistencia = value; }
        public Alumno Alumno { get => _alumno; set => _alumno = value; }

        public override string ToString()
        {
            if (this._estaPresente == true)
            {
                return $"{_fechaAsistencia.ToString()} {_alumno.ToString()} está presente SI por {_preceptor.ToString()} registrado el {_fechaHoraReal.ToString()}";
            }
            else
            {
                return $"{_fechaAsistencia.ToString()} {_alumno.ToString()} está presente NO por {_preceptor.ToString()} registrado el {_fechaHoraReal.ToString()}";
            }
            

        }
    }
}
