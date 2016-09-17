using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SampleEF.Models;

namespace SampleEF.DAL
{
    public class MahasiswaDAL : IMasterClass<Mahasiswa>
    {
        private SampleDbEntities db;

        public MahasiswaDAL()
        {
            db = new SampleDbEntities();
        }

        public void Delete(Mahasiswa obj)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Mahasiswa> GetAll()
        {
            var results = from m in db.Mahasiswas.Include("Kota").Include("Kota.Negara")
                          orderby m.Nama
                          select m;

            return results;
        }

        public IQueryable<Mahasiswa> GetAll(string keyword)
        {
            throw new NotImplementedException();
        }

        public Mahasiswa GetById(string Id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Mahasiswa obj)
        {
            throw new NotImplementedException();
        }

        public void Update(Mahasiswa obj)
        {
            throw new NotImplementedException();
        }
    }
}