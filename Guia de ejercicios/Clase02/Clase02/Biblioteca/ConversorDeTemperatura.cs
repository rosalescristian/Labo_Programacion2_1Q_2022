using System;

namespace Biblioteca
{
    public static class ConversorDeTemperatura // Si la clase es estática, todos sus miembros, metodos deben ser estaticos
    {
        private const float ceroAbsoluto = 273.15f; // Atributo de clase. Las constantes no necesitan q les defina el STATIC adelante xq lo toma de ese modo automaticamente
        
        /// <summary>
        /// Convierte el valor recibido a Grados Kelvin
        /// </summary>
        /// <param name="temperaturaCelsius">Valor recibido que indica la temperatura a Convertir</param>
        /// <returns>Devuelve la temperatura en Grados Kelvin</returns>
        public static float ConvertirCelsiusAKelvin(float temperaturaCelsius)
        {
            return temperaturaCelsius + ceroAbsoluto;
        }

        /// <summary>
        /// Convierte el valor recibido a Grados Celsius
        /// </summary>
        /// <param name="temperaturaKelvin">Valor recibido que indica la temperatura a Convertir</param>
        /// <returns>Devuelve la temperatura en Grados Celsius</returns>
        public static float ConvertirKelvinACelsius(float temperaturaKelvin)
        {
            return temperaturaKelvin - ceroAbsoluto;
        }
    }
}
