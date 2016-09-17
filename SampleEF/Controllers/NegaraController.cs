using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SampleEF.Models;
using SampleEF.DAL;

namespace SampleEF.Controllers
{
    public class NegaraController : Controller
    {
        // GET: Negara
        public ActionResult Index(string keyword = "")
        {
            NegaraDAL negaraDal = new NegaraDAL();
            return View(negaraDal.GetAll(keyword));
        }

        // GET: Negara/Details/5
        public ActionResult Details(int id)
        {
            NegaraDAL negaraDAL = new NegaraDAL();
            return View(negaraDAL.GetById(id.ToString()));
        }

        // GET: Negara/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Negara/Create
        [HttpPost]
        public ActionResult Create(Negara negara)
        {
            NegaraDAL negaraDal = new NegaraDAL();
            try
            {
                if (ModelState.IsValid)
                {
                    negaraDal.Insert(negara);
                }
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Error: " + ex.Message;
                return View();
            }
        }

        // GET: Negara/Edit/5
        public ActionResult Edit(int id)
        {
            NegaraDAL negaraDal = new NegaraDAL();
            var result = negaraDal.GetById(id.ToString());
            return View(result);
        }

        // POST: Negara/Edit/5
        [HttpPost]
        public ActionResult Edit(Negara negara)
        {
            NegaraDAL negaraDal = new NegaraDAL();
            try
            {
                negaraDal.Update(negara);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Error = "<div class='alert alert-danger'>" + ex.Message + "</div>";
                return View();
            }
        }

        // GET: Negara/Delete/5
        public ActionResult Delete(int id)
        {
            NegaraDAL negaraDal = new NegaraDAL();
            var result = negaraDal.GetById(id.ToString());

            return View(result);
        }

        // POST: Negara/Delete/5
        [HttpPost]
        public ActionResult Delete(Negara negara)
        {
            NegaraDAL negaraDal = new NegaraDAL();
            try
            {
                negaraDal.Delete(negara);
                return RedirectToAction("Index");
            }
            catch(Exception ex)
            {
                ViewBag.Error = "<div class='alert alert-danger'>" + ex.Message + "</div>";
                return View();
            }
        }
    }
}
