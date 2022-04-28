using System;
using System.Collections.Generic; //este using es para poder usar Listas
using Ejercicio_I01;

namespace Clase08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 08: Herencia | Ejercicio I01: El viajar es un placer";

            VehiculoTerrestre vehiculo = new VehiculoTerrestre(3, 2, Colores.Rojo);
            VehiculoTerrestre camion = new Camion(vehiculo.CantidadRuedas, vehiculo.CantidadPuertas, vehiculo.Color, 6, 14000);
            VehiculoTerrestre auto = new Automovil(4, 5, Colores.Azul, 5, 5);
            //VehiculoTerrestre moto = new Moto(2, 0, Colores.Blanco, 250);

            VehiculoTerrestre.MostrarVehiculo(auto);


            Console.ReadKey();
        }
    }
}
