using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PROJECT2MVC.Models;

namespace PROJECT2MVC.Controllers
{
    [Authorize]
    public class ProductenController : Controller
    {
        private CRMEntities db = new CRMEntities();

        //
        // GET: /Producten/

        public ActionResult Index()
        {
            return View(db.Producten.ToList());
        }

        //
        // GET: /Producten/Details/5

        public ActionResult Details(int id = 0)
        {
            Product product = db.Producten.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        //
        // GET: /Producten/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Producten/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            //laatste productId opvragen en verhogen met 1 om de nieuwe productId te creëren 
            //- foutmelding "Violation of PK constraint" vermijden 
            //- EF voegt anders steeds product met productId 0 toe
            product.ProductId = db.Producten.Max(p => p.ProductId) + 1;
            if (ModelState.IsValid)
            {
                db.Producten.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }

        //
        // GET: /Producten/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Product product = db.Producten.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        //
        // POST: /Producten/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        //
        // GET: /Producten/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Product product = db.Producten.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        //
        // POST: /Producten/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Producten.Find(id);
            db.Producten.Remove(product);
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