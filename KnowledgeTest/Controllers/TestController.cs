using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KnowledgeTest.Entities;
using KnowledgeTest.DataContexts;

namespace KnowledgeTest.Controllers
{
    public class TestController : Controller
    {
        private KnowledgeTestDb db = new KnowledgeTestDb();

        // GET: /Test/
        public ActionResult Index()
        {
            return View(db.Tests.ToList());
        }

        // GET: /Test/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Test test = db.Tests.Find(id);
            if (test == null)
            {
                return HttpNotFound();
            }
            return View(test);
        }

        // GET: /Test/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Test/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Name")] Test test)
        {
            if (ModelState.IsValid)
            {
                db.Tests.Add(test);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(test);
        }

        // GET: /Test/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Test test = db.Tests.Find(id);
            if (test == null)
            {
                return HttpNotFound();
            }
            return View(test);
        }

        // POST: /Test/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Name")] Test test)
        {
            if (ModelState.IsValid)
            {
                db.Entry(test).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(test);
        }

        // GET: /Test/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Test test = db.Tests.Find(id);
            if (test == null)
            {
                return HttpNotFound();
            }
            return View(test);
        }

        // POST: /Test/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Test test = db.Tests.Find(id);
            db.Tests.Remove(test);
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

        public ActionResult Take(int id)
        {
            var test = db.Tests.FirstOrDefault(t => t.Id == id);
            return View(test);
        }

        public JsonResult Questions(int id)
        {
            var questions = db.Questions
                        .Where(q => q.TestId == id)
                        .ToList();

            foreach (var question in questions)
            {
                question.Answers = db.Answers
                                        .Where(a => a.QuestionId == question.Id)
                                        .ToList()
                                        .Select(a => new Answer() { Id = a.Id,
                                                                    Name = a.Name,
                                                                    IsCorrect = a.IsCorrect
                                                                }).ToArray()
                                        ;
            }

            return Json(questions, JsonRequestBehavior.AllowGet);
        }
    }
}
