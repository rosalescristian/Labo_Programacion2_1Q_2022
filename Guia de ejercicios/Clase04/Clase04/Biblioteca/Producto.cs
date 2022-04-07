using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;
        
        /// <summary>
        /// Constructor de instancia con parametros
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="codigo"></param>
        /// <param name="precio"></param>
        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetMarca()
        {
            return this.marca;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public float GetPrecio()
        {
            return this.precio;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string MostrarProducto(Producto p)
        {
            return $"{p.marca} - {p.precio} - {p.codigoDeBarra}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="marca"></param>
        /// <returns></returns>
        public static bool operator !=(Producto p, string marca)
        {
            return (p.marca != marca);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Producto p1, Producto p2)
        {
            return (p1.marca != p2.marca && p1.codigoDeBarra != p2.codigoDeBarra);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        /// <param name="marca"></param>
        /// <returns></returns>
        public static bool operator ==(Producto p, string marca)
        {
            return (p.marca == marca);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Producto p1, Producto p2)
        {
            return (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
    }
}
