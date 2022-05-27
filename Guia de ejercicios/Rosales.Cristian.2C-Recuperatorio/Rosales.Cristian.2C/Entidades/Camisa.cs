using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Entidades
{
    public class Camisa : Prenda
    {
        private Color colorSecundario;

        /// <summary>
        /// Consructor con parametros
        /// </summary>
        /// <param name="modelo"></param>
        /// <param name="talle"></param>
        /// <param name="colorPrimario"></param>
        /// <param name="colorSecundario"></param>
        public Camisa(string modelo, Talles talle, Color colorPrimario, Color colorSecundario) : base(modelo, talle, colorPrimario)
        {
            this.colorSecundario = colorSecundario;
        }

        /// <summary>
        /// Informacion
        /// </summary>
        /// <returns>String con los datos del producto</returns>
        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Informacion());
            sb.AppendLine($"Con vivos {this.colorSecundario}");
            return sb.ToString();
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
                sb.AppendLine($"Pecho 49 y Manga 67");
                return sb.ToString();
            }
            sb.AppendLine($"Pecho 53 y Manga 69");
            return sb.ToString();
        }
    }
}
