using System;
using System.Collections;
using System.Collections.Generic;

namespace Clase06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Main con Regiones, OJO

            #region List - GENERICA

            List<string> mascotas = new List<string>();
            mascotas.Add("Firulais");
            mascotas.Add("Salem");
            mascotas.Add("Bola de nieve");
            mascotas.Add("Gaturro");

            Console.WriteLine($"La mnascota de la posicion 3 es: {mascotas[3]}");
            
            Console.WriteLine("Recorro con ForEach");
            foreach(string mascota in mascotas)
            {
                Console.WriteLine(mascota);
            }

            #endregion

            #region ArrayList - NO GENERICA - Esta no la usamos
            //Estas colecciones pueden recibir cualquier tipo de dato, x eso tiene pesona y booleano
            ArrayList arrayList = new ArrayList();
            arrayList.Add(15);
            arrayList.Add(new Persona("Esteban"));
            arrayList.Add(false);

            #endregion



            Console.WriteLine("Hello World!");
        }
    }
}
