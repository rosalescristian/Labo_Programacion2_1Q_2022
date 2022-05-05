using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cerveza : Botella
    {
        private const int MEDIDA = 330;
        private Tipo tipo;

        public Cerveza(int capacidadML, int contenidoML, string Marca) 
                        : base(capacidadML, contenidoML, Marca)
        {
            this.tipo = Tipo.Vidrio;
        }
        public Cerveza(int capacidadML, int contenidoML, string marca ,Tipo tipo) 
                        : base(capacidadML, contenidoML, marca)
        {
            this.tipo=tipo;
        }

        public override int ServirMedida()
        {
            if(MEDIDA <= this.Contenido)
            {
                double contenidoDouble = this.Contenido;
                contenidoDouble = contenidoDouble-(MEDIDA * 0.8);
                this.Contenido = (int)contenidoDouble;
                return this.Contenido;
            };
            this.Contenido = 0;
            return this.Contenido;

        }

        protected override string GenerarInforme()
        {
            return base.GenerarInforme();
        }
    }
}
