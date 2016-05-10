using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosTransferencia
{
    public class TOFactura
    {
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public TOCliente ClienteF { get; set; }
        public TODetalleFactura detalle { get; set; }
        public int Total { get; set; }

        public TOFactura() { }

        public TOFactura(int num, DateTime fecha, TOCliente c, TODetalleFactura d, int t)
        {
            this.Numero = num;
            this.Fecha = fecha;
            this.ClienteF = c;
            this.detalle = d;
            this.Total = t;
        }
    }
}
