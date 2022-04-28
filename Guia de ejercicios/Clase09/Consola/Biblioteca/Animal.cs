using System;

namespace Biblioteca
{
    public class Animal
    {
        public string nombre;

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
    }
}
