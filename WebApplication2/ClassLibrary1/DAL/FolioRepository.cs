using System.Collections.Generic;
using System.Linq;
using Db4objects.Db4o;
using ClassLibrary1.Biz;
using System;

namespace WebAppDb4o.Data
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
                var result = db.QueryByExample(new Folio { RowGuid = model.RowGuid });
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
        
        public ParallelQuery<Folio> ParallelQuery()
        {
            var lista = new List<Folio>();
            using (var db = Db4oFactory.OpenFile(Path))
            {
                var result = db.QueryByExample(new Folio(null, null, null, 0, null));
                while (result != null && result.HasNext()) lista.Add((Folio)result.Next());
                db.Close();
            }
            return lista.AsParallel();
        }

        void ICrud<Folio>.Add(Folio model)
        {
            throw new NotImplementedException();
        }

        List<Person> ICrud<Folio>.All()
        {
            throw new NotImplementedException();
        }

        void ICrud<Folio>.Delete(Folio model)
        {
            throw new NotImplementedException();
        }

        void ICrud<Folio>.Edit(Folio model)
        {
            throw new NotImplementedException();
        }

        Folio ICrud<Folio>.Find(Folio model)
        {
            throw new NotImplementedException();
        }

        ParallelQuery<Folio> ICrud<Folio>.ParallelQuery()
        {
            throw new NotImplementedException();
        }
    }
}