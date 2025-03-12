using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeCambioPOO.Entidades
{
    public class PesoArgentino : Moneda
    {
        public PesoArgentino()
        {
        }
        public PesoArgentino(Decimal cantidad)
        {
        }

        public override string MostrarDatos()
        {
            return base.MostrarDatos() + $"\n No tiene cotizaciones";
        }
        public override decimal ObtenerValorEnPesos()
        {
            return Cantidad;
        }
    }
}
