using System;
using Biblioteca;

namespace Ejercicio_I08___El_tiempo_pasa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 02: 30/03/2021 - Ejercicio I08";

            DateTime fechaHoy = DateTime.Now;
            int diaNac, mesNac, anioNac;

            Console.WriteLine("A continuación ingrese el día de su cumpleaños:");
            if(int.TryParse(Console.ReadLine(), out diaNac))
            {
                Console.WriteLine("A continuación ingrese el mes de su cumpleaños:");
                if (int.TryParse(Console.ReadLine(), out mesNac))
                {
                    Console.WriteLine("A continuación ingrese el anio de su cumpleaños:");
                    if (int.TryParse(Console.ReadLine(), out anioNac))
                    {
                        Console.WriteLine("La cantidad de Dias vividos es: {0}",CalculosConFechas.CalcularDiferenciaDias(diaNac, mesNac, anioNac, fechaHoy));
                    }
                }
            }
            else
            {
                Console.WriteLine("Ha ingresado un valor erroneo, reingrese.");
            }
            Console.ReadKey();
        }
    }
}
