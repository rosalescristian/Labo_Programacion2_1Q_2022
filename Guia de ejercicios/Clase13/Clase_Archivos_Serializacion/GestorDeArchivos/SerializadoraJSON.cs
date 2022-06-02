using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace GestorDeArchivos
{
    public class SerializadoraJSON <T>
        where T : class, new()
    {
        public void GuardarJSON(T objeto, string path)
        {
            JsonSerializerOptions options = new JsonSerializerOptions();
            options.WriteIndented = true;

            string json = JsonSerializer.Serialize(objeto, options);
            ManejadorArchivosDeTexto.Guardar(path, json);

        }
        public T LeerJSON(string path)
        {
            string json = ManejadorArchivosDeTexto.Leer(path);

            return JsonSerializer.Deserialize<T>(json);

        }
    }
}
