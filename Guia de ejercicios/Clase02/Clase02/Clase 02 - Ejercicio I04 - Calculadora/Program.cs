using System;
using Biblioteca;
namespace Clase_02___Ejercicio_I04___Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 02 : 30/03/22 - Ejercicio I04 Calculadora";

            int operandoUno, operandoDos;
            char operacionMatematica;
            char exit = 'n';
            do
            {
                Console.WriteLine("Ingrese el Operando UNO: ");
                int.TryParse(Console.ReadLine(), out operandoUno);

                Console.WriteLine("Ingrese el Operando DOS: ");
                int.TryParse(Console.ReadLine(), out operandoDos);

                Console.WriteLine("Ingrese la operacion matematica(+ - * /): ");
                char.TryParse(Console.ReadLine(), out operacionMatematica);

                Console.WriteLine(Calculadora.Calcular(operandoUno, operandoDos, operacionMatematica));
                Console.WriteLine("Desea Salir? (s/n)");
                char.TryParse(Console.ReadLine(), out exit);

            } while (exit == 'n');


            Console.ReadKey();
        }
    }
}
