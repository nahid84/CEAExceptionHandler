using Microsoft.AspNetCore.Mvc;

namespace ExceptionDealer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VersionController : ControllerBase
    {
        private const string _version = "1.0.0";

        public IActionResult GetVersion()
        {
            return Ok(@"{ ""Version"" : """ + _version + @""" }");
        }
    }
}