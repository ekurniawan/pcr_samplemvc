using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SampleEF.Models;

namespace SampleEF.DAL
{
    public class KotaDAL : IMasterClass<Kota>
    {
        public void Delete(Kota obj)
        {
            //implementasi delete
            throw new NotImplementedException();
        }

        public IQueryable<Kota> GetAll(string keyword)
        {
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