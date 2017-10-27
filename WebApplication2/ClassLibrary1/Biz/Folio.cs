using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Biz
{
    public class Folio
    {
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private int DNI { get; set; }
        private int Libro { get; set; }

        public Folio(string nombre, string apellido, int dni, int Libro) {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
        }

        public Folio() {

        }
    }
}
