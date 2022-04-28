using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01
{
    public enum Colores 
    { 
        Rojo, Blanco, Azul, Gris, Negro 
    };
    
    public class VehiculoTerrestre
    {
        private short cantidadRuedas;
        private short cantidadPuertas;
        private Colores color;
        //private short cantidadMarchas; Estos dos atributos comentados, es xq no estan en todas las Clases
        //private int pesoCarga; Estos dos atributos comentados, es xq no estan en todas las Clases

        public VehiculoTerrestre()
        {
            //siguen existiendo los constructores por defecto
        }

        public VehiculoTerrestre(short cantidadRuedas, short cantidadPuertas, Colores color)//, short cantidadMarchas, int pesoCarga) X el comentario de arriba (VER ATRIBUTOS)
        {
            this.CantidadRuedas = cantidadRuedas;
            this.CantidadPuertas = cantidadPuertas;
            this.Color = color;
            //this.CantidadMarchas = cantidadMarchas;
            //this.PesoCarga = pesoCarga;
        }

        public short CantidadRuedas
        {
            get { return this.cantidadRuedas; }
            set { cantidadRuedas = value; }
        }

        public short CantidadPuertas
        {
            get { return this.cantidadPuertas; }
            set { this.cantidadPuertas = value; }
        }

        public Colores Color
        {
            get { return this.color; }
            set { this.color = value; } 
        }

        //public short CantidadMarchas
        //{
        //    get { return this.cantidadMarchas; }
        //    set { this.cantidadMarchas = value; }
        //}

        //public int PesoCarga
        //{
        //    get { return this.pesoCarga; }
        //    set { pesoCarga = value; }
        //}

        public string MostrarVehiculo(Automovil v)
        {
            return $"{v.CantidadPuertas}";
        }
    }
}
