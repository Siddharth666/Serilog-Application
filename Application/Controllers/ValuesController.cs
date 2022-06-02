using Microsoft.AspNetCore.Mvc;

namespace Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesControllers : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<ValuesControllers> _logger;

        public ValuesControllers(ILogger<ValuesControllers> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetValues")]
        public void Hey()
        {
            _logger.LogWarning("User is not valid");
        }
    }
}