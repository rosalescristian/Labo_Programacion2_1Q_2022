using System;
using GestorDeArchivos;
using static System.Environment; // forma de incluir una clase que despues es parte del scope del archivo
// using static System.Console; // Tb podriamos hacer esto con Console y no incluirlo en las lineas de codigo antes del WriteLine por ejemplo
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CON UN ARCHIVO DE TXT
            //string path = @"D:\Cosas\UTN FRA\2022\Laboratorio y Programacion\Labo_Programacion2_1Q_2022\Guia de ejercicios\Clase13\Clase_Archivos_Serializacion\MiArchivo.txt";

            //StringBuilder sb = new StringBuilder();
            //sb.AppendLine("Habia una vez una vaca");
            //sb.AppendLine("en la quebrada de humahuaca");
            //sb.AppendLine("Maria Elena Walsh");

            //try
            //{
            //    //ManejadorArchivosDeTexto.Guardar(path, sb.ToString(),true);
            //    ManejadorArchivosDeTexto.Guardar(path, sb.ToString(),false);

            //    Console.WriteLine(ManejadorArchivosDeTexto.Leer(path));
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}

            //Console.ReadKey();

            //CON UN ARCHIVO XML
            //string path = GetFolderPath(SpecialFolder.Desktop) + @"/Archivos/Alumno.xml";
            //string path = @"D:\Cosas\UTN FRA\2022\Laboratorio y Programacion\Labo_Programacion2_1Q_2022\Guia de ejercicios\Clase13\Clase_Archivos_Serializacion\Alumno.xml";
            //try
            //{
            //    Alumno alumno = new Alumno()
            //    {
            //        Nombre = "Pepe Rodriguez",
            //        Edad = 54
            //    };//Forma de instanciar los datos del objeto

            //    Serializadora.GuardarXML(alumno, path);
            //    Console.WriteLine("OK");
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}

            //Console.ReadKey();

            //string path = @"D:\Cosas\UTN FRA\2022\Laboratorio y Programacion\Labo_Programacion2_1Q_2022\Guia de ejercicios\Clase13\Clase_Archivos_Serializacion\ListaAlumnos.xml";
            
            List<Alumno> listaDeAlumnos = new List<Alumno>()
            {
                new Alumno()
                {
                    Nombre = "Carlos Gomez",
                    Edad = 54
                },
                new Alumno()
                {
                    Nombre = "Cristian Rosales",
                    Edad = 35
                }
            };
            
            //try//VERSION ORIGINAL
            //{
            //    Serializadora<List<Alumno>>.GuardarXML(listaDeAlumnos, path);
            //    Console.ReadKey();
            //    List<Alumno> lista = Serializadora<List<Alumno>>.LeerXML(path);

            //    foreach (Alumno alumno in lista)
            //    {
            //        Console.WriteLine(alumno.Nombre);
            //        Console.WriteLine(alumno.Edad);
            //    }

            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}

            try//USANDO GENERICS
            {
                //SerializadoraXML<List<Alumno>>.GuardarXML(listaDeAlumnos, path);
                //Console.ReadKey();
                //List<T> lista = SerializadoraXML<List<Alumno>>.LeerXML(path);

                //foreach(Alumno alumno in lista)
                //{
                //    Console.WriteLine(alumno.Nombre);
                //    Console.WriteLine(alumno.Edad);
                //} // NO FUNCIONA, NO LO VOLVIMOS A VER. PASAMOS A JSON
                //Console.WriteLine("OK GENERICS");

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            string path = @"D:\Cosas\UTN FRA\2022\Laboratorio y Programacion\Labo_Programacion2_1Q_2022\Guia de ejercicios\Clase13\Clase_Archivos_Serializacion\ListaAlmunosJSON.JSON";
            // USANDO JSON
            try
            {
                SerializadoraJSON<List<Alumno>> serializadora = new SerializadoraJSON<List<Alumno>>();
                serializadora.GuardarJSON(listaDeAlumnos, path);
                List<Alumno> listaDeserializada = serializadora.LeerJSON(path);
                Console.WriteLine("OK JSON");
                Console.ReadKey();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
