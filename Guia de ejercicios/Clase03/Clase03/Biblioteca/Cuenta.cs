using System;
using System.Text;

namespace Biblioteca
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="titular">Razon Social del titular de la cuenta</param>
        /// <param name="cantidad">Monto actual de dinero en la cuenta</param>
        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Recupera el Nombre del titular de la cuenta
        /// </summary>
        /// <returns></returns>
        public string GetTitular()
        {
            return this.titular;
        }
        
        /// <summary>
        /// Recupera el Saldo de la cuenta
        /// </summary>
        /// <returns></returns>
        public decimal GetCantidad()
        {
            return this.cantidad;
        }

        /// <summary>
        /// Muestra los datos de la cuenta
        /// </summary>
        /// <param name="cuenta">Recibe la cuenta que deseo mostrar</param>
        /// <returns>Devuelve un string con los datos de la cuenta</returns>
        public static string MostrarDatosDeLaCuenta(Cuenta cuenta)
        {
            StringBuilder sb = new StringBuilder();
            
            sb.Append("El titular de la cuenta es: ");
            sb.AppendLine(cuenta.GetTitular());
            sb.Append("El monto disponible en la cuenta es: $ ");
            sb.AppendLine(cuenta.GetCantidad().ToString());

            return sb.ToString();
        }

        /// <summary>
        /// Ingresa dinero a la cuenta
        /// </summary>
        /// <param name="monto">El monto que se va a ingresar</param>
        public void IngresarDinero(decimal monto)
        {
            if(monto>0)
            {
                this.cantidad += monto;
            }
        }

        /// <summary>
        /// Retira dinero de la cuenta
        /// </summary>
        /// <param name="monto">El monto que se va a retirar</param>
        public void RetirarDinero(decimal monto)
        {
            this.cantidad += monto;
        }
    }
}
