using System;


namespace Biblioteca
{
    public static class FizzBuzz
    {
        public static string Dividir(this Int32 i)
        {
            string retorno = string.Empty; //Esta fue la inicializacion de Esteban
            
            if (i % 3 == 0)
            {
                retorno += "Fizz";
            }
            if(i%5 == 0)
            {
                retorno += "Buzz";
            }
            if (string.IsNullOrEmpty(retorno))
            {
                retorno = i.ToString(); 
            }

            return retorno;
        }
    }
}
