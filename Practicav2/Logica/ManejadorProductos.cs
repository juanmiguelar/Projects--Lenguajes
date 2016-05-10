using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using ObjetosTransferencia;

namespace Logica
{
    public class ManejadorProductos
    {

        public ManejadorProductos() { }

        public Producto buscar(String cod) {

            DAOProducto daoP = new DAOProducto();

            TOProducto toP = daoP.buscar(cod);

            return new Producto(toP.Codigo, toP.Descripcion, toP.Precio);
        }
    }
}
