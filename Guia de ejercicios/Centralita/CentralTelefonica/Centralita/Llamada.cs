using System;
using System.Text;

namespace Centralita
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        /// <summary>
        /// Constructor con Parametros
        /// </summary>
        /// <param name="duracion"></param>
        /// <param name="nroDestino"></param>
        /// <param name="nroOrigen"></param>
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        /// <summary>
        /// Propiedad Duracion. ReadOnly.
        /// </summary>
        public float Duracion
        {
            get
            {
                return this.duracion;
            }
        }

        /// <summary>
        /// Propiedad NroOrigen. Read Only
        /// </summary>
        public string NroOrigen
        {
            get
            {
                return this.nroOrigen;
            }
        }

        /// <summary>
        /// Propiedad NroDestino. Read Only
        /// </summary>
        public string NroDestino
        {
            get
            {
                return this.nroDestino;
            }
        }

        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            return 0;
        }

        public static string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            return sb.ToString();
        }



    }
}
