using System;
using System.IO;

namespace GestorDeArchivos
{
    public class ManejadorArchivosDeTexto
    {
        public static void Guardar(string path, string texto)
        {
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter(path);//el path donde se guarda el archivo
                streamWriter.WriteLine(texto); //este metodo guarda el string TEXTO dentro del path
            
                streamWriter.Close();

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }
            finally
            {
                if (streamWriter is not null) //Una forma de gestionarlo
                {
                    streamWriter.Close();
                }
            }


        }

        /// <summary>
        /// Sobrecarga de Guardar agregando info al archivo existente
        /// </summary>
        /// <param name="path"></param>
        /// <param name="texto"></param>
        /// <param name="agregar"></param>
        public static void Guardar(string path, string texto, bool agregar)
        {
            try
            {
                using (StreamWriter streamWriter = new StreamWriter(path, agregar))// otra forma de manejar la escritura con el cierre del archivo incluido y no tenemos q hacer el Close()
                {
                    streamWriter.WriteLine(texto);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message); ;
            }
        }

        public static string Leer(string path)
        {
            try
            {
                using(StreamReader streamReader = new StreamReader(path))
                {
                    return streamReader.ReadToEnd();
                }
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
        }



    }
}
