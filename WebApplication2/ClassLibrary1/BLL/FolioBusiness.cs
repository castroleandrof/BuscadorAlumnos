using ClassLibrary1.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAppDb4o.Data;

namespace ClassLibrary1.BLL
{
         public class FolioBusiness
        {

            public static void Add(Folio categoria)
            {
                var cdal = new FolioRepository();
                cdal.Add(categoria);
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

            public static void Edit(Folio categoria)
            {
                var cdal = new FolioRepository();
                cdal.Edit(categoria);
            }
                 
            public static void Delete(Folio categoria)
            {
                var cdal = new FolioRepository();
                cdal.Delete(categoria);
            }

        }
    }
