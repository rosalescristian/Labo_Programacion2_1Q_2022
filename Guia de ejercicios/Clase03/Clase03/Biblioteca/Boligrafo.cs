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
            this.tinta = tinta;
            this.color = color;
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
            short nivelTinta = GetTinta();
            bool pintado = false;
            dibujo = "";
            short consumo = (short)(gasto * -1);
            if(nivelTinta >= gasto)
            {
                pintado = true;
                Console.ForegroundColor = this.GetColor();
                dibujo = new string('*', gasto);
                SetTinta(consumo);
            }
            else if(nivelTinta < gasto)
            {
                pintado = true;
                Console.ForegroundColor = this.GetColor();
                dibujo = new string('*', nivelTinta);
                SetTinta(consumo);
            }
            return pintado;
            
        }

        /// <summary>
        /// 
        /// </summary>
        public void Recargar()
        {
            short recarga = (short)(cantidadTintaMaxima-GetTinta());
            SetTinta(recarga);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="tinta"></param>
        private void SetTinta(short tinta)
        {
            short nivelTinta = GetTinta();
            short nuevoNivelTinta = (short)(nivelTinta + tinta);
            if(nuevoNivelTinta >= 0 && nuevoNivelTinta <= cantidadTintaMaxima)
            {
                this.tinta += tinta;
            }

        }


    }
}
