using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleEF.Models;

namespace SampleEF.Controllers
{
    public class LoginController : Controller
    {
        private SampleDbEntities db = new SampleDbEntities();

        // GET: Login
        public ActionResult Index()
        {
           
            return View();
        }

        public ActionResult LoginUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginUser(string username,string password)
        {
            var result = (from p in db.Penggunas
                          where p.Username == username && p.Password == password
                          select p).FirstOrDefault();

            if (result!=null)
            {
                Session["username"] = username;
                return RedirectToAction("Index", "Negara");
            }
            else
            {
                ViewBag.Error = "<div class='alert alert-danger'>"+
                    "Gagal melakukan login, cek username atau password"+"</div>";
            }

            return View();
        }

        public ActionResult Logout()
        {
            Session["username"] = null;
            //Session.RemoveAll();
            return RedirectToAction("LoginUser", "Login");
        }



    }
}