using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectosTransferencia
{
    public class TOPedido
    {
        public List<TODisenno> Disennos { set; get; }
        public TOCliente Cliente { set; get; }

        public TOPedido() { }

        public TOPedido(List<TODisenno> disennos, TOCliente cliente)
        {
            this.Disennos = disennos;
            this.Cliente = cliente;
        }
    }
}
