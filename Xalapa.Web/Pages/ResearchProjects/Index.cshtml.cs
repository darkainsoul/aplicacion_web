using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xalapa.Web.Models;

namespace Xalapa.Web.Pages
{
    public class ResearchProjectsModel : PageModel
    {
        public IEnumerable<ResearchProject> ProyectoInvestigaciones { get; set; }

        const string url = "https://localhost:5001/ResearchProjects";
        public async Task OnGet()
        {
            ProyectoInvestigaciones = new List<ResearchProject>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ProyectoInvestigaciones = JsonConvert.DeserializeObject<List<ResearchProject>>(apiResponse);
                }
            }
        }
    }
}
