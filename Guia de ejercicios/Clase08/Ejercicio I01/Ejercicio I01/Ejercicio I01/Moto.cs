using System;

namespace Ejercicio_I01
{
    public class Moto:VehiculoTerrestre
    {
        private short cilindrada;

        public Moto() : base()
        {
            //Invoca a la base
        }
        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color,
                short cilindrada)
                : base(cantidadRuedas, cantidadPuertas, color)
        {
            //solo se inicializan los atributos propios de la clase
            this.Cilindrada = cilindrada;
        }

        public short Cilindrada
        {
            get { return this.cilindrada; }
            set { this.cilindrada = value; }
        }

    }
}
