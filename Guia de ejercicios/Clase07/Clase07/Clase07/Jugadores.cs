using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase07
{
    public enum EColor
    {
        Rojo, Azul, Verde, Amarillo
    }
    public enum ENacionalidad
    {
        Argentina, Peru
    }
    internal class Jugadores
    {
        //public enum EColor
        //{
        //    Rojo, Azul, Verde
        //}

        private string nombre;
        private int partidosJugados;
        private int totalGoles;
        private EColor colorCamiseta;

        public EColor Color
        {
            get
            {
                return this.colorCamiseta;
            }
            set
            {
                this.colorCamiseta = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public int PartidosJugados
        {
            get 
            { 
                return this.partidosJugados; 
            }

            set
            {
                if (this.ValidarPartidos(value))
                {
                    this.partidosJugados = value;
                }
            }
        }

        public float PromedioDeGoles
        {
            get
            {
                return (float)this.totalGoles / this.partidosJugados;
            }
        }

        private bool ValidarPartidos(int partidosJugados)
        {
            return partidosJugados >= 0;
        }


        public Jugadores(string nombre, int partidosJugados, int totalGoles)
        {
            this.nombre = nombre;
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
        }
    }
}
