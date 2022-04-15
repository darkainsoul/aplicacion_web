using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Xalapa.API.BusinessLogic;
using Xalapa.API.Entities;
namespace Xalapa.API.Services.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AcademicGroupController : ControllerBase
    {
        private readonly ILogger<AcademicGroupController> _logger;

        public AcademicGroupController(ILogger<AcademicGroupController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<AcademicGroups> Get()
        {
            AcademicGroupsBL bl = new AcademicGroupsBL();
            yield return bl.GetList();
        }

        [HttpGet("{id}")]
        public IEnumerable<AcademicGroups> Get(int id)
        {
            AcademicGroupsBL bl = new AcademicGroupsBL();
            yield return bl.Get(id);
        }

        [HttpPost]
        public void Insert(AcademicGroups request)
        {
            AcademicGroupsBL bl = new AcademicGroupsBL();
            bl.Insert(request);
        }

        [HttpPut]
        public void Update(AcademicGroups request)
        {
            AcademicGroupsBL bl = new AcademicGroupsBL();
            bl.Update(request);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            AcademicGroupsBL bl = new AcademicGroupsBL();
            bl.Delete(id);
        }
    }
}