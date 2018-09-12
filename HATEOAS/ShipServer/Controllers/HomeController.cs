namespace ShipServer.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Route("/")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var baseUrl = $"{Request.Scheme}://{Request.Host.Value}";
            return Ok(new { starshipClass = $"{baseUrl}/api/starshipclass" });
        }
    }
}
