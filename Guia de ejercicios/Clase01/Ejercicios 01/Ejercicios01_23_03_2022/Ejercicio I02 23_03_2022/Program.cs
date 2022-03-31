using System;

namespace Ejercicio_I02_23_03_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I02 - Cuadrado y Cubo";

            double numero, cuadrado, cubo;
            bool condicion = false;
            do
            {
                Console.WriteLine("Ingrese un nro Mayor a CERO.");
                if (double.TryParse(Console.ReadLine(), out numero) && (numero > 0))
                {
                    cuadrado = Math.Pow(numero, 2);
                    cubo = Math.Pow(numero, 3);
                    condicion = true;
                    Console.WriteLine("El Nro ingresado es: {0}.\n El Cuadrado es: {1}.\n El Cubo es: {2}", numero, cuadrado, cubo);
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
            } while (!condicion);
            Console.ReadKey();

        }
    }
}
