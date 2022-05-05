using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosalesCristian2C
{
    public class AppMusical : Aplication
    {
        private List<string> listaCanciones;

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="listaCanciones"></param>
        public AppMusical(string nombre, SistemaOperativo sistemaOperativo, 
                            int tamanioMb)
                            : base(nombre, sistemaOperativo, tamanioMb)
        {
            this.listaCanciones = new List<string>();
        }

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="listaCanciones"></param>
        public AppMusical (string nombre, SistemaOperativo sistemaOperativo,
                            int tamanioMb, List<string> listaCanciones)
                            : base (nombre, sistemaOperativo, tamanioMb)        
        {
            this.listaCanciones = listaCanciones;
        }

        /// <summary>
        /// Propiedad Tamanio, ReadOnly
        /// </summary>
        public override int Tamanio
        {
            get
            {
                return this.tamanioMb+(this.listaCanciones.Count)*2;
            }
        }

        /// <summary>
        /// Imprime la info de la app
        /// </summary>
        /// <returns>STRING</returns>
        public override string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine($"{base.ObtenerInformacionApp()}");
            sb.AppendLine($"Lista de Canciones instaladas en la App: ");
            foreach(string str in this.listaCanciones)
            {
                sb.AppendLine($"\tNombre de la cancion: {str}");
            }

            return sb.ToString();

        }
    }
}
