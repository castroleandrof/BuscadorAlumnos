using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Biz;
using WebApplication2.DAL;

namespace WebApplication2.BLL
{
         public class FolioBusiness
        {

            public static void Add(Folio folio)
            {
            folio.Id = Guid.NewGuid().ToString();
            var cdal = new FolioRepository();
            cdal.Add(folio);
            }

            public static List<Folio> GetFolioList()
            {
                var cdal = new FolioRepository();
                return cdal.All();
            }

            public static Folio Find(Folio categoria)
            {
                var cdal = new FolioRepository();
                return cdal.Find(categoria);
            }

             public static Folio Find_Id(string Id)
            {
            var cdal = new FolioRepository();
            return cdal.Find_id(Id);
            }


        public static void Edit(Folio categoria)
            {
                var cdal = new FolioRepository();
                cdal.Edit(categoria);
            }
        public static List<Folio> BuscarNombre(string nombre, string apellido)
        {
            List<Folio> listFolio = new List<Folio>();
            FolioRepository db = new FolioRepository(false);
            var lista = db.All().Where(o => o.Nombre.Equals(nombre, StringComparison.InvariantCultureIgnoreCase) && o.Apellido.Equals(apellido, StringComparison.InvariantCultureIgnoreCase));
            foreach (Folio x in lista) {
                listFolio.Add(x);
            }        
            return listFolio;

        }

        public static void Delete(Folio categoria)
            {
                var cdal = new FolioRepository();
                cdal.Delete(categoria);
            }

        }
    }
