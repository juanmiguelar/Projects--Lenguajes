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
using Logica;

namespace InterfazGrafica
{
    public partial class AdministrarClientes : Form
    {

        private ListaClientes lista;

        public AdministrarClientes()
        {
            InitializeComponent();
            lista = new ListaClientes();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            lista.cargar();
            this.dataGridClientes.DataSource = lista.obtener();
        }
    }
}
