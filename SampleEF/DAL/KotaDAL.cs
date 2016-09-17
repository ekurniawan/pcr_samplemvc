using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SampleEF.Models;

namespace SampleEF.DAL
{
    public class KotaDAL : IMasterClass<Kota>
    {
        private SampleDbEntities db;

        public KotaDAL()
        {
            db = new SampleDbEntities();
        }

        public void Delete(Kota obj)
        {
            //implementasi delete
            throw new NotImplementedException();
        }

        public IQueryable<Kota> GetAll()
        {
            var results = from k in db.Kotas.Include("Negara")
                          orderby k.NamaKota
                          select k;

            return results;
        }

        public IQueryable<Kota> GetAll(string keyword)
        {
            //keterangan
            throw new NotImplementedException();
        }

        public Kota GetById(string Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Kota obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Kota obj)
        {
            throw new NotImplementedException();
        }
    }
}