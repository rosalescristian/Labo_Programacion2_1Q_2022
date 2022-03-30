using System;
using Biblioteca;

namespace Clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 02: 30/03/22 - Metodos";

            float temperaturaCelsius = 30;
            
            float temperaturaKelvin = ConversorDeTemperatura.ConvertirCelsiusAKelvin(temperaturaCelsius);

            Console.WriteLine(temperaturaKelvin);

            Console.ReadKey();
        }
    }
}
