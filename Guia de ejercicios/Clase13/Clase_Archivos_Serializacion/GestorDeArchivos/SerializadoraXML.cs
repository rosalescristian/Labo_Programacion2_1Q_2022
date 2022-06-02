using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace GestorDeArchivos
{
    public static class SerializadoraXML <T>   //ACA HICIMOS LA CLASE GENERICA CON RESTRICCIONES
        where T : class, new()                 //RESTRICCIONES PARA PARAMETRIZAR LA CLASE: TIENE Q SER
                                               //UNA CLASE Y TENER UN CONSTRUCTOR SIN ARGUMENTOS
    {
        /// <summary>
        /// VERSION ORIGINAL SIN USAR GENERICS
        /// </summary>
        /// <param name="alumno"></param>
        /// <param name="path"></param>
        //public static void GuardarXML(Alumno alumno, string path)
        //{
        //    using(StreamWriter sw = new StreamWriter(path))
        //    {
        //        XmlSerializer serializer = new XmlSerializer(typeof(Alumno));
        //        serializer.Serialize(sw, alumno);
        //    } 
        //}
        public static void GuardarXML(T objeto, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(sw, objeto);
            }
        }

        public static void GuardarXML(List<Alumno> alumno, string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Alumno>));
                serializer.Serialize(sw, alumno);
            }
        }

        /// <summary>
        /// VERSION ORIGINAL SIN USAR GENERICS
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        //public static List<Alumno> LeerXML(string path)
        //{
        //    using (StreamReader sw = new StreamReader(path))
        //    {
        //        XmlSerializer serializer = new XmlSerializer(typeof(List<Alumno>));
        //        return serializer.Deserialize(sw) as List<Alumno>;
        //    }
        //}
        public static T LeerXML(string path)
        {
            using (StreamReader sw = new StreamReader(path))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                return serializer.Deserialize(sw) as T;
            }
        }
    }
}
