using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectosTransferencia;
using EnlaceDatos;

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

        public Disenno(String Nombre, String Descripcion, String Tipo, int Precio)
        {

            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.Tipo = Tipo;
            this.Precio = Precio;
        }

        public int guardar() {
            DAODisenno daod = new DAODisenno();
            TODisenno tod = new TODisenno(this.Nombre, this.Descripcion, this.Tipo, this.Precio);

            tod = daod.guardar(tod);

            this.ID_Disenno = tod.ID_Disenno;

            return this.ID_Disenno;

        }

    }
}
