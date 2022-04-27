using System;

namespace Ejercicios01_23_03_2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio I01 - Min, Max y Avg";

            Console.WriteLine(Double.MinValue);
            int numero, minimo=int.MaxValue, maximo=int.MinValue, suma=0, contador=0, promedio=0;

            do
            {
                Console.WriteLine("Ingrese un nro Natural.");
                if(int.TryParse(Console.ReadLine(), out numero)&&(numero >0 && numero <10))
                {
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                    if (numero < minimo)
                    {
                        minimo = numero;
                    }
                    suma += numero;
                    contador++;
                    //Console.WriteLine("Nro 1: {0}, Nro 2: {1}", suma, contador);
                }
            } while (contador < 5);
            promedio = suma / 5;
            Console.WriteLine("El Maximo es: {0}.\n El Minimo es: {1}.\n El Promedio es: {2}", maximo, minimo, promedio);
            Console.ReadKey();
        }
    }
}
