using System;
using Biblioteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 09: 28/04/2022 - Polimorfismo";

            Animal animal = new Animal();
            Perro perro = new Perro();
            Gato gato = new Gato();

            Animal gatoDos = new Gato();
            Animal perroDos = new Perro();


            Console.WriteLine(animal.EmitirSonido());
            Console.WriteLine(perro.EmitirSonido());
            Console.WriteLine(gato.EmitirSonido());
            Console.WriteLine("----------------------------");
            Console.WriteLine(gatoDos.EmitirSonido()); // Independientemente de que son de tipo ANIMAL, usan el metodo de la instancia GATO
            Console.WriteLine(perroDos.EmitirSonido()); // Independientemente de que son de tipo ANIMAL, usan el metodo de la instancia PERRO

            Console.ReadKey();
        }
    }
}
