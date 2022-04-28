using System;

namespace Biblioteca
{
    public class Animal
    {
        public virtual string EmitirSonido()//VIRTUAL nos deja cambiar el comportamiento del metodo
        {
            return "Emitiendo sonido...";
        }
    }
}
