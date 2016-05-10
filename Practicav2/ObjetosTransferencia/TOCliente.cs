using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjetosTransferencia
{
    public class TOCliente
    {
        public String Cedula { get; set; }
        public String Nombre { get; set; }

        public TOCliente() { }

        public TOCliente(String ced, String Nombre)
        {
            this.Cedula = ced;
            this.Nombre = Nombre;
        }
    }
}
