using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01
{
    public class Automovil:VehiculoTerrestre
    {
        private int cantidadPasajeros;
        private short cantidadMarchas;

        public Automovil():base()
        {
            //Invoca a la base
        }
        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color,
                short cantidadMarchas, int cantidadPasajeros)
                : base(cantidadRuedas, cantidadPuertas, color)
        {
            //Solo inicializamos los atributos propios de la clase, los otros son heredados
            this.CantidadMarchas = cantidadMarchas;
            this.CantidadPasajeros = cantidadPasajeros;
        }
    
        public int CantidadPasajeros
        {
            get { return this.cantidadPasajeros; }
            set { this.cantidadPasajeros = value; }
        }

        public short CantidadMarchas
        {
            get { return this.cantidadMarchas; }
            set { this.cantidadMarchas = value; }
        }


    }
}
