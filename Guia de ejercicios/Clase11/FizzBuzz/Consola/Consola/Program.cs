using System;
using Biblioteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char salir = 'N';
            int numero;
            do
            {
                Console.WriteLine("Ingrese un nro: ");
                if(int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine(numero.Dividir());
                }
                Console.WriteLine("Desea salir? S/N");
                Char.TryParse(Console.ReadLine(), out salir);
               
            } while (salir == 'N');
        }
    }
}
