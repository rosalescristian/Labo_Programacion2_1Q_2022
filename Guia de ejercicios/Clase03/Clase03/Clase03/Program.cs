using System;
using Biblioteca;

namespace Clase03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 03: 31/03/2022 - Ejercicio I01";

            Cuenta nuevaCuenta = new Cuenta("Armando Puertas", 13579);
            Console.WriteLine(Cuenta.MostrarDatosDeLaCuenta(nuevaCuenta));
            
            nuevaCuenta.IngresarDinero(10000);
            Console.WriteLine(Cuenta.MostrarDatosDeLaCuenta(nuevaCuenta));
            
            nuevaCuenta.IngresarDinero(-7500);
            Console.WriteLine(Cuenta.MostrarDatosDeLaCuenta(nuevaCuenta));
            
            nuevaCuenta.RetirarDinero(-7500);
            Console.WriteLine(Cuenta.MostrarDatosDeLaCuenta(nuevaCuenta));

            nuevaCuenta.IngresarDinero(3250);
            Console.WriteLine(Cuenta.MostrarDatosDeLaCuenta(nuevaCuenta));

            nuevaCuenta.RetirarDinero(-50000);
            Console.WriteLine(Cuenta.MostrarDatosDeLaCuenta(nuevaCuenta));

            Console.ReadKey();
        }
    }
}
