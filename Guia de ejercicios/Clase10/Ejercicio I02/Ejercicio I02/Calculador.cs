using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02
{
    public static class Calculador
    {
        public static int Calcular(int valorUno, int valorDos)
        {
            int cociente;
            try
            {
                cociente = valorUno / valorDos;
            }
            catch (DivideByZeroException)
            {
                cociente = int.MinValue;
                Console.WriteLine("ERROR! No se puede dividir por cero");
            }
            return cociente;


        }

    }
}
