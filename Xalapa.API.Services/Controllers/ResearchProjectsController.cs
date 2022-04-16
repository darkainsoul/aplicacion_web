using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Xalapa.API.BusinessLogic;
using Xalapa.API.Entities;

namespace Xalapa.API.Services.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ResearchProjectsController : ControllerBase
    {
        private readonly ILogger<ResearchProjectsController> _logger;

        public ResearchProjectsController(ILogger<ResearchProjectsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ResearchProjects> Get()
        {
            ResearchProjectsBL bl = new ResearchProjectsBL();
            return bl.GetList();
        }

        [HttpGet("{id}")]
        public ResearchProjects Get(int id)
        {
            ResearchProjectsBL bl = new ResearchProjectsBL();
            return bl.Get(id);
        }

        [HttpPost]
        public void Insert(ResearchProjects request)
        {
            ResearchProjectsBL bl = new ResearchProjectsBL();
            bl.Insert(request);
        }

        [HttpPut]
        public void Update(ResearchProjects request)
        {
            ResearchProjectsBL bl = new ResearchProjectsBL();
            bl.Update(request);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ResearchProjectsBL bl = new ResearchProjectsBL();
            bl.Delete(id);
        }
    }
}