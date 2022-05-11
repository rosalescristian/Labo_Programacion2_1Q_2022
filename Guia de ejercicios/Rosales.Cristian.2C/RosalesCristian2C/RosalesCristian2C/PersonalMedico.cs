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
        private bool esResidente;

        /// <summary>
        /// Constructor con Parametros, se alimenta de la clase base
        /// </summary>
        /// <param name="apellido"></param>
        /// <param name="nombre"></param>
        /// <param name="nacimiento"></param>
        /// <param name="consultas"></param>
        /// <param name="esResidente"></param>
        public PersonalMedico(string nombre, string apellido, 
                            DateTime nacimiento, bool esResidente)
                            : base(nombre, apellido, nacimiento)
        {
            this.consultas = new List<Consulta>();
            this.esResidente = esResidente;
        }

        /// <summary>
        /// Overrride FichaExtra
        /// </summary>
        /// <returns>STRING con Datos del Medico y su historial de consultas</returns>
        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(String.Format("¿Finalizo Residencia? {0}", 
                            this.esResidente ? "SI" : "NO"));
            sb.AppendLine($"ATENCIONES: ");
            foreach(Consulta consulta in consultas)
            {
                Persona auxPersona = (Persona)consulta.Paciente;
                Paciente auxPaciente = consulta.Paciente;
                sb.Append($"{auxPersona.FichaPersonal(auxPersona)}");
                sb.Append($"{auxPaciente.FichaExtra()}");
                sb.AppendLine("");
                //sb.Append($"{consulta.ToString()}");
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
