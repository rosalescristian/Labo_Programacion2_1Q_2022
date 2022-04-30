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



            Console.ReadKey();
        }
    }
}
