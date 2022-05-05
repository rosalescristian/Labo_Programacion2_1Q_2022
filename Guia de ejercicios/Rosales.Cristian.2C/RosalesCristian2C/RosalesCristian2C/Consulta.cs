using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Consulta
    {
        private DateTime fecha;
        private Paciente paciente;

        /// <summary>
        /// Prop Fecha. ReadOnly
        /// </summary>
        public DateTime Fecha
        {
            get
            {
                return this.Fecha;
            }
        }

        /// <summary>
        /// Prop Paciente. ReadOnly
        /// </summary>
        public Paciente Paciente
        {
            get
            {
                return this.paciente;
            }
        }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="fecha"></param>
        /// <param name="paciente"></param>
        public Consulta(DateTime fecha, Paciente paciente)
        {
            this.fecha = fecha;
            this.paciente = paciente;
        }

        /// <summary>
        /// Override de ToString() 
        /// </summary>
        /// <returns>Devuelve FECHA + PACIENTE (NombreCompleto)</returns>
        public override string ToString()
        {
            return $"{this.fecha} se ha atendido a {this.paciente}";
        }

    }
}
