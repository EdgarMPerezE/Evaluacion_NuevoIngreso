using Evaluacion_NuevoIngreso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Evaluacion_NuevoIngreso.Repository
{
    public class PeriodoRepository
    {
        public List<Periodo> GetEstudiantes()
        {
            using (var db = new EvaluacionContext())
            {
                return db.Periodo.ToList();
            }
        }

        internal void Crear(Periodo model)
        {
            using (var db = new EvaluacionContext())
            {
                db.Periodo.Add(model);
                db.SaveChanges();
            }
        }
    }
}