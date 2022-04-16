using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Xalapa.API.BusinessLogic;
using Xalapa.API.Entities;

namespace Xalapa.API.Services.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ThesisDirectorsController : ControllerBase
    {
        private readonly ILogger<ThesisDirectorsController> _logger;

        public ThesisDirectorsController(ILogger<ThesisDirectorsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ThesisDirectors> Get()
        {
            ThesisDirectorsBL bl = new ThesisDirectorsBL();
            return bl.GetList();
        }

        [HttpGet("{id}")]
        public ThesisDirectors Get(int id)
        {
            ThesisDirectorsBL bl = new ThesisDirectorsBL();
            return bl.Get(id);
        }

        [HttpPost]
        public void Insert(ThesisDirectors request)
        {
            ThesisDirectorsBL bl = new ThesisDirectorsBL();
            bl.Insert(request);
        }

        [HttpPut]
        public void Update(ThesisDirectors request)
        {
            ThesisDirectorsBL bl = new ThesisDirectorsBL();
            bl.Update(request);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ThesisDirectorsBL bl = new ThesisDirectorsBL();
            bl.Delete(id);
        }
    }
}