using System;

namespace Biblioteca
{
    public class ConversorDeTemperatura
    {
        /// <summary>
        /// 
        /// </summary>
        public static float ConvertirCelsiusAKelvin(float temperaturaCelsius)
        {
            return temperaturaCelsius + 273.15f;
        }
    }
}
