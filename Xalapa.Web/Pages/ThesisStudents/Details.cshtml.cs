using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Xalapa.Web.Models;

namespace Xalapa.Web.Pages.ThesisStudents
{
    public class DetailsModel : PageModel
    {
        [BindProperty]
        public ThesisStudent EstudianteTesis { get; set; }

        const string url = "https://localhost:5001/ThesisStudents";

        public async Task OnGet(int id)
        {
            EstudianteTesis = new ThesisStudent();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url + "/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    EstudianteTesis = JsonConvert.DeserializeObject<ThesisStudent>(apiResponse);
                }
            }
        }
    }
}
