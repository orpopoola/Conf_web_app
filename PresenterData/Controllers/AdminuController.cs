using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PresenterData.Models;

namespace PresenterData.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminuController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Adminu
        public ActionResult Index(string sortBy)
        {
            ViewBag.TotalSort = sortBy == "Totmar" ? "Totmar_desc" : "Totmar";
            ViewBag.SessionSort = sortBy == "SessionId" ? "SessionId_desc" : "SessionId";
            ViewBag.PaperSort = sortBy == "Nominate" ? "Nominate_desc" : "Nominate";
            var presenters = db.Presenters.AsQueryable();
            switch (sortBy)
            {
                case "Totmar":
                    presenters = presenters.OrderBy(s => s.Totmar);
                    break;
                case "Totmar_desc":
                    presenters = presenters.OrderByDescending(s => s.Totmar);
                    break;
                case "SessionId":
                    presenters = presenters.OrderBy(s => s.SessionId);
                    break;
                case "SessionId_desc":
                    presenters = presenters.OrderByDescending(s => s.SessionId);
                    break;
                case "Nominate":
                    presenters = presenters.OrderBy(s => s.Nominate);
                    break;
                case "Nominate_desc":
                    presenters = presenters.OrderByDescending(s => s.Nominate);
                    break;
                default:
                    presenters = presenters.OrderBy(s => s.StudentName);
                    break;
            }
            return View(presenters.ToList());
        }

        // GET: Adminu/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Presenter presenter = db.Presenters.Find(id);
            if (presenter == null)
            {
                return HttpNotFound();
            }
            return View(presenter);
        }

        // GET: Adminu/Create
        public ActionResult Create()
        {           
            return View();
        }

        // POST: Adminu/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,StudentName,SessionId,PaperId,PaperTitle,SelectedClarity,SelectedEyecon,SelectedInteng,SelectedTimekee,SelectedOrigqua,SelectedCorlev,SelectedWellstru,SelectedGooduse,SelectedQuestwell,SelectedClearansw,Totmar,Nominate,Comments")] Presenter presenter)
        {
            presenter.Totmar = (presenter.SelectedClarity + presenter.SelectedClearansw + presenter.SelectedCorlev + presenter.SelectedEyecon + presenter.SelectedGooduse + presenter.SelectedInteng + presenter.SelectedOrigqua + presenter.SelectedQuestwell + presenter.SelectedTimekee + presenter.SelectedWellstru).ToString();
            
            if (ModelState.IsValid)
            {
                //uncomment to enable create function for admin then add link to Index.cshtml for admin
                //db.Presenters.Add(presenter);
                //db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(presenter);
        }

        // GET: Adminu/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Presenter presenter = db.Presenters.Find(id);
            if (presenter == null)
            {
                return HttpNotFound();
            }
            return View(presenter);
        }

        // POST: Adminu/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StudentName,SessionId,PaperId,SelectedClarity,SelectedEyecon,SelectedInteng,SelectedTimekee,SelectedOrigqua,SelectedCorlev,SelectedWellstru,SelectedGooduse,SelectedQuestwell,SelectedClearansw,Totmar,Nominate,Comments")] Presenter presenter)
        {
            presenter.Totmar = (presenter.SelectedClarity + presenter.SelectedClearansw + presenter.SelectedCorlev + presenter.SelectedEyecon + presenter.SelectedGooduse + presenter.SelectedInteng + presenter.SelectedOrigqua + presenter.SelectedQuestwell + presenter.SelectedTimekee + presenter.SelectedWellstru).ToString();
            presenter.SessionId = 11221.ToString();
            if (ModelState.IsValid)
            {
                db.Entry(presenter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(presenter);
        }

        // GET: Adminu/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Presenter presenter = db.Presenters.Find(id);
            if (presenter == null)
            {
                return HttpNotFound();
            }
            return View(presenter);
        }

        // POST: Adminu/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Presenter presenter = db.Presenters.Find(id);
            db.Presenters.Remove(presenter);
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
