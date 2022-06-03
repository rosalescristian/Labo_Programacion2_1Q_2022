using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Biblioteca
{
    public class ClienteDAO
    {
        private static string connectionString;
        private SqlConnection connection;
        private SqlCommand command;


        static ClienteDAO()
        {
            connectionString = @"Server=.\SQLEXPRESS01;Database=ClientesBD; Trusted_Connection=True;";

        }
        public ClienteDAO()
        {
            connection = new SqlConnection(ClienteDAO.connectionString);
            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;

        }

        public void Guardar(Cliente cliente)
        {

            try
            {
                connection.Open();

                string query = "INSERT INTO Clientes (nombre, direccion) VALUES (@nombre, @direccion)";

                command.CommandText = query;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("nombre", cliente.Nombre);
                command.Parameters.AddWithValue("direccion", cliente.Direccion);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public List<Cliente> Leer()
        {
            List<Cliente> lista = new List<Cliente>();
            try
            {
                string query = "SELECT * FROM Clientes";
                connection.Open();
                command.CommandText = query;

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    int id = dataReader.GetInt32(0);
                    string nombre = dataReader.GetString(1);
                    string direccion = dataReader.GetString(2);

                    Cliente cliente = new Cliente(id, nombre, direccion);

                    lista.Add(cliente);
                }
                return lista;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }

        }
        public void Modificar(int id, Cliente cliente)
        {
            try
            {
                string query = "UPDATE Clientes SET nombre = @nombre, direccion = @direccion WHERE id = @id";

                connection.Open();

                command.CommandText = query;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("id", id);
                command.Parameters.AddWithValue("nombre", cliente.Nombre);
                command.Parameters.AddWithValue("direccion", cliente.Direccion);

                command.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
        public void Eliminar(int id)
        {
            try
            {
                string query = "DELETE FROM Clientes WHERE id = @idBuscado";

                connection.Open();

                command.CommandText= query;

                command.Parameters.Clear();
                command.Parameters.AddWithValue("idBuscado", id);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (connection is not null && connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }

    }
}
