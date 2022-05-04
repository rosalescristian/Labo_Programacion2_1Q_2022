using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jardin
    {
        public enum ETipo
        {
            Terrozo, Arenozo
        }
        
        private int espacioTotal;
        private List<Planta> plantas;
        private ETipo tipo;

        private int myVar;

        public ETipo TipoSuelo
        {
            set
            { 
                this.tipo = value;
            }
        }

        private int EspacioOcupado()
        {
            return 0;
        }

        private int EspacioOcupado(Planta planta)
        {
            return 0;
        }

        private Jardin()
        {

        }

        private Jardin()
        {

        }

        public Jardin(int espacioTotal)
        {
            this.espacioTotal = espacioTotal;
        }

        public static bool operator +(Jardin jardin, Planta planta)
        {
            return true;
        }

        public override string ToString()
        {
            return base.ToString();
        }



    }
}
