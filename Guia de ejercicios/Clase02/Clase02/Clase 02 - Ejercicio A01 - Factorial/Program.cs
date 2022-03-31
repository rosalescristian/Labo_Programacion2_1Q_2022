using System;
using Biblioteca;

namespace Clase_02___Ejercicio_A01___Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 02 : 30/03/22 - Ejercicio A01 Calculo de Factorial";

            int numeroUno;
            Console.WriteLine("Ingrese un nro: ");
            if(int.TryParse(Console.ReadLine(), out numeroUno))
            {
                Console.WriteLine(CalculaFactorial.CalcularFactorial(numeroUno));
            }
            Console.ReadKey();
        }
    }
}
