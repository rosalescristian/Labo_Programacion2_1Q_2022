using System;

namespace Biblioteca
{
    public static class IntExtendido
    {
        /// <summary>
        /// Int Extendido - Juego FizzBuzz
        /// </summary>
        /// <param name="i">Numero sobre el cual corre el metodo</param>
        /// <returns>Devuelve Fizz si i%3==0 // Buzz si i%5==0 // FizzBuzz si i%3%5==0 else i.ToString()</returns>
        public static string FizzBuzz(this Int32 i)
        {
            string retorno = string.Empty; //Esta fue la inicializacion de Esteban
            
            if (i % 3 == 0)
            {
                retorno += "Fizz";
            }
            if(i%5 == 0)
            {
                retorno += "Buzz";
            }
            if (string.IsNullOrEmpty(retorno))
            {
                retorno = i.ToString(); 
            }

            return retorno;
        }
    }
}
