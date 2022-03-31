using System;
using Biblioteca;

namespace Clase_02___Ejercicio_I05___Apr_las_tablas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 02: 30/03/22 - Ejercicio I05";

            int numeroIngresado;

            Console.WriteLine("Ingrese un nro para ver la tabla de multiplicar: ");
            if(int.TryParse(Console.ReadLine(),out numeroIngresado))
            {
                Console.WriteLine(AprendeTablas.TablasDeMultiplicar(numeroIngresado));
            }

            Console.ReadKey();
        }
    }
}
