using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Xalapa.API.BusinessLogic;
using Xalapa.API.Entities;

namespace Xalapa.API.Services.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ResearchersController : ControllerBase
    {
        private readonly ILogger<ResearchersController> _logger;

        public ResearchersController(ILogger<ResearchersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Researchers> Get()
        {
            ResearchersBL bl = new ResearchersBL();
            return bl.GetList();
        }

        [HttpGet("{id}")]
        public Researchers Get(int id)
        {
            ResearchersBL bl = new ResearchersBL();
            return bl.Get(id);
        }

        [HttpPost]
        public void Insert(Researchers request)
        {
            ResearchersBL bl = new ResearchersBL();
            bl.Insert(request);
        }

        [HttpPut]
        public void Update(Researchers request)
        {
            ResearchersBL bl = new ResearchersBL();
            bl.Update(request);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ResearchersBL bl = new ResearchersBL();
            bl.Delete(id);
        }
    }
}