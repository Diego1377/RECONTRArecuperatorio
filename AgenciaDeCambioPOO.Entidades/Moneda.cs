using System.Xml.Serialization;

namespace AgenciaDeCambioPOO.Entidades
{
    [XmlInclude(typeof(Divisa))]
    [XmlInclude(typeof(PesoArgentino))]
    public abstract class Moneda
    {
        private string nombre;
        private string abreviatura;
        private decimal cantidad;
        public Moneda()
        {

        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Abreviatura
        {
            get { return abreviatura; }
            set { abreviatura = value; }
        }

        public decimal Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }


        public virtual string MostrarDatos()
        {
            return $"Moneda: {Nombre} ({Abreviatura}) - Cantidad: {Cantidad}";
        }

        public abstract decimal ObtenerValorEnPesos();
    }
}
