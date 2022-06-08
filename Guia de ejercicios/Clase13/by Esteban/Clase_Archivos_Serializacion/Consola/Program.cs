using Entidades;
using Persistencia;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Environment;


namespace Consola
{
    internal class Program
    {
        static void Main(string [] args)
        {
            try
            {
                //ARCHIVOS DE TEXTO TXT
                Console.WriteLine($"Trabajo con archivos de texto: {NewLine}");

                //Guardar txt en el escritorio, si el archivo existe agrega al final sino lo crea
                string path = GetFolderPath(SpecialFolder.Desktop);

                ManejadorArchivosDeTexto manejadorTxt = new ManejadorArchivosDeTexto();
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Habia una vez una vaca");
                sb.AppendLine("en la quebrada de Humahuaca");
                sb.AppendLine("Como era muy vieja, muy vieja");
                sb.AppendLine("Estaba sorda de una oreja");

                manejadorTxt.Guardar(path, "MiArchivo.txt", sb.ToString());

                //Leo el archivo txt
                string textoLeido = manejadorTxt.Leer(path, "MiArchivo.txt");
                Console.WriteLine(textoLeido);

                Console.ReadKey();
                Console.Clear();

                //SERIALIZACION XML
                Console.WriteLine($"Trabajo con serializacion XML: {NewLine}");


                List<Cliente> clientes = new List<Cliente>();
                clientes.Add(new Cliente("Maria Elena", "Walsh"));
                clientes.Add(new Cliente("Julio", "Cortazar"));
                clientes.Add(new Cliente("Jorge Luis", "Borges"));

                //Guardo la lista de clientes en xml en el escritorio
                Serializadora<List<Cliente>> serializadoraXml = new Serializadora<List<Cliente>>();
                serializadoraXml.Guardar(path, "clientes.xml", clientes);

                //Leo la lista de clientes y muestro el nombre
                List<Cliente> clientesLeidos = serializadoraXml.Leer(path, "clientes.xml");

                foreach (Cliente item in clientesLeidos)
                {
                    Console.WriteLine(item.NombreCompleto);
                }

                Console.ReadKey();
                Console.Clear();

                //SERIALIZACION JSON
                Console.WriteLine($"Trabajo con serializacion JSON: {NewLine}");
                Random random = new Random();

                List<Factura> facturas = new List<Factura>();
                facturas.Add(new Factura(random.Next(1000, 10000), "UTN", 412.25f));
                facturas.Add(new Factura(random.Next(1000, 10000), "UBA", 10000.75f));
                facturas.Add(new Factura(random.Next(1000, 10000), "UADE", 87422.25f));

                Serializadora<List<Factura>> serializadoraJSON = new Serializadora<List<Factura>>();

                //Guardo la lista de facturas
                serializadoraJSON.Guardar(path, "facturas.json", facturas);

                //Leo la lista de facturas
                List<Factura> facturasLidas = serializadoraJSON.Leer(path, "facturas.json");

                foreach (Factura item in facturasLidas)
                {
                    Console.WriteLine(item.Imprimir());
                }

            }catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }


            Console.WriteLine("OK");
        }
    }
}
