using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Producto
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
        /// Devuelve la Marca del producto
        /// </summary>
        /// <returns></returns>
        public string GetMarca()
        {
            return this.marca;
        }

        /// <summary>
        /// Devuelve el precio del producto
        /// </summary>
        /// <returns></returns>
        public float GetPrecio()
        {
            return this.precio;
        }

        /// <summary>
        /// Muestra un string con los datos del producto
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static string MostrarProducto(Producto p)
        {
            return $"Marca: {p.marca} - Precio: {p.precio} - Cod. de Barras: {p.codigoDeBarra}";
        }

        /// <summary>
        /// Compara si la marca del producto es distinto a la marca ingresada por parametros
        /// </summary>
        /// <param name="p"></param>
        /// <param name="marca"></param>
        /// <returns></returns>
        public static bool operator !=(Producto p, string marca)
        {
            return p.marca != marca;
        }

        /// <summary>
        /// Compara si la marca de los productos y sus codigos de barra son distintos
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator !=(Producto p1, Producto p2)
        {
            return p1.marca != p2.marca && p1.codigoDeBarra != p2.codigoDeBarra;
        }

        /// <summary>
        /// Compara la marca del producto vs la marca ingresada por parametro
        /// </summary>
        /// <param name="p"></param>
        /// <param name="marca"></param>
        /// <returns></returns>
        public static bool operator ==(Producto p, string marca)
        {
            return p.marca == marca;
        }

        /// <summary>
        /// Compara si la marca de los productos y sus codigos de barras son distintos
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Producto p1, Producto p2)
        {
            if(p1 is not null && p2 is not null)
            {
                return p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra;
            }
            return false;
        }

        /// <summary>
        /// Devuelve el codigo de barras del producto
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
    }
}
