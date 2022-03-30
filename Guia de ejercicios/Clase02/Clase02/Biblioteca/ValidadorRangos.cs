using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class ValidadorRangos
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
            /*
             * Esteban lo resolvió así y es válido:
             * return valor >= min && valor <= max; // Compara si el valor ingresado cumple con el true y devuelve true o false.
             */
        
        }
    }
}
