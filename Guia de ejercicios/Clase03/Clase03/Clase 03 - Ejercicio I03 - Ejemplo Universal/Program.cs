using System;
using Biblioteca;
using System.Text;

namespace Clase_03___Ejercicio_I03___Ejemplo_Universal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 03: 31/03/2022 - Ejercicio I03 - Ejemplo Universal";

            Estudiante alumnoUno = new Estudiante("Quito", "Esteban", "122864");
            Estudiante alumnoDos = new Estudiante("Puertas", "Armando", "122865");
            Estudiante alumnoTres = new Estudiante("Rito", "Chespi", "122866");
            StringBuilder mostrarAlumnos = new StringBuilder();
            
            alumnoUno.SetNotaPrimerParcial(8);
            alumnoUno.SetNotaSegundoParcial(10);

            alumnoDos.SetNotaPrimerParcial(7);
            alumnoDos.SetNotaSegundoParcial(6);

            alumnoTres.SetNotaPrimerParcial(3);
            alumnoTres.SetNotaSegundoParcial(5);

            //Console.WriteLine(alumnoUno.MostrarEstudiante(),"");
            mostrarAlumnos.AppendLine(alumnoUno.MostrarEstudiante());
            mostrarAlumnos.Append($"{Environment.NewLine}");
            mostrarAlumnos.AppendLine(alumnoDos.MostrarEstudiante());
            mostrarAlumnos.Append($"{Environment.NewLine}");
            mostrarAlumnos.AppendLine(alumnoTres.MostrarEstudiante());
            mostrarAlumnos.Append($"{Environment.NewLine}");
            Console.WriteLine(mostrarAlumnos.ToString());

            Console.ReadKey();
        }
    }
}
