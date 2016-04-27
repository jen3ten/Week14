using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Week14_CodeFirstGradeBook_04132016.Models;

namespace Week14_CodeFirstGradeBook_04132016.Controllers
{
    public class StudentAssignmentGradesController : Controller
    {
        private Week14_CodeFirstGradeBook_04132016Context db = new Week14_CodeFirstGradeBook_04132016Context();

        // GET: StudentAssignmentGrades
        public ActionResult Index()
        {
            var studentAssignmentGrades = db.StudentAssignmentGrades.Include(s => s.AssignmentID).Include(s => s.StudentID);
            return View(studentAssignmentGrades.ToList());
        }

        // GET: StudentAssignmentGrades/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentAssignmentGrades studentAssignmentGrades = db.StudentAssignmentGrades.Find(id);
            if (studentAssignmentGrades == null)
            {
                return HttpNotFound();
            }
            return View(studentAssignmentGrades);
        }

        // GET: StudentAssignmentGrades/Create
        public ActionResult Create()
        {
            ViewBag.AssignID = new SelectList(db.Assignments, "AssignmentID", "Title");
            ViewBag.StuID = new SelectList(db.Students, "StudentID", "FirstName");
            return View();
        }

        // POST: StudentAssignmentGrades/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StuID,AssignID,PointsAwarded,Grade")] StudentAssignmentGrades studentAssignmentGrades)
        {
            if (ModelState.IsValid)
            {
                db.StudentAssignmentGrades.Add(studentAssignmentGrades);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AssignID = new SelectList(db.Assignments, "AssignmentID", "Title", studentAssignmentGrades.AssignID);
            ViewBag.StuID = new SelectList(db.Students, "StudentID", "FirstName", studentAssignmentGrades.StuID);
            return View(studentAssignmentGrades);
        }

        // GET: StudentAssignmentGrades/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentAssignmentGrades studentAssignmentGrades = db.StudentAssignmentGrades.Find(id);
            if (studentAssignmentGrades == null)
            {
                return HttpNotFound();
            }
            ViewBag.AssignID = new SelectList(db.Assignments, "AssignmentID", "Title", studentAssignmentGrades.AssignID);
            ViewBag.StuID = new SelectList(db.Students, "StudentID", "FirstName", studentAssignmentGrades.StuID);
            return View(studentAssignmentGrades);
        }

        // POST: StudentAssignmentGrades/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StuID,AssignID,PointsAwarded,Grade")] StudentAssignmentGrades studentAssignmentGrades)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentAssignmentGrades).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AssignID = new SelectList(db.Assignments, "AssignmentID", "Title", studentAssignmentGrades.AssignID);
            ViewBag.StuID = new SelectList(db.Students, "StudentID", "FirstName", studentAssignmentGrades.StuID);
            return View(studentAssignmentGrades);
        }

        // GET: StudentAssignmentGrades/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentAssignmentGrades studentAssignmentGrades = db.StudentAssignmentGrades.Find(id);
            if (studentAssignmentGrades == null)
            {
                return HttpNotFound();
            }
            return View(studentAssignmentGrades);
        }

        // POST: StudentAssignmentGrades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentAssignmentGrades studentAssignmentGrades = db.StudentAssignmentGrades.Find(id);
            db.StudentAssignmentGrades.Remove(studentAssignmentGrades);
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
