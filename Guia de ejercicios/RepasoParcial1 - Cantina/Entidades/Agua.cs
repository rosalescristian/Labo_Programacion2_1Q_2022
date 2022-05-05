using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Agua : Botella
    {
        private const int MEDIDA = 400;

        public Agua(int capacidadML, int contenidoML, string marca) 
                    : base(capacidadML, contenidoML, marca)
        {

        }

        protected override string GenerarInforme()
        {
            return base.GenerarInforme();
        }
        
        public override int ServirMedida()
        {
            if(MEDIDA <= this.Contenido)
            {
                this.Contenido = this.Contenido - MEDIDA;
                return this.Contenido;
            }
            this.Contenido = 0;
            return this.Contenido;
        }

        public int ServirMedida(int medida)
        {
            if(medida == MEDIDA)
            {
                return this.ServirMedida();
            }
            if(medida <= this.Contenido)
            {
                this.Contenido = this.Contenido - medida;
                return this.Contenido;
            }
            this.Contenido=0;
            return this.Contenido;
        }
    }
}
