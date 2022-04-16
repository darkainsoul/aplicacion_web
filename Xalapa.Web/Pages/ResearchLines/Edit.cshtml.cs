using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xalapa.Web.Models;

namespace Xalapa.Web.Pages.ResearchLines
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public ResearchLine LineaInvestigacion { get; set; }

        const string url = "https://localhost:5001/ResearchLines";
        public async Task OnGet(int id)
        {
            LineaInvestigacion = new ResearchLine();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync(url + "/" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    LineaInvestigacion = JsonConvert.DeserializeObject<ResearchLine>(apiResponse);
                }
            }
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                string myJson = JsonConvert.SerializeObject(LineaInvestigacion);
                using (HttpClient client = new HttpClient())
                {
                    using (HttpResponseMessage response = await client.PutAsync(new Uri(url), new StringContent(myJson, Encoding.UTF8, "application/json")))
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
