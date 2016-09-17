using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SampleEF.Models;
using SampleEF.DAL;

namespace SampleEF.Controllers
{
    public class PenggunaController : Controller
    {
        // GET: Pengguna
        public ActionResult Index()
        {
            PenggunaDAL pgnDal = new PenggunaDAL();
            return View(pgnDal.GetAll());
        }

        public ActionResult Registrasi()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registrasi(Pengguna pengguna)
        {
            PenggunaDAL pgnDal = new PenggunaDAL();
            try
            {
                pgnDal.Registrasi(pengguna);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Pengguna pgn)
        {
            PenggunaDAL pgnDal = new PenggunaDAL();
            if(pgnDal.CekLogin(pgn))
            {
                Session["username"] = pgn.Username;
                Session["role"] = pgn.Role;
                return RedirectToAction("Index", "Mahasiswa");
            }
            else
            {
                ViewBag.Error = "<div class='alert alert-danger'>Cek username dan password anda</div>";
                return View();
            }
        }
    }
}