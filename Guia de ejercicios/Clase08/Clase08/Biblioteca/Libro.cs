using System;

namespace Biblioteca
{
    public class Libro : Publicacion
    {
        private string autor;
        private int precio;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="autor"></param>
        /// <param name="fechaPublicacion"></param>
        public Libro(string titulo, string autor, int precio, DateTime fechaPublicacion):base(titulo, fechaPublicacion)
        {
            this.autor = autor;
            this.precio = precio;
        }
        public int Precio
        {
            get { return precio; }
            set { precio = value; }
        }


        ///// <summary>
        ///// Es un metodo de la clase Libro, no usa el original de Publicacion
        ///// </summary>
        ///// <returns></returns>
        //public new string MostrarDatos()//al ponerle NEW al metodo, se oculta la implementacion
        //                                //del metodo heredado(Trae el dato AUTOR que es un atributo de
        //                                //la clase LIBRO no PUBLICACION)
        //{
        //    //Como estoy heredando, puedo acceder a los atributos de la clase base
        //    //Esto es una hereancia explicita (GetType()[devuelve el tipo de instancia]que hereda de Objet)
        //    return $"{this.GetType().Name} || Titulo: {this.titulo} - Autor: {this.autor} - Precio: {this.precio} - Publicado: {this.fechaPublicacion.Date}";
        //    //tb podemos hacer return $"{base.MostrarDatos()} {this.autor}";
        //    //estanos llamando al metodo MostrarDatos() de la clase BASE y
        //    //sumando el atributo especifico de la clase hijo
        //}

    }
}
