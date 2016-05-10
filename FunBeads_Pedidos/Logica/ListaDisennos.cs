using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectosTransferencia;
using EnlaceDatos;

namespace Logica
{
    public class ListaDisennos
    {
        public List<Disenno> lista { get; set; }

        public ListaDisennos() {
            lista = new List<Disenno>();
        }

        public void cargar() {
            TOListaDisennos toLD;
            DAOListaDisenno daoLD = new DAOListaDisenno();

            toLD = daoLD.cargar();

            lista = convert(toLD.lista);
        }

        public void refresh() {
            lista = new List<Disenno>();
            cargar();
        }

        private List<Disenno> convert(List<TODisenno> l2) {
            List<Disenno> l1 = new List<Disenno>();
            foreach (TODisenno item in l2)
            {
                l1.Add(new Disenno(item.ID_Disenno, item.Nombre, item.Descripcion, item.Tipo, item.Precio));
            }

            return l1;
        }
    }
}
