using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Xalapa.API.BusinessLogic;
using Xalapa.API.Entities;

namespace Xalapa.API.Services.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ThesisStudentsController : ControllerBase
    {
        private readonly ILogger<ThesisStudentsController> _logger;

        public ThesisStudentsController(ILogger<ThesisStudentsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ThesisStudents> Get()
        {
            ThesisStudentsBL bl = new ThesisStudentsBL();
            yield return bl.GetList();
        }

        [HttpGet("{id}")]
        public IEnumerable<ThesisStudents> Get(int id)
        {
            ThesisStudentsBL bl = new ThesisStudentsBL();
            yield return bl.Get(id);
        }

        [HttpPost]
        public void Insert(ThesisStudents request)
        {
            ThesisStudentsBL bl = new ThesisStudentsBL();
            bl.Insert(request);
        }

        [HttpPut]
        public void Update(ThesisStudents request)
        {
            ThesisStudentsBL bl = new ThesisStudentsBL();
            bl.Update(request);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ThesisStudentsBL bl = new ThesisStudentsBL();
            bl.Delete(id);
        }
    }
}
