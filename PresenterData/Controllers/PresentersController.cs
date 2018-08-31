using Microsoft.AspNet.Identity;
using PresenterData.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace PresenterData.Controllers
{
    [Authorize(Roles = "Marker1, Admin")]
    public class PresentersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
                
        // GET: Presenters

        public ActionResult Index(string sortBy)
        {
            
            
            ViewBag.TotalSort = sortBy == "Totmar" ? "Totmar_desc" : "Totmar";
            var presenters = db.Presenters.AsQueryable();
            switch(sortBy)
            {
                case "Totmar":
                    presenters = presenters.OrderBy(s => s.Totmar);
                    break;
                case "Totmar_desc":
                    presenters = presenters.OrderByDescending(s => s.Totmar);
                    break;
                default:
                    presenters = presenters.OrderBy(s => s.StudentName);
                    break;
            }
            return View(presenters.ToList());
        }

        public ActionResult List(string sortBy)
        {
            ViewBag.TotalSort = sortBy == "Totmar" ? "Totmar_desc" : "Totmar";
            var presenters = db.Presenters.AsQueryable();
            switch (sortBy)
            {
                case "Totmar":
                    presenters = presenters.OrderBy(s => s.Totmar);
                    break;
                case "Totmar_desc":
                    presenters = presenters.OrderByDescending(s => s.Totmar);
                    break;
                default:
                    presenters = presenters.OrderBy(s => s.PaperId);
                    break;
            }
            return View(presenters.ToList());
        }

        // GET: Presenters/Details/5
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

        // GET: Presenters/Create
        public ActionResult Create(int? id)
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
            

                var item = new Presenter
                {
                    StudentName = presenter.StudentName,
                    PaperTitle = presenter.PaperTitle,
                    PaperId = presenter.PaperId,
                    eyecons = new List<Eyecon>
                {
                    new Eyecon{Id = 1, EyeconName = "Poor"},
                    new Eyecon{Id = 2, EyeconName = "Fair"},
                    new Eyecon{Id = 3, EyeconName = "Adequate"},
                    new Eyecon{Id = 4, EyeconName = "Good"},
                    new Eyecon{Id = 5, EyeconName = "Excellent"},
                },

                    claritys = new List<Clarity>
                {
                    new Clarity{Id = 1, ClarityName = "Poor"},
                    new Clarity{Id = 2, ClarityName = "Fair"},
                    new Clarity{Id = 3, ClarityName = "Adequate"},
                    new Clarity{Id = 4, ClarityName = "Good"},
                    new Clarity{Id = 5, ClarityName = "Excellent"},
                },

                    intengs = new List<Inteng>
                {
                    new Inteng{Id = 1, IntengName = "Poor"},
                    new Inteng{Id = 2, IntengName = "Fair"},
                    new Inteng{Id = 3, IntengName = "Adequate"},
                    new Inteng{Id = 4, IntengName = "Good"},
                    new Inteng{Id = 5, IntengName = "Excellent"},
                },

                    timekees = new List<Timekee>
                {
                    new Timekee{Id = 1, TimekeeName = "Poor"},
                    new Timekee{Id = 2, TimekeeName = "Fair"},
                    new Timekee{Id = 3, TimekeeName = "Adequate"},
                    new Timekee{Id = 4, TimekeeName = "Good"},
                    new Timekee{Id = 5, TimekeeName = "Excellent"},
                },

                    origquas = new List<Origqua>
                {
                    new Origqua{Id = 1, OrigquaName = "Poor"},
                    new Origqua{Id = 2, OrigquaName = "Fair"},
                    new Origqua{Id = 3, OrigquaName = "Adequate"},
                    new Origqua{Id = 4, OrigquaName = "Good"},
                    new Origqua{Id = 5, OrigquaName = "Excellent"},
                },

                    corlevs = new List<Corlev>
                {
                    new Corlev{Id = 1, CorlevName = "Poor"},
                    new Corlev{Id = 2, CorlevName = "Fair"},
                    new Corlev{Id = 3, CorlevName = "Adequate"},
                    new Corlev{Id = 4, CorlevName = "Good"},
                    new Corlev{Id = 5, CorlevName = "Excellent"},
                },

                    wellsturs = new List<Wellstru>
                {
                    new Wellstru{Id = 1, WellstruName = "Poor"},
                    new Wellstru{Id = 2, WellstruName = "Fair"},
                    new Wellstru{Id = 3, WellstruName = "Adequate"},
                    new Wellstru{Id = 4, WellstruName = "Good"},
                    new Wellstru{Id = 5, WellstruName = "Excellent"},
                },

                    gooduses = new List<Gooduse>
                {
                    new Gooduse{Id = 1, GooduseName = "Poor"},
                    new Gooduse{Id = 2, GooduseName = "Fair"},
                    new Gooduse{Id = 3, GooduseName = "Adequate"},
                    new Gooduse{Id = 4, GooduseName = "Good"},
                    new Gooduse{Id = 5, GooduseName = "Excellent"},
                },

                    questwells = new List<Questwell>
                {
                    new Questwell{Id = 1, QuestwellName = "Poor"},
                    new Questwell{Id = 2, QuestwellName = "Fair"},
                    new Questwell{Id = 3, QuestwellName = "Adequate"},
                    new Questwell{Id = 4, QuestwellName = "Good"},
                    new Questwell{Id = 5, QuestwellName = "Excellent"},
                },

                    clearansws = new List<Clearansw>
                {
                    new Clearansw{Id = 1, ClearanswName = "Poor"},
                    new Clearansw{Id = 2, ClearanswName = "Fair"},
                    new Clearansw{Id = 3, ClearanswName = "Adequate"},
                    new Clearansw{Id = 4, ClearanswName = "Good"},
                    new Clearansw{Id = 5, ClearanswName = "Excellent"},
                }
                };
                return View(item);
            
        }

        

        // POST: Presenters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,StudentName,PaperTitle,PaperId,SessionId,SelectedClarity,SelectedEyecon,SelectedInteng,SelectedTimekee,SelectedOrigqua,SelectedCorlev,SelectedWellstru,SelectedGooduse,SelectedQuestwell,SelectedClearansw,Totmar,Nominate,Nmarked,Comments")] Presenter presenter)
        {
              presenter.Totmar = (presenter.SelectedClarity + presenter.SelectedClearansw + presenter.SelectedCorlev + presenter.SelectedEyecon + presenter.SelectedGooduse + presenter.SelectedInteng + presenter.SelectedOrigqua + presenter.SelectedQuestwell + presenter.SelectedTimekee + presenter.SelectedWellstru).ToString();
                presenter.NMarked = true;
                presenter.SessionId = 1.ToString();
                if (ModelState.IsValid)
                {
                    db.Entry(presenter).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("List");
                }

                return View(presenter);
            
        }

        // GET: Presenters/Edit/5
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
            //return View(item);
            return View(presenter);
        }

        // POST: Presenters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StudentName,PaperTitle,PaperId,SessionId,SelectedClarity,SelectedEyecon,SelectedInteng,SelectedTimekee,SelectedOrigqua,SelectedCorlev,SelectedWellstru,SelectedGooduse,SelectedQuestwell,SelectedClearansw,Totmar,Nominate,Nmarked,Comments")] Presenter presenter)
        {
            presenter.Totmar = (presenter.SelectedClarity + presenter.SelectedClearansw + presenter.SelectedCorlev + presenter.SelectedEyecon + presenter.SelectedGooduse + presenter.SelectedInteng + presenter.SelectedOrigqua + presenter.SelectedQuestwell + presenter.SelectedTimekee + presenter.SelectedWellstru).ToString();
            presenter.SessionId = 1.ToString();
            if (ModelState.IsValid)
            {
                db.Entry(presenter).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(presenter);
        }

        // GET: Presenters/Delete/5
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

        // POST: Presenters/Delete/5
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
