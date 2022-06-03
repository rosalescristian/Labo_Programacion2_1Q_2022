using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; //Se agrega el PaqueteNuGet en el proyecto de la conexion a la DDBB =>                                   System.Data.SqlClient

namespace Biblioteca
{
    public class ClienteDAO
    {
        private static string connectionString;
        private SqlConnection connection;

        static ClienteDAO()
        {
            connectionString = @"Server=.;Database=CLIENTESDB;Trusted_Connection=True;";
        }
        public ClienteDAO()
        {

        }
        public void Guardar(Cliente cliente)
        {
            //Vamos a usar las connection Strings de la web: https://www.connectionstrings.com/
            //Trusted Connection
            //string connectionString = @"Server=.;Database=CLIENTESDB;Trusted_Connection=True;";
            this.connection = new SqlConnection(ClienteDAO.connectionString);//instancio un nuevo
                                                                            //conectarme;
            try
            {
                connection.Open();//Abrimos la conexion

                string query = "INSERT INTO DBO.CLIENTES (NOMBRE,DIRECCION) VALUES (@nombre, @direccion)";

                //Parametrizamos la consulta
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.Clear();
                sqlCommand.Parameters.AddWithValue("nombre", cliente.Nombre);
                sqlCommand.Parameters.AddWithValue("nombre", cliente.Direccion);

                sqlCommand.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                //1 Forma de validar y cerrar la conexion de SQL
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

        public List<Cliente> Leer()
        {
            //Aca defino la lista donde voy a sumar el cliente que lei en el metodo
            List<Cliente> lista = new List<Cliente>();

            try
            {
                string query = "SELECT * FROM DBO.CLIENTES";

                //Usando Using nos evitamos hacer el Close de la conexion.
                using (SqlConnection connection = new SqlConnection(@"Server=.;Database=CLIENTESDB;Trusted_Connection=True;"))
                {
                    connection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    SqlDataReader dataReader = sqlCommand.ExecuteReader();

                    while (dataReader.Read())
                    {
                        //las columnas se nombran en los Get con el indice de la columna en la tabla como un array
                        int id = dataReader.GetInt32(0);
                        string nombre = dataReader.GetString(1);
                        string  direccion = dataReader.GetString(2);

                        //Creo un nuevo cliente
                        Cliente cliente = new Cliente(id, nombre, direccion);
                        
                        //Sumo el cliente nuevo de la DDBB a la lista Cliente de este METODO
                        lista.Add(cliente);
                    }
                }
                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }
        }
    }
}
