using System;
using Biblioteca;

namespace Clase04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 04 : 06/04/2022 - Sobrecargas; Ejercicio I01: Sumador";

            Sumador sumadorUno = new Sumador();
            Sumador sumadorDos = new Sumador(15);

            long resultadoLongUno = sumadorUno.Sumar(4, 5);
            Console.WriteLine($"Cantidad de Sumas = {(int)sumadorUno}");

            string resultadoStringUno = sumadorUno.Sumar("Hola", " Mundo");

            Console.WriteLine($"Resultado de long + long = {resultadoLongUno}"); // {Environment.NewLine} Funciona en los Console.WriteLine

            Console.WriteLine($"Cantidad de Sumas = {(int)sumadorUno}");

            Console.WriteLine($"Resultado de string + string = {resultadoStringUno}");

            Console.WriteLine($"Cantidad de Sumas = {(int)sumadorUno}");

            Console.WriteLine($"Cantidad de Sumas s1 + s2={sumadorUno+sumadorDos}");

            Console.WriteLine($"Son iguales si tienen misma cantidad de sumas = {sumadorUno | sumadorDos}");

            Console.ReadKey();
        }
    }
}
