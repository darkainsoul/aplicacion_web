using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xalapa.Web.Models;

namespace Xalapa.Web.Pages.ResearchCenters
{
    public class IndexModel : PageModel
    {
        public IEnumerable<ResearchCenter> CentroInvestigaciones { get; set; }

        const string url = "https://localhost:5001/ResearchCenters";
        public async Task OnGet()
        {
            CentroInvestigaciones = new List<ResearchCenter>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    CentroInvestigaciones = JsonConvert.DeserializeObject<List<ResearchCenter>>(apiResponse);
                }
            }
        }
    }
}
