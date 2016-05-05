using System.Collections.Generic;
using System.Web.Mvc;
using Telos.Admin.Business;
using Telos.Admin.Model;
using Telos.Admin.Web.Models;
using Telos.Admin.Web.Models.ModelsMapper;

namespace Telos.Admin.Web.Controllers
{
    public class AlunoController : Controller
    {
        private AlunoService service;

        public AlunoController(AlunoService service)
        {
            this.service = service;
        }

        public ActionResult Index()
        {
            var alunos = service.RetrieveAll().To<IEnumerable<AlunoModel>>();
            return View(alunos);
        }

        public ActionResult Edit(long id)
        {
            var aluno = service.FindByCode(id).To<AlunoModel>();
            if (aluno == null)
            {
                return HttpNotFound();
            }
            return View(aluno);
        }

        public ActionResult Details(long id)
        {
            var aluno = service.FindByCode(id).To<AlunoModel>();
            if (aluno == null)
            {
                return HttpNotFound();
            }
            return View(aluno);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(AlunoModel unidade)
        {
            if (ModelState.IsValid)
            {
                service.Create(unidade.To<Aluno>());

                return RedirectToAction("Index");
            }

            return View(unidade);
        }

        [HttpPost]
        public ActionResult Edit(AlunoModel aluno)
        {
            if (ModelState.IsValid)
            {
                service.Update(aluno.To<Aluno>());
                return RedirectToAction("Index");
            }
            return View(aluno);
        }

        public ActionResult Delete(long id)
        {
            AlunoModel aluno = service.FindByCode(id).To<AlunoModel>();
            if (aluno == null)
            {
                return HttpNotFound();
            }
            return View(aluno);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(long id)
        {
            service.Delete(id);
            return RedirectToAction("Index");
        }
    }
}