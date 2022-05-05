using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RosalesCristian2C
{
    public static class Dispositivo
    {
        public enum SistemaOperativo
        {
            ANDROID, IOS
        }

        private static List<Aplication> appInstaladas;
        private static SistemaOperativo sistemaOperativo;

        /// <summary>
        /// Constructor estatico
        /// </summary>
        static Dispositivo()
        {
            appInstaladas = new List<Aplication>();
            Dispositivo.sistemaOperativo = SistemaOperativo.ANDROID;
        }

        /// <summary>
        /// Instalar una app en el dispositivo si son compatibles y hay espacio suficiente
        /// </summary>
        /// <param name="app"></param>
        /// <returns>True si se pudo instalar, false si no, o si no son compatibles</returns>
        public static bool InstalarApp(Aplication app)
        {
            if(app.OS.ToString() == Dispositivo.sistemaOperativo.ToString())
            {
                return Dispositivo.appInstaladas + app;
            }
            return false;
        }

        /// <summary>
        /// Imprime la info del dispositivo y la lista de aplicaciones instaladas
        /// </summary>
        /// <returns>STRING con la info del device y todas las app instaladas con su informacion</returns>
        public static string ObtenerInformacionDispositivo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Sistema Operativo: {Dispositivo.sistemaOperativo}");
            sb.AppendLine($"App Instaladas: ");
            foreach(Aplication app in appInstaladas)
            {
                sb.AppendLine($"{app.ObtenerInformacionApp()}");
            }

            return sb.ToString();
        }


    }
}
