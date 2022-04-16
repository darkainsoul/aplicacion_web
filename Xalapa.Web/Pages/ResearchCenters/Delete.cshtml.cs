using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xalapa.Web.Models;

namespace Xalapa.Web.Pages.ResearchCenters
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public ResearchCenter CentroInvestigacion { get; set; }

        const string url = "https://localhost:5001/ResearchCenters";

        public async Task OnGet(int id)
        {
            CentroInvestigacion = new ResearchCenter();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url + "/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    CentroInvestigacion = JsonConvert.DeserializeObject<ResearchCenter>(apiResponse);
                }
            }
        }

        public async Task<IActionResult> OnPost()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.DeleteAsync(new Uri(url + "/" + CentroInvestigacion.id)))
                {
                    using (HttpContent content = response.Content)
                    {
                        string myContent = await content.ReadAsStringAsync();
                    }
                }
            }
            return RedirectToPage("Index");
        }
    }
}
