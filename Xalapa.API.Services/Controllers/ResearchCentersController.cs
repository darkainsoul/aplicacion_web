using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Xalapa.API.BusinessLogic;
using Xalapa.API.Entities;

namespace Xalapa.API.Services.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ResearchCentersController : ControllerBase
    {
        private readonly ILogger<ResearchCentersController> _logger;

        public ResearchCentersController(ILogger<ResearchCentersController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ResearchCenters> Get()
        {
            ResearchCentersBL bl = new ResearchCentersBL();
            return bl.GetList();
        }

        [HttpGet("{id}")]
        public ResearchCenters Get(int id)
        {
            ResearchCentersBL bl = new ResearchCentersBL();
            return bl.Get(id);
        }

        [HttpPost]
        public void Insert(ResearchCenters request)
        {
            ResearchCentersBL bl = new ResearchCentersBL();
            bl.Insert(request);
        }

        [HttpPut]
        public void Update(ResearchCenters request)
        {
            ResearchCentersBL bl = new ResearchCentersBL();
            bl.Update(request);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ResearchCentersBL bl = new ResearchCentersBL();
            bl.Delete(id);
        }
    }
}