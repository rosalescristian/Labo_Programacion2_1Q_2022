using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        /// <summary>
        /// Constructor Generico
        /// </summary>
        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        /// <summary>
        /// Constructor de instancia con Parametros
        /// </summary>
        /// <param name="capacidad"></param>
        /// <param name="ubicacion"></param>
        public Estante(int capacidad, int ubicacion):this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        /// <summary>
        /// Devuelve el array de productos completo
        /// </summary>
        /// <returns></returns>
        public Producto[] GetProductos()
        {
            return this.productos;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Ubicacion del Estante: {e.ubicacionEstante}");
            foreach(Producto producto in e.productos)
            {
                sb.AppendLine(Producto.MostrarProducto(producto));
            }
            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator ==(Estante e, Producto p)
        {
            foreach(Producto producto in e.productos)
            {
                if(producto == p)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Estante operator -(Estante e, Producto p)
        {
            if(e == p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if(e.productos[i] == p)
                    {
                        e.productos[i] = null;
                    }

                }
            }
            return e;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator +(Estante e, Producto p)
        {
            if(e != p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
