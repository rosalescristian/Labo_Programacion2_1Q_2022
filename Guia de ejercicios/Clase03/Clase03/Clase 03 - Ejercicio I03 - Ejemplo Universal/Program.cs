using System;
using Biblioteca;

namespace Clase_03___Ejercicio_I03___Ejemplo_Universal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 03: 31/03/2022 - Ejercicio I03 - Ejemplo Universal";

            Estudiante alumnoUno = new Estudiante("Quito", "Esteban", "122864");

            alumnoUno.SetNotaPrimerParcial(7);
            alumnoUno.SetNotaSegundoParcial(10);

            Console.WriteLine(alumnoUno.MostrarEstudiante());
            //Estudiante alumnoDos = new Estudiante("Quito", "Esteban", "122864");
            //Estudiante alumnoTres = new Estudiante("Quito", "Esteban", "122864");



            Console.ReadKey();
        }
    }
}
