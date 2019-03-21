using Evaluacion_NuevoIngreso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Evaluacion_NuevoIngreso.Repository
{
    public class ClasesRepository
    {
        public List<Clases> GetClases()
        {
            using (var db = new EvaluacionContext())
            {
                return db.Clases.ToList();
            }
        }

        internal void Crear(Clases model)
        {
            using (var db = new EvaluacionContext())
            {
                db.Clases.Add(model);
                db.SaveChanges();
            }
        }
    }    
}