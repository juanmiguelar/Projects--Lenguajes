using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Cliente
    {
        public String Cedula { get; set; }
        public String Nombre { get; set; }

        public Cliente() { }

        public Cliente(String ced, String Nombre) {
            this.Cedula = ced;
            this.Nombre = Nombre;
        }
    }
}
