using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SistemaBancario.Models;

namespace SistemaBancario.Controllers
{
    public class CuentaBancariaController : Controller
    {
        private Contexto db = new Contexto();

        // GET: CuentaBancaria
        public ActionResult Index()
        {
            return View(db.CuentaBancaria.ToList());
        }

        // GET: CuentaBancaria/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CuentaBancaria cuentaBancaria = db.CuentaBancaria.Find(id);
            if (cuentaBancaria == null)
            {
                return HttpNotFound();
            }
            return View(cuentaBancaria);
        }

        // GET: CuentaBancaria/Create
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NumeroCuenta,NombreCuenta")] CuentaBancaria cuentaBancaria)
        {
            if (ModelState.IsValid)
            {
                db.CuentaBancaria.Add(cuentaBancaria);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cuentaBancaria);
        }

        // GET: CuentaBancaria/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CuentaBancaria cuentaBancaria = db.CuentaBancaria.Find(id);
            if (cuentaBancaria == null)
            {
                return HttpNotFound();
            }
            return View(cuentaBancaria);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NumeroCuenta,NombreCuenta")] CuentaBancaria cuentaBancaria)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cuentaBancaria).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cuentaBancaria);
        }

        // GET: CuentaBancaria/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CuentaBancaria cuentaBancaria = db.CuentaBancaria.Find(id);
            if (cuentaBancaria == null)
            {
                return HttpNotFound();
            }
            return View(cuentaBancaria);
        }

        // POST: CuentaBancaria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CuentaBancaria cuentaBancaria = db.CuentaBancaria.Find(id);
            db.CuentaBancaria.Remove(cuentaBancaria);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
