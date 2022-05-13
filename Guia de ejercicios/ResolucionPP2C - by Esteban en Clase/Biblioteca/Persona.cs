using System;
using System.IO;
using System.Text;

namespace Biblioteca
{
    public abstract class Persona
    {
        protected string apellido;
        protected string nombre;
        protected string barrioResidencia;
        protected DateTime fechaNacimiento;

        public int Edad
        {
            get
            {
                return DateTime.Today.AddTicks(-this.fechaNacimiento.Ticks).Year - 1;
            }
        }
        public string NombreCompleto
        {
            get { return string.Format($"{this.nombre} {this.apellido}"); }
        }

        protected Persona( string nombre, string apellido, DateTime fechaNacimiento)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }
        protected Persona(string nombre, string apellido, DateTime fechaNacimiento, string barrioResidencia) : this(nombre, apellido, fechaNacimiento)
        {

            this.barrioResidencia = barrioResidencia;
        }


        public static string FichaPersonal(Persona p)
        {
            StringBuilder sb = new StringBuilder();
            if (p is not null)
            {
                sb.AppendLine(p.ToString());
                sb.AppendLine($"Edad {p.Edad}");
                sb.AppendLine(p.FichaExtra());
            }

            return sb.ToString();

        }
        public override string ToString()
        {
            return this.NombreCompleto;
        }
        abstract internal string FichaExtra();
    }
}
