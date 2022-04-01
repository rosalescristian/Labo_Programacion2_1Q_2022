using System;

namespace Biblioteca
{
    public class Boligrafo
    {
        #region Atributos
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;
        #endregion

        /// <summary>
        /// Consrtuctor
        /// </summary>
        /// <param name="tinta"></param>
        /// <param name="color"></param>
        public Boligrafo(short tinta, ConsoleColor color)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public short GetTinta()
        {
            return this.tinta;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="gasto"></param>
        /// <param name="dibujo"></param>
        /// <returns></returns>
        public bool Pintar(short gasto, out string dibujo)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public void Recargar()
        {
            short recarga = (short)(100-GetTinta());
            SetTinta(recarga);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tinta"></param>
        private void SetTinta(short tinta)
        {
            short nivelTinta = GetTinta();
            int nuevoNivelTinta = nivelTinta + tinta;
            if(nuevoNivelTinta > -1 && nuevoNivelTinta < 101)
            {
                this.tinta += tinta;
            }

        }


    }
}
