using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Perro : Animal
    {
        public Perro():base()
        {

        }
        public Perro(string nombre) : base(nombre)
        {

        }

        public override string EmitirSonido()//Se usa OVERRIDE para cambiar el metodo de la clase base (Metodo Sobrescrito)
        {
            return "Woof Woof";
        }

        public new string Pensar()
        {
            return "Los perros no piensan...";
        }
    }
}
