using System;
using System.ComponentModel.DataAnnotations;

namespace Xalapa.Web.Models
{
    public class ThesisDirector
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre")]
        public string name { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Fecha creación")]
        public DateTime date_register { get; set; }
    }
}
