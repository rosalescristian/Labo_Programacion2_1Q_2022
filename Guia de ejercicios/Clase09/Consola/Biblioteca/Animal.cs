using System;

namespace Biblioteca
{
    public class Animal
    {
        public string nombre;

        public Animal()
        {

        }
        public Animal(string nombre)
        {
            this.nombre = nombre;   
        }

        public virtual string EmitirSonido()//VIRTUAL nos deja cambiar el comportamiento del metodo
        {
            return "Emitiendo sonido...";
        }

        public string Pensar()
        {
            return "Pensando...";
        }
        public static bool operator ==(Animal g1, Animal g2)
        {
            return g1 is not null && g2 is not null && g1.nombre == g2.nombre;
        }

        public static bool operator !=(Animal g1, Animal g2)
        {
            return !(g1 == g2);
        }
    }
}
