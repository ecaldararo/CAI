using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    [DataContract]
    public abstract class Persona
    {
        protected static int id;
        protected int _codigo;
        protected string _nombre;
        protected string _apellido;
        protected bool _activo;
        protected string _estadoCivil;



    }
}
