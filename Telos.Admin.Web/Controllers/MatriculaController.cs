using System.Collections.Generic;
using System.Web.Mvc;
using Telos.Admin.Business;
using Telos.Admin.Model;
using Telos.Admin.Web.Models;
using Telos.Admin.Web.Models.ModelsMapper;

namespace Telos.Admin.Web.Controllers
{
    public class MatriculaController : Controller
    {
        private MatriculaService service;

        public MatriculaController(MatriculaService service)
        {
            this.service = service;
        }

        public ActionResult Index()
        {
            var matricula = service.RetrieveAll().To<IEnumerable<MatriculaModel>>();
            return View(matricula);
        }

        public ActionResult Edit(string id)
        {
            var matricula = service.FindByCode(id).To<MatriculaModel>();
            if (matricula == null)
            {
                return HttpNotFound();
            }
            return View(matricula);
        }

        public ActionResult Details(string id)
        {
            var matricula = service.FindByCode(id).To<MatriculaModel>();
            if (matricula == null)
            {
                return HttpNotFound();
            }
            return View(matricula);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(MatriculaModel matricula)
        {
            if (ModelState.IsValid)
            {
                service.Create(matricula.To<Matricula>());

                return RedirectToAction("Index");
            }

            return View(matricula);
        }

        [HttpPost]
        public ActionResult Edit(MatriculaModel matricula)
        {
            if (ModelState.IsValid)
            {
                service.Update(matricula.To<Matricula>());
                return RedirectToAction("Index");
            }
            return View(matricula);
        }

        public ActionResult Delete(string id)
        {
            MatriculaModel aluno = service.FindByCode(id).To<MatriculaModel>();
            if (aluno == null)
            {
                return HttpNotFound();
            }
            return View(aluno);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}