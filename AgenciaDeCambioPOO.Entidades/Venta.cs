using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeCambioPOO.Entidades
{
    public class Venta : Transaccion
    {
        public Divisa DivisaOperacion { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Cotizacion { get; private set; }

        public Venta(Divisa divisaOperacion, decimal cantidad)
        {
            DivisaOperacion = divisaOperacion;
            Cantidad = cantidad;
            ObtenerCotizacion(divisaOperacion);
            Total = Cantidad * Cotizacion;
        }

        public override void ObtenerCotizacion(Divisa divisa)
        {
            Cotizacion = divisa.CotizacionVenta;
        }

        public override void MostrarTransaccion()
        {
            base.MostrarTransaccion();
            Console.WriteLine("Venta realizada satisfactoriamente");
        }
    }
}
