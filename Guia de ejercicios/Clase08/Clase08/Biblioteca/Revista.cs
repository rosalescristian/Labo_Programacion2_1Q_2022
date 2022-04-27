using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Revista : Publicacion
    {
        private int cantidadPaginas;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="titulo"></param>
        /// <param name="cantidadPaginas"></param>
        /// <param name="fechaPublicacion"></param>
        public Revista(string titulo, int cantidadPaginas, DateTime fechaPublicacion) : base(titulo, fechaPublicacion)
        {
            this.cantidadPaginas = cantidadPaginas;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public new string MostrarDatos()//al ponerle NEW al metodo, se oculta la implementacion
                                        //del metodo heredado(Trae el dato AUTOR que es un atributo de
                                        //la clase LIBRO no PUBLICACION)
        {
            //Como estoy heredando, puedo acceder a los atributos de la clase base
            //Esto es una hereancia explicita (GetType()[devuelve el tipo de instancia]que hereda de Objet)
            return $"{this.GetType().Name} || Titulo: {this.titulo} - Cant. Paginas: {this.cantidadPaginas} - Publicado: {this.fechaPublicacion.Date}";
        }
    }
}
