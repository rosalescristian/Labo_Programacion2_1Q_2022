using System;

namespace Ejercicio_I01
{
    public class Moto:VehiculoTerrestre
    {
        private short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color,
                short cilindrada)
                : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.CantidadRuedas = cantidadRuedas;
            this.CantidadPuertas = cantidadPuertas;
            this.Color = color;
            this.Cilindrada = cilindrada;
        }

        public short Cilindrada
        {
            get { return this.cilindrada; }
            set { this.cilindrada = value; }
        }

    }
}
