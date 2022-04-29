using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PerroAbs : AnimalAbstracta
    {
        public PerroAbs(string nombre):base(nombre)
        {

        }

        public override string JuegoFavorito
        {
            get
            {
                return "pelota";
            }
        }

        public override string EmitirSonido()
        {
            return $"Woof Gau Abstracto";
        }
    }
}
