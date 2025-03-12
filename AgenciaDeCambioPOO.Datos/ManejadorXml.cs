using AgenciaDeCambioPOO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AgenciaDeCambioPOO.Datos
{
    public class ManejadorXml : IArchivo<Moneda>
    {
        public void GuardarDatos(string ruta, List<Moneda> datos)
        {

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Moneda>));
            using (StreamWriter escritor = new StreamWriter(ruta))
            {
                xmlSerializer.Serialize(escritor, datos);
            }
        }

        public List<Moneda> LeerDatos(string ruta)
        {
            if (!File.Exists(ruta)) return new List<Moneda> { };
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Moneda>));
            using (StreamReader lector = new StreamReader(ruta))
            {
                return (List<Moneda>)xmlSerializer.Deserialize(lector)!;
            }
        }
    }

}

