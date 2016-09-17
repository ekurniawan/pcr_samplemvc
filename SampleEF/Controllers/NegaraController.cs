using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SampleEF.Models;
using SampleEF.DAL;

using X.PagedList;

namespace SampleEF.Controllers
{
    public class NegaraController : Controller
    {

        public ActionResult SamplePaging(int? page)
        {
            NegaraDAL negaraDal = new NegaraDAL();
            var results = negaraDal.GetAll();
            var pageNumber = page ?? 1;
            var ListNegara = results.ToPagedList(pageNumber, 3);
            //ViewBag.ListNegara = ListNegara;
            return View(ListNegara);
        }

        // GET: Negara
        public ActionResult Index(string keyword = "")
        {
            string username;
            if(Session["username"]!=null)
            {
                username = Session["username"].ToString();
                NegaraDAL negaraDal = new NegaraDAL();
                ViewBag.Username = username;
                return View(negaraDal.GetAll(keyword));
            }
            else
            {
                return RedirectToAction("LoginUser", "Login");
            }

           
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
