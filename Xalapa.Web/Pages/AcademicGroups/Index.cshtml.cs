using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xalapa.Web.Models;

namespace Xalapa.Web.Pages
{
    public class AcademicGroupsModel : PageModel
    {
        public IEnumerable<AcademicGroup> GruposAcademicos { get; set; }
        const string url = "https://localhost:5001/AcademicGroup";
        public async Task OnGet()
        {
            GruposAcademicos = new List<AcademicGroup>();

            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    GruposAcademicos = JsonConvert.DeserializeObject<List<AcademicGroup>>(apiResponse);
                }
            }
        }
    }
}
