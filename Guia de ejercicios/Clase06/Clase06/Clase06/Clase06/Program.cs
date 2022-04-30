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

            // Se ordenan en funcion de la Key
            #region Dictionary - GENERICA - (Key,Value)

            Dictionary<string, string> comidasLatinoamericanas = new Dictionary<string, string>();

            comidasLatinoamericanas.Add("taco", "Mexico");
            comidasLatinoamericanas.Add("mole poblano", "Mexico");
            comidasLatinoamericanas.Add("ceviche", "Peru");
            comidasLatinoamericanas.Add("causa limeña", "Peru");
            comidasLatinoamericanas.Add("choripan", "Argentina");

            Console.WriteLine("------------------------------");
            Console.WriteLine("Recorro el Key Value Pair");
            foreach (KeyValuePair<string,string> item in comidasLatinoamericanas)
            {
                Console.WriteLine($"El plato {item.Key} pertenece a {item.Value}");
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Recorro solo las Keys");
            foreach (string item in comidasLatinoamericanas.Keys)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Recorro solo los Values");
            foreach (string item in comidasLatinoamericanas.Values)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Indexazion en base a la key");
            Console.WriteLine($"Mole pertenece a: {comidasLatinoamericanas["mole poblano"]}");

            Console.WriteLine($"Contiene Empanadas? {comidasLatinoamericanas.ContainsKey("empanadas")}");
            Console.WriteLine($"Contiene Empanadas? {comidasLatinoamericanas.ContainsValue("Argentina")}");


            Console.ReadKey();

            #endregion

            //Usamos solo listas genericas en la cursada
            #region List - GENERICA

            Console.WriteLine("------------------------------");
            List<string> mascotas = new List<string>();
            mascotas.Add("Firulais");
            mascotas.Add("Salem");
            mascotas.Add("Bola de nieve");
            mascotas.Add("Gaturro");

            Console.WriteLine($"La mnascota de la posicion 3 es: {mascotas[3]}");

            Console.WriteLine("------------------------------");
            Console.WriteLine("Recorro con ForEach");
            foreach(string mascota in mascotas)
            {
                Console.WriteLine(mascota);
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("Recorro con For");
            for (int i = 0; i < mascotas.Count; i++)
            {
                Console.WriteLine(mascotas[i]);
            }

            Console.WriteLine("------------------------------");
            //Inserto con Inser en la posicion 1 y el anterior 1 se corre a la 2.
            mascotas.Insert(1, "Pepe");

            Console.WriteLine("Recorro con ForEach");
            foreach (string mascota in mascotas)
            {
                Console.WriteLine(mascota);
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine($"La posicion de salem es : { mascotas.IndexOf("Salem")}");

            mascotas.Remove("Salem");
            mascotas.RemoveAt(mascotas.Count - 1);//le pasas el index del elemento a borrar

            #endregion

            //Estas colecciones pueden recibir cualquier tipo de dato, x eso tiene pesona y booleano
            #region ArrayList - NO GENERICA - Esta no la usamos
            Console.WriteLine("------------------------------");
            ArrayList arrayList = new ArrayList();
            arrayList.Add(15);
            arrayList.Add(new Persona("Esteban"));
            arrayList.Add(false);
            Console.ReadKey();

            #endregion




            Console.ReadKey();
        }
    }
}
