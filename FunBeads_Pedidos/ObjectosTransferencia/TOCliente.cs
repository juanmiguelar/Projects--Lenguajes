using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectosTransferencia
{
    public class TOCliente
    {
        public int ID_Cliente { get; set; }
        public String Nombre { get; set; }

        public TOCliente()
        {

        }

        public TOCliente(int id, String nombre)
        {
            this.ID_Cliente = id;
            this.Nombre = nombre;
        }
    }
}
