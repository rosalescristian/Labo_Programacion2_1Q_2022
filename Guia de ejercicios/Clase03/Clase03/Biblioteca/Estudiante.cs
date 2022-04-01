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
        private Random random;
        #endregion

        /// <summary>
        /// Constructor Estatico - Inicializa Random
        /// </summary>
        public Estudiante()
        {
            this.random = new Random();
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
            double notaFinal = 0;
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
            sb.Append("Nombre: ");
            sb.AppendLine(this.nombre);
            sb.Append("Apellido: ");
            sb.Append("Legajo: ");
            sb.AppendLine(this.legajo);
            sb.AppendFormat("Nota Parcial 1: {0}", notaPrimerParcial);
            sb.AppendFormat("Nota Parcial 2: {0}", notaSegundoParcial);
            sb.AppendFormat("Promedio: {0}", CalcularPromedio());
            sb.AppendFormat("Nota Final: {0}",CalcularNotaFinal());

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

