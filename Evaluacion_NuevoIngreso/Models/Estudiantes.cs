using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Evaluacion_NuevoIngreso.Models
{
    public class Estudiantes
    {
        public int Id { get; set; }
        [Required]
        [StringLength(25)]
        public string Nombre { get; set; }
        [Required]
        [StringLength(25)]
        public string PrimerApellido { get; set; }        
        [StringLength(25)]
        public string SegundoApellido { get; set; }
        [Required]
        public DateTime Nacimiento { get; set; }

        public List<Periodo> Periodo { get; set; }
    }
}