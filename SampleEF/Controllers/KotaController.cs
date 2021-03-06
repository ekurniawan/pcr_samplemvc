﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SampleEF.Models;
using SampleEF.DAL;

namespace SampleEF.Controllers
{
    [Authorize]
    public class KotaController : Controller
    {
        // GET: Kota
        [Authorize(Users = "erick@actual-training.com")]
        public ActionResult Index()
        {
            KotaDAL kotaDal = new KotaDAL();
            var results = kotaDal.GetAll();
            return View(results);
        }

        // GET: Kota/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Kota/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kota/Create
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

        // GET: Kota/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Kota/Edit/5
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

        // GET: Kota/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Kota/Delete/5
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
