using System;
using Biblioteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 09: 28/04/2022 - Polimorfismo";

            //La herencia no polimorfica se fija en el tipo de datos de la variable(Se resuelve en tiempo de compilacion)
            //La herencia polimorfica se fija en la instancia ( se resuelve en tiempo de ejecucion)
            Animal animal = new Animal("a");
            Perro perro = new Perro("a");
            Gatito gatito = new Gatito("a");
            //La herencia se resuelve en tiempo de ejecucion (CLR) q elige los metodos que va a ejecutar
            //El polimorfismo se resuelve en tiempo de ejecucion (CLR)

            Gato gato = new Gato("Salem");
            Animal gatoDos = new Gato("Bola de Nieve");
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

            Console.WriteLine(" - Herencia NO Polimorfica (new) En los metodos de las clases derivadas - ");
            
            Console.WriteLine(animal.Pensar());
            Console.WriteLine(perro.Pensar());
            Console.WriteLine(gato.Pensar());
            Console.WriteLine("----------------------------");
            Console.WriteLine(gatoDos.Pensar()); // Independientemente de que son de tipo ANIMAL, usan el metodo de la instancia GATO
            Console.WriteLine(perroDos.Pensar()); // Independientemente de que son de tipo ANIMAL, usan el metodo de la instancia PERRO
            Console.WriteLine(gatito.Pensar()); // Independientemente de que son de tipo ANIMAL, usan el metodo de la instancia GATO
            Console.WriteLine(gatitoDos.Pensar()); // Independientemente de que son de tipo ANIMAL, usan el metodo de la instancia GATO

            Console.WriteLine("----------------------------");
            Console.WriteLine(" - OVERRIDE de EQUALS y GetHashCode /// Funciona como una 'sobrecarga' - ");
            Console.WriteLine(" - Sobreescritura de Equivalencias - ");
            
            Animal gatoTres = new Gato();
            gatoTres = gatoDos;

            Console.WriteLine(gatoDos.Equals(gatoTres));


            Console.ReadKey();
        }
    }
}
