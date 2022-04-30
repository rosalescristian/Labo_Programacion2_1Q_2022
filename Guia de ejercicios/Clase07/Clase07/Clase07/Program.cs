using System;

namespace Clase07
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Jugador j = new Jugador("Fede", 10, 2);
            //Jugadores j = new Jugadores("Cristian", 10, 2);
            //Jugadores j = new Jugadores("Fede", 10, 2);
            string equipoDondeJugo = j [0];
            Console.WriteLine($"Equipo en el que jugò: {equipoDondeJugo}");
            j[0] = "z";
            Console.WriteLine($"Equipo en el que jugò: {equipoDondeJugo}");

            j.PartidosJugados = 20;

            Console.WriteLine(j.Nombre);
            Console.WriteLine(j.PartidosJugados);
            Console.WriteLine(j.PromedioDeGoles);
            Console.WriteLine(j.Color);
            
            //Se puede usar random para asignar desde el int q compone el Enumerado (funciona como un array, esta indexado y es base 0)
            j.Color = (EColor)new Random().Next(0, 4);

            //El enumerado color estaba dentro de la clase Jugadores
            //j.Color = Jugadores.EColor.Rojo;

            //El enumerado esta fuera de la clase y lo puedo consultar de cualquier lado
            j.Color = EColor.Rojo;
            j.Color = (EColor)33;

            Console.WriteLine(j.Color);

            Console.ReadKey();
        }
    }
}
