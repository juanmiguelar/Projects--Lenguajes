using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Producto
    {
        public String Codigo { get; set; }
        public String Descripcion { get; set; }
        public int Precio { get; set; }

        public Producto() { }

        public Producto(String cod, String des, int precio) {
            this.Codigo = cod;
            this.Descripcion = des;
            this.Precio = precio;
        }
    }
}
