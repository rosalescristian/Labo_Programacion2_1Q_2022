using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Entidades
{
    public class Jean : Prenda
    {
        public enum Calce
        {
            Ajustado, Normal, Ancho
        }
        
        private Calce calce;

        /// <summary>
        /// Informacion
        /// </summary>
        /// <returns>STRING con la info del producto</returns>
        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Informacion());
            sb.AppendLine($"Calce {this.calce}");
            return sb.ToString();
        }

        /// <summary>
        /// Constructor con Parametros
        /// </summary>
        /// <param name="modelo"></param>
        /// <param name="talle"></param>
        /// <param name="colorPrimario"></param>
        /// <param name="calce"></param>
        public Jean(string modelo, Talles talle, Color colorPrimario, Calce calce) : base(modelo, talle, colorPrimario)
        {
            this.calce = calce;
        }

        /// <summary>
        /// Tamanio
        /// </summary>
        /// <returns>Devuelve un string con el tamaño de la CAMISA</returns>
        public override string Tamanio()
        {
            StringBuilder sb = new StringBuilder();
            if (this.talle == Talles.Chico)
            {
                sb.AppendLine($"Cintura 100 y Pierna 104");
                return sb.ToString();
            }
            sb.AppendLine($"Cintura 116 y Pierna 112");
            return sb.ToString();
        }
    }
}
