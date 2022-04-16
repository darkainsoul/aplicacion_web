using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Xalapa.API.BusinessLogic;
using Xalapa.API.Entities;

namespace Xalapa.API.Services.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ResearchLinesController : ControllerBase
    {
        private readonly ILogger<ResearchLinesController> _logger;

        public ResearchLinesController(ILogger<ResearchLinesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ResearchLines> Get()
        {
            ResearchLinesBL bl = new ResearchLinesBL();
            return bl.GetList();
        }

        [HttpGet("{id}")]
        public ResearchLines Get(int id)
        {
            ResearchLinesBL bl = new ResearchLinesBL();
            return bl.Get(id);
        }

        [HttpPost]
        public void Insert(ResearchLines request)
        {
            ResearchLinesBL bl = new ResearchLinesBL();
            bl.Insert(request);
        }

        [HttpPut]
        public void Update(ResearchLines request)
        {
            ResearchLinesBL bl = new ResearchLinesBL();
            bl.Update(request);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ResearchLinesBL bl = new ResearchLinesBL();
            bl.Delete(id);
        }
    }
}