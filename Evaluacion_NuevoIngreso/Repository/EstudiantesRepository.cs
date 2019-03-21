using Evaluacion_NuevoIngreso.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Evaluacion_NuevoIngreso.Repository
{
    public class EstudiantesRepository
    {
        public List<Estudiantes> GetEstudiantes()
        {
            using (var db = new EvaluacionContext())
            {
                return db.Estudiantes.ToList();
            }
        }

        internal void Crear(Estudiantes model)
        {
            using (var db = new EvaluacionContext())
            {
                db.Estudiantes.Add(model);
                db.SaveChanges();
            }
        }

        internal void Actualizar(Estudiantes model)
        {
            using (var db = new EvaluacionContext())
            {
                db.Entry(model).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        internal void Eliminar(int id)
        {
            using (var db = new EvaluacionContext())
            {
                Estudiantes estudiante = db.Estudiantes.Find(id);
                db.Estudiantes.Remove(estudiante);
                db.SaveChanges();
            }
        }

        internal Estudiantes GetInfo(int? id)
        {
            using (var db = new EvaluacionContext())
            {
                Estudiantes estudiante = db.Estudiantes.Find(id);                
                return estudiante;
            }
        }


    }
}