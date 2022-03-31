using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class CalculadoraDeArea
    {
        /// <summary>
        /// Calcula la superficie de un cuadrado
        /// </summary>
        /// <param name="longitudLado">Largo del lado </param>
        /// <returns>Devuelve el valor cuadrado del lado</returns>
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            return longitudLado * longitudLado;
        }

        /// <summary>
        /// Devuelve el area del Triangulo
        /// </summary>
        /// <param name="baseTriangulo">Largo de la base del triangulo</param>
        /// <param name="altura">Altura del triangulo</param>
        /// <returns>Devuelve la superficio del triangulo ingresado</returns>
        public static double CalcularAreaTriangulo(double baseTriangulo, double altura)
        {
            return Math.Round((baseTriangulo * altura)/2,2,MidpointRounding.ToEven);
        }

        /// <summary>
        /// Devuelve el area de un circulo
        /// </summary>
        /// <param name="radio">Radio del circulo</param>
        /// <returns>Devuelve el area del circulo ingresado</returns>
        public static double CalcularAreaCirculo(double radio)
        {
            return Math.Round(Math.PI * (radio * radio),2,MidpointRounding.ToEven);
        }
    }
}
