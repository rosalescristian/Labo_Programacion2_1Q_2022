using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Rosal : Planta
    {
        public enum Color
        {
            Roja, Blanca, Amarilla, Rosa, Azul
        }
        
        private Color florColor;

        /// <summary>
        /// Constructor con parametros. Reutiliza el otro constructor
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="tamanio"></param>
        public Rosal(string nombre, int tamanio) : this(nombre, tamanio, Color.Rosa)
        {
            
        }

        /// <summary>
        /// Constructor con parametros.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="tamanio"></param>
        public Rosal(string nombre, int tamanio, Color flor) : base(nombre, tamanio)
        {
            this.florColor = flor;
        }

        /// <summary>
        /// Propiedad TieneFlores. ReadOnly
        /// </summary>
        public override bool TieneFlores
        {
            get
            {
                return true;
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
        /// Muestra el resumen de datos de Rosales
        /// </summary>
        /// <returns>STRING. Los datos de PLANTA + Rosal</returns>
        public override string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine(base.ResumenDeDatos());
            sb.AppendLine($"Flores de color: {this.florColor}");
                        
            return sb.ToString();
        }



    }
}
