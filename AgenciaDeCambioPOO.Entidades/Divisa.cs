using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AgenciaDeCambioPOO.Entidades
{
    

    public class Divisa : Moneda
    {
        public decimal CotizacionCompra { get; set; }
        public decimal CotizacionVenta { get; set; }
        public Divisa() { }
        public Divisa(decimal cotizacionCompra, decimal cotizacionVenta)
        {
            CotizacionCompra = cotizacionCompra;
            CotizacionVenta = cotizacionVenta;
        }
        public override decimal ObtenerValorEnPesos()
        {
           return  Cantidad * CotizacionCompra; 
        }
        public override string MostrarDatos()
        {
            return base.MostrarDatos() + $"\n- Compra: {CotizacionCompra} - Venta: {CotizacionVenta}";
        }
    }
}
