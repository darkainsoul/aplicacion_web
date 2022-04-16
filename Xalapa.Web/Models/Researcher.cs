using System;
using System.ComponentModel.DataAnnotations;

namespace Xalapa.Web.Models
{
    public class Researcher
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Required(ErrorMessage ="El nombre es obligatorio")]
        [Display(Name = "Nombre")]
        public string name { get; set; }
        [DataType(DataType.Date)]
        [Display(Name ="Fecha creación")]
        public DateTime date_register { get; set; }
        [Display(Name = "Grado Académico")]
        public string academic_grade { get; set; }

        [Display(Name = "Especialidad")]
        public string speciality { get; set; }

        [Display(Name = "Área de conocimiento")]
        public string knowledge_areas { get; set; }
        [Display(Name = "Años de experiencia")]
        public int years_of_experience { get; set; }
    }
}
