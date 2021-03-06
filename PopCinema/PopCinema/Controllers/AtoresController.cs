﻿
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
    public class AtoresController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Atores
        public ActionResult Index()
        {
            return View(db.Atores.ToList());
        }

        // GET: Atores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Atores ator = db.Atores.Find(id);
            if (ator == null)
            {
                TempData["Error"] = "Unexpected error";
                return RedirectToAction("Index");
            }
            return View(ator);
        }

        // GET: Atores/Create
        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Atores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Nome,Biografia,Sexo,Nacionalidade,DataNascimento,FotoAtor")] Atores ator)
        {
            if (ModelState.IsValid)
            {
                db.Atores.Add(ator);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ator);
        }

        // GET: Atores/Edit/5
        [Authorize(Roles = "Admin")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                //cria mensagem de erro
                TempData["Error"] = "Unexpected error";
                return RedirectToAction("Index");
            }
            Atores ator = db.Atores.Find(id);
            if (ator == null)
            {
                TempData["Error"] = "Unexpected error";
                return RedirectToAction("Index");
            }
            return View(ator);
        }

        // POST: Atores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Nome,Biografia,Sexo,Nacionalidade,DataNascimento,FotoAtor")] Atores ator)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ator).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ator);
        }

        // GET: Atores/Delete/5
        [Authorize(Roles = "Admin")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                TempData["Error"] = "Unexpected error";
                return RedirectToAction("Index");
            }
            Atores ator = db.Atores.Find(id);
            if (ator == null)
            {
                TempData["Error"] = "Unexpected error";
                return RedirectToAction("Index");
            }
            return View(ator);
        }

        // POST: Atores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Atores ator = db.Atores.Find(id);
            db.Atores.Remove(ator);
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
