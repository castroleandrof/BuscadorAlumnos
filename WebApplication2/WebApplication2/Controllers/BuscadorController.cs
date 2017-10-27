using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Biz;
using WebApplication2.BLL;

namespace WebApplication2.Controllers
{
    public class BuscadorController : Controller
    {
        // GET: Buscador
        //public ActionResult Index()
        //{
        //    return View();
        //}

        // GET: Buscador/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Buscador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Buscador/Create
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

        // GET: Buscador/Edit/5
        public ActionResult Index(string id)
        {
            var list = FolioBusiness.BuscarNombre("leandro", "castro");
            return View(list);
        }

        // POST: Buscador/Edit/5
        [HttpPost]
        public ActionResult Index(Folio folio)
        {
            //try
            //{
            //var lista = FolioBusiness.GetFolioList();
            //return View(lista);
                var list = FolioBusiness.BuscarNombre(folio.Nombre, folio.Apellido);
                return View(list);
            //}
            //catch
            //{
            //    return View();
            //}
        }

        // GET: Buscador/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Buscador/Delete/5
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
