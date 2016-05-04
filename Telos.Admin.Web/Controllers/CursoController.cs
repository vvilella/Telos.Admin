using System.Collections.Generic;
using System.Web.Mvc;
using Telos.Admin.Business;
using Telos.Admin.Model;
using Telos.Admin.Web.Models;
using Telos.Admin.Web.Models.ModelsMapper;

namespace Telos.Admin.Web.Controllers
{
    public class CursoController : Controller
    {
        private CursoService service;

        public CursoController(CursoService service)
        {
            this.service = service;
        }

        public ActionResult Index()
        {
            var cursos = service.RetrieveAll().To<IEnumerable<CursoModel>>();
            return View(cursos);
        }

        public ActionResult Edit(string id)
        {
            var curso = service.FindByCode(id).To<CursoModel>();
            if (curso == null)
            {
                return HttpNotFound();
            }
            return View(curso);
        }

        public ActionResult Details(string id)
        {
            var curso = service.FindByCode(id).To<CursoModel>();
            if (curso == null)
            {
                return HttpNotFound();
            }
            return View(curso);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CursoModel curso)
        {
            if (ModelState.IsValid)
            {
                service.Create(curso.To<Curso>());

                return RedirectToAction("Index");
            }

            return View(curso);
        }

        [HttpPost]
        public ActionResult Edit(CursoModel curso)
        {
            if (ModelState.IsValid)
            {
                service.Update(curso.To<Curso>());
                return RedirectToAction("Index");
            }
            return View(curso);
        }

        public ActionResult Delete(string id)
        {
            CursoModel unidade = service.FindByCode(id).To<CursoModel>();
            if (unidade == null)
            {
                return HttpNotFound();
            }
            return View(unidade);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(string id)
        {
            service.Delete(id);
            return RedirectToAction("Index");
        }

    }
}
