using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tienda
    {
        private List<Prenda> prendas;

        /// <summary>
        /// Prop. Prendas. ReadOnly
        /// </summary>
        public List<Prenda> Prendas
        {
            get
            {
                return this.prendas;
            }
        }

        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public Tienda()
        {
            this.prendas = new List<Prenda>();
        }

        /// <summary>
        /// Sobrecarga del operador MENOS
        /// </summary>
        /// <param name="tienda"></param>
        /// <param name="prenda"></param>
        /// <returns></returns>
        public static Tienda operator -(Tienda tienda, Prenda prenda)
        {
            if (tienda.Prendas.Contains(prenda))
            {
                int indexPrenda = tienda.Prendas.IndexOf(prenda);
                tienda.Prendas[indexPrenda].Stock -= prenda.Stock;
            }
            return tienda;
        }

        /// <summary>
        /// Sobrecarga del operador MAS
        /// </summary>
        /// <param name="tienda"></param>
        /// <param name="prenda"></param>
        /// <returns>Devuelve la tienda con el stock o el producto sumado depende del caso</returns>
        public static Tienda operator +(Tienda tienda, Prenda prenda)
        {
            if (tienda.Prendas.Contains(prenda))
            {
                int indexPrenda = tienda.Prendas.IndexOf(prenda);
                tienda.Prendas[indexPrenda].Stock += prenda.Stock;
            }
            tienda.Prendas.Add(prenda);
            return tienda;

        }
    }
}
