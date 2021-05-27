using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exceptions;

namespace Librerias
{
    public class Presentismo
    {

        private List<Preceptor> _preceptores;
        private static List<Alumno> _alumnos;
        private List<Asistencia> _asistencias;


        // iniciar Presentismo con los siguientes datos
        public Presentismo()
        {
            _alumnos = new List<Alumno>();
            _asistencias = new List<Asistencia>();
            _preceptores = new List<Preceptor>();

            _preceptores.Add(new Preceptor(5, "Jorgelina", "Ramos", true));
            _preceptores.Add(new Preceptor(6, "Juan", "Gutierrez", false));

            _alumnos.Add(new AlumnoRegular(123, "Carlos", "Juárez", "cj@gmail.com"));
            _alumnos.Add(new AlumnoRegular(124, "Carla", "Jaime", "carla@gmail.com"));
            _alumnos.Add(new AlumnoOyente(320, "Ramona", "Vals"));
            _alumnos.Add(new AlumnoOyente(321, "Alejandro", "Medina"));
        }

        private bool AsistenciaRegistrada(string fecha)
        {
            List<Asistencia> lista = this.GetAsistenciasPorFecha(fecha);

            if (!this._asistencias.Exists(x => x.FechaAsistencia == fecha))
            {
                return true;
            }
            else
            {
                throw new AsistenciaInconsistenteException();
            }

        }
        
        private int GetCantidadAlumnosRegulares()
        {
            int cant = 0;
            foreach (AlumnoRegular i in _alumnos)
            {
                cant++;
            }
            return cant;
        }

        public Preceptor GetPreceptorActivo()
        {
            Preceptor preceptor = _preceptores.SingleOrDefault(x => x.Activo == true); // puede fallar
            return preceptor;
        }
        public static List<Alumno> GetListaAlumnos()
        {
            return _alumnos;
        }
        public void AgregarAsistencia(List<Asistencia> listaHoy)
        {
            string fecha = listaHoy.FirstOrDefault().FechaAsistencia;

            if (!this._asistencias.Exists(x => x.FechaAsistencia == fecha ))
            {
                if(AsistenciaRegistrada(fecha) == true)
                    _asistencias.AddRange(listaHoy);
            }
            else
            {
                throw new AsistenciaExistenteEseDiaException();
            }
            
        }
        
        public static List<Asistencia> GetAsistenciasPorFecha(string fecha)
        {
            return _asistencias.FindAll(x => x.FechaAsistencia == fecha);
        }
    }
}
