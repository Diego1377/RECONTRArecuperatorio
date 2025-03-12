using AgenciaDeCambioPOO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeCambioPOO.Datos
{
    public class AgenciaDeCambio
    {
        private readonly RepositorioMonedas _repositorioMonedas;

        public AgenciaDeCambio(RepositorioMonedas repositorioMonedas)
        {
            _repositorioMonedas = repositorioMonedas;
        }

        public List<Moneda> ObtenerTodas()
        {
            return _repositorioMonedas.ObtenerTodas();
        }
    }
}
