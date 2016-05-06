using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Pedido : Guardable
    {
        public List<Disenno> Disennos { set; get; }
        public Cliente Cliente { set; get; }

        public Pedido() {}

        public Pedido(List<Disenno> disennos, Cliente cliente) {
            this.Disennos = disennos;
            this.Cliente = cliente;
        }

        public int guardar() {
            return 0;
        }

    }
}
