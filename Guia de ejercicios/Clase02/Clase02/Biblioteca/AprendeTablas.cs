using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class AprendeTablas
    {
        /// <summary>
        /// Devuelve la tabla de multiplicar de un nro especifico
        /// </summary>
        /// <param name="numero">Es el nro con el cual se va a mostrar la tabla de multiplicar</param>
        /// <returns>Devuelve la tabla de multiplicar para el nro ingresado</returns>
        public static string TablasDeMultiplicar(int numero)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int producto = 0;

            stringBuilder.Append($"{Environment.NewLine}");
            stringBuilder.AppendFormat("Tabla de Multiplicar del numero {0}: ", numero);
            stringBuilder.Append($"{Environment.NewLine}");
            for (int i = 0; i<11; i++)
            {
                producto = numero * i;
                stringBuilder.Append(numero);
                stringBuilder.Append(" x ");
                stringBuilder.Append(i);
                stringBuilder.Append(" = ");
                stringBuilder.Append(producto);
                stringBuilder.Append($"{Environment.NewLine}");
            }
            return stringBuilder.ToString();
        }
    }
}
