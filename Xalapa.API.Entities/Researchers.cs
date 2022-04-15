namespace Xalapa.API.Entities
{
    public class Researchers : MainEntity
    {
        public string academic_grade { get; set; }
        public string speciality { get; set; }
        public string knowledge_areas { get; set; }
        public int years_of_experience { get; set; }
    }
}