using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Factura
    {
        private int numero;
        private string razonSocial;
        private float importe;

        public Factura()
        {

        }
        public Factura(int numero, string razonSocial, float importe)
        {
            this.numero = numero;
            this.razonSocial = razonSocial;
            this.importe = importe;
        }

        public int Numero { get => numero; set => numero = value; }
        public string RazonSocial { get => razonSocial; set => razonSocial = value; }
        public float Importe { get => importe; set => importe = value; }

        public string Imprimir()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Factura N° {this.Numero} - Razon Social: {this.RazonSocial}");
            sb.AppendLine($"Importe ${this.Importe} ");
            return sb.ToString();
        }
    }
}
