using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Evaluacion_NuevoIngreso.Models
{
    public class EvaluacionContext : DbContext
    {
        public EvaluacionContext() : base("DefaultConnection")
        {

        }
        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Clases> Clases { get; set; }
        public DbSet<Periodo> Periodo { get; set; }
    }
}