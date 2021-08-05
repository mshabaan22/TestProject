using Microsoft.AspNetCore.Mvc;

namespace Com.IPMagiX.test.Controllers.V1
{
    [ApiController]
    public class WelcomeController : ControllerBase
    {
        [HttpGet("")]
        public ActionResult Welcome()
        {
            string version = GetType().Assembly.GetName().Version.ToString();
            return Ok(version);
        }
    }
}
