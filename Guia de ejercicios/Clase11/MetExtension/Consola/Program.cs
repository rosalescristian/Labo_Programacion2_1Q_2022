using System;
using Biblioteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "Hola Mundo";

            int cantidadDePalabras = texto.ContarPalabras();
            Console.WriteLine(cantidadDePalabras);
            
            Console.ReadKey();
        }
    }
}
