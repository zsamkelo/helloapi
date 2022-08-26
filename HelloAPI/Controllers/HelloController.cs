using Microsoft.AspNetCore.Mvc;

namespace HelloAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {

        private readonly ILogger<HelloController> _logger;

        public HelloController(ILogger<HelloController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetHello")]
        public string Get(string name)
        {
            return $"Hello {name}";
        }
    }
}