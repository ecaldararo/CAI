using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string EstadoCivil { get => _estadoCivil; set => _estadoCivil = value; }
        public bool Activo { get => _activo; set => _activo = value; }

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
            string act = "Inactivo";
            if (_activo == true)
                act = "Activo";

            return $"{_codigo}-{_apellido}, {_nombre} : Estado: {act}, Estado Civil: {_estadoCivil}";
        }
    }
}
