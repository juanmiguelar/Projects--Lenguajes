using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Disenno : Guardable
    {
        public int ID_Disenno { get; set; }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public String Tipo { get; set; }
        public int Precio { get; set; }

        public Disenno() { }

        public Disenno(int ID_Disenno, String Nombre, String Descripcion, String Tipo, int Precio) {
            this.ID_Disenno = ID_Disenno;
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Tipo = Tipo;
            this.Precio = Precio;
        }

        public int guardar() {
            return 0;
        }

    }
}
