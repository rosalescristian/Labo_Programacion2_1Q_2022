using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class AnimalAbstracta
    {
        public string nombre;

        public AnimalAbstracta(string nombre)// El constructor se mantiene porq puede tener atributos
        {
            this.nombre = nombre;
        }

        public abstract string JuegoFavorito { get; }

        public abstract string EmitirSonido();

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
