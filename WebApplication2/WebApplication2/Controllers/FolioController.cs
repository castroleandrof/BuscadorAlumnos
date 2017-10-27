using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Biz;
using WebApplication2.BLL;

namespace WebApplication2.Controllers
{
    public class FolioController : Controller
    {
        // GET: Folio
        public ActionResult Index()
        {
            var lista = FolioBusiness.GetFolioList();
            return View(lista);
        }

        // GET: Folio/Details/5
        public ActionResult Details(string id)
        {
            Console.WriteLine(id);
            var folio = FolioBusiness.Find_Id(id);
            return View(folio);
        }

        // GET: Folio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Folio/Create
        [HttpPost]
        public ActionResult Create(Folio model)
        {
            try
            {
                FolioBusiness.Add(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Folio/Edit/5
        public ActionResult Edit(string id)
        {
            var folio = FolioBusiness.Find_Id(id);
            return View(folio);
        }

        // POST: Folio/Edit/5
        [HttpPost]
        public ActionResult Edit(Folio model)
        {
            try
            {
                // TODO: Add update logic here

                FolioBusiness.Edit(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Folio/Delete/5
        public ActionResult Delete(string id)
        {
            var student = FolioBusiness.Find_Id(id);
            return View(student);
        }

        // POST: Folio/Delete/5
        [HttpPost]
        public ActionResult Delete(Folio model)
        {
            try
            {
                // TODO: Add delete logic here
                FolioBusiness.Delete(model);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
