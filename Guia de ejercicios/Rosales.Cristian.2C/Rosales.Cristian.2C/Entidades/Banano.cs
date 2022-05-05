using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public  class Banano : Planta
    {
        private string codigo;

        /// <summary>
        /// Constructor con parametros, utiliza el de base.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="tamanio"></param>
        /// <param name="codigo"></param>
        public Banano(string nombre, int tamanio, string codigo) : base(nombre, tamanio)
        {
            this.codigo = codigo;
        }

        /// <summary>
        /// Propiedad Tiene Flores. ReadOnly
        /// </summary>
        public override bool TieneFlores
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Propiedad Tiene Fruto. ReadOnly
        /// </summary>
        public override bool TieneFruto
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Muestra el resumen de datos de Banano
        /// </summary>
        /// <returns>STRING. Los datos de PLANTA + Banano</returns>
        public override string ResumenDeDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.ResumenDeDatos());
            sb.AppendLine($"Codigo Internacional: {this.codigo}");
            
            return sb.ToString();
        }

        
    }
}
