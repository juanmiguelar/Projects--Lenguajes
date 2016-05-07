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



        public CrearFactura()
        {
            InitializeComponent();
        }

        private void CrearFactura_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Producto p = new Producto();
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
    }
}
