using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PopCinema.Models;

namespace PopCinema.Controllers
{
    public class FilmesAtoresController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: FilmesAtores
        public ActionResult Index()
        {
            var filmesAtores = db.FilmesAtores.Include(f => f.Ator).Include(f => f.Filme);
            return View(filmesAtores.ToList());
        }

        // GET: FilmesAtores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FilmesAtores filmesAtores = db.FilmesAtores.Find(id);
            if (filmesAtores == null)
            {
                return HttpNotFound();
            }
            return View(filmesAtores);
        }

        // GET: FilmesAtores/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            ViewBag.AtorFK = new SelectList(db.Atores, "ID", "Nome");
            ViewBag.FilmeFK = new SelectList(db.Filmes, "ID", "Titulo");
            return View();
        }

        // POST: FilmesAtores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FilmeFK,AtorFK,Personagem")] FilmesAtores filmesAtores)
        {
            if (ModelState.IsValid)
            {
                db.FilmesAtores.Add(filmesAtores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AtorFK = new SelectList(db.Atores, "ID", "Nome", filmesAtores.AtorFK);
            ViewBag.FilmeFK = new SelectList(db.Filmes, "ID", "Titulo", filmesAtores.FilmeFK);
            return View(filmesAtores);
        }

        // GET: FilmesAtores/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FilmesAtores filmesAtores = db.FilmesAtores.Find(id);
            if (filmesAtores == null)
            {
                return HttpNotFound();
            }
            ViewBag.AtorFK = new SelectList(db.Atores, "ID", "Nome", filmesAtores.AtorFK);
            ViewBag.FilmeFK = new SelectList(db.Filmes, "ID", "Titulo", filmesAtores.FilmeFK);
            return View(filmesAtores);
        }

        // POST: FilmesAtores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FilmeFK,AtorFK,Personagem")] FilmesAtores filmesAtores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(filmesAtores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AtorFK = new SelectList(db.Atores, "ID", "Nome", filmesAtores.AtorFK);
            ViewBag.FilmeFK = new SelectList(db.Filmes, "ID", "Titulo", filmesAtores.FilmeFK);
            return View(filmesAtores);
        }

        // GET: FilmesAtores/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FilmesAtores filmesAtores = db.FilmesAtores.Find(id);
            if (filmesAtores == null)
            {
                return HttpNotFound();
            }
            return View(filmesAtores);
        }

        // POST: FilmesAtores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FilmesAtores filmesAtores = db.FilmesAtores.Find(id);
            db.FilmesAtores.Remove(filmesAtores);
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
