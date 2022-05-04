using System;
using System.Text;

namespace Entidades
{
    public abstract class Planta
    {
        private string nombre;
        private int tamanio;

        /// <summary>
        /// Propiedad Tamanio. ReadOnly.
        /// </summary>
        public int Tamanio
        {
            get
            {
                return this.tamanio;
            }
        }

        /// <summary>
        /// Propiedad TieneFlores. Abstracta
        /// </summary>
        public abstract bool TieneFlores { get; }

        /// <summary>
        /// Propiedad TieneFruto. Abstracta
        /// </summary>
        public abstract bool TieneFruto { get; }

        /// <summary>
        /// Contsructor con Paramertos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="tamanio"></param>
        public Planta(string nombre, int tamanio)
        {
            this.nombre = nombre;
            this.tamanio = tamanio; 
        }

        /// <summary>
        /// Muestra los datos de la planta
        /// </summary>
        /// <returns>STRING con Nombre, Tamanio, Flores y Fruto.</returns>
        public virtual string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();
            //Yo lo hice con AppendFormat, habìa que usar STRING.FORMAT. Esta linea esta MAL.
            //sb.AppendFormat($"{0} tiene un tamanio de {1}\n Tiene flores {2}\nTiene fruto {3}",this.nombre, TieneFlores, TieneFruto);
            
            sb.AppendLine($"{this.nombre} tiene un tamanio de {this.Tamanio}");
            sb.AppendLine(string.Format("Tiene Flores {0}", this.TieneFlores ? "SI" : "NO"));
            sb.AppendLine(string.Format("Tiene Flores {0}", this.TieneFruto ? "SI" : "NO"));
            
            return sb.ToString();
        }
    }
}
