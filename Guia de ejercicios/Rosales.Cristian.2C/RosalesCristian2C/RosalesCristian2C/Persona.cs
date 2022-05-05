using System;
using System.Text;

namespace Entidades
{
    public abstract class Persona
    {
        protected string apellido;
        protected string nombre;
        protected string barrioRecidencia;
        protected DateTime nacimiento;

        /// <summary>
        /// Constructor con parametros. Incluye Barrio
        /// </summary>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="barrioRecidencia"></param>
        /// <param name="nacimiento"></param>
        protected Persona(string nombre, string apellido, 
                            DateTime nacimiento, string barrioRecidencia)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.barrioRecidencia = barrioRecidencia;
            this.nacimiento = nacimiento;
        }

        /// <summary>
        /// Constructor con parametros. SIN Barrio
        /// </summary>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="barrioRecidencia"></param>
        /// <param name="nacimiento"></param>
        protected Persona(string nombre, string apellido, DateTime nacimiento)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.nacimiento = nacimiento;
        }

        /// <summary>
        /// Prop Edad. ReadOnly
        /// </summary>
        public int Edad
        {
            get
            {
                return DateTime.Today.AddTicks(-this.nacimiento.Ticks).Year - 1;
            }
        }

        /// <summary>
        /// Prop NombreCompleto. ReadOnly
        /// </summary>
        public string NombreCompleto
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(string.Format("{0}, {1}", this.apellido, this.nombre));
                return sb.ToString();
            }
        }

        /// <summary>
        /// Override de ToString
        /// </summary>
        /// <returns>Devuelve nombre completo con el formato Apellido, Nombre</returns>
        public override string ToString()
        {
            return this.NombreCompleto;
        }

        /// <summary>
        /// Devuelve todos los datos de la persona instanciada
        /// </summary>
        /// <param name="p">Persona a buscar sus datos</param>
        /// <returns>STRING </returns>
        public string FichaPersonal(Persona p)
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"{this.ToString()}");
            sb.AppendLine($"Edad: {this.Edad}");
            sb.AppendLine($"Barrio de Recidencia: {this.barrioRecidencia}");
            sb.AppendLine($"Fecha de Nacimiento: {this.nacimiento.ToString()}");

            return sb.ToString();
        }

        abstract internal string FichaExtra();



    }
}
