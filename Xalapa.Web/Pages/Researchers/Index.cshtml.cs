using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xalapa.Web.Models;

namespace Xalapa.Web.Pages
{
    public class ResearchersModel : PageModel
    {
        public IEnumerable<Researcher> Investigadores { get; set; }
        private const string url = "https://localhost:5001/Researchers";

        public ResearchersModel()
        {
        }

        public async Task OnGet()
        {
            Investigadores = new List<Researcher>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    Investigadores = JsonConvert.DeserializeObject<List<Researcher>>(apiResponse);
                }
            }
        }
    }
}