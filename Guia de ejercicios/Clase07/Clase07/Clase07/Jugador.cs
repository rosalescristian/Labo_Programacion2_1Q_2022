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
    internal class Jugador
    {
        //Esta comentado este Enumerado porque lo mudè fuera de la clase
        //public enum EColor
        //{
        //    Rojo, Azul, Verde
        //}

        private string nombre;
        private int partidosJugados;
        private int totalGoles;
        private EColor colorCamiseta;
        string[] equipos;

        public string this[int index]
        {
            get
            {
                return equipos[index];
            }
            set
            {
                equipos[index] = value;
            }
        }

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


        public Jugador(string nombre, int partidosJugados, int totalGoles)
        {
            this.nombre = nombre;
            this.partidosJugados = partidosJugados;
            this.totalGoles = totalGoles;
            this.equipos = new string[3];
            this.equipos[0]= "A";
            this.equipos[0]= "B";
            this.equipos[0]= "C";
        }
    }
}
