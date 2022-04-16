using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Xalapa.Web.Models;

namespace Xalapa.Web.Pages.Researchers
{
    public class DetailsModel : PageModel
    {
        [BindProperty]
        public Researcher Investigador { get; set; }

        const string url = "https://localhost:5001/Researchers";

        public async Task OnGet(int id)
        {
            Investigador = new Researcher();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url + "/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    Investigador = JsonConvert.DeserializeObject<Researcher>(apiResponse);
                }
            }
        }
    }
}
