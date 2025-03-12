using AgenciaDeCambioPOO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaDeCambioPOO.Datos
{
    public interface IArchivo<T> where T : class
    {
        List<T> LeerDatos(string ruta);
        void GuardarDatos(string ruta, List<T> datos);
    }
}
