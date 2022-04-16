using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xalapa.Web.Models;

namespace Xalapa.Web.Pages.AcademicGroups
{
    public class EditModel : PageModel
    {
        [BindProperty]
        public AcademicGroup GruposAcademico { get; set; }

        const string url = "https://localhost:5001/AcademicGroup";
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

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                string myJson = JsonConvert.SerializeObject(GruposAcademico);
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
