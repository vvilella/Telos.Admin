using System.Collections.Generic;
using System.Web.Mvc;
using Telos.Admin.Business;
using Telos.Admin.Model;
using Telos.Admin.Web.Models;
using Telos.Admin.Web.Models.ModelsMapper;

namespace Telos.Admin.Web.Controllers
{
    public class ProfessorController : Controller
    {
        private ProfessorService service;

        public ProfessorController(ProfessorService service)
        {
            this.service = service;
        }

        public ActionResult Index()
        {
            var professores = service.RetrieveAll().To<IEnumerable<ProfessorModel>>();
            return View(professores);
        }

        public ActionResult Edit(string id)
        {
            var professor = service.FindByCode(id).To<ProfessorModel>();
            if (professor == null)
            {
                return HttpNotFound();
            }
            return View(professor);
        }

        public ActionResult Details(string id)
        {
            var professor = service.FindByCode(id).To<ProfessorModel>();
            if (professor == null)
            {
                return HttpNotFound();
            }
            return View(professor);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProfessorModel professor)
        {
            if (ModelState.IsValid)
            {
                service.Create(professor.To<Professor>());

                return RedirectToAction("Index");
            }

            return View(professor);
        }

        [HttpPost]
        public ActionResult Edit(ProfessorModel professor)
        {
            if (ModelState.IsValid)
            {
                service.Update(professor.To<Professor>());
                return RedirectToAction("Index");
            }
            return View(professor);
        }

        public ActionResult Delete(string id)
        {
            ProfessorModel professor = service.FindByCode(id).To<ProfessorModel>();
            if (professor == null)
            {
                return HttpNotFound();
            }
            return View(professor);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}