using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Xalapa.Web.Models;

namespace Xalapa.Web.Pages.AcademicGroups
{
    public class DetailsModel : PageModel
    {
        [BindProperty]
        public AcademicGroup GruposAcademico { get; set; }

        private const string url = "https://localhost:5001/AcademicGroup";

        public async Task OnGet(int id)
        {
            GruposAcademico = new AcademicGroup();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url + "/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    GruposAcademico = JsonConvert.DeserializeObject<AcademicGroup>(apiResponse);
                }
            }
        }
    }
}