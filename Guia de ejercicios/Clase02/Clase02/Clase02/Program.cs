using System;
using Biblioteca;

namespace Clase02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 02: 30/03/22 - Metodos";

            //float temperaturaCelsius = 30;
            //float temperaturaKelvin = ConversorDeTemperatura.ConvertirCelsiusAKelvin(temperaturaCelsius);
            //Console.WriteLine(temperaturaKelvin);

            int numero;
            int contador = 0;
            int min = int.MaxValue;
            int max = int.MinValue;

            Console.WriteLine("Ingrese el Limite Superior: ");
            if (int.TryParse(Console.ReadLine(), out max))
            {
                Console.WriteLine("Ingrese el Limite Inferior: ");
                if (int.TryParse(Console.ReadLine(), out min))
                {
                    do
                    {
                        Console.WriteLine("Ingrese un Numero: ");
                        if (int.TryParse(Console.ReadLine(), out numero))
                        {
                            if (Validador.Validar(numero, min, max))
                            {
                                Console.WriteLine("El nro se encuentra dentro del rango ingresado");
                            }
                            else
                            {
                                Console.WriteLine("El nro NO se encuentra dentro del rango ingresado");
                            }
                            contador++;
                        }
                    } while (contador < 5);
                }
            }
            else
            {
                Console.WriteLine("Ha ingresado un dato erroneo");
            }

            Console.ReadKey();
        }
    }
}
