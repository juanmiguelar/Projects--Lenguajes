using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosTransferencia
{
    public class TODetalleFactura
    {
        public String NumeroFactura { get; set; }
        public List<TOProducto> lista { get; set; }

        public TODetalleFactura() {
            lista = new List<TOProducto>();
        }

        public TODetalleFactura(String num, List<TOProducto> lista)
        {
            this.NumeroFactura = num;
            this.lista = lista;
        }
    }
}
