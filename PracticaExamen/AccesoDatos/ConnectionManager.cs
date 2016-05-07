using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace AccesoDatos
{
    public class ConnectionManager
    {
        private String connectionString;
        public SqlConnection connection { get; }

        public ConnectionManager() {
            connectionString = Properties.Settings.Default.connectionString;
            connection = new SqlConnection();
            connection.ConnectionString = this.connectionString;
        }

        public void abrir() {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void cerrar() {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }
}
