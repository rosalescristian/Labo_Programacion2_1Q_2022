using System;

namespace Biblioteca
{
    public abstract class Sobrescrito
    {
        protected string miAtributo;

        public Sobrescrito()
        {
            this.miAtributo = "Probar abstractos";
        }
        
        public abstract string MiPropiedad
        {
            get;
        }

        public abstract string MiMetodo();

        public override string ToString()
        {
            return $"Este es mi metodo ToString sobrescrito!";
        }

        public static bool operator ==(Sobrescrito a, Sobrescrito b)
        {
            return a == b;
        }

        public static bool operator !=(Sobrescrito a, Sobrescrito b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            Sobrescrito sobrescrito = obj as Sobrescrito;
            return sobrescrito is not null && this == sobrescrito;
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }


    }
}
