using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SampleEF.Models;
using SampleEF.DAL;
using SampleEF.Helpers;

namespace SampleEF.DAL
{
    public class PenggunaDAL
    {
        private SampleDbEntities db;
        public PenggunaDAL()
        {
            db = new SampleDbEntities();
        }

        public IQueryable<Pengguna> GetAll()
        {
            return db.Penggunas.OrderBy(p => p.Username);
        }

        public void Registrasi(Pengguna pengguna)
        {
            var newPengguna = new Pengguna
            {
                Username = pengguna.Username,
                Password = Enkripsi.GetMd5(pengguna.Password),
                Role = pengguna.Role
            };
            try
            {
                db.Penggunas.Add(newPengguna);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool CekLogin(Pengguna pengguna)
        {
            string hashPass = Enkripsi.GetMd5(pengguna.Password);
            var result = (from p in db.Penggunas
                         where p.Username == pengguna.Username &&
                         p.Password == hashPass
                         select p).FirstOrDefault();

            if (result != null)
                return true;
            else
                return false;

        }
    }
}