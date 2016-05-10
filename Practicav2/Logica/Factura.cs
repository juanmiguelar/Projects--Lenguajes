using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjetosTransferencia;
using AccesoDatos;

namespace Logica
{
    public class Factura
    {
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente ClienteF { get; set; }
        public DetalleFactura detalle { get; set; }

        public Factura() { }

        public Factura(int num, DateTime fecha, Cliente c, DetalleFactura d) {
            this.Numero = num;
            this.Fecha = fecha;
            this.ClienteF = c;
            this.detalle = d;
        }

        public int guardar() {

            DAOFactura daoF = new DAOFactura();
            TOFactura toF = new TOFactura();
            toF.ClienteF = this.getTOCliente();
            toF.detalle = this.getTODetalle();
            toF.Total = detalle.total();

            toF = daoF.guardar(toF);

            this.Numero = toF.Numero;
            this.Fecha = toF.Fecha;

            return this.Numero;
        }

        private TODetalleFactura getTODetalle() {

            TODetalleFactura toD = new TODetalleFactura();

            foreach (Producto item in detalle.lista)
            {
                toD.lista.Add(new TOProducto(item.Codigo, item.Descripcion, item.Precio));
            }

            return toD;
        }

        private TOCliente getTOCliente() {
            return new TOCliente(ClienteF.Cedula, ClienteF.Nombre);
        }

    }
}
