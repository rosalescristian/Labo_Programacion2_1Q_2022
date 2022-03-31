using System;
using Biblioteca;

namespace Clase_02___Ejercicio_I06___Areas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 02: 30/03/22 - Ejercicio I06";

            int opcion;
            double lado;
            double altura;
            double radio;
            double areaCuadrado;
            double areaTriangulo;
            double areaCirculo;
            char exit = 'n';

            do
            {
                Console.WriteLine("Seleccione el calculo que desea resolver:\n\t1- Area Cuadrado\n\t2- Area Triangulo\n\t3- Area Circulo\n");
                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el largo del lado del cuadrado: ");
                            if (double.TryParse(Console.ReadLine(), out lado))
                            {
                                areaCuadrado = CalculadoraDeArea.CalcularAreaCuadrado(lado);
                                Console.WriteLine("El area del cuadrado es {0} cm cuadrados.", areaCuadrado);
                            }
                            break;
                        case 2:
                            Console.WriteLine("Ingrese la base del triangulo: ");
                            if (double.TryParse(Console.ReadLine(), out lado))
                            {
                                Console.WriteLine("Ingrese la altura del triangulo: ");
                                if (double.TryParse(Console.ReadLine(), out altura))
                                {
                                    areaTriangulo = CalculadoraDeArea.CalcularAreaTriangulo(lado, altura);
                                    Console.WriteLine("El area del triangulo es {0} cm cuadrados.", areaTriangulo);
                                }
                            }
                            break;
                        case 3:
                            Console.WriteLine("Ingrese el radio del circulo: ");
                            if (double.TryParse(Console.ReadLine(), out radio))
                            {
                                areaCirculo = CalculadoraDeArea.CalcularAreaCirculo(radio);
                                Console.WriteLine("El area del circulo es {0} cm cuadrados.", areaCirculo);
                            }
                            break;
                    }
                    Console.WriteLine("Desea salir? (s/n)\n");
                    char.TryParse(Console.ReadLine(), out exit);
                }
            } while (exit == 'n');
            
            Console.ReadKey();
        }
    }
}
