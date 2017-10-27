using System.Collections.Generic;
using System.Linq;
using System;
using Db4objects.Db4o;
using WebApplication2.Biz;

namespace WebApplication2.DAL
{

    public class FolioRepository : BaseRepository, ICrud<Folio>
    {
        
        public void Add(Folio Folio)
        {

            using (var db = Db4oFactory.OpenFile(Path))
            {
                db.Store(Folio);
                db.Commit();
                db.Close();
            }
        }
    
        public List<Folio> All()
        {
            var lista = new List<Folio>();
            using (var db = Db4oFactory.OpenFile(Path))
            {
                var result = db.QueryByExample(new Folio());
                while (result != null && result.HasNext()) lista.Add((Folio)result.Next());

                db.Close();
            }
            return lista;
        }
        public FolioRepository(bool res) {

        }

        public FolioRepository()
        {
        }

        public void Delete(Folio model)
        {
            using (var db = Db4oFactory.OpenFile(Path))
            {
                var result = db.QueryByExample(new Folio {Id = model.Id});
                var proto = (Folio) result[0];
                db.Delete(proto);
                db.Commit();
                db.Close();
            }
        }
       
        public void Edit(Folio model)
        {
            using (var db = Db4oFactory.OpenFile(Path))
            {
                var result = db.QueryByExample(new Folio { Id = model.Id });
                var proto = (Folio)result[0];
                ObjectMapper(model, proto);
                db.Store(proto);
                db.Commit();
                db.Close();
            }
        }

       
        
        public Folio Find(Folio model)
        {
            Folio proto;
            using (var db = Db4oFactory.OpenFile(Path))
            {
                var result = db.QueryByExample(model);
                proto = (Folio)result[0];
                db.Close();
            }
            return proto;
        }

        public Folio Find_id(string id)
        {
            Folio proto;
            using (var db = Db4oFactory.OpenFile(Path))
            {
                var result = db.QueryByExample(new Folio { Id = id });
                proto = (Folio)result[0];
                db.Close();
            }

            return proto;
        }

        public ParallelQuery<Folio> ParallelQuery()
        {
            var lista = new List<Folio>();
            using (var db = Db4oFactory.OpenFile(Path))
            {
                var result = db.QueryByExample(new Folio(null, null, 0, 0));
                while (result != null && result.HasNext()) lista.Add((Folio)result.Next());
                db.Close();
            }
            return lista.AsParallel();
        }

    }
}