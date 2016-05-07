using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetosTransferencia;
using System.Data.SqlClient;
using System.Data;

namespace AccesoDatos
{
    public class DAOCliente
    {
        private ConnectionManager connection;
        private SqlCommand comando;
        private String query;

        public DAOCliente() {
            connection = new ConnectionManager();
        }

        public void guardar(TOCliente cliente) {
            query = "INSERT INTO Clientes VALUES(@cedula, @nombre)";
            comando = new SqlCommand(query, connection.connection);

            comando.Parameters.AddWithValue("@cedula", cliente.Cedula);
            comando.Parameters.AddWithValue("@nombre", cliente.Nombre);

            try
            {
                connection.abrir();
                comando.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            finally {
                connection.cerrar();
            }
        }

        public List<TOCliente> cargar() {

            List<TOCliente> lista = new List<TOCliente>();
            comando = this.selectCommand();

            try
            {
                connection.abrir();

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        String cedula, nombre;

                        cedula = reader["Cedula"].ToString();
                        nombre = reader["NombreCompleto"].ToString();
                        lista.Add(new TOCliente(cedula, nombre));
                    }
                    reader.Close();
                }
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            finally {
                connection.cerrar();
            }


            return lista;

        }

        private SqlCommand selectCommand() {

            query = "SELECT * FROM Clientes";

            SqlCommand c = new SqlCommand(query, connection.connection);
            return c;
        }

    }
}
