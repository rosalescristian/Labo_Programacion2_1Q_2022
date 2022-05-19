using System;

namespace Biblioteca
{
    public static class StringExtendido
    {

        public static int ContarPalabras(this String s)
        {
            //Devuelve un array lleno con cada split que hace, y el Lenght, nos dice el largo del array, en este caso el largo del string. Xq estamos separando por espacio vacio ' '
            return s.Split(' ').Length;
        }
    }
}
