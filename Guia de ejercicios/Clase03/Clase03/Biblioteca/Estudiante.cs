using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estudiante
    {
        #region Atributos
        private string apellido;
        private string nombre;
        private string legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private Random random = new Random();
        #endregion

        /// <summary>
        /// Constructor Estatico - Inicializa Random
        /// </summary>
        public Estudiante()
        {
            this.random.Next();
        }

        /// <summary>
        /// Constructor - Inicializa los Atributos
        /// </summary>
        /// <param name="apellido">Apellido a ingresar del Estudiante</param>
        /// <param name="nombre">Nombre a ingresar del Estudiante</param>
        /// <param name="legajo">Legajo a ingresar del Estudiante</param>
        public Estudiante(string apellido, string nombre, string legajo)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.legajo = legajo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double CalcularNotaFinal()
        {
            double notaFinal = -1;
            if(this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                notaFinal = random.Next(6, 11);
            }
            return notaFinal;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial+this.notaSegundoParcial)/2;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="alumno"></param>
        /// <returns></returns>
        public string MostrarEstudiante()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Nombre: {0}, Apellido: {1}, Legajo: {2}", this.nombre,this.apellido,this.legajo);
            sb.Append($"{Environment.NewLine}");
            sb.AppendFormat("Nota Parcial 1: {0}. Nota Parcial 2: {1}", this.notaPrimerParcial, this.notaSegundoParcial);
            sb.Append($"{Environment.NewLine}");
            sb.AppendFormat("Promedio: {0}", CalcularPromedio());
            sb.Append($"{Environment.NewLine}");
            double notaFinal = CalcularNotaFinal();
            if (notaFinal != -1)
            {
                sb.AppendFormat("Nota Final: {0}",notaFinal);
            }
            else
            {
                sb.AppendFormat("Alumno Desaprobado.");
            }

            return sb.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nota"></param>
        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="nota"></param>
        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

    }
}

