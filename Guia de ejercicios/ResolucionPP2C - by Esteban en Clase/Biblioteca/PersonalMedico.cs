using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public  class PersonalMedico :Persona
    {
        private List<Consulta> consultas;
        private bool esResidente;

        public PersonalMedico(string nombre, string apellido, DateTime fecha, bool esResidente)
            :base(nombre, apellido, fecha)
        {
            this.esResidente = esResidente;
            this.consultas = new List<Consulta>();
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Finalizó residencia: {0}{1}", this.esResidente ? "NO" : "SI", Environment.NewLine);
            sb.AppendLine("ATENCIONES");
            foreach (Consulta item in this.consultas)
            {
                sb.AppendLine(Persona.FichaPersonal(item.Paciente));
            }
            return sb.ToString();
        }
        public static Consulta operator +(PersonalMedico doctor, Paciente paciente)
        {
            Consulta consulta;
            if (doctor is not null && paciente is not null)
            {
                consulta = new Consulta(DateTime.Now, paciente);
                doctor.consultas.Add(consulta);
                return consulta;
            }
            throw new ArgumentException();
        }
    }
}
