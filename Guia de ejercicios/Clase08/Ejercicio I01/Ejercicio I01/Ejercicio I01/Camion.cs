using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01
{
    
    public class Camion: VehiculoTerrestre
    {
        private short cantidadMarchas;
        private int pesoCarga;

        public Camion() : base()
        {
            //Invoca a la base
        }

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, 
                        short cantidadMarchas, int pesoCarga) 
                        :base(cantidadRuedas, cantidadPuertas, color)
        {
            //solo se inicializan los atributos propios de la clase
            this.CantidadMarchas = cantidadMarchas;
            this.PesoCarga = pesoCarga;
        }

        public short CantidadMarchas
        {
            get { return this.cantidadMarchas; }
            set { this.cantidadMarchas = value; }
        }
        
        public int PesoCarga
        {
            get { return this.pesoCarga; }
            set { this.pesoCarga = value; }
        }


    }
}
