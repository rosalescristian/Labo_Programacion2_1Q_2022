using System;
using System.Collections.Generic;

namespace Entidades
{
    public class Cliente: Persona
    {
        private int numero;
        private List<string> direcciones;
        private Random rand;

        public Cliente()
        {

        }
        public Cliente(string nombre, string apellido)
            :base(nombre, apellido)
        {
            this.rand = new Random();
            this.numero = rand.Next(100);
            this.direcciones = new List<string>()
            {
                $"Calle falsa{rand.Next(1000,4000)}",
                $"Calle falsa{rand.Next(1000,4000)}",
                $"Calle falsa{rand.Next(1000,4000)}"
            };
        }

        public int Numero { get => numero; set => numero = value; }
        public List<string> Direcciones { get => direcciones; set => direcciones = value; }
    }
}
