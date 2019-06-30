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
    public class FilmesUtilizadoresController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: FilmesUtilizadores
        public ActionResult Index()
        {
            var filmesUtilizadores = db.FilmesUtilizadores.Include(f => f.Filme).Include(f => f.Utilizador);
            return View(filmesUtilizadores.ToList());
        }

        // GET: FilmesUtilizadores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FilmesUtilizadores filmesUtilizadores = db.FilmesUtilizadores.Find(id);
            if (filmesUtilizadores == null)
            {
                return HttpNotFound();
            }
            return View(filmesUtilizadores);
        }

        // GET: FilmesUtilizadores/Create
        public ActionResult Create()
        {
            ViewBag.FilmeFK = new SelectList(db.Filmes, "ID", "Titulo");
            ViewBag.UtilizadorFK = new SelectList(db.Utilizadores, "ID", "Nome");
            return View();
        }

        // POST: FilmesUtilizadores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdClassificacao,Classificacao,FilmeFK,UtilizadorFK")] FilmesUtilizadores filmesUtilizadores)
        {
            if (ModelState.IsValid)
            {
                db.FilmesUtilizadores.Add(filmesUtilizadores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FilmeFK = new SelectList(db.Filmes, "ID", "Titulo", filmesUtilizadores.FilmeFK);
            ViewBag.UtilizadorFK = new SelectList(db.Utilizadores, "ID", "Nome", filmesUtilizadores.UtilizadorFK);
            return View(filmesUtilizadores);
        }

        // GET: FilmesUtilizadores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FilmesUtilizadores filmesUtilizadores = db.FilmesUtilizadores.Find(id);
            if (filmesUtilizadores == null)
            {
                return HttpNotFound();
            }
            ViewBag.FilmeFK = new SelectList(db.Filmes, "ID", "Titulo", filmesUtilizadores.FilmeFK);
            ViewBag.UtilizadorFK = new SelectList(db.Utilizadores, "ID", "Nome", filmesUtilizadores.UtilizadorFK);
            return View(filmesUtilizadores);
        }

        // POST: FilmesUtilizadores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdClassificacao,Classificacao,FilmeFK,UtilizadorFK")] FilmesUtilizadores filmesUtilizadores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(filmesUtilizadores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FilmeFK = new SelectList(db.Filmes, "ID", "Titulo", filmesUtilizadores.FilmeFK);
            ViewBag.UtilizadorFK = new SelectList(db.Utilizadores, "ID", "Nome", filmesUtilizadores.UtilizadorFK);
            return View(filmesUtilizadores);
        }

        // GET: FilmesUtilizadores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FilmesUtilizadores filmesUtilizadores = db.FilmesUtilizadores.Find(id);
            if (filmesUtilizadores == null)
            {
                return HttpNotFound();
            }
            return View(filmesUtilizadores);
        }

        // POST: FilmesUtilizadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FilmesUtilizadores filmesUtilizadores = db.FilmesUtilizadores.Find(id);
            db.FilmesUtilizadores.Remove(filmesUtilizadores);
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
