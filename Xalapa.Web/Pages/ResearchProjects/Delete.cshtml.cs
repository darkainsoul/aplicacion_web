using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xalapa.Web.Models;

namespace Xalapa.Web.Pages.ResearchProjects
{
    public class DeleteModel : PageModel
    {
        [BindProperty]
        public ResearchProject ProyectoInvestigacion { get; set; }

        const string url = "https://localhost:5001/ResearchProjects";

        public async Task OnGet(int id)
        {
            ProyectoInvestigacion = new ResearchProject();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url + "/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    ProyectoInvestigacion = JsonConvert.DeserializeObject<ResearchProject>(apiResponse);
                }
            }
        }

        public async Task<IActionResult> OnPost()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.DeleteAsync(new Uri(url + "/" + ProyectoInvestigacion.id)))
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
