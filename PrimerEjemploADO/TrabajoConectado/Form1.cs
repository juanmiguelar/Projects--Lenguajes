using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregado para permitir instaciar
// Es importante porque asi importamos todo lo que este dentro de este namespace
using System.Data.SqlClient; 


namespace TrabajoConectado
{
    public partial class Form1 : Form
    {

        DataTable dataPerson;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dataPerson = new DataTable();
            // El data table por defecto no puede tener columnas
            dataPerson.Columns.Add("cod");
            dataPerson.Columns.Add("name");
            dataPerson.Columns.Add("lastName");

            // Creamos un objeto sqlconnection para poder conectarnos a la base de datos
            SqlConnection sqlConnection = new SqlConnection();
            //Es la manera de poder entrar a nuestra base de datos
            //String connectionString = "Data Source=.\\sql2014;Initial Catalog=AdventureWorks2012;Integrated Security=true";
            // Logramos poner el connectionString el property adecuado para la conexion a la base de datos
            sqlConnection.ConnectionString = TrabajoConectado.Properties.Settings.Default.connectionString;

            // Necesito la sentencia de SQL que vamos a ejecutar.
            SqlCommand commander = new SqlCommand();
            // Es el query que vamos a ejecutar
            String query = "SELECT BusinessEntityID as cod, FirstName as name, LastName as lastName FROM Person.Person;";
            // Aqui se coloca el comando que se va a ejecutar
            commander.CommandText = query;
            // El commander necesita poder conectarse
            commander.Connection = sqlConnection;

            // De ahora en adelante lo hare de la siguiente forma
            // SqlCommand x = new SqlCommand(query, conexion);

            /* Devuelve un entero, me dice cuantas filas fueron afectadas.
            //commander.ExecuteNonQuery;

            // Primera fila primera columna
            //commander.ExecuteScalar;

            // Devuelve un data reader
            // commander.ExecuteReader; */

            
            // Verificar si la conexion esta abierta
            if (sqlConnection.State != ConnectionState.Open)
                sqlConnection.Open(); // Abrir la conexión

            // Obtener el lector
            SqlDataReader reader = commander.ExecuteReader();

            // Preguntar si tiene filas
            if (reader.HasRows) {
                // True en caso de que hayan más filas
                // False si ya no tiene más filas que leer
                while (reader.Read()) {
                    
                    int cod;
                    String name, lastName;

                    // El valor entre los parentesis cuadrados es el nombre de la columna
                    cod = Int32.Parse(reader["cod"].ToString());
                    name = reader["name"].ToString();
                    lastName = reader["lastName"].ToString();
                    dataPerson.Rows.Add(cod, name, lastName);
                    //MessageBox.Show(cod + " " + name + " " + lastName);
                    //Console.WriteLine(cod + " " + name + " " + lastName);
                }
                reader.Close();
            }

            // Verificar si la conexion esta cerrada
            if (sqlConnection.State != ConnectionState.Closed)
                sqlConnection.Close();

            grdPerson.DataSource = dataPerson;
        }
    }
}
