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
    public class AnswerController : Controller
    {
        private KnowledgeTestDb db = new KnowledgeTestDb();

        // GET: /Answer/
        public ActionResult Index(int id)
        {
            var answers = db.Answers.Include(a => a.Question).Where(a => a.QuestionId == id);
            return View(answers.ToList());
        }

        // GET: /Answer/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Answer answer = db.Answers.Find(id);
            if (answer == null)
            {
                return HttpNotFound();
            }
            return View(answer);
        }

        // GET: /Answer/Create
        public ActionResult Create(int id)
        {
            var answer = new Answer();
            var question = db.Questions.FirstOrDefault(q => q.Id == id);
            answer.QuestionId = id;
            answer.Question = question;
            return View(answer);
        }

        // POST: /Answer/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="Id,Name,IsCorrect,Value,QuestionId")] Answer answer)
        {
            if (ModelState.IsValid)
            {
                db.Answers.Add(answer);
                db.SaveChanges();
                return RedirectToAction("Index","Question");
            }

            ViewBag.QuestionId = new SelectList(db.Questions, "Id", "Name", answer.QuestionId);
            return View(answer);
        }

        // GET: /Answer/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Answer answer = db.Answers.Find(id);
            if (answer == null)
            {
                return HttpNotFound();
            }
            ViewBag.QuestionId = new SelectList(db.Questions, "Id", "Name", answer.QuestionId);
            return View(answer);
        }

        // POST: /Answer/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="Id,Name,IsCorrect,Value,QuestionId")] Answer answer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(answer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index","Question");
            }
            ViewBag.QuestionId = new SelectList(db.Questions, "Id", "Name", answer.QuestionId);
            return View(answer);
        }

        // GET: /Answer/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Answer answer = db.Answers.Find(id);
            if (answer == null)
            {
                return HttpNotFound();
            }
            return View(answer);
        }

        // POST: /Answer/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Answer answer = db.Answers.Find(id);
            db.Answers.Remove(answer);
            db.SaveChanges();
            return RedirectToAction("Index","Question");
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
