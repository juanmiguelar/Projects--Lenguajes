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
    public class DAOProducto
    {

        private ConnectionManager connection;
        private SqlCommand comando;

        public DAOProducto() {
            connection = new ConnectionManager();
        }

        public TOProducto search(String cod) {

            TOProducto p = new TOProducto();
            comando = this.searchStatement(cod);
            p.Codigo = cod;
           
            try
            {
                connection.abrir();
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        String descripcion;
                        String precio;

                        descripcion = reader["Descripcion"].ToString();
                        precio = reader["PrecioUnitario"].ToString();
                        p.Descripcion = descripcion;
                        
                        p.Precio = int.Parse(precio, System.Globalization.NumberStyles.Currency);
                    }

                }
                
                reader.Close();
                return p;

            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            finally {
                connection.cerrar();
                
            }

        }

        private SqlCommand searchStatement(String p) {
            String query = "Select * From Productos where Codigo=@cod";

            SqlCommand c = new SqlCommand(query, connection.connection);
            c.Parameters.AddWithValue("cod", p);
            return c;
        }

    }
}
