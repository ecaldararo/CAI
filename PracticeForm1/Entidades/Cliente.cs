using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        public string Activo()
        {
            if (_activo == true)
                return "Activo";
            else
                return "Inactivo";
        }

    public Cliente(string nombre, string apellido, bool activo, string estadoCivil)
        {
            id += 1;
            _codigo = id;
            _nombre = nombre;
            _apellido = apellido;
            _activo = activo;
            _estadoCivil = estadoCivil;
        }
        public override string ToString()
        {
            return $"{_codigo}-{_apellido}, {_nombre} : Estado: {Activo()}, Estado Civil: {_estadoCivil}";
        }
    }
}
