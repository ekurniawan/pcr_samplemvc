using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SampleEF.Models;

namespace SampleEF.DAL
{
    public class NegaraDAL : IMasterClass<Negara>
    {
        private SampleDbEntities db;

        public NegaraDAL()
        {
            db = new SampleDbEntities();
        }

        public void Delete(Negara obj)
        {
            var result = GetById(obj.NegaraId.ToString());
            try
            {
                db.Negaras.Remove(result);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IQueryable<Negara> GetAll(string keyword="")
        {
            //var result = db.Negaras.OrderBy(n => n.NamaNegara);
            IQueryable<Negara> results;
            if(keyword=="")
            {
                results = from n in db.Negaras
                              orderby n.NamaNegara ascending
                              select n;
            }
            else
            {
                results = from n in db.Negaras
                          where n.NamaNegara.Contains(keyword)
                          orderby n.NamaNegara ascending
                          select n;
            }
            return results;
        }

        public Negara GetById(string Id)
        {
            int intId = Convert.ToInt32(Id);
            var result = (from n in db.Negaras
                         where n.NegaraId == intId 
                         select n).FirstOrDefault();
            return result;
        }

        public void Insert(Negara obj)
        {
            try
            {
                db.Negaras.Add(obj);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Update(Negara obj)
        {
            var result = GetById(obj.NegaraId.ToString());
            try
            {
                result.NamaNegara = obj.NamaNegara;
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}