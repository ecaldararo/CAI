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

        }

        public string FechaAsistencia { get => _fechaAsistencia; set => _fechaAsistencia = value; }

        public override string ToString()
        {
            return $"FECHAREFERENCIA  está presente  por registrado el ";
            //return $"FECHAREFERENCIA {_alumno.ToString()} está presente {_alumno.} por {PRECEPTOR FORMATEADO} registrado el {FECHAHORAREAL}";

        }
    }
}
