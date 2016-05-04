using System.Collections.Generic;
using System.Web.Mvc;
using Telos.Admin.Model;
using Telos.Admin.Business;
using Telos.Admin.Web.Models;
using Telos.Admin.Web.Models.ModelsMapper;

namespace Telos.Admin.Web.Controllers
{
    public class UnidadeController : Controller
    {
        private UnidadeService service;

        public UnidadeController(UnidadeService service)
        {
            this.service = service;
        }

        public ActionResult Index()
        {
            var unidades = service.RetrieveAll().To<IEnumerable<UnidadeModel>>();
            return View(unidades);
        }

        public ActionResult Edit(string id)
        {
            var unidade = service.FindByCode(id).To<UnidadeModel>();
            if (unidade == null)
            {
                return HttpNotFound();
            }
            return View(unidade);
        }

        public ActionResult Details(string id)
        {
            var unidade = service.FindByCode(id).To<UnidadeModel>();
            if (unidade == null)
            {
                return HttpNotFound();
            }
            return View(unidade);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(UnidadeModel unidade)
        {
            if (ModelState.IsValid)
            {
                service.Create(unidade.To<Unidade>());

                return RedirectToAction("Index");
            }

            return View(unidade);
        }

        [HttpPost]
        public ActionResult Edit(UnidadeModel unidade)
        {
            if (ModelState.IsValid)
            {
                service.Update(unidade.To<Unidade>());
                return RedirectToAction("Index");
            }
            return View(unidade);
        }

        public ActionResult Delete(string id)
        {
            UnidadeModel unidade = service.FindByCode(id).To<UnidadeModel>();
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