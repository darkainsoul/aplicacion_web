using System;
using System.ComponentModel.DataAnnotations;

namespace Xalapa.Web.Models
{
    public class ResearchLine
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
        public string goals { get; set; }
        public string common_objectives { get; set; }
    }
}
