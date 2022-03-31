using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class CalculosConFechas
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="diaNac"></param>
        /// <param name="mesNac"></param>
        /// <param name="anioNac"></param>
        /// <param name="diaActual"></param>
        /// <param name="mesActual"></param>
        /// <param name="anioActual"></param>
        /// <returns></returns>
        public static double CalcularDiferenciaDias(int diaNac, int mesNac, int anioNac, DateTime fechaActual)
        {
            //Anios 365.25 dias (asi nivelo los años bisiestos)
            //Meses 30.4375 dias (asi nivelo los años bisiestos)
            DateTime fechaNac = new DateTime(anioNac, mesNac, diaNac);
            double cantDiasVividos = (fechaActual.Day - fechaNac.Day)+(fechaActual.Month-fechaNac.Month)*30.4375+(fechaActual.Year-fechaNac.Year)*365.25;
            cantDiasVividos = Math.Round(cantDiasVividos, 0);
            return cantDiasVividos;
        }
    }
}
