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
    public class CreateModel : PageModel
    {
        [BindProperty]
        public ResearchProject ProyectoInvestigacion { get; set; }

        const string url = "https://localhost:5001/ResearchProjects";

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                string myJson = JsonConvert.SerializeObject(ProyectoInvestigacion);
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage response = await client.PostAsync(new Uri(url), new StringContent(myJson, Encoding.UTF8, "application/json")))
                    {
                        using (HttpContent content = response.Content)
                        {
                            string myContent = await content.ReadAsStringAsync();
                        }
                    }
                }
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
