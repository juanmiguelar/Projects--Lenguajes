using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosTransferencia
{
    public class TOListaClientes
    {
        public List<TOCliente> lista { get; set; }

        public TOListaClientes()
        {
            lista = new List<TOCliente>();
        }
    }
}
