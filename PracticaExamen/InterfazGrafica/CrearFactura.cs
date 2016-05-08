using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace InterfazGrafica
{
    public partial class CrearFactura : Form
    {

        private Producto p;
        private Factura f;
        private ListaClientes listaClientes;

        public CrearFactura()
        {
            InitializeComponent();
            
        }

        private void CrearFactura_Load(object sender, EventArgs e)
        {
            f = new Factura();
            listaClientes = new ListaClientes();
            refreshcbx();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                p = new Producto();
                String cod = txtCod.Text;

                p = p.buscarme(cod);

                txtDescripcion.Text = p.Descripcion;
                txtPrecio.Text = p.Precio.ToString();

            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.p != null)
            {
                f.Detalle.agregar(p);
                txtTotal.Text = f.Detalle.total().ToString();
                refreshDatagrid();
            }
        }

        private void refreshDatagrid() {
            datagridDetalle.DataSource = null;
            this.datagridDetalle.DataSource = f.Detalle.obtener();
        }

        private void refreshcbx() {

            cbxClientes.DataSource = null;
            listaClientes.cargar();
            cbxClientes.DataSource = listaClientes.obtener();
            cbxClientes.DisplayMember = "Nombre";
            cbxClientes.ValueMember = "Cedula";
        }

        private void cbxClientes_Click(object sender, EventArgs e)
        {
            refreshcbx();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Cliente client = (Cliente)cbxClientes.SelectedItem;
            f.Cliente = client;
            f.ID_Factura = f.guardar();

            MessageBox.Show("Su numero de factura es: " + f.ID_Factura);
        }
    }
}
