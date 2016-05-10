using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using ObjetosTransferencia;

namespace Logica
{
    public class ListaClientes
    {
        public List<Cliente> lista { get; set; }

        public ListaClientes() {
            lista = new List<Cliente>();
        }

        public void cargar() {
            DAOCliente daoC = new DAOCliente();
            TOListaClientes toL = daoC.selectClientes();

            foreach (TOCliente item in toL.lista)
            {
                lista.Add(new Cliente(item.Cedula, item.Nombre));
            }
        }

        public void refresh() {
            lista = new List<Cliente>();
            cargar();
        }
    }
}
