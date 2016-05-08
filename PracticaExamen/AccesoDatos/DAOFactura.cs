using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using ObjetosTransferencia;

namespace AccesoDatos
{
    public class DAOFactura
    {
        private ConnectionManager connection;
        private SqlDataAdapter adaptador;

        public DAOFactura() {
            connection = new ConnectionManager();
            adaptador = new SqlDataAdapter();

            adaptador.InsertCommand = crearInsert();
        }

        public TOFactura guardar(TOFactura factura) {

            String query = "Insert into Factura Values(@numero, GETDATE(), @cedula, @total);";
            SqlCommand c = new SqlCommand(query, connection.connection);

            int cod = (this.obtenerCodigo() + 1);
            factura.Detalle.numeroFactura = cod;

            c.Parameters.AddWithValue("@numero", cod );
            c.Parameters.AddWithValue("@cedula", factura.Cliente.Cedula);
            c.Parameters.AddWithValue("@total", factura.Total);
            
            try
            {
                connection.abrir();
                c.ExecuteNonQuery();
                connection.cerrar();

                guardarProductos(factura.Detalle.lista);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            finally {
                connection.cerrar();
            }

            factura.ID_Factura = cod;
            return factura;
        }

        private void guardarProductos(List<TOProducto> list) {
            try
            {
                DataTable d = crearDataTable(list);
                adaptador.Update(d);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private DataTable crearDataTable(List<TOProducto> list) {

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("numero");
            dataTable.Columns.Add("cod");
            dataTable.Columns.Add("des");
            dataTable.Columns.Add("precio");

            int cod = this.obtenerCodigo();

            foreach (TOProducto item in list)
            {
                dataTable.Rows.Add(cod, item.Codigo, item.Descripcion, item.Precio);
            }

            return dataTable;
        }

        private SqlCommand crearInsert() {

            String query = "INSERT INTO DetalleFactura VALUES(@num, @cod, @des, @precio);";

            SqlCommand c = new SqlCommand(query, connection.connection);
            SqlParameter num = new SqlParameter("@num", SqlDbType.NChar, 10, "numero");
            SqlParameter cod = new SqlParameter("@cod", SqlDbType.NVarChar, 50, "cod");
            SqlParameter des = new SqlParameter("@des", SqlDbType.NVarChar, 200, "des");
            SqlParameter precio = new SqlParameter("@precio", SqlDbType.Money, 10, "precio");

            c.Parameters.Add(num);
            c.Parameters.Add(cod);
            c.Parameters.Add(des);
            c.Parameters.Add(precio);

            return c;
        }

        private SqlCommand obtenerUltimoCodigo() {
            String query = "SELECT Count(*) From Factura;";
            SqlCommand c = new SqlCommand(query, connection.connection);

            return c;
        }

        private int obtenerCodigo() {
            SqlCommand c = this.obtenerUltimoCodigo();
            int count = 0;
            try
            {
                connection.abrir();
                count = Int32.Parse(c.ExecuteScalar().ToString());
                return count;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
            finally {
                connection.cerrar();
            }
        }
    }
}
