using System;

namespace Clase07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Jugadores j = new Jugadores("Fede", 10, 2);
            //Jugadores j = new Jugadores("Cristian", 10, 2);
            //Jugadores j = new Jugadores("Fede", 10, 2);

            j.PartidosJugados = 20;

            Console.WriteLine(j.Nombre);
            Console.WriteLine(j.PartidosJugados);
            Console.WriteLine(j.PromedioDeGoles);
            Console.WriteLine(j.Color);
            

            j.Color = (EColor)new Random().Next(0, 4);

            Console.WriteLine(j.Color);

            //El enumerado color estaba dentro de la clase Jugadores
            //j.Color = Jugadores.EColor.Rojo;

            //El enumerado esta fuera de la clase y lo puedo consultar de cualquier lado
            j.Color = EColor.Rojo;
            j.Color = (EColor)33;

            Console.ReadKey();
        }
    }
}
