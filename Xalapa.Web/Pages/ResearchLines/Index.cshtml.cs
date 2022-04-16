using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xalapa.Web.Models;

namespace Xalapa.Web.Pages
{
    public class ResearchLinesModel : PageModel
    {
        public IEnumerable<ResearchLine> LineaInvestigaciones { get; set; }


        const string url = "https://localhost:5001/ResearchLines";
        public async Task OnGet()
        {
            LineaInvestigaciones = new List<ResearchLine>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    LineaInvestigaciones = JsonConvert.DeserializeObject<List<ResearchLine>>(apiResponse);
                }
            }
        }
    }
}
