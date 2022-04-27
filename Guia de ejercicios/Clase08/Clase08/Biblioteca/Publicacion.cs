using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Publicacion
    {
        
        //con PROTECTED nos permite usarlas como private y
        //acceder desde las clases heredadas desde cualquier lado
        protected string titulo; // en el video Esteban las hizo publicas para no armar las propiedades. SON PRIVADAS
        protected DateTime fechaPublicacion; // en el video Esteban las hizo publicas para no armar las propiedades. SON PRIVADAS

        /// <summary>
        /// 
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="fechaPublicacion"></param>
        public Publicacion(string titulo, DateTime fechaPublicacion)
        {
            this.titulo = titulo;
            this.fechaPublicacion = fechaPublicacion;
        }

        /// <summary>
        /// Esta es la propiedad que se construye automaticamente con el Quick Actions (Modificada para q quede de la forma tradicional)
        /// </summary>
        public string Titulo 
        { 
            get
            {
                return this.titulo;
            }
            set
            {
                this.titulo = value;
            }
        }

        //si tipeamos propfull + 2TABS nos crea un atributo y sus propiedades automaticamente
        //private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set { myVar = value; }
        //}

        /// <summary>
        /// Esta es la propiedad que se construye automaticamente con el Quick Actions
        /// </summary>
        public DateTime FechaPublicacion { get => fechaPublicacion; set => fechaPublicacion = value; }

        /// <summary>
        /// ESTE METODO ESTA COMENTADO XQ CREAMOS LAS PROPIEDADES
        /// </summary>
        /// <returns></returns>
        public string MostrarDatos()
        {
            //Como estoy heredando, puedo acceder a los atributos de la clase base
            //Esto es una hereancia explicita (GetType()[devuelve el tipo de instancia]que hereda de Objet)
            return $"{this.GetType().Name} || Titulo: {this.titulo} - Publicado: {this.fechaPublicacion.Date}";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="p"></param>
        public static void Imprimir(Publicacion p)
        {
            Console.WriteLine(p.MostrarDatos());
        }
    }
}
