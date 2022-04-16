using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xalapa.Web.Models;

namespace Xalapa.Web.Pages
{
    public class ThesisStudentsModel : PageModel
    {
        public IEnumerable<ThesisStudent> EstudiantesTesis { get; set; }

        const string url = "https://localhost:5001/ThesisStudents";
        public async Task OnGet()
        {
            EstudiantesTesis = new List<ThesisStudent>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    EstudiantesTesis = JsonConvert.DeserializeObject<List<ThesisStudent>>(apiResponse);
                }
            }
        }
    }
}
