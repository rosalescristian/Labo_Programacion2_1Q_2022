using System;
using Biblioteca;

namespace Clase_02___Ejercicio_I07___Pitagoras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 02 : 30/03/2022 - Ejercicio I07";

            int baseTriangulo, altura;

            Console.WriteLine("Ingrese la base del triangulo: ");
            if (int.TryParse(Console.ReadLine(), out baseTriangulo))
            {
                Console.WriteLine("Ingrese la altura del triangulo: ");
                if (int.TryParse(Console.ReadLine(), out altura))
                {
                    Console.WriteLine("La hipotenusa del Triangulo es: {0}",Pitagoras.CalcularHipotenusa(baseTriangulo, altura));
                }
            }
            Console.ReadKey();
        }
    }
}
