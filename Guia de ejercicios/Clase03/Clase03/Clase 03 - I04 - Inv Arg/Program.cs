using System;
using Biblioteca;

namespace Clase_03___I04___Inv_Arg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 3: 31/03/2022 - Ejercicio I04: Invento Argentino";
            
            Boligrafo boligrafoUno = new Boligrafo(100, ConsoleColor.Blue);
            string dibujoBoligrafoUno = "";
            
            Boligrafo boligrafoDos = new Boligrafo(50, ConsoleColor.Red);
            string dibujoBoligrafoDos = "";

            Console.WriteLine(boligrafoUno.GetColor());
            Console.WriteLine(boligrafoUno.GetTinta());
            
            if(boligrafoUno.Pintar(30,out dibujoBoligrafoUno))
            {
                Console.WriteLine(dibujoBoligrafoUno);
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            boligrafoUno.Recargar();
            Console.WriteLine(boligrafoUno.GetTinta());

            Console.WriteLine(boligrafoDos.GetColor());
            Console.WriteLine(boligrafoDos.GetTinta());
            if(boligrafoDos.Pintar(12, out dibujoBoligrafoDos))
            {
               Console.WriteLine(dibujoBoligrafoDos);
               Console.ForegroundColor = ConsoleColor.Gray;
            }
            Console.WriteLine(boligrafoDos.GetTinta());
            boligrafoDos.Recargar();
            Console.WriteLine(boligrafoDos.GetTinta());

            Console.ReadKey();
        }
    }
}
