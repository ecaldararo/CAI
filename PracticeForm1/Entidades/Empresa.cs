using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    
    public class Empresa
    {
        private int _codigo;
        private string _nombre;
        private string _direccion;
        public List<Cliente> listClientes;

        public Empresa(int cod, string nom, string dir)
        {
            Codigo = cod;
            Nombre = nom;
            Direccion = dir;
            listClientes = new List<Cliente>();
        }

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }

        public static List<Cliente> GetLista(Empresa e)
        {
            return e.listClientes;
        }

        public override string ToString()
        {
            return $"{Codigo}-{Nombre}";
        }

    }
}
