using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Factorial
    {
        /// <summary>
        /// Calcula el Factorial de un nro
        /// </summary>
        /// <param name="calcularFactorial">Numero sobre el cual se va a calcular el factorial</param>
        /// <returns>Devuelve el factorial del nro ingresado</returns>
        public static int CalcularFactorial(int calcularFactorial)
        {
            /* El factorial de un número es una operación que consiste en multiplicar 
            * un numero “n” por todos los números enteros positivos que estén debajo de él,
            * por ejemplo el factorial de 3 es el resultado de multiplicar 3 por 2 por 1.
            */
            int factorial = 1;
            for(int i=1;i<calcularFactorial+1;i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }
    }
}
