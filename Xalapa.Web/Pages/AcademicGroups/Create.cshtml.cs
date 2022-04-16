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
    public class CrearModel : PageModel
    {
        [BindProperty] 
        public AcademicGroup GruposAcademico { get; set; }

        const string url = "https://localhost:5001/AcademicGroup";

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                string myJson = JsonConvert.SerializeObject(GruposAcademico);
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
