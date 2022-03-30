using System;

namespace Biblioteca
{
    public static class ConversorDeTemperatura // Si la clase es estática, todos sus miembros, metodos deben ser estaticos
    {
        private const float ceroAbsoluto = 273.15f; // Atributo de clase. Las constantes no necesitan q les defina el STATIC adelante xq lo toma de ese modo automaticamente
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="temperaturaCelsius"></param>
        /// <returns></returns>
        public static float ConvertirCelsiusAKelvin(float temperaturaCelsius)
        {
            return temperaturaCelsius + ceroAbsoluto;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="temperaturaKelvin"></param>
        /// <returns></returns>
        public static float ConvertirKelvinACelsius(float temperaturaKelvin)
        {
            return temperaturaKelvin - ceroAbsoluto;
        }
    }
}
