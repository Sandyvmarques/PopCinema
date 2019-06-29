using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PopCinema.Models;

namespace PopCinema.Controllers
{
    public class FilmesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Filmes
        public ActionResult Index()
        {
            return View(db.Filmes.ToList());
        }

        // GET: Filmes/Details/5
        /// <summary>
        /// Mostra os dados de um Filme
        /// </summary>
        /// <param name="id">identifica um filme</param>
        /// <returns>devolve a View com os dados</returns>
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                //caso não seja devolvido nenhum id, o utilizador
                //retorna para a página Index

                return RedirectToAction("Index");
            }

            Filmes filme = db.Filmes.Find(id);
            if (filme == null)
            {
                //o filme não foi encontrado (não existe)
                return RedirectToAction("Index");
            }

            //enviar para a View os dados do Filme que foi procurado e encontrado
            return View(filme);
        }

        // GET: Filmes/Create
        public ActionResult Create()
        {
            return View();
        }

		// POST: Filmes/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "ID,Titulo,Ano,Sinopse,Capa,Trailer")] Filmes filme, HttpPostedFileBase UploadImag)
		{
			string path = "";
			bool PictureExist=false;

			if (UploadImag == null)
			{
				filme.Capa = "noPoster.jpg";
			}
			else
			{
				if (UploadImag.ContentType == "image/jpg" ||
					UploadImag.ContentType == "image/png")
				{
					string extensao = Path.GetExtension(UploadImag.FileName).ToLower();
					Guid g;
					g = Guid.NewGuid();
					string nome = g.ToString() + extensao;
					path= Path.Combine(Server.MapPath("~/Imagens/CapasFilmes"), nome);
					filme.Capa = nome;
					PictureExist = true;
				}
			}
		
				if (ModelState.IsValid)
            {
				try
				{
					db.Filmes.Add(filme);
					db.SaveChanges();
					if (PictureExist)

						UploadImag.SaveAs(path);
					return RedirectToAction("Index");


				}
				catch (Exception)
				{
					ModelState.AddModelError("", "Ocorreu um erro com a escrita " +
										"dos dados do novo Agente");
				}

				}

            return View(filme);
        }

        // GET: Filmes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filmes filme = db.Filmes.Find(id);
            if (filme == null)
            {
                return HttpNotFound();
            }
            return View(filme);
        }

        // POST: Filmes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Titulo,Ano,Sinopse,Capa,Trailer")] Filmes filme)
        {
            if (ModelState.IsValid)
            {
                db.Entry(filme).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(filme);
        }

        // GET: Filmes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Filmes filme = db.Filmes.Find(id);
            if (filme == null)
            {
                return HttpNotFound();
            }
            return View(filme);
        }

        // POST: Filmes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Filmes filme = db.Filmes.Find(id);
            db.Filmes.Remove(filme);
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
