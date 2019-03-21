using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Evaluacion_NuevoIngreso.Models
{
    public class Periodo
    {
        public int Id { get; set; }
        [Required]
        public int Periodos { get; set; }
        public int ClasesId { get; set; }
        public int EstudiantesId { get; set; }
        
        [ForeignKey("ClasesId")]
        public Clases Clases { get; set; }
        [ForeignKey("EstudiantesId")]
        public Estudiantes Estudiantes { get; set; }
    }
}