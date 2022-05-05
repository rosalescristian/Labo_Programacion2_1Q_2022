using System;
using System.Text;
using System.Collections.Generic;

namespace RosalesCristian2C
{
    public abstract class Aplication
    {
        public enum SistemaOperativo
        {
            ANDROID, IOS
        }

        protected string nombre;
        protected int tamanioMb;
        protected SistemaOperativo sistemaOperativo;

        /// <summary>
        /// Consrtuctor con parametros
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="tamanioMb"></param>
        /// <param name="sistemaOperativo"></param>
        protected Aplication(string nombre, SistemaOperativo sistemaOperativo, int tamanioMb)
        {
            this.nombre = nombre;
            this.tamanioMb = tamanioMb;
            this.sistemaOperativo = sistemaOperativo;
        }

        /// <summary>
        /// Propiedad Abstracta Tamanio. ReadOnly
        /// </summary>
        public abstract int Tamanio{ get;}

        /// <summary>
        /// Propiedad SistemaOperativo. ReadOnly
        /// </summary>
        public SistemaOperativo OS
        {
            get
            {
                return this.sistemaOperativo;
            }
        }

        /// <summary>
        /// Obtener Info
        /// </summary>
        /// <returns>Devuelve STRING con todos los atributos de la Aplicacion</returns>
        public virtual string ObtenerInformacionApp()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Tamanio: {this.Tamanio}");
            sb.AppendLine($"Sistema Operativo: {this.OS}");

            return sb.ToString();
        }

        /// <summary>
        /// Devuelve la aplicacion con el mayor tamanio
        /// </summary>
        /// <param name="listaApp">Lista a recorrer </param>
        public static implicit operator Aplication(List<Aplication> listaApp)
        {
            int maxTamanio = int.MinValue;
            Aplication auxApp = null;
            if(listaApp is not null)
            {
                foreach (Aplication aplication in listaApp)
                {
                    if(aplication.Tamanio > maxTamanio)
                    {
                        maxTamanio = aplication.Tamanio;
                        auxApp = aplication;
                    }
                }
            }
            return auxApp;
        }

        /// <summary>
        /// Sobrecarga !=
        /// </summary>
        /// <param name="listaApp">Instancia de Lista a recorrer</param>
        /// <param name="app">App a comparar</param>
        /// <returns>True si el nombre de la app NO esta en la lista</returns>
        public static bool operator !=(List<Aplication>listaApp, Aplication app)
        {
            return !(listaApp == app);
        }

        /// <summary>
        /// Sobrecarga ==
        /// </summary>
        /// <param name="listaApp">Instancia de Lista a recorrer</param>
        /// <param name="app">App a comparar</param>
        /// <returns>True si el nombre de la app SI esta en la lista</returns>
        public static bool operator ==(List<Aplication> listaApp, Aplication app)
        {
            foreach(Aplication item in listaApp)
            {
                if(item.nombre == app.nombre)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Sobrecarga +
        /// </summary>
        /// <param name="listaApp">Instancia de la lista a recorrer</param>
        /// <param name="app">App a agregar</param>
        /// <returns>True si se pudo agregar.</returns>
        public static bool operator +(List<Aplication> listaApp, Aplication app)
        {
            if(listaApp is not null && app is not null && listaApp != app)
            {
                listaApp.Add(app);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sobreescritura TOSTRING()
        /// </summary>
        /// <returns>Nombre Aplicacion</returns>
        public override string ToString()
        {
            return this.nombre;
        }



    }
}
