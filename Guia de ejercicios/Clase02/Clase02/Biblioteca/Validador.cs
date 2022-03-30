using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Validador
    {
        /// <summary>
        /// Valida que el valor ingresado se encuentre en un rango determinado
        /// </summary>
        /// <param name="valor">Dato a Validar</param>
        /// <param name="min">Minimo Valor Incluido</param>
        /// <param name="max">Maximo Valor Incluido</param>
        /// <returns>Devuelve TRUE si el valor se encuentra dentro del rango</returns>
        public static bool Validar(int valor, int min, int max)
        {
            bool validador = false;
            if((valor >= min) && (valor <= max))
            {
                validador = true;
            }
            return validador;
        }
    }
}
