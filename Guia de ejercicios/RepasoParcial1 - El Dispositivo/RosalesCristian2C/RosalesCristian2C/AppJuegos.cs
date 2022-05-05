using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosalesCristian2C
{
    public class AppJuegos : Aplication
    {
        /// <summary>
        /// Constructor con parametros, utiliza el de la clase base
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="tamanioMb"></param>
        /// <param name="sistemaOperativo"></param>
        public AppJuegos(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb) 
                        : base(nombre, sistemaOperativo, tamanioMb)
        {

        }

        /// <summary>
        /// Override Propiedad Tamanio, ReadOnly
        /// </summary>
        public override int Tamanio
        {
            get
            {
                return this.tamanioMb;
            }
        }
    }
}
