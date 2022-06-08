using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    internal interface IPersistirDatos <T>
        where T : class
    {
        
        public void Guardar(string path, string nombreArchivo, T contenido);
       

        public T Leer(string path, string nombreArchivo);
    }
}
