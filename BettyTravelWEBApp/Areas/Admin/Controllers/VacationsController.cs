using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BettyTravel.Data;
using BettyTravel.Services;
using BettyTravelApp.Models.BindingModels;
using BettyTravelApp.Models.EntityModels;
using BettyTravelApp.Models.ViewModels.Admin;

namespace BettyTravelApp.Areas.Admin.Controllers
{
    [RouteArea("admins")]
    [RoutePrefix("vacations")]
    [Authorize(Roles = "admin")]
    public class VacationsController : Controller
    {

        private AdminService service;

        public VacationsController()
        {
            this.service = new AdminService();
        }


        // GET: Admin/Vacations
        [HttpGet]
        [Route("all")]
        public ActionResult All()
        {
            IEnumerable<VacationVM> vm = this.service.GetAllVacations();

            if (vm == null)
            {
                return View("VacationNotFound");
            }

            return this.View(vm);
        }

        // GET: Admin/Vacations/Details/5
        [HttpGet]
        [Route("detailsd/{id}")]
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return View("VacationNotFound");
            }

            VacationCRUDvm vm = this.service.GetDetails(id);

            if (vm == null)
            {
                return View("VacationNotFound");
            }
            return View(vm);
        }

        // GET: Admin/Vacations/Create
        [HttpGet]
        [Route("create")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Vacations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("create")]
        public ActionResult Create(VacationBM bind)
        {
            if (ModelState.IsValid)
            {
                this.service.CreateVacation(bind);
               
                return RedirectToAction("All");
            }

            return View(bind);
        }

        // GET: Admin/Vacations/Edit/5
        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return View("VacationNotFound");
            }

            VacationCRUDvm vm = this.service.GetDetails(id);

            if (vm == null)
            {
                return View("VacationNotFound");
            }

            return View(vm);
        }

        // POST: Admin/Vacations/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("edit")]
        public ActionResult Edit(VacationCRUDvm vm)
        {
            if (ModelState.IsValid)
            {
                this.service.CheckState(vm);

                return RedirectToAction("All");
            }
            return View(vm);
        }

        // GET: Admin/Vacations/Delete/5
        [HttpGet]
        [Route("delete/{id}")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return View("VacationNotFound");
            }

            VacationCRUDvm vm = this.service.GetDetails(id);

            if (vm == null)
            {
                return View("VacationNotFound");
            }
            return View(vm);
        }

        // POST: Admin/Vacations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("delete/{id}")]
        public ActionResult DeleteConfirmed(int id)
        {
            VacationCRUDvm vm = this.service.GetDetails(id);
            this.service.RemoveVacation(vm);

            return RedirectToAction("All");
        }

        [HttpGet]
        public ActionResult ViewReservations()
        {
            AdminAditionalDataVM vm = this.service.GetAllReservations();
            return this.View(vm);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.service.Despose();
                
            }

            base.Dispose(disposing);
        }
    }
}
