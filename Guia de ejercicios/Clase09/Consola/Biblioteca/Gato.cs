using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Gato : Animal
    {
        public override string EmitirSonido()//Se usa OVERRIDE para cambiar el metodo de la clase base (Metodo Sobrescrito)
        {
            return "Miau miau";
        }

        public new string Pensar()
        {
            return "Estoy pensando en dominar el mundo...";
        }

        public static bool operator ==(Gato g1, Gato g2)
        {
            return g1 is not null && g2 is not null && g1.nombre == g2.nombre;
        }

        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }

    }
}
