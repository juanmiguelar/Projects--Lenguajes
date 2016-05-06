using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Cliente : Guardable
    {

        public int ID_Cliente { get; set; }
        public String Nombre { get; set; }

        public Cliente() {

        }

        public Cliente(int id, String nombre) {
            this.ID_Cliente = id;
            this.nombre = nombre;
        }
        
        public int guardar() {
            return 0;
        }
    }
}
