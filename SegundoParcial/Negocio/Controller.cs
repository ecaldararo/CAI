using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Negocio
{
    public class Controller
    {
        public PlazoFijoMapper _plazoFijoMapper;
        public List<TipoPlazoFijo> _tiposPF;
        public List<PlazoFijo> _listaPlazosFijos;
        public Operador _operador;

        public Controller()
        {
            _plazoFijoMapper = new PlazoFijoMapper();
            _operador = new Operador();

            _tiposPF = new List<TipoPlazoFijo>();
            _tiposPF.Add(new TipoPlazoFijo(1, "Plazo Fijo Web", 0.41));
            _tiposPF.Add(new TipoPlazoFijo(2, "Plazo Fijo UVA", 0.03));

            
        }

        public List<PlazoFijo> TraerTodos()
        {
            _operador._listaPlazosFijos = _plazoFijoMapper.TraerTodos();

            return _operador._listaPlazosFijos;
        }

        public string Alta(PlazoFijo pf)
        {
            TransactionResult result = _plazoFijoMapper.Alta(pf);

            if (result.IsOk == true)
                return "Alta exitosa";
            else
                return "Error en el alta";

        }



    }
}
