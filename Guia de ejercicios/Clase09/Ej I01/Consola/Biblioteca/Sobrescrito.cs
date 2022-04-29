using System;

namespace Biblioteca
{
    public class Sobrescrito
    {
        //public Sobrescrito()
        //{
        //    this.miAtributo = "Probar abstractos";
        //}

        public override string ToString()
        {
            return $"Este es mi metodo ToString sobrescrito!";
        }

        //public static bool operator ==(object a, object b)
        //{
        //    return a == b;
        //}

        //public static bool operator !=(object a, object b)
        //{
        //    return !(a == b);
        //}

        public override bool Equals(object obj)
        {
            return obj is not null && base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return 1142510181;
        }


    }
}
