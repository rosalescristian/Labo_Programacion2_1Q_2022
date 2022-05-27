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
                Persona auxPersona = consulta.Paciente;
                Paciente auxPaciente = consulta.Paciente;
                sb.Append($"{auxPersona.FichaPersonal(auxPersona)}");
                sb.Append($"{auxPaciente.FichaExtra()}");
                sb.AppendLine("");
            }
            return sb.ToString();
        }

        /// <summary>
        /// Operador +
        /// </summary>
        /// <param name="doctor">Doctor al que se le va a agregar la consulta en su lista</param>
        /// <param name="paciente">Paciente que va a sumarse a la consulta del doc</param>
        /// <returns>TRUE si se pudo agregar, si no FALSE</returns>
        public static bool operator +(PersonalMedico doctor, Paciente paciente)
        {
            if(doctor is not null && paciente is not null)
            {
                Consulta auxConsulta = new Consulta(DateTime.Now, paciente);
                doctor.consultas.Add(auxConsulta);
                return true;
            }
            return false;
        }

    }
}
