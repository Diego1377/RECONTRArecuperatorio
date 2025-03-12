using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeCambioPOO.Entidades
{
   public abstract class Transaccion
    {
        private DateTime _fecha;
        private decimal _total;

        public DateTime Fecha
        {
            get { return _fecha; }
            private set { _fecha = value; }
        }

        public decimal Total
        {
            get { return _total; }
            protected set { _total = value; }
        }

        public Transaccion()
        {
            _fecha = DateTime.Now;
        }

        public abstract void ObtenerCotizacion(Divisa divisa);

        public virtual void MostrarTransaccion()
        {
            Console.WriteLine($"Fecha: {Fecha}");
            Console.WriteLine($"Total: {Total}");
        }
    }
}
