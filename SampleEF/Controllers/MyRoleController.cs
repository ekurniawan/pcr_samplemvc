
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using SampleEF.Models;

namespace SampleEF.Controllers
{
    public class MyRoleController : Controller
    {
        private SampleDbEntities db;

        public MyRoleController()
        {
            db = new SampleDbEntities();
        }

        // GET: MyRole
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddRole()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddRole(IdentityRole roleName)
        {
            using (var roleManager =
                new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db)))
            {
                roleManager.Create(roleName);
                return RedirectToAction("Index");
            }
        }
    }
}