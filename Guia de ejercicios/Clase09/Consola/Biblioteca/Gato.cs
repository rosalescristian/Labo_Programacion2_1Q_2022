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
    }
}
