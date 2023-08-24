using justin_mahaffay.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;
using Markdig;


namespace justin_mahaffay.Controllers
{
    public class AuthorController : Controller
    {
        private AuthorDBContext db = new AuthorDBContext();

        // GET: AuthorController
        public ActionResult Index(int? pageNumber)
        {
            var authors = from e in db.Authors
                            orderby e.ID
                            select e;
            return View(authors.ToPagedList(pageNumber ?? 1, 3));
        }

        // GET: AuthorController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: AuthorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AuthorController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Author auth)
        {
            try
            {
                db.Authors.Add(auth);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController/Edit/5
        public ActionResult Edit(int id)
        {          
            
             var author = db.Authors.SingleOrDefault(m => m.ID == id);            

            return View(author);
        }

        // POST: AuthorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                var author = db.Authors.SingleOrDefault(m => m.ID == id);

                author.author = Request.Form["author"];
                author.time = Convert.ToDateTime(Request.Form["time"]);
                author.subject = Request.Form["subject"];
                author.body = Markdown.ToHtml(Request.Form["body"]);
                db.SaveChanges();
                {     
                    return RedirectToAction("Index");
                }
                
            }
            catch
            {
                return View();
            }
        }

        // GET: AuthorController/Delete/5
        public ActionResult Delete(int id)
        {
            var author = db.Authors.SingleOrDefault(m => m.ID == id);

            return View(author);
        }

        // POST: AuthorController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var author = db.Authors.SingleOrDefault(m => m.ID == id);
                db.Authors.Remove(author);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

    }
}
