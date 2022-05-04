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

        static Jardin()// constructor estatico, OJO!
        {
            Jardin.suelo = Jardin.Tipo.Terrozo;
        }

        private Jardin()
        {
            this.plantas = new List<Planta>();
        }

        public Jardin(int espacioTotal) : this() //llama al constructor Privado para instanciar la lista de plantas!
        {
            this.espacioTotal = espacioTotal;
        }

        private int EspacioOcupado()
        {
            int espacioTotalOcupado = 0;
            foreach(Planta p in this.plantas)
            {
                espacioTotalOcupado += p.Tamanio;
            }
            return espacioTotalOcupado;
        }

        private int EspacioOcupado(Planta planta)
        {
            return this.EspacioOcupado() + planta.Tamanio;
        }

        public static bool operator +(Jardin jardin, Planta planta)
        {
            if(planta is not null && jardin is not null && jardin.espacioTotal >= jardin.EspacioOcupado(planta))
            {
                jardin.plantas.Add(planta);
                return true;
            }
            return false;
        }

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
