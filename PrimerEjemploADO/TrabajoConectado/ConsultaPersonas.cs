using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace TrabajoConectado
{
    public partial class ConsultaPersonas : Form
    {

        DataTable dataPerson;

        public ConsultaPersonas()
        {
            InitializeComponent();
            dataPerson = new DataTable();
        }

        private void ConsultaPersonas_Load(object sender, EventArgs e)
        { 

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dataPerson = new DataTable();
            // El data table por defecto no puede tener columnas
            dataPerson.Columns.Add("FirstName");
            dataPerson.Columns.Add("LastName");


            String buscar = txtCriterio.Text;
            String query = "SELECT FirstName, LastName FROM Person WHERE FirstName LIKE @Criterio OR LastName Like @Criterio";

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = TrabajoConectado.Properties.Settings.Default.connectionString;

            SqlCommand commander = new SqlCommand(query, sqlConnection);
            commander.Parameters.AddWithValue("Criterio", buscar);


            // Verificar si la conexion esta abierta
            if (sqlConnection.State != ConnectionState.Open)
                sqlConnection.Open(); // Abrir la conexión

            // Obtener el lector
            SqlDataReader reader = commander.ExecuteReader();

            // Preguntar si tiene filas
            if (reader.HasRows)
            {
                // True en caso de que hayan más filas
                // False si ya no tiene más filas que leer
                while (reader.Read())
                {
                    String firstName, lastName;

                    // El valor entre los parentesis cuadrados es el nombre de la columna
                    firstName = reader["FirstName"].ToString();
                    lastName = reader["LastName"].ToString();
                    dataPerson.Rows.Add(firstName, lastName);
                }
                reader.Close();
            }

            // Verificar si la conexion esta cerrada
            if (sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();

            dataGridView1.DataSource = dataPerson;
        }
    }
}
