using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jardin
    {
        public enum Tipo
        {
            Terrozo, Arenozo
        }
        
        private int espacioTotal;
        private List<Planta> plantas;
        private static Tipo suelo; //el atributo es Estatico, ojo con el enunciado.

        /// <summary>
        /// Constructor Estatico, setea el suelo como tipo Terrozo.
        /// </summary>
        static Jardin()// constructor estatico, OJO!
        {
            Jardin.suelo = Jardin.Tipo.Terrozo;
        }

        /// <summary>
        /// Constructor privado, se llama desde el public, instancia e inicializa la lista.
        /// </summary>
        private Jardin()
        {
            this.plantas = new List<Planta>();
        }

        /// <summary>
        /// Constructor con parametros. Inicializa el espacio.
        /// </summary>
        /// <param name="espacioTotal"></param>
        public Jardin(int espacioTotal) : this() //llama al constructor Privado para instanciar la lista de plantas!
        {
            this.espacioTotal = espacioTotal;
        }

        /// <summary>
        /// Devuelve el espacio ocupado de las plantas en la lista de Plantas del Jardin.
        /// </summary>
        /// <returns>Cant de espacio ocupado en la lista de las plantas</returns>
        private int EspacioOcupado()
        {
            int espacioTotalOcupado = 0;
            foreach(Planta p in this.plantas)
            {
                espacioTotalOcupado += p.Tamanio;
            }
            return espacioTotalOcupado;
        }

        /// <summary>
        /// Calcula el espacio ocupado
        /// </summary>
        /// <param name="planta"></param>
        /// <returns>Devuelve el espacio ocupado mas el tamanio de la planta</returns>
        private int EspacioOcupado(Planta planta)
        {
            return this.EspacioOcupado() + planta.Tamanio;
        }

        /// <summary>
        /// Sobrecarga del operador +
        /// </summary>
        /// <param name="jardin">Jardin donde se agrega la planta</param>
        /// <param name="planta">Planta a agregar</param>
        /// <returns>Si se pudo agregar TRUE; si no, FALSO</returns>
        public static bool operator +(Jardin jardin, Planta planta)
        {
            if(planta is not null && jardin is not null && jardin.espacioTotal >= jardin.EspacioOcupado(planta))
            {
                jardin.plantas.Add(planta);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Sobreescritura del Metodo ToString()
        /// </summary>
        /// <returns>Devuelve un string con la composicion del Jardin. El espacio Ocupado y la lista de plantas</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Composicion del jardin {Jardin.suelo}");
            sb.AppendLine($"Espacio ocupado {this.EspacioOcupado()} de {this.espacioTotal}");
            sb.AppendLine($"LISTA DE PLANTAS: ");

            foreach(Planta p in this.plantas)
            {
                sb.AppendLine(p.ResumenDeDatos());
            }

            return sb.ToString();
        }



    }
}
