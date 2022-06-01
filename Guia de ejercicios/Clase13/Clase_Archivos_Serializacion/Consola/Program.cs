using System;
using GestorDeArchivos;
using static System.Environment; // forma de incluir una clase que despues es parte del scope del archivo
// using static System.Console; // Tb podriamos hacer esto con Console y no incluirlo en las lineas de codigo antes del WriteLine por ejemplo
using System.IO;
using System.Text;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = GetFolderPath(SpecialFolder.Desktop) + @"/Archivos/MiArchivo.txt";
            
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Habia una vez una vaca");
            sb.AppendLine("en la quebrada de humahuaca");
            sb.AppendLine("Maria Elena Walsh");

            try
            {
                //ManejadorArchivosDeTexto.Guardar(path, sb.ToString(),true);
                ManejadorArchivosDeTexto.Guardar(path, sb.ToString(),false);

                Console.WriteLine(ManejadorArchivosDeTexto.Leer(path));
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
