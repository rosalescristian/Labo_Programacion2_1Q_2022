namespace Consola
{
    internal class Program
    {
        public static int Comparar(int a, int b)
        {
            return b - a;
        }
        static void Main(string [] args)
        {
​
            #region Ordenar Listas
​
            List<int> list = new List<int>()
            {
                4,78,2,54,36,5
            };
​
​
            Console.WriteLine("Muestra en el orden que fue cargada");
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
​
            //orden ascendete
            list.Sort();
​
            Console.WriteLine("------------");
            Console.WriteLine("muestro lista en orden ascendente");
​
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
​
​
            list.Sort(Comparar);
​
            Console.WriteLine("------------");
            Console.WriteLine("muestro lista en orden descendente");
​
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            #endregion
​
            #region Stack
​
            Stack<char> palabras = new Stack<char>();
​
            palabras.Push('H');
            palabras.Push('O');
            palabras.Push('L');
            palabras.Push('A');
            palabras.Push(' ');
            palabras.Push('M');
            palabras.Push('U');
            palabras.Push('N');
            palabras.Push('D');
            palabras.Push('O');
​
            palabras.Pop();
            Console.WriteLine(  palabras.Peek());
​
            foreach (char letra in palabras)
            {
                Console.WriteLine(letra);
            }
            Console.ReadKey();
​
            #endregion
        
​
            #region Queue
​
            Queue<Persona> colaDeAtención = new Queue<Persona>();
​
            colaDeAtención.Enqueue(new Persona("Roberto"));
            colaDeAtención.Enqueue(new Persona("Juan"));
            colaDeAtención.Enqueue(new Persona("Agustin"));
            colaDeAtención.Enqueue(new Persona("Soledad"));
​
            Console.WriteLine("Muestro en orden FIFO");
            foreach (Persona p in colaDeAtención)
            {
                    Console.WriteLine(p.nombre);
            }
            Console.WriteLine("---------------");
​
            Console.WriteLine(colaDeAtención.Peek().nombre);
            Console.WriteLine(colaDeAtención.Peek().nombre);
​
            Console.WriteLine("Atendiendo");
            while (colaDeAtención.Count > 0)
            {
                Console.WriteLine($"Antendiendo a: {colaDeAtención.Dequeue().nombre}");
                Thread.Sleep(2000);
            }
​
            Console.ReadKey();
            #endregion
​
​
            #region Dictionary
​
            Dictionary<string, string> comidasLatinomaericanas = new Dictionary<string, string>();
​
            comidasLatinomaericanas.Add("taco", "Mexico");
            comidasLatinomaericanas.Add("mole poblano", "Mexico");
            comidasLatinomaericanas.Add("ceviche", "Peru");
            comidasLatinomaericanas.Add("causa limeña", "Peru");
            comidasLatinomaericanas.Add("choripan", "Argentina");
            comidasLatinomaericanas.Add("empanadas", "Argentina");
​
            foreach (KeyValuePair<string, string> item in comidasLatinomaericanas)
            {
                if (item.Value == "Argentina")
                {
                    Console.WriteLine($"El plato {item.Key} pertenece a {item.Value}");
                }
            }
​
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Recorro las Keys");
            foreach (string item in comidasLatinomaericanas.Keys)
            {
                Console.WriteLine(item);
            }
​
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Recorro los Values");
            foreach (string item in comidasLatinomaericanas.Values)
            {
                Console.WriteLine(item);
            }
​
            Console.WriteLine("-------------------");
            Console.WriteLine("indexacion en base a la key");
            Console.WriteLine($"mole pertenece a: {comidasLatinomaericanas ["mole poblano"]}");
​
            Console.WriteLine($"contiene empandas?:{comidasLatinomaericanas.ContainsKey("empenadas")}");
            Console.WriteLine($"contiene Argentina?:{comidasLatinomaericanas.ContainsValue("Argentina")}");
​
            Console.ReadKey();
​
            #endregion
​
​
            #region List
​
            List<string> mascotas = new List<string>();
​
            mascotas.Add("Firulais");
            mascotas.Add("Salem");
            mascotas.Add("Bola de nieve");
            mascotas.Add("Gaturro");
​
            Console.WriteLine($"la mascota de la posicion 3 es: {mascotas [3]}");
​
            Console.WriteLine("recorro con foreach");
​
            foreach (string item in mascotas)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("recorro con for");
​
            for (int i = 0; i < mascotas.Count; i++)
            {
                Console.WriteLine(mascotas [i]);
            }
​
            mascotas.Insert(1, "Pepe");
​
            Console.WriteLine("recorro con foreach despues de insert");
​
            foreach (string item in mascotas)
            {
                Console.WriteLine(item);
            }
​
            Console.WriteLine($" la posicion de Salem es: {mascotas.IndexOf("Salem")}");
​
            mascotas.Remove("Salem");
​
            mascotas.RemoveAt(2);
​
            Console.ReadKey();
            #endregion
​
            #region ArrayList - NO GENERICA - Esta no la usamos
​
            ArrayList arrayList = new ArrayList();
            arrayList.Add(15);
            arrayList.Add(new Persona("Esteban"));
            arrayList.Add(false);
​
            #endregion
            Console.WriteLine("Hello World!");
        }
    }
    class Persona
    {
        public string nombre;
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }
    }
}