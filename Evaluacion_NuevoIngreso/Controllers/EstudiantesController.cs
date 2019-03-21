using Evaluacion_NuevoIngreso.Models;
using Evaluacion_NuevoIngreso.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Evaluacion_NuevoIngreso.Controllers
{
    public class EstudiantesController : Controller
    {
        private EstudiantesRepository _repository;

        public EstudiantesController()
        {
            _repository = new EstudiantesRepository();
        }

        // GET: Estudiantes
        public ActionResult Lista()
        {
            var model = _repository.GetEstudiantes();
            return View(model);
        }

        // GET: Crear
        public ActionResult Crear()
        {            
            return View();
        }

        // POST: Crear
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Crear(Estudiantes model)
        {
            if (ModelState.IsValid)
            {
                _repository.Crear(model);
                return RedirectToAction("Lista");
            }
            return View(model);
        }

        // GET: Actualizar
        public ActionResult Actualizar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View(_repository.GetInfo(id));
        }

        // POST: Actualizar
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Actualizar(Estudiantes model)
        {
            if (ModelState.IsValid)
            {
                _repository.Actualizar(model);
                return RedirectToAction("Lista");
            }
            return View(model);
        }

        // GET: Eliminar
        public ActionResult Eliminar(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            return View(_repository.GetInfo(id));
        }

        // POST: Eliminar
        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public ActionResult EliminarConfirmed(int id)
        {
            if (id == 0)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                _repository.Eliminar(id);
                return RedirectToAction("Lista");
            }            
        }
    }
}