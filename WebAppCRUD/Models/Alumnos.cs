using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCRUD.Models
{
    public class Alumnos
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="Campo Obligatorio")]
        [StringLength(25)]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(25)]
        [Display(Name ="Apellido Paterno")]
        public string ApePat { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(25)]
        [Display(Name = "Apellido Materno")]
        public string ApeMat { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        public byte Semestre { get; set; }
        [Required(ErrorMessage = "Campo Obligatorio")]
        [StringLength(25)]
        public string Carrera  { get; set; }

    }
}
