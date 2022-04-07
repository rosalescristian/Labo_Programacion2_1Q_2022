using System;

namespace Biblioteca
{
    public class Sumador
    {
        private int cantidadSumas;

        /// <summary>
        /// 
        /// </summary>
        public Sumador():this(0) // :this(0) es para reutilizar el otro Constructor
        {
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cantidadSumas"></param>
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        /// <summary>
        /// Conversion Expicita a INT
        /// </summary>
        /// <param name="s"></param>
        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static bool operator |(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas == s2.cantidadSumas;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            return a + b; // Concatena Strings
        }
    }
}
