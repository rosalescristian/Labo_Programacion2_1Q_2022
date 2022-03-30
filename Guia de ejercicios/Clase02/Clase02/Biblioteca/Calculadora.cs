using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Calculadora
    {
        /// <summary>
        /// Devuelve el resultado de una operacion Matematica Seleccionada por el usuario
        /// </summary>
        /// <param name="operandoUno">Primer Valor para Operar</param>
        /// <param name="operandoDos">Segundo Valor para Operar</param>
        /// <param name="operacionMatematica">Operacion a resolver</param>
        /// <returns>Devuelve el resultado de la operacion solicitada entre los operandos ingresados</returns>
        public static float Calcular(float operandoUno, float operandoDos, char operacionMatematica)
        {
            float resultado = 0;
            switch(operacionMatematica)
            {
                case '+':
                    resultado = operandoUno + operandoDos;
                    break;
                case '-':
                    resultado =  operandoUno - operandoDos;
                    break;
                case '*':
                    resultado =  operandoUno * operandoDos;
                    break;
                case '/':
                    if (!Calculadora.Validar(operandoDos))
                    {
                        Console.WriteLine("No se puede dividir por CERO.");
                    }
                    else
                    {
                        resultado = operandoUno / operandoDos;
                    }
                    break;
                default:
                    Console.WriteLine("Hubo un error! No se pudo calcular.");
                    break;
            }
            return resultado;
        }

        /// <summary>
        /// Valida si el Operando en el caso de la division es distinto de CERO
        /// </summary>
        /// <param name="operandoDos">El nro a validar si es o no cero</param>
        /// <returns>Devuelve TRUE si el valor es distinto de CERO</returns>
        private static bool Validar(float operandoDos)
        {
            return operandoDos != 0;
        }
    }
}
