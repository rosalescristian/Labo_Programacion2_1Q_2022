using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public enum Diagnostico
    {
        Curado, Gripe, Covid
    }
    public class Paciente : Persona
    {
        private Diagnostico diagnostico;

        public Paciente(string nombre, string apellido, DateTime fecha,string barrio)
            :base(nombre, apellido, fecha, barrio)
        {
            
        }

        public Diagnostico Diagnostico
        {
            get
            {
                return diagnostico;
            }
            set
            {
                diagnostico = value;
            }
        }

        internal override string FichaExtra()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Reside en {this.barrioResidencia}");
            sb.AppendLine($"{this.Diagnostico}");

            return sb.ToString();
        }
    }
}
