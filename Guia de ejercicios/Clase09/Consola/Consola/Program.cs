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
            Gatito gatito = new Gatito();

            Animal gatoDos = new Gato();
            Animal perroDos = new Perro();
            Animal gatitoDos = new Gatito();

            Console.WriteLine(" - Herencia Polimorfica (Virtual/Override) En los metodos de las clases derivadas - ");
            
            Console.WriteLine(animal.EmitirSonido());
            Console.WriteLine(perro.EmitirSonido());
            Console.WriteLine(gato.EmitirSonido());
            Console.WriteLine("----------------------------");
            Console.WriteLine(gatoDos.EmitirSonido()); // Independientemente de que son de tipo ANIMAL, usan el metodo de la instancia GATO
            Console.WriteLine(perroDos.EmitirSonido()); // Independientemente de que son de tipo ANIMAL, usan el metodo de la instancia PERRO
            Console.WriteLine(gatito.EmitirSonido());
            Console.WriteLine(gatitoDos.EmitirSonido());

            Console.WriteLine(" - Herencia no Polimorfica (new) En los metodos de las clases derivadas - ");
            
            Console.WriteLine(animal.Pensar());
            Console.WriteLine(perro.Pensar());
            Console.WriteLine(gato.Pensar());
            Console.WriteLine("----------------------------");
            Console.WriteLine(gatoDos.Pensar()); // Independientemente de que son de tipo ANIMAL, usan el metodo de la instancia GATO
            Console.WriteLine(perroDos.Pensar()); // Independientemente de que son de tipo ANIMAL, usan el metodo de la instancia PERRO
            Console.WriteLine(gatito.Pensar()); // Independientemente de que son de tipo ANIMAL, usan el metodo de la instancia GATO
            Console.WriteLine(gatitoDos.Pensar()); // Independientemente de que son de tipo ANIMAL, usan el metodo de la instancia GATO

            Console.ReadKey();
        }
    }
}
