﻿using System;
using Biblioteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Sobre-Sobrescrito";
            //Sobrescrito objetoSobrescrito = new Sobrescrito();
            Sobrescrito objetoSobrescrito = new SobreSobrescrito();

            Console.WriteLine(objetoSobrescrito.ToString());

            string objeto = "¡Este es mi método ToString sobrescrito!";

            Console.WriteLine("----------------------------------------------");
            Console.Write("Comparación Sobrecargas con String: ");
            Console.WriteLine(objetoSobrescrito.Equals(objeto));

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetoSobrescrito.GetHashCode());

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(objetoSobrescrito.MiPropiedad);
            Console.WriteLine(objetoSobrescrito.MiMetodo());

            Console.ReadKey();
        }
    }
}
