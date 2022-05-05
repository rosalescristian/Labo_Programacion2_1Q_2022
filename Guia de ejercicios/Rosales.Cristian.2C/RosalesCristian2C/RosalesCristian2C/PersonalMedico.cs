using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PersonalMedico : Persona
    {
        private List<Consulta> consultas;
        private bool esRecidente;

        /// <summary>
        /// Constructor con Parametros, se alimenta de la clase base
        /// </summary>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="nacimiento"></param>
        /// <param name="consultas"></param>
        /// <param name="esRecidente"></param>
        public PersonalMedico(string nombre, string apellido, 
                            DateTime nacimiento, bool esRecidente)
                            : base(nombre, apellido, nacimiento)
        {
            this.consultas = new List<Consulta>();
            this.esRecidente = esRecidente;
        }

        /// <summary>
        /// Overrride FichaExtra
        /// </summary>
        /// <returns>STRING con Datos del Medico y su historial de consultas</returns>
        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(String.Format("¿Finalizo Residencia? {0}", 
                            this.esRecidente ? "SI" : "NO"));
            sb.AppendLine($"ATENCIONES: ");
            foreach(Consulta consulta in consultas)
            {
                sb.AppendLine($"{consulta.ToString()}");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Operador +
        /// </summary>
        /// <param name="doctor"></param>
        /// <param name="paciente"></param>
        /// <returns></returns>
        public static bool operator +(PersonalMedico doctor, Paciente paciente)
        {
            if(doctor is not null && paciente is not null)
            {
                Consulta consultaAux = new Consulta(DateTime.Now, paciente);
                doctor.consultas.Add(consultaAux);
                return true;
            }
            return false;
        }

    }
}
