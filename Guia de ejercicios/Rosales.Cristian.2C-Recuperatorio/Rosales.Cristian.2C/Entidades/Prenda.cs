using System;
using System.Drawing;
using System.Text;

namespace Entidades
{
    public abstract class Prenda
    {
        public enum Talles
        {
            Chico, Grande
        }

        protected Color colorPrimario;
        protected string modelo;
        protected int stock;
        protected Talles talle;

        /// <summary>
        /// Prop Stock. Get y Set.
        /// </summary>
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                this.stock = value;
            }
        }

        /// <summary>
        /// Devuelve toda la informacion de la prenda
        /// </summary>
        /// <returns></returns>
        public virtual string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Color Primario: {this.colorPrimario}");
            sb.AppendLine($"Modelo: {this.modelo}");
            sb.AppendLine($"Stock: {this.Stock}");
            sb.AppendLine($"Talle: {this.talle}");

            return sb.ToString();
        }

        /// <summary>
        /// Sobrefcarga operador !=
        /// </summary>
        /// <param name="prenda1">Prenda a comparar</param>
        /// <param name="prenda2">Prenda a Comparar</param>
        /// <returns>TRUE si Distinto, FALSE si no</returns>
        public static bool operator !=(Prenda prenda1, Prenda prenda2)
        {
            return !(prenda1 == prenda2);
        }

        /// <summary>
        /// Sobrecarga operador ==
        /// </summary>
        /// <param name="prenda1">Prenda a comparar</param>
        /// <param name="prenda2">Prenda a comparar</param>
        /// <returns>TRUE si son iguales (Prenda.Modelo y Prenda.Talle), FALSE si no</returns>
        public static bool operator ==(Prenda prenda1, Prenda prenda2)
        {
            if(prenda1.modelo == prenda2.modelo && prenda1.talle == prenda2.talle)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Consrtuctor con parametros
        /// </summary>
        /// <param name="modelo"></param>
        public Prenda(string modelo)
        {
            this.modelo = modelo;
            this.Stock = 1;
        }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="modelo"></param>
        /// <param name="talle"></param>
        public Prenda(string modelo, Talles talle) : this (modelo)
        {
            this.talle = talle;
        }

        /// <summary>
        /// Constructor con Parametros
        /// </summary>
        /// <param name="modelo"></param>
        /// <param name="talle"></param>
        /// <param name="colorPrimario"></param>
        public Prenda(string modelo, Talles talle, Color colorPrimario) : this(modelo, talle)
        {
            this.colorPrimario = colorPrimario;
        }

        /// <summary>
        /// Metodo Abstracto Tamanio 
        /// </summary>
        /// <returns></returns>
        public abstract string Tamanio();
    }
}
