using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KubeDeployWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : Controller
    {
        public ValuesController()
        {

        }

        public IActionResult Get()
        {

            return Ok("Hello, world");
        }
    }
}
