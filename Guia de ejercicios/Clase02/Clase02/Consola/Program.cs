using System;
using System.Text;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 02: 30/03/2022 - StringBuilder";

            string comision = "2do C";
            string anio = "2022";
            
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("Hola");
            stringBuilder.Append($" Mundo {Environment.NewLine}"); // agrega texto
            stringBuilder.AppendLine("Programacion II"); // agrega texto con un salto de linea al final
            stringBuilder.AppendLine("Laboratorio II");
            stringBuilder.AppendFormat("Comision {0} {1}", comision, anio); // no pone salto de linea

            Console.WriteLine(stringBuilder.ToString());

            
            Console.ReadKey();
        }
    }
}
