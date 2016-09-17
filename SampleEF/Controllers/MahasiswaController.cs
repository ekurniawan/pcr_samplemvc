using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SampleEF.Models;
using SampleEF.DAL;

namespace SampleEF.Controllers
{
    public class MahasiswaController : Controller
    {
        // GET: Mahasiswa
        public ActionResult Index()
        {
            if (Session["username"] == null)
                return RedirectToAction("Login", "Pengguna");

            MahasiswaDAL mhsDal = new MahasiswaDAL();
            return View(mhsDal.GetAll());
        }

        // GET: Mahasiswa/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mahasiswa/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mahasiswa/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mahasiswa/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mahasiswa/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mahasiswa/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mahasiswa/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
