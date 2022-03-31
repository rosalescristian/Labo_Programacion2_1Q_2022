using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Pitagoras
    {
        /// <summary>
        /// Metodo que calcula el valor de la hipotenusa de acuerdo al teorema de pitagoras
        /// </summary>
        /// <param name="baseTriangulo">Base del triangulo</param>
        /// <param name="altura">Altura del Triangulo</param>
        /// <returns>Devuelve el valor de la hipotenusa</returns>
        public static double CalcularHipotenusa(int baseTriangulo, int altura)
        {
            return Math.Sqrt(Math.Pow(baseTriangulo,2)+ Math.Pow(altura,2));
        }
    }
}
