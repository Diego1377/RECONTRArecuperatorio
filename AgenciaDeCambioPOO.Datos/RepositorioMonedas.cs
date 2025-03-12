using AgenciaDeCambioPOO.Entidades;
using System.Reflection;

namespace AgenciaDeCambioPOO.Datos
{
    public class RepositorioMonedas
    {
        private readonly string _ruta;
        private readonly IArchivo<Moneda> _manejadorXml;

        private Dictionary<string, Moneda> moneda = new();

        public RepositorioMonedas(string ruta, IArchivo<Moneda> manejadorXml)
        {
            _ruta = ruta;
            _manejadorXml = manejadorXml;
            CargarMonedas();
        }

        private void CargarMonedas()
        {
            var lista = _manejadorXml.LeerDatos(_ruta);
            moneda = lista.ToDictionary(m => m.Abreviatura, m => m);
        }
        public List<Moneda> ObtenerTodas()
        {
            return moneda.Values
                .Where(m => !(m is PesoArgentino))
                .OrderBy(m => m.Nombre)
                .ToList();
        }
        public Moneda? BuscarMoneda(string nombre)
        {
            moneda.TryGetValue(nombre, out Moneda? buscarMoneda);
            return buscarMoneda;
        }

        public void GuardarMoneda(Moneda moneda)
        {
            var monedaBuscada = BuscarMoneda(moneda.Nombre);
            if (monedaBuscada == null)
            {
                this.moneda.Add(moneda.Nombre, moneda);
            }
            else
            {
                monedaBuscada.Abreviatura = moneda.Abreviatura;
                monedaBuscada.Cantidad = moneda.Cantidad;
            }
            GuardarDatos();
        }

        private void GuardarDatos()
        {
            _manejadorXml.GuardarDatos(_ruta, moneda.Values.ToList());
        }
    }
}
