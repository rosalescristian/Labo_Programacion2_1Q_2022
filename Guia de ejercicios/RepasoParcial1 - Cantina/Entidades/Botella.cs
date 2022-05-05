using System;
using System.Text;

namespace Entidades
{
    public abstract class Botella
    {
        public enum Tipo { Vidrio, Plastico }
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        protected Botella(int capacidadML, int contenidoML, string marca)
        {
            if(capacidadML < contenidoML)
            {
                contenidoML = capacidadML;
            }
            this.capacidadML = capacidadML;
            this.Contenido = contenidoML;
            this.marca = marca;
        }

        public int CapacidadLitros
        {
            get
            {
                return this.capacidadML/1000;
            }
        }

        public int Contenido
        {
            get
            {
                return this.contenidoML;
            }
            set
            {
                this.contenidoML = value;  
            }
        }

        public float PorcentajeContenido
        {
            get
            {
                return (float)this.contenidoML/this.capacidadML;
            }
        }

        protected virtual string GenerarInforme()
        {
            StringBuilder sb =  new StringBuilder();

            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"Contenido disponible en ml: {this.Contenido}");
            sb.AppendLine($"Capacidad total en lts: {this.CapacidadLitros}");
            sb.AppendLine($"Porcentaje de Contenido ocupado: {this.PorcentajeContenido}");
            return sb.ToString();
        }

        public abstract int ServirMedida();

        public override string ToString()
        {
            return this.GenerarInforme(); ;
        }




    }
}
