using System;

namespace PrimerPograma
{
    internal class  Program
    {               
        static void Main(string[] args)
        {
            Console.Title="Clase 01 - Programa 01 - 23/03/2022";

            //Math.Min()
            //Console.
            
            /*
             * Ctrl+Barra => Habilita el IntelliSence de nuevo
             * F2 => Renombrar
             * Shift+Alt+ArrowDown => Editar varias lineas juntas
             * Recordar la ventana de Inmediate Window
             * 
             * */
            
            int i = 0;
            i++;

            Console.WriteLine(i.ToString());

            /*if(CheckArray(args))
            {*/
                Console.WriteLine("Hello World!"/* + args[0]*/);
            //}
                
            Console.ReadKey();
        }

        static bool CheckArray(string [] args)
        {
            return args.Length > 0;
        }
    }
}
