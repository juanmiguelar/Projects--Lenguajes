using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class DetalleFactura
    {
        public String NumeroFactura { get; set; }
        public List<Producto> lista { get; set; }

        public DetalleFactura() {
            this.lista = new List<Producto>();
        }

        public DetalleFactura(String num, List<Producto> lista)
        {
            this.NumeroFactura = num;
            this.lista = lista;
        }

        public int total()
        {

            int total = 0;

            foreach (Producto item in lista)
            {
                total += item.Precio;
            }

            return total;
        }
    }
}
