using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PROJECT2MVC.Models;
using System.ComponentModel.DataAnnotations;

namespace PROJECT2MVC.Controllers
{
    [Authorize]
    public class CategorieController : Controller
    {
        private CRMEntities db = new CRMEntities();

        //
        // GET: /Categorie/

        public ActionResult Index()
        {
            return View(db.Categorieën.ToList());
        }

        //
        // GET: /Categorie/Details/5

        public ActionResult Details(string id = null)
        {
            Categorie categorie = db.Categorieën.Find(id);
            if (categorie == null)
            {
                return HttpNotFound();
            }
            return View(categorie);
        }

        //
        // GET: /Categorie/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Categorie/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Categorie categorie)
        {
            if (ModelState.IsValid)
            {
                db.Categorieën.Add(categorie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(categorie);
        }

        //
        // GET: /Categorie/Edit/5

        public ActionResult Edit(string id = null)
        {
            Categorie categorie = db.Categorieën.Find(id);
            if (categorie == null)
            {
                return HttpNotFound();
            }
            return View(categorie);
        }

        //
        // POST: /Categorie/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Categorie categorie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categorie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categorie);
        }

        //
        // GET: /Categorie/Delete/5

        public ActionResult Delete(string id = null)
        {
            Categorie categorie = db.Categorieën.Find(id);
            if (categorie == null)
            {
                return HttpNotFound();
            }
            return View(categorie);
        }

        //
        // POST: /Categorie/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Categorie categorie = db.Categorieën.Find(id);
            db.Categorieën.Remove(categorie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}