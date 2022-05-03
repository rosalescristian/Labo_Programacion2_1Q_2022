using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Centralita
{
    public class Local : Llamada
    {
        protected float costo;

        public Local(Llamada llamada, float costo)
        {
            this.costo = costo;
        }
        public Local(float costo) : base (duracion,nroDestino,nroOrigen)
        {
            this.costo = costo;
        }

        /// <summary>
        /// Propiedad Costo Llamada. ReadOnly
        /// </summary>
        public float CostoLlamada
        {
            get
            {
                return this.costo;
            }
        }

        private float CalcularCosto()
        {
            return 0;
        }

        public new string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            return sb.ToString();   
        }


    }
}
