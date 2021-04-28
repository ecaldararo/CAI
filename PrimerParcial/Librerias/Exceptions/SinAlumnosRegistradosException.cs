using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class SinAlumnosRegistradosException : Exception
    {
        public SinAlumnosRegistradosException(string msg) : base(msg)
        {

        }

        public SinAlumnosRegistradosException() : base("Sin Alumnos Registrados.")
        {

        }
    }

}
