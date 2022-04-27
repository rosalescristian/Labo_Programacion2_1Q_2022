using System;
using System.Collections.Generic; //este using es para poder usar Listas
using Biblioteca;

namespace Clase08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 08: Herencia | 2022-04-27";

            Publicacion publicacion = new Publicacion("Guia de C#", DateTime.Now);
            Libro libro = new Libro("Rayuela", "Julio Cortazar", 2500, new DateTime(1966, 04, 12));
            Revista revista = new Revista("Noticias", 369, new DateTime(2022, 04, 26));

            List<Publicacion>listaDeLibros = new List<Publicacion>();
            listaDeLibros.Add(libro);
            listaDeLibros.Add(revista);
            listaDeLibros.Add(publicacion);

            Console.WriteLine("FOREACH");
            //este foreach toma todo como PUBLICACION
            foreach (Publicacion item in listaDeLibros)
            {
                Console.WriteLine(item.MostrarDatos());
                // Aca valida si el ITEM PUBLICACION es LIBRO
                if(item is Libro)
                {
                    //esto esta CASTEADO a TIPO LIBRO el item y se usa la propiedad PRECIO
                    //para q devuelva el valor del libro (lo pega al final)
                    //tb podriamos llamar al metodo de la clase Libro
                    Console.WriteLine($"${((Libro)item).Precio}");
                }
            }
            //Console.WriteLine(publicacion.MostrarDatos());
            Console.WriteLine("Libro.MostrarDatos()");
            Console.WriteLine(libro.MostrarDatos());
            //Console.WriteLine(revista.MostrarDatos());
            Console.WriteLine("Publicacion.Imprimir");
            Publicacion.Imprimir(libro);

            Console.ReadKey();
        }
    }
}
