using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Arbusto : Planta
    {
        /// <summary>
        /// Propiedad TieneFlores. ReadOnly
        /// </summary>
        public override bool TieneFlores
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Propiedad TieneFruto. ReadOnly
        /// </summary>
        public override bool TieneFruto
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Constructor con parametros q llama a la base.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="tamanio"></param>
        public Arbusto(string nombre, int tamanio) 
                        : base(nombre, tamanio)
        {

        }


    }
}
