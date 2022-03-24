using System;

namespace Ejercicio_I03_23_03_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I03 - Numeros Primos";

            int numero;
            char salir = 'N';
            bool condicion = false;
            do
            {
                Console.WriteLine("Ingrese un nro.");
                
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Variable {0}",numero);
                    //Console.WriteLine("El Nro ingresado es: {0}.\n El Cuadrado es: {1}.\n El Cubo es: {2}", numero, cuadrado, cubo);
                }
                else
                {
                    Console.WriteLine("ERROR. ¡Reingresar número! ¿O desea salir S/N?");
                    salir = Console.ReadKey();

                }
            } while (!condicion);
            Console.ReadKey();

        }
    }
}
