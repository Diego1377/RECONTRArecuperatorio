using AgenciaDeCambioPOO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AgenciaDeCambioPOO.Datos
{
    public class RepositorioTransacciones
    {
         private readonly string _ruta;
        private readonly RepositorioMonedas? _repositorioMonedas;
        private readonly IArchivo<Transaccion> _manejadorSecuencial;
        private List<Transaccion> _transacciones = new();

        public RepositorioTransacciones(
                RepositorioMonedas repositorioMonedas,
                IArchivo<Transaccion> manejadorSecuencial,
                string ruta)
        {
            _repositorioMonedas = repositorioMonedas;
            _manejadorSecuencial = manejadorSecuencial;
            _ruta = ruta;
        }

        public void AgregarTransaccion(Transaccion transaccion)
        {
            _transacciones.Add(transaccion);
            _manejadorSecuencial.GuardarDatos(_ruta, _transacciones);
        }

        public void GuardarTransaccion(Transaccion transaccion)
        {
            _transacciones.Add(transaccion);

            Moneda? pesoArgentino = _repositorioMonedas!.BuscarMoneda("ARS");
           
            if (transaccion is Venta)
            {
                pesoArgentino!.Cantidad += transaccion.Total;

            }
            else
            {
                pesoArgentino!.Cantidad -= transaccion.Total;

            }
            _repositorioMonedas.GuardarMoneda(pesoArgentino);
            _manejadorSecuencial.GuardarDatos(_ruta, _transacciones);
        }

        public List<Transaccion> ObtenerTransacciones()
        {
            return _transacciones;
        }
    }
}
