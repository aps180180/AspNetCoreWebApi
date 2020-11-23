using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Microsoft.AspNetCore.Mvc;

namespace Smartschool.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProfessorController : ControllerBase
    {
        public ProfessorController()
        {
            
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Professor ok");
        }
    }
}