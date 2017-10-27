using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication2.Biz
{
    public class Folio
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int DNI { get; set; }
        public int Libro { get; set; }
        public String Id { get; set; }


        public Folio(string nombre, string apellido, int dni, int Libro) {
            Nombre = nombre;
            Apellido = apellido;
            DNI = dni;
        }

        public Folio() {

        }
    }
}
