using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        public string diagnostico;

        /// <summary>
        /// Prop Diagnostico
        /// </summary>
        public string Diagnostico
        {
            get
            {
                return this.diagnostico;
            }
            set
            {
                this.diagnostico = value;
            }
        }

        /// <summary>
        /// Override de Ficha Extra imprime la ficha del Paciente con su barrio y diagnostico
        /// </summary>
        /// <returns></returns>
        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"Reside en: {this.barrioResidencia}");
            sb.AppendLine($"{this.Diagnostico}");
            
            return sb.ToString();
        }

        /// <summary>
        /// Constructor con parametros, usa los de la clase BASE
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacimiento"></param>
        /// <param name="barrioResidencia"></param>
        public Paciente(string nombre, string apellido, DateTime nacimiento, 
                        string barrioResidencia) 
                        : base(nombre, apellido, nacimiento, barrioResidencia)
        {

        }
    }
}
