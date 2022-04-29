using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class SobreSobrescrito : Sobrescrito
    {
        public SobreSobrescrito() : base()
        {

        }
        public override string MiMetodo()
        {
            return MiPropiedad;
        }

        public override string MiPropiedad
        {
            get
            {
                return this.miAtributo;
            }
        }
    }
}
